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
using System.IO;
using System.Collections.Specialized;
using static Retrobit.Games.Post_File;
using static Retrobit.Games.UserControl3;

namespace Retrobit.Games
{
    
    public partial class UserControl1 : UserControl
    {
       private string rburl = string.Empty;

        public UserControl1()
        {
            InitializeComponent();
            userControl171.Visible = false;
            userControl181.Visible = false;
            userControl191.Visible = false;
            userControl201.Visible = false;
            userControl31.Visible = false;
            userControl131.Visible = false;
            userControl141.Visible = false;
            userControl151.Visible = false;
            userControl161.Visible = false;
            userControl101.Visible = false;
            userControl111.Visible = false;
            userControl121.Visible = false;
            userControl61.Visible = false;
            userControl71.Visible = false;
            userControl81.Visible = false;
            userControl51.Visible = false;
            userControl91.Visible = false;
            button6.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00005.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl71.Visible = true;
                        userControl71.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00005.php";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00001.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl81.Visible = true;
                        userControl81.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00001.php";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00004.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl31.Visible = true;
                        userControl31.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00004.php";
            }

            
             

        }
        private void button4_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00008.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl61.Visible = true;
                        userControl61.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00008.php";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl101.Visible = false;
            userControl111.Visible = false;
            userControl121.Visible = false;
            userControl131.Visible = false;
            userControl141.Visible = false;
            userControl151.Visible = false;
            userControl161.Visible = false;
            userControl171.Visible = false;
            userControl181.Visible = false;
            userControl191.Visible = false;
            userControl201.Visible = false;
            userControl31.Visible = false;
            userControl61.Visible = false;
            userControl71.Visible = false;
            userControl81.Visible = false;
            userControl91.Visible = false;
            button6.Visible = false;
        }

        private void userControl31_Load_1(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void userControl81_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00002.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl91.Visible = true;
                        userControl91.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00002.php";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00003.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl101.Visible = true;
                        userControl101.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00003.php";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00006.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl111.Visible = true;
                        userControl111.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00006.php";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00007.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl121.Visible = true;
                        userControl121.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00007.php";
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BringToFront();
            button3.Size = new Size(275, 200);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(251, 173);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BringToFront();
            button5.Size = new Size(275, 200);
            button5.Location = new Point(237, 0);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Size = new Size(251, 173);
            button5.Location = new Point(251, 0);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BringToFront();
            button9.Size = new Size(275, 200);
            button9.Location = new Point(492, 0);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Size = new Size(251, 173);
            button9.Location = new Point(502, 0);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BringToFront();
            button2.Size = new Size(275, 200);
            button2.Location = new Point(730, 0);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(251, 173);
            button2.Location = new Point(753, 0);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BringToFront();
            button1.Size = new Size(275, 200);
            button1.Location = new Point(0, 160);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(251, 173);
            button1.Location = new Point(0, 173);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BringToFront();
            button7.Size = new Size(275, 200);
            button7.Location = new Point(240, 160);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Size = new Size(251, 173);
            button7.Location = new Point(251, 173);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BringToFront();
            button8.Size = new Size(275, 200);
            button8.Location = new Point(490, 160);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Size = new Size(251, 173);
            button8.Location = new Point(502, 173);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BringToFront();
            button4.Size = new Size(275, 200);
            button4.Location = new Point(730, 160);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(251, 173);
            button4.Location = new Point(753, 173);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BringToFront();
            button10.Size = new Size(275, 200);
            button10.Location = new Point(0, 334);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Size = new Size(251, 173);
            button10.Location = new Point(0, 346);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BringToFront();
            button11.Size = new Size(275, 200);
            button11.Location = new Point(240, 334);
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Size = new Size(251, 173);
            button11.Location = new Point(251, 346);
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();
            button12.Size = new Size(275, 200);
            button12.Location = new Point(491, 334);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.Size = new Size(251, 173);
            button12.Location = new Point(502, 346);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BringToFront();
            button13.Size = new Size(275, 200);
            button13.Location = new Point(730, 334);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Size = new Size(251, 173);
            button13.Location = new Point(753, 346);
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BringToFront();
            button14.Size = new Size(275, 200);
            button14.Location = new Point(0, 492);
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.Size = new Size(251, 173);
            button14.Location = new Point(0, 519);
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BringToFront();
            button15.Size = new Size(275, 200);
            button15.Location = new Point(240, 492);
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.Size = new Size(251, 173);
            button15.Location = new Point(251, 519);
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BringToFront();
            button16.Size = new Size(275, 200);
            button16.Location = new Point(490, 492);
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.Size = new Size(251, 173);
            button16.Location = new Point(502, 519);
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BringToFront();
            button17.Size = new Size(275, 200);
            button17.Location = new Point(730, 492);
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.Size = new Size(251, 173);
            button17.Location = new Point(753, 519);
        }

        private void userControl81_Load_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00009.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl131.Visible = true;
                        userControl131.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00009.php";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00010.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl141.Visible = true;
                        userControl141.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00010.php";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00022.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl151.Visible = true;
                        userControl151.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00022.php";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00021.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl161.Visible = true;
                        userControl161.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00021.php";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00026.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl201.Visible = true;
                        userControl201.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00026.php";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00025.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl191.Visible = true;
                        userControl191.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00025.php";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00024.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl181.Visible = true;
                        userControl181.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00024.php";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00023.n64");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl171.Visible = true;
                        userControl171.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00023.php";
            }
        }

        private void userControl221_Load(object sender, EventArgs e)
        {

        }

        private void userControl91_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(rburl);
        }

        private void UserControl1_VisibleChanged(object sender, EventArgs e)
        {
            userControl101.Visible = false;
            userControl111.Visible = false;
            userControl121.Visible = false;
            userControl131.Visible = false;
            userControl141.Visible = false;
            userControl151.Visible = false;
            userControl161.Visible = false;
            userControl171.Visible = false;
            userControl181.Visible = false;
            userControl191.Visible = false;
            userControl201.Visible = false;
            userControl31.Visible = false;
            userControl61.Visible = false;
            userControl71.Visible = false;
            userControl81.Visible = false;
            userControl91.Visible = false;
            button6.Visible = false;
        }

    }
}
