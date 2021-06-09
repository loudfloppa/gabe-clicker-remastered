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
    public partial class selectitem : Form
    {
        public selectitem()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectitem_Load(object sender, EventArgs e)
        {
            t.Start();
            
        }

        private void selectitem_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            type.Text = Form1.slotitem;
            selectedSlot = Form1.selectedSlot;
            
        }

        private int selectedSlot;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(type.Text == "empty")
            {
                MessageBox.Show("Cannot delete an object that does not exist.", "Object was not deleted.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedSlot--;
                Form1.inventoryContents[selectedSlot] = "empty";
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(type.Text == "empty")
            {
                MessageBox.Show("Cannot select an object that does not exist.", "Object was not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (type.Text == "a secret ;)")
            {
                MessageBox.Show("Cannot select an object that does not exist...?", "For some reason object was not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
