using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace Retrobit.Games
{
    public partial class UserControl23 : UserControl
    {
        private string rburl = string.Empty;
        public UserControl23()
        {
            InitializeComponent();
            button17.Visible = false;
            userControl241.Visible = false;
            userControl251.Visible = false;
            userControl261.Visible = false;
            userControl271.Visible = false;
            userControl281.Visible = false;
            userControl291.Visible = false;
            userControl301.Visible = false;
            userControl311.Visible = false;
            userControl321.Visible = false;
            userControl331.Visible = false;
            userControl341.Visible = false;
            userControl351.Visible = false;
            userControl361.Visible = false;
            userControl371.Visible = false;
            userControl381.Visible = false;
            userControl391.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BringToFront();
            button1.Size = new Size(275, 200);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(251, 173);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BringToFront();
            button2.Size = new Size(275, 200);
            button2.Location = new Point(237, 0);

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(251, 173);
            button2.Location = new Point(251, 0);

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BringToFront();
            button3.Size = new Size(275, 200);
            button3.Location = new Point(492, 0);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(251, 173);
            button3.Location = new Point(502, 0);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BringToFront();
            button4.Size = new Size(275, 200);
            button4.Location = new Point(730, 0);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(251, 173);
            button4.Location = new Point(753, 0);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BringToFront();
            button5.Size = new Size(275, 200);
            button5.Location = new Point(0, 160);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Size = new Size(251, 173);
            button5.Location = new Point(0, 173);

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BringToFront();
            button6.Size = new Size(275, 200);
            button6.Location = new Point(240, 160);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Size = new Size(251, 173);
            button6.Location = new Point(251, 173);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BringToFront();
            button7.Size = new Size(275, 200);
            button7.Location = new Point(490, 160);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Size = new Size(251, 173);
            button7.Location = new Point(502, 173);

        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BringToFront();
            button8.Size = new Size(275, 200);
            button8.Location = new Point(730, 160);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Size = new Size(251, 173);
            button8.Location = new Point(753, 173);

        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BringToFront();
            button9.Size = new Size(275, 200);
            button9.Location = new Point(0, 334);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Size = new Size(251, 173);
            button9.Location = new Point(0, 346);

        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BringToFront();
            button10.Size = new Size(275, 200);
            button10.Location = new Point(240, 334);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Size = new Size(251, 173);
            button10.Location = new Point(251, 346);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BringToFront();
            button11.Size = new Size(275, 200);
            button11.Location = new Point(491, 334);
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Size = new Size(251, 173);
            button11.Location = new Point(502, 346);

        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();
            button12.Size = new Size(275, 200);
            button12.Location = new Point(730, 334);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.Size = new Size(251, 173);
            button12.Location = new Point(753, 346);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BringToFront();
            button13.Size = new Size(275, 200);
            button13.Location = new Point(0, 492);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Size = new Size(251, 173);
            button13.Location = new Point(0, 519);

        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BringToFront();
            button14.Size = new Size(275, 200);
            button14.Location = new Point(240, 492);
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.Size = new Size(251, 173);
            button14.Location = new Point(251, 519);
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BringToFront();
            button15.Size = new Size(275, 200);
            button15.Location = new Point(490, 492);
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.Size = new Size(251, 173);
            button15.Location = new Point(502, 519);

        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BringToFront();
            button16.Size = new Size(275, 200);
            button16.Location = new Point(730, 492);
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.Size = new Size(251, 173);
            button16.Location = new Point(753, 519);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00030.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl271.Visible = true;
                        userControl271.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00030.php";
            }

        }

        public void button4_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00033.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl241.Visible = true;
                        userControl241.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00033.php";

            }

        }

        private void UserControl23_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00032.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl251.Visible = true;
                        userControl251.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00032.php";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            userControl241.Visible = false;
            userControl251.Visible = false;
            userControl261.Visible = false;
            userControl271.Visible = false;
            userControl281.Visible = false;
            userControl291.Visible = false;
            userControl301.Visible = false;
            userControl311.Visible = false;
            userControl321.Visible = false;
            userControl331.Visible = false;
            userControl341.Visible = false;
            userControl351.Visible = false;
            userControl361.Visible = false;
            userControl371.Visible = false;
            userControl381.Visible = false;
            userControl391.Visible = false;
            button17.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00031.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl261.Visible = true;
                        userControl261.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00031.php";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00037.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl291.Visible = true;
                        userControl291.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00037.php";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00036.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                       userControl281.Visible = true;
                       userControl281.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00036.php";
            }
        }

        private void userControl291_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00035.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl311.Visible = true;
                        userControl311.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00035.php";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00034.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl301.Visible = true;
                        userControl301.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00034.php";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00038.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl321.Visible = true;
                        userControl321.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00038.php";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00039.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl331.Visible = true;
                        userControl331.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00039.php";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00040.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl341.Visible = true;
                        userControl341.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00040.php";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00041.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl351.Visible = true;
                        userControl351.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00041.php";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00042.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl361.Visible = true;
                        userControl361.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00042.php";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00043.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl371.Visible = true;
                        userControl371.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00043.php";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00044.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl381.Visible = true;
                        userControl381.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00044.php";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            rburl = string.Empty;
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00045.smc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl391.Visible = true;
                        userControl391.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00045.php";
            }

        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(rburl);
        }

        private void UserControl23_VisibleChanged(object sender, EventArgs e)
        {
            userControl241.Visible = false;
            userControl251.Visible = false;
            userControl261.Visible = false;
            userControl271.Visible = false;
            userControl281.Visible = false;
            userControl291.Visible = false;
            userControl301.Visible = false;
            userControl311.Visible = false;
            userControl321.Visible = false;
            userControl331.Visible = false;
            userControl341.Visible = false;
            userControl351.Visible = false;
            userControl361.Visible = false;
            userControl371.Visible = false;
            userControl381.Visible = false;
            userControl391.Visible = false;
            button17.Visible = false;
        }
    }
}
