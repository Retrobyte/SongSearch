using SongSearch.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SongSearch.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            this.FormClosing -= Main_FormClosing;

            this.safeInvoke(() =>
            {
                using (ExceptionHandler eh = new ExceptionHandler((Exception)e.ExceptionObject))
                    eh.ShowDialog();

                this.Close();
            });
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Are you sure to exit?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) searchButton.PerformClick();
        }

        private void mainMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = mainListView.SelectedItems.Count != 1;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(songTitleTextBox.Text))
            {
                MessageBox.Show("The song title cannot be left empty.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(artistTextBox.Text))
            {
                MessageBox.Show("The artist name cannot be left empty.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string search = String.Format("{0} - {1}", songTitleTextBox.Text.ToLower(), artistTextBox.Text.ToLower());
            mainListView.Items.Clear();

            Thread t = new Thread(() =>
                {
                    disableControls(true);

                    WebClient pageDownloader = new WebClient();
                    string page = pageDownloader.DownloadString(String.Format("http://mp3clan.com/mp3_source.php?q={0}", HttpUtility.UrlEncode(search)));

                    MatchCollection mcollect = Regex.Matches(page, "((http)(?::\\/{2}[\\w]+)(?:[\\/|\\.]?)(?:[^\\s\"]*)).*?(download).*?(\".*?\")");

                    if (mcollect.Count == 0)
                    {
                        MessageBox.Show("No results found.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        foreach (Match m in mcollect)
                        {
                            string tid = m.Groups[1].Value.Split('&')[2].Split('=')[1];
                            string name = m.Groups[4].Value.Replace('_', ' ').Trim('"');
                            string bit = string.Empty;
                            string length = string.Empty;

                            while (string.IsNullOrEmpty(length) || length == ":00 min")
                            {
                                try
                                {
                                    using (WebClient w = new WebClient())
                                    {
                                        string bitpage = w.DownloadString(String.Format("http://mp3clan.com/bitrate.php?tid={0}", tid));
                                        string[] songinfo = Regex.Split(bitpage, "<br>");

                                        bit = songinfo[0].Trim();
                                        length = songinfo[1].Trim();
                                    }
                                }
                                catch { }
                            }

                            Song s = new Song(tid, name, bit, length);

                            mainListView.safeInvoke(() =>
                                {
                                    mainListView.Items.Add(new ListViewItem(new string[] { s.Name, s.BitRate, s.Length, "Idle" }) { Name = tid, Tag = s });
                                });
                        }
                    }

                    pageDownloader.Dispose();

                    disableControls(false);
                });

            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
        }

        private void listenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No song is selected!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Song s = (Song)mainListView.SelectedItems[0].Tag;

            mainPlayer.URL = s.DownloadLink;
        }

        private void copyUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No song is selected!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clipboard.SetText(((Song)mainListView.SelectedItems[0].Tag).DownloadLink);
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No song is selected!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Song s = (Song)mainListView.SelectedItems[0].Tag;

            using (SaveFileDialog sfd = new SaveFileDialog() { FileName = s.Name + ".mp3" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (WebClient w = new WebClient())
                    {
                        w.DownloadProgressChanged += (sdr1, ev1) =>
                            {
                                mainListView.Items[s.Id].SubItems[3].Text = ev1.ProgressPercentage.ToString() + "%";
                            };

                        w.DownloadFileCompleted += (sdr2, ev2) =>
                            {
                                mainListView.Items[s.Id].SubItems[3].Text = "100%";
                            };

                        w.DownloadFileAsync(new Uri(s.DownloadLink), sfd.FileName);
                    }
                }
            }
        }

        private void disableControls(bool b)
        {
            searchButton.safeInvoke(() =>
                {
                    searchButton.Enabled = !b;
                });
        }
    }
}
