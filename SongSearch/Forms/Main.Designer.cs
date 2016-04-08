namespace SongSearch.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.songTitleLabel = new System.Windows.Forms.Label();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainListView = new RetroNet.Controls.AeroListView();
            this.songHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitRateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lengthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Location = new System.Drawing.Point(12, 15);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.songTitleLabel.TabIndex = 0;
            this.songTitleLabel.Text = "Song Title:";
            // 
            // songTitleTextBox
            // 
            this.songTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songTitleTextBox.Location = new System.Drawing.Point(79, 12);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.Size = new System.Drawing.Size(293, 22);
            this.songTitleTextBox.TabIndex = 1;
            this.songTitleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(36, 43);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(37, 13);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist:";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artistTextBox.Location = new System.Drawing.Point(79, 40);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(212, 22);
            this.artistTextBox.TabIndex = 3;
            this.artistTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(297, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listenToolStripMenuItem,
            this.copyUrlToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(129, 70);
            this.mainMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.mainMenuStrip_Opening);
            // 
            // listenToolStripMenuItem
            // 
            this.listenToolStripMenuItem.Image = global::SongSearch.Properties.Resources.sound;
            this.listenToolStripMenuItem.Name = "listenToolStripMenuItem";
            this.listenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listenToolStripMenuItem.Text = "Listen";
            this.listenToolStripMenuItem.Click += new System.EventHandler(this.listenToolStripMenuItem_Click);
            // 
            // copyUrlToolStripMenuItem
            // 
            this.copyUrlToolStripMenuItem.Image = global::SongSearch.Properties.Resources.page_paste;
            this.copyUrlToolStripMenuItem.Name = "copyUrlToolStripMenuItem";
            this.copyUrlToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.copyUrlToolStripMenuItem.Text = "Copy Url";
            this.copyUrlToolStripMenuItem.Click += new System.EventHandler(this.copyUrlToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Image = global::SongSearch.Properties.Resources.arrow_down;
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // mainListView
            // 
            this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songHeader,
            this.bitRateHeader,
            this.lengthHeader,
            this.progressHeader});
            this.mainListView.ContextMenuStrip = this.mainMenuStrip;
            this.mainListView.FullRowSelect = true;
            this.mainListView.Location = new System.Drawing.Point(12, 68);
            this.mainListView.MultiSelect = false;
            this.mainListView.Name = "mainListView";
            this.mainListView.ShowItemToolTips = true;
            this.mainListView.Size = new System.Drawing.Size(360, 214);
            this.mainListView.TabIndex = 5;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            // 
            // songHeader
            // 
            this.songHeader.Text = "Song";
            this.songHeader.Width = 161;
            // 
            // bitRateHeader
            // 
            this.bitRateHeader.Text = "Bit Rate";
            // 
            // lengthHeader
            // 
            this.lengthHeader.Text = "Length";
            // 
            // progressHeader
            // 
            this.progressHeader.Text = "Progress";
            // 
            // mainPlayer
            // 
            this.mainPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPlayer.Enabled = true;
            this.mainPlayer.Location = new System.Drawing.Point(0, 288);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainPlayer.OcxState")));
            this.mainPlayer.Size = new System.Drawing.Size(384, 45);
            this.mainPlayer.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 333);
            this.Controls.Add(this.mainPlayer);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.songTitleTextBox);
            this.Controls.Add(this.songTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SongSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songTitleLabel;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Button searchButton;
        private RetroNet.Controls.AeroListView mainListView;
        private System.Windows.Forms.ContextMenuStrip mainMenuStrip;
        private System.Windows.Forms.ColumnHeader songHeader;
        private System.Windows.Forms.ColumnHeader bitRateHeader;
        private System.Windows.Forms.ColumnHeader lengthHeader;
        private System.Windows.Forms.ToolStripMenuItem listenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader progressHeader;
        private AxWMPLib.AxWindowsMediaPlayer mainPlayer;
    }
}