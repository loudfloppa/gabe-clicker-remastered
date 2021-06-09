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
    public partial class consolewindow : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        public consolewindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Tomato;
           
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.Salmon;
            
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int gabeCount;
            int gabesPerSecond;
            bool developer;
            bool debug;
            bool demonMode;

            string command = input.Text;
            string[] outputcmd = command.Split(' ');
            switch (outputcmd[0])
            {
                default:
                    output.Text = "CSE1: command root argument not defined or is invalid. did you make a typo?";
                    break;
                case "set":
                    switch (outputcmd[1])
                    {
                        default:
                            output.Text = "CSE2: command sub root argument not defined or is invalid. did you make a typo?";
                            break;
                        case "gabeCount":
                            try
                            {
                                gabeCount = Convert.ToInt32(outputcmd[2]);
                                Form1.gabes = gabeCount;
                                output.Text = "internal int gabeCount set to " + gabeCount.ToString();
                            }
                            catch
                            {
                                output.Text = "CSE3: selected sub command value not set or is out of range.";
                            }
                            break;
                        case "gabesPerSecond":
                            try
                            {
                                gabesPerSecond = Convert.ToInt32(outputcmd[2]);
                                Form1.gabes = gabesPerSecond;
                                output.Text = "internal int gabesPerSecond set to " + gabesPerSecond.ToString();
                            }
                            catch
                            {
                                output.Text = "CSE3: selected sub command value not set or is out of range.";
                            }
                            break;
                        case "demonMode":
                            try
                            {
                                demonMode = Convert.ToBoolean(outputcmd[2]);
                                Form1.demonMode = true;
                                output.Text = "special mode demonMode set to " + demonMode.ToString();
                            }
                            catch
                            {
                                output.Text = "CSE3: selected sub command value not set or is out of range.";
                            }
                            break;
                    }
                break;
                case "mode":
                    switch (outputcmd[1])
                    {
                        default:
                            output.Text = "CSE2: command sub root argument not defined or is invalid. did you make a typo?";
                            break;
                        case "developer":
                            try
                            {
                                developer = Convert.ToBoolean(outputcmd[2]);
                                output.Text = "internal bool developerModeEnabled set to " + developer.ToString();
                            }
                            catch
                            {
                                output.Text = "CSE3: selected sub command value not set or is out of range.";
                            }
                            break;
                        case "debug":
                            try
                            {
                                debug = Convert.ToBoolean(outputcmd[2]);
                                output.Text = "internal bool debugModeEnabled set to " + debug.ToString();
                            }
                            catch
                            {
                                output.Text = "CSE3: selected sub command value not set or is out of range.";
                            }
                            break;
                    }
                    break;
            }

            //string outputText = string.Join("", outputcmd);
            //output.Text = outputText;
           
        }
    }
}
