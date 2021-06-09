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
    public partial class devmode : Form
    {
        public devmode()
        {
            InitializeComponent();
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

        private void hidetext_CheckedChanged(object sender, EventArgs e)
        {
            if(hidetext.Checked == true){
                keyenter.UseSystemPasswordChar = true;
            }
            else
            {
                keyenter.UseSystemPasswordChar = false;
            }
        }

        string globalKey = "vke2394";
        private void submit_Click(object sender, EventArgs e)
        {
            switch (keyenter.Text)
            {
                default:
                    keyStatus.Visible = true;
                    keyStatus.Text = "key denied.";
                    keyStatus.ForeColor = Color.Red;
                    break;
                case "vke2394":
                    keyStatus.Visible = true;
                    keyStatus.Text = "key accepted.";
                    keyStatus.ForeColor = Color.Green;
                    Form1.developerModeEnabled = true;
                    label4.Visible = true;
                    break;
                case "fuy4961":
                    keyStatus.Visible = true;
                    keyStatus.Text = "key accepted. have fun testing!";
                    keyStatus.ForeColor = Color.Green;
                    Form1.developerModeEnabled = true;
                    break;
            }
        }

        

        private void keyStatus_Click(object sender, EventArgs e)
        {

        }

        private void devmode_Load(object sender, EventArgs e)
        {

        }
    }
}
