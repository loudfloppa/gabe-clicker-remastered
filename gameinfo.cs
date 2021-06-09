using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gabe_clicker_remastered
{
    public partial class gameinfo : Form
    {
        public gameinfo()
        {
            InitializeComponent();

            label3.Text = "file version: " + Form1.fileVersion;
            label5.Text = "build: " + Form1.build;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = gabe_clicker_remastered.Properties.Resources.ui_close_highlighted;
            pictureBox2.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = gabe_clicker_remastered.Properties.Resources.ui_close;
            pictureBox2.BackColor = SystemColors.Highlight;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by vibe cat, contact on discord 'vibe cat#0404'", "gabe clicker remastered info", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
