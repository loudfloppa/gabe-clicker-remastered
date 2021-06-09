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
    public partial class patchdialog : Form
    {
        public patchdialog()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.Image = gabe_clicker_remastered.Properties.Resources.ui_close_highlighted;
            close.BackColor = SystemColors.HotTrack;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = gabe_clicker_remastered.Properties.Resources.ui_close;
            close.BackColor = SystemColors.Highlight;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
