using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;


namespace gabe_clicker_remastered
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

        public static int gabes;
        public static int gPS;
        public static bool developerModeEnabled;
        public static bool demonMode;
        public static string[] inventoryContents = {"empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty"};

        // #####################################################################
        // version info
        public static string fileVersion = "1.0.0";
        public static string build = "0765";
        //######################################################################

        private void redraw()
        {
            if(demonMode == true)
            {
                gabeClick.BackgroundImage = gabe_clicker_remastered.Properties.Resources.ui_easteregg1_scary;
                gabeClick.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                gabeClick.BackgroundImage = gabe_clicker_remastered.Properties.Resources.ui_gabethegodofthisuniverseiloveyou;
                gabeClick.BackgroundImageLayout = ImageLayout.Stretch;
            }
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.Highlight;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void shop_MouseEnter(object sender, EventArgs e)
        {
            shop.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void shop_MouseLeave(object sender, EventArgs e)
        {
            shop.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(24, 24, 24);
        }

        private bool toggle = true;

        private void anim_menuExpand()
        {
            
            if(label4.Width < 140)
            {
                anim_menu.Start();
            }
            else
            {
                label4.Width = 140;
                anim_menu.Stop();
                menuName.Visible = true;
                shopName.Visible = true;
                powerName.Visible = true;
                settingsName.Visible = true;
                label52.Visible = true;
                if (consolelabelEnabled)
                {
                    label53.Visible = true;
                }

                
            }
        }
        // fart uwu
        private void anim_menuContract()
        {

            if (label4.Width > 42)
            {
                menuName.Visible = false;
                shopName.Visible = false;
                powerName.Visible = false;
                settingsName.Visible = false;
                label52.Visible = false;
                label53.Visible = false;
                anim_menu1.Start();
            }
            else
            {
                label4.Width = 42;
                anim_menu1.Stop();
                
            }
        }

        private void anim_menu1_Tick(object sender, EventArgs e)
        {
            label4.Width = label4.Width - 10;
            anim_menuContract();
        }

        private void anim_menu_Tick(object sender, EventArgs e)
        {
            label4.Width = label4.Width + 10;
            anim_menuExpand();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(toggle == true)
            {
                anim_menuExpand();
                toggle = false;
            }
            else
            {
                anim_menuContract();
                toggle = true;
            }

            
        }

        private bool shopToggle = true;

        


        private void shop_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.snd_shop_music;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            if (shopToggle == true)
            {
                updateShopGabes();
                shopWindow.Visible = true;
                shopToggle = false;
                if (muted == false)
                {
                    snd.Play();
                }
            }
            else
            {
                snd.Stop();
                updateMainGabes();
                label29.Text = "";
                shopWindow.Visible = false;
                settingsPanel.Visible = false;
                shopToggle = true;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            loadGame();

            //string banned = ConfigurationSettings.AppSettings.Get("banned");
            //if(banned == "1")
            //{
            //    banPanel.Visible = true;
            //    code.Text = "code: previous_ban_detected";
            //}

            string g;
            //g = ConfigurationSettings.AppSettings.Get("gabenCount");
            //gabes = Convert.ToInt32(g);
            label27.Text = gabes.ToString() + " gabes";
            string gp;
            //gp = ConfigurationSettings.AppSettings.Get("gabesperSecond");
            //gPS = Convert.ToInt32(gp);
            label28.Text = gPS.ToString() + " gabes per second";


            
        }

        private void loadGame()
        {
            // get the amount of gabes from app.config
            gabes = Convert.ToInt32(ConfigurationSettings.AppSettings.Get("gabenCount"));
            label27.Text = gabes.ToString() + " gabes";
            // get the amount of gabes per second from app.config
            gPS = Convert.ToInt32(ConfigurationSettings.AppSettings.Get("gabesperSecond"));
            label28.Text = gPS.ToString() + " gabes per second";
            // check if developer mode is enabled
            developerModeEnabled = Convert.ToBoolean(ConfigurationSettings.AppSettings.Get("developerEnabled"));
            if(developerModeEnabled == true)
            {
                label44.Visible = true;
                console.Visible = true;
            }
            else
            {
                label44.Visible = false;
                console.Visible = false;
            }

            debugtext.Text = "game loaded:\n retrieved gabes: " + gabes + "\n retrieved gPS: " + gPS;
            
        }

        public void updateDeveloperModeStatus()
        {
            if (developerModeEnabled == true)
            {
                label44.Visible = true;
                console.Visible = true;
            }
            else
            {
                label44.Visible = false;
                console.Visible = false;
            }
        }

        private void saveGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Failed to save.", "gabe clicker remastered - save system does not exist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateMainGabes()
        {
            label27.Text = gabes.ToString() + " gabes";
            label28.Text = gPS.ToString() + " gabes per second";
        }

        public static string tempRarity;
        public static string tempName;

        private int tG2;
        private int tG1;
        public static Random r = new Random();
        private void gabeClick_Click(object sender, EventArgs e)
        {
            tG1 = gabes;

            gabes++;
            updateMainGabes();
            int v = 0;
            v = r.Next(1, 1000);

            if(v > 940)
            {
                getRandomitem();
            }
            
            
            compareTG();
        }
        public static string item;
        public static string itemType;
        public static string itemDuration;
        private void getRandomitem()
        {
            
            int v = r.Next(1, 5);
            switch (v)
            {
                case 1:
                    item = "engineer gaming shard";
                    itemType = "ingredient";
                    itemDuration = "";
                    break;
                case 2:
                    item = "gabe shard";
                    itemType = "ingredient";
                    itemDuration = "";
                    break;
                case 3:
                    item = "monkenite";
                    itemType = "ingredient";
                    itemDuration = "";
                    break;
                case 4:
                    item = "2x gabes per click";
                    itemType = "booster";
                    itemDuration = "5 minutes";
                    break;
                case 5:
                    item = "2x gabes per second";
                    itemType = "booster";
                    itemDuration = "5 minutes";
                    break;
            }
            itemdialogShow();
            if(inventoryContents[0] == "empty")
            {
                inventoryContents[0] = item;
            }
            else
            {
                if(inventoryContents[1] == "empty")
                {
                    inventoryContents[1] = item;
                }
                else
                {
                    if(inventoryContents[2] == "empty")
                    {
                        inventoryContents[2] = item;
                    }
                    else
                    {
                        if(inventoryContents[3] == "empty")
                        {
                            inventoryContents[3] = item;
                        }
                        else
                        {
                            if(inventoryContents[4] == "empty")
                            {
                                inventoryContents[4] = item;
                            }
                            else
                            {
                                if(inventoryContents[5] == "empty")
                                {
                                    inventoryContents[5] = item;
                                }
                                else
                                {
                                    if(inventoryContents[6] == "empty")
                                    {
                                        inventoryContents[6] = item;
                                    }
                                    else
                                    {
                                        if(inventoryContents[7] == "empty")
                                        {
                                            inventoryContents[7] = item;
                                        }
                                        else
                                        {
                                            if(inventoryContents[8] == "empty")
                                            {
                                                inventoryContents[8] = item;
                                            }
                                            else
                                            {
                                                if(inventoryContents[9] == "empty")
                                                {
                                                    inventoryContents[9] = item;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Could not give item.");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void itemdialogShow()
        {
            itemgivedialog i = new itemgivedialog();
            i.Show();
        }

        private void compareTG()
        {
            int difference = Math.Abs(tG1 - tG2);
            label49.Text = ("cps: " + difference);
            label50.Text = "tg1: " + tG1.ToString();
            label51.Text = "tg2: " + tG2.ToString();
            if(difference > 20)
            {
                banPanel.Visible = true;
                code.Text = "code: click_speed_exceeds_maximum";
                //ConfigurationSettings.AppSettings.Remove("GAC");
                //ConfigurationSettings.AppSettings.Add("GAC", "1");
            }
            
        }

        private void AACticker_Tick(object sender, EventArgs e)
        {
            gabes = gabes + gPS;
            redraw();
            updateDeveloperModeStatus();
            checkMenuConsoleButton();
            tG2 = gabes;
            // check for running autoclickers
            Process[] pname = Process.GetProcessesByName("AutoClicker");
            if (pname.Length != 0)
            {
                banPanel.Visible = true;
                code.Text = "code: process_detected";
                //ConfigurationSettings.AppSettings.Remove("GAC");
                //ConfigurationSettings.AppSettings.Add("GAC", "1");
            }

            //use the timer to update the amount of gabes in the shop
            updateShopGabes();
            updateProfiler();
            updateMainGabes();
            slot1.Text = inventoryContents[0];
            slot2.Text = inventoryContents[1];
            slot3.Text = inventoryContents[2];
            slot4.Text = inventoryContents[3];
            slot5.Text = inventoryContents[4];
            slot6.Text = inventoryContents[5];
            slot7.Text = inventoryContents[6];
            slot8.Text = inventoryContents[7];
            slot9.Text = inventoryContents[8];
            slot10.Text = inventoryContents[9];


        }

        private void checkMenuConsoleButton()
        {
            if(developerModeEnabled == true)
            {
                if(console.Checked == true)
                {
                    pictureBox9.Visible = true;
                    consolelabelEnabled = true;
                }
                else
                {
                    pictureBox9.Visible = false;
                    consolelabelEnabled = false;
                }
            }
            else
            {
            
            pictureBox9.Visible = false;
            consolelabelEnabled = false;
             
            }
        }

        private void updateShopGabes()
        {
            updateMainGabes();
            money.Text = "you have " + gabes.ToString() + " gabes";
            if(gabes < 0)
            {
                money.Text = "request failed";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gabes < 50)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 2;
                gabes = gabes - 50;
                updateShopGabes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gabes < 125)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 5;
                gabes = gabes - 125;
                updateShopGabes();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gabes < 375)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 15;
                gabes = gabes - 375;
                updateShopGabes();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gabes < 875)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 35;
                gabes = gabes - 875;
                updateShopGabes();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gabes < 10000)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 150;
                gabes = gabes - 10000;
                updateShopGabes();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gabes < 50000)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 750;
                gabes = gabes - 50000;
                updateShopGabes();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gabes < 200000)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 3000;
                gabes = gabes - 200000;
                updateShopGabes();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gabes < 600000)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 9000;
                gabes = gabes - 600000;
                updateShopGabes();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (gabes < 1000000)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 15000;
                gabes = gabes - 1000000;
                updateShopGabes();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (gabes < 10000000)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 150000;
                gabes = gabes - 10000000;
                updateShopGabes();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (gabes < 100000000)
            {
                label29.Text = "purchase failed";
                label29.ForeColor = Color.Red;
            }
            else
            {
                label29.Text = "purchase successful";
                label29.ForeColor = Color.Green;
                gPS = gPS + 1500000;
                gabes = gabes - 100000000;
                updateShopGabes();
            }
        }
        private bool toggle1 = false;
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            if (toggle == true)
            {
                settingsPanel.Visible = true;
                toggle = false;
            }
            else
            {
                toggle = true;
                shopWindow.Visible = false;
                settingsPanel.Visible = false;

            }
        }

        private void clrGAC_Click(object sender, EventArgs e)
        {
            cleargac clr = new cleargac();
            clr.Show();
        }

        private void dbgmode_CheckedChanged(object sender, EventArgs e)
        {
            if(dbgmode.Checked == true)
            {
                showcps.Enabled = true;
                saveoutput.Enabled = true;
                console.Enabled = true;
                label46.Visible = true;
            }
            else
            {
                showcps.Enabled = false;
                showcps.Checked = false;
                saveoutput.Enabled = false;
                saveoutput.Checked = false;
                console.Enabled = false;
                console.Checked = false;
                label46.Visible = false;
            }
        }

        private void saveoutput_CheckedChanged(object sender, EventArgs e)
        {
            if (saveoutput.Checked == true)
            {
                debugtext.Visible = true;
                
            }
            else
            {
                debugtext.Visible = false;
            }
        }

        private void devMode_Click(object sender, EventArgs e)
        {
            gabe_clicker_remastered.devmode devDialog = new gabe_clicker_remastered.devmode();
            devDialog.Show();
        }

        public static bool muted;
        private void mutegame_CheckedChanged(object sender, EventArgs e)
        {
            if (mutegame.Checked)
            {
                muted = true;
            }
            else
            {
                muted = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            developerModeEnabled = false;
            console.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            gameinfo gameinfo = new gameinfo();
            gameinfo.Show();
        }

        private void saveoutput_CheckedChanged_1(object sender, EventArgs e)
        {
            if (saveoutput.Checked)
            {
                debugtext.Visible = true;
            }
            else
            {
                debugtext.Visible = false;
            }
        }

        Process process = Process.GetCurrentProcess();

        private void updateProfiler()
        {
            long memoryUsage = process.WorkingSet64;
            label48.Text = "memory: " + memoryUsage.ToString();
        }

        private void showcps_CheckedChanged(object sender, EventArgs e)
        {
            if (showcps.Checked)
            {
                profiler.Visible = true;
            }
            else
            {
                profiler.Visible = false;
            }
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.FromArgb(24, 24, 24);
        }
        private bool consolelabelEnabled;
        private void console_CheckedChanged(object sender, EventArgs e)
        {
            if (console.Enabled == true)
            {
                updateDeveloperModeStatus();
                pictureBox9.Visible = true;
                consolelabelEnabled = true;
            }
            else
            {
                updateDeveloperModeStatus();
                pictureBox9.Visible = false;
                consolelabelEnabled = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            patchdialog patches = new patchdialog();
            patches.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            consolewindow consolewindow = new consolewindow();
            consolewindow.Show();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            System.IO.Stream str = gabe_clicker_remastered.Properties.Resources.trolled;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        bool invtoggle;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (invtoggle == true)
            {
                invtoggle = false;
                inventoryPanel.Visible = true;
                inventoryLoad();
            }
            else
            {
                invtoggle = true;
                inventoryPanel.Visible = false;
            }
        }

        private void inventoryLoad()
        {
            slot1.Text = inventoryContents[0];
            slot2.Text = inventoryContents[1];
            slot3.Text = inventoryContents[2];
            slot4.Text = inventoryContents[3];
            slot5.Text = inventoryContents[4];
            slot6.Text = inventoryContents[5];
            slot7.Text = inventoryContents[6];
            slot8.Text = inventoryContents[7];
            slot9.Text = inventoryContents[8];
            slot10.Text = inventoryContents[9];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            craftingwindow.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            craftingwindow.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("plz remov thx");
        }

        private void slot1_MouseEnter(object sender, EventArgs e)
        {
            slot1.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot1_MouseLeave(object sender, EventArgs e)
        {
            slot1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot2_MouseEnter(object sender, EventArgs e)
        {
            slot2.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot2_MouseLeave(object sender, EventArgs e)
        {
            slot2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot3_MouseEnter(object sender, EventArgs e)
        {
            slot3.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot3_MouseLeave(object sender, EventArgs e)
        {
            slot3.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot4_MouseEnter(object sender, EventArgs e)
        {
            slot4.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot4_MouseLeave(object sender, EventArgs e)
        {
            slot4.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot5_MouseEnter(object sender, EventArgs e)
        {
            slot5.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot5_MouseLeave(object sender, EventArgs e)
        {
            slot5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot6_MouseEnter(object sender, EventArgs e)
        {
            slot6.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot6_MouseLeave(object sender, EventArgs e)
        {
            slot6.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot7_MouseEnter(object sender, EventArgs e)
        {
            slot7.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot7_MouseLeave(object sender, EventArgs e)
        {
            slot7.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot8_MouseEnter(object sender, EventArgs e)
        {
            slot8.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot8_MouseLeave(object sender, EventArgs e)
        {
            slot8.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot9_MouseEnter(object sender, EventArgs e)
        {
            slot9.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot9_MouseLeave(object sender, EventArgs e)
        {
            slot9.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void slot10_MouseEnter(object sender, EventArgs e)
        {
            slot10.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void slot10_MouseLeave(object sender, EventArgs e)
        {
            slot10.BackColor = Color.FromArgb(64, 64, 64);
        }
        public static string slotitem;
        public static int selectedSlot;
        private void slot1_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot1.Text;
            selectedSlot = 1;
        }

        private void slot2_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot2.Text;
            selectedSlot = 2;
        }

        private void slot3_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot3.Text;
            selectedSlot = 3;
        }

        private void slot4_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot4.Text;
            selectedSlot = 4;
        }

        private void slot5_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot5.Text;
            selectedSlot = 5;
        }

        private void slot6_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot6.Text;
            selectedSlot = 6;
        }

        private void slot7_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot7.Text;
            selectedSlot = 7;
        }

        private void slot8_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot8.Text;
            selectedSlot = 8;
        }

        private void slot9_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot9.Text;
            selectedSlot = 9;
        }

        private void slot10_Click(object sender, EventArgs e)
        {
            openItemOptions();
            slotitem = slot10.Text;
            selectedSlot = 10;
        }

        private void openItemOptions()
        {
            selectitem i = new selectitem();
            i.Show();
        }
        public bool secret1found;
        private void powerName_Click(object sender, EventArgs e)
        {
            
            if (secret1found == true)
            {
                MessageBox.Show("It seems you have this already? What..");
            }
            else
            {
                itemgivedialog i = new itemgivedialog();
                i.Show();
                item = "a secret ;)";
                itemType = "???";
                itemDuration = "???";
                if (inventoryContents[0] == "empty")
                {
                    inventoryContents[0] = item;
                }
                else
                {
                    if (inventoryContents[1] == "empty")
                    {
                        inventoryContents[1] = item;
                    }
                    else
                    {
                        if (inventoryContents[2] == "empty")
                        {
                            inventoryContents[2] = item;
                        }
                        else
                        {
                            if (inventoryContents[3] == "empty")
                            {
                                inventoryContents[3] = item;
                            }
                            else
                            {
                                if (inventoryContents[4] == "empty")
                                {
                                    inventoryContents[4] = item;
                                }
                                else
                                {
                                    if (inventoryContents[5] == "empty")
                                    {
                                        inventoryContents[5] = item;
                                    }
                                    else
                                    {
                                        if (inventoryContents[6] == "empty")
                                        {
                                            inventoryContents[6] = item;
                                        }
                                        else
                                        {
                                            if (inventoryContents[7] == "empty")
                                            {
                                                inventoryContents[7] = item;
                                            }
                                            else
                                            {
                                                if (inventoryContents[8] == "empty")
                                                {
                                                    inventoryContents[8] = item;
                                                }
                                                else
                                                {
                                                    if (inventoryContents[9] == "empty")
                                                    {
                                                        inventoryContents[9] = item;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Could not give item.");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                secret1found = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
