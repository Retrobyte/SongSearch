using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongSearch.Forms
{
    public partial class ExceptionHandler : Form
    {
        public ExceptionHandler(Exception ex)
        {
            InitializeComponent();

            errorTextBox.Text = ex.ToString();
        }

        private void ExceptionHandler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
