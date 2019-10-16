using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Retrobit.Games
{
    public partial class UserControl21 : UserControl
    {
        private string rburl = string.Empty;

        public UserControl21()
        {
            InitializeComponent();
            button17.Visible = false;
            userControl601.Visible = false;
            userControl611.Visible = false;
            userControl621.Visible = false;
            userControl631.Visible = false;
            userControl641.Visible = false;
            userControl651.Visible = false;
            userControl661.Visible = false;
            userControl671.Visible = false;
            userControl681.Visible = false;
            userControl691.Visible = false;
            userControl701.Visible = false;
            userControl711.Visible = false;
            userControl721.Visible = false;
            userControl731.Visible = false;
            userControl741.Visible = false;
            userControl751.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00080.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl651.Visible = true;
                        userControl651.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00080.php";
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BringToFront();
            button5.Size = new Size(302, 325);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Size = new Size(251, 270);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BringToFront();
            button2.Size = new Size(302, 325);
            button2.Location = new Point(226, 0);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(251, 270);
            button2.Location = new Point(251, 0);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BringToFront();
            button1.Size = new Size(302, 325);
            button1.Location = new Point(477, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(251, 270);
            button1.Location = new Point(502, 0);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BringToFront();
            button3.Size = new Size(302, 325);
            button3.Location = new Point(702, 0);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(251, 270);
            button3.Location = new Point(753, 0);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BringToFront();
            button4.Size = new Size(302, 325);
            button4.Location = new Point(0, 242);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(251, 270);
            button4.Location = new Point(0, 270);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BringToFront();
            button6.Size = new Size(302, 325);
            button6.Location = new Point(225, 242);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Size = new Size(251, 270);
            button6.Location = new Point(251, 270);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BringToFront();
            button7.Size = new Size(302, 325);
            button7.Location = new Point(477, 242);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Size = new Size(251, 270);
            button7.Location = new Point(502, 270);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BringToFront();
            button8.Size = new Size(302, 325);
            button8.Location = new Point(702, 242);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Size = new Size(251, 270);
            button8.Location = new Point(753, 270);
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();
            button12.Size = new Size(187, 200);
            button12.Location = new Point(0, 508);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
           button12.Size = new Size(126, 135);
           button12.Location = new Point(0, 540);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BringToFront();
            button11.Size = new Size(187, 200);
            button11.Location = new Point(105, 508);
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Size = new Size(126, 135);
            button11.Location = new Point(125, 540);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BringToFront();
            button9.Size = new Size(187, 200);
            button9.Location = new Point(232, 508);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Size = new Size(126, 135);
            button9.Location = new Point(252, 540);
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BringToFront();
            button14.Size = new Size(187, 200);
            button14.Location = new Point(357, 508);
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.Size = new Size(126, 135);
            button14.Location = new Point(377, 540);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BringToFront();
            button10.Size = new Size(187, 200);
            button10.Location = new Point(483, 508);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Size = new Size(126, 135);
            button10.Location = new Point(503, 540);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BringToFront();
            button13.Size = new Size(187, 200);
            button13.Location = new Point(608, 508);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Size = new Size(126, 135);
            button13.Location = new Point(628, 540);
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BringToFront();
            button15.Size = new Size(187, 200);
            button15.Location = new Point(734, 508);
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.Size = new Size(126, 135);
            button15.Location = new Point(754, 540);
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BringToFront();
            button16.Size = new Size(187, 200);
            button16.Location = new Point(820, 508);
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.Size = new Size(126, 135);
            button16.Location = new Point(880, 540);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00073.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl601.Visible = true;
                        userControl601.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00073.php";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
            userControl601.Visible = false;
            userControl611.Visible = false;
            userControl621.Visible = false;
            userControl631.Visible = false;
            userControl641.Visible = false;
            userControl651.Visible = false;
            userControl661.Visible = false;
            userControl671.Visible = false;
            userControl681.Visible = false;
            userControl691.Visible = false;
            userControl701.Visible = false;
            userControl711.Visible = false;
            userControl721.Visible = false;
            userControl731.Visible = false;
            userControl741.Visible = false;
            userControl751.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00074.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl611.Visible = true;
                        userControl611.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00074.php";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00085.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl621.Visible = true;
                        userControl621.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00085.php";
            }
        }

        private void userControl611_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00075.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl631.Visible = true;
                        userControl631.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00075.php";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00070.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl641.Visible = true;
                        userControl641.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00070.php";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00081.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl661.Visible = true;
                        userControl661.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00081.php";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00082.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl671.Visible = true;
                        userControl671.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00082.php";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00076.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl681.Visible = true;
                        userControl681.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00076.php";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00072.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl691.Visible = true;
                        userControl691.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00072.php";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00077.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl701.Visible = true;
                        userControl701.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00077.php";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00071.gbc");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl711.Visible = true;
                        userControl711.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00071.php";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00084.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl721.Visible = true;
                        userControl721.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00084.php";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00079.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl731.Visible = true;
                        userControl731.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00079.php";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00078.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl741.Visible = true;
                        userControl741.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00078.php";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00083.gba");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl751.Visible = true;
                        userControl751.BringToFront();
                        button17.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00083.php";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(rburl);
        }

        private void UserControl21_VisibleChanged(object sender, EventArgs e)
        {
            button17.Visible = false;
            userControl601.Visible = false;
            userControl611.Visible = false;
            userControl621.Visible = false;
            userControl631.Visible = false;
            userControl641.Visible = false;
            userControl651.Visible = false;
            userControl661.Visible = false;
            userControl671.Visible = false;
            userControl681.Visible = false;
            userControl691.Visible = false;
            userControl701.Visible = false;
            userControl711.Visible = false;
            userControl721.Visible = false;
            userControl731.Visible = false;
            userControl741.Visible = false;
            userControl751.Visible = false;
        }
    }
}
