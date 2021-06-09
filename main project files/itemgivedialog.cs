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
    public partial class itemgivedialog : Form
    {
        public itemgivedialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemgivedialog_Load(object sender, EventArgs e)
        {
            name.Text = Form1.item;
            type.Text = "type: " + Form1.itemType;
            duration.Text = "duration: " + Form1.itemDuration;
            if(name.Text == "")
            {
                name.Text = "huh? this shouldn't be appearing..";
                type.Text = "ERR_NO_TYPE <-- rip bozo";
                duration.Text = "refer to instruction manual page 070320";
            }
            if (Form1.muted == false)
            {
                System.IO.Stream str = gabe_clicker_remastered.Properties.Resources.snd_itemnotification;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }
    }
}
