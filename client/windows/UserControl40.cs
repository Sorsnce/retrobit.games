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
    public partial class UserControl40 : UserControl
    {
        private string rburl = string.Empty;

        public UserControl40()
        {
            InitializeComponent();
            button6.Visible = false;
            userControl411.Visible = false;
            userControl421.Visible = false;
            userControl431.Visible = false;
            userControl441.Visible = false;
            userControl451.Visible = false;
            userControl461.Visible = false;
            userControl471.Visible = false;
            userControl481.Visible = false;
            userControl491.Visible = false;
            userControl501.Visible = false;
            userControl511.Visible = false;
            userControl521.Visible = false;
            userControl531.Visible = false;
            userControl541.Visible = false;
            userControl551.Visible = false;
            userControl561.Visible = false;
            userControl571.Visible = false;
            userControl581.Visible = false;
            userControl591.Visible = false;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BringToFront();
            button7.Size = new Size(181, 250);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Size = new Size(143, 196);

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BringToFront();
            button1.Location = new Point(124, 0);
            button1.Size = new Size(181, 250);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(143, 196);
            button1.Location = new Point(143, 0);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BringToFront();
            button2.Location = new Point(267, 0);
            button2.Size = new Size(181, 250);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Location = new Point(286, 0);
            button2.Size = new Size(143, 196);
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BringToFront();
            button14.Location = new Point(410, 0);
            button14.Size = new Size(181, 250);
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.Location = new Point(429, 0);
            button14.Size = new Size(143, 196);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BringToFront();
            button4.Location = new Point(553, 0);
            button4.Size = new Size(181, 250);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Location = new Point(572, 0);
            button4.Size = new Size(144, 196);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BringToFront();
            button5.Location = new Point(696, 0);
            button5.Size = new Size(181, 250);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Location = new Point(716, 0);
            button5.Size = new Size(144, 196);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BringToFront();
            button8.Location = new Point(823, 0);
            button8.Size = new Size(181, 250);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Location = new Point(860, 0);
            button8.Size = new Size(144, 196);
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BringToFront();
            button15.Location = new Point(0, 169);
            button15.Size = new Size(181, 250);
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.Location = new Point(0, 196);
            button15.Size = new Size(143, 196);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BringToFront();
            button3.Location = new Point(124, 169);
            button3.Size = new Size(181, 250);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Location = new Point(143, 196);
            button3.Size = new Size(143, 196);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BringToFront();
            button13.Location = new Point(267, 169);
            button13.Size = new Size(181, 250);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Location = new Point(286, 196);
            button13.Size = new Size(143, 196);
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();
            button12.Location = new Point(410, 169);
            button12.Size = new Size(181, 250);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.Location = new Point(429, 196);
            button12.Size = new Size(143, 196);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BringToFront();
            button11.Location = new Point(553, 169);
            button11.Size = new Size(181, 250);

        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Location = new Point(572, 196);
            button11.Size = new Size(144, 196);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BringToFront();
            button10.Location = new Point(697, 169);
            button10.Size = new Size(181, 250);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Location = new Point(716, 196);
            button10.Size = new Size(144, 196);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BringToFront();
            button9.Location = new Point(823, 169);
            button9.Size = new Size(181, 250);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Location = new Point(860, 196);
            button9.Size = new Size(144, 196);
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BringToFront();
            button16.Location = new Point(0, 368);
            button16.Size = new Size(237, 325);
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.Location = new Point(0, 392);
            button16.Size = new Size(201, 276);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            userControl411.Visible = false;
            userControl421.Visible = false;
            userControl431.Visible = false;
            userControl441.Visible = false;
            userControl451.Visible = false;
            userControl461.Visible = false;
            userControl471.Visible = false;
            userControl481.Visible = false;
            userControl491.Visible = false;
            userControl501.Visible = false;
            userControl511.Visible = false;
            userControl521.Visible = false;
            userControl531.Visible = false;
            userControl541.Visible = false;
            userControl551.Visible = false;
            userControl561.Visible = false;
            userControl571.Visible = false;
            userControl581.Visible = false;
            userControl591.Visible = false;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BringToFront();
            button17.Location = new Point(180, 368);
            button17.Size = new Size(237, 325);
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.Location = new Point(200, 392);
            button17.Size = new Size(201, 276);
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BringToFront();
            button18.Location = new Point(381, 368);
            button18.Size = new Size(237, 325);
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.Location = new Point(401, 392);
            button18.Size = new Size(201, 276);
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            button19.BringToFront();
            button19.Location = new Point(582, 368);
            button19.Size = new Size(237, 325);
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.Location = new Point(602, 392);
            button19.Size = new Size(201, 276);
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            button20.BringToFront();
            button20.Location = new Point(767, 368);
            button20.Size = new Size(237, 325);
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.Location = new Point(803, 392);
            button20.Size = new Size(201, 276);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00067.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl411.Visible = true;
                        userControl411.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00067.php";
            }
        }

        private void userControl411_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00066.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl421.Visible = true;
                        userControl421.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00066.php";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00052.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl431.Visible = true;
                        userControl431.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00052.php";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00058.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl441.Visible = true;
                        userControl441.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00058.php";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00054.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl451.Visible = true;
                        userControl451.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00054.php";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00055.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl461.Visible = true;
                        userControl461.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00055.php";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00056.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl471.Visible = true;
                        userControl471.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00056.php";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00064.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl481.Visible = true;
                        userControl481.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00064.php";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00065.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl491.Visible = true;
                        userControl491.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00065.php";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00050.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl501.Visible = true;
                        userControl501.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00050.php";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00051.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl511.Visible = true;
                        userControl511.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00051.php";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00060.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl521.Visible = true;
                        userControl521.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00060.php";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00057.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl531.Visible = true;
                        userControl531.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00057.php";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00053.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl541.Visible = true;
                        userControl541.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00053.php";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00059.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl551.Visible = true;
                        userControl551.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00059.php";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00068.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl561.Visible = true;
                        userControl561.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00068.php";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00061.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl571.Visible = true;
                        userControl571.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00061.php";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00062.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl581.Visible = true;
                        userControl581.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00062.php";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            bool exist = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00063.nes");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    exist = response.StatusCode == HttpStatusCode.OK;
                    using (var client = new WebClient())
                    {
                        userControl591.Visible = true;
                        userControl591.BringToFront();
                        button6.Visible = true;
                    }
                }
            }
            catch
            {
                linkLabel1.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                linkLabel1.Text = "You do not own this Game. Click here to purchase this Game.";
                rburl = "https://retrobit.games/00063.php";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(rburl);
        }

        private void UserControl40_VisibleChanged(object sender, EventArgs e)
        {
            button6.Visible = false;
            userControl411.Visible = false;
            userControl421.Visible = false;
            userControl431.Visible = false;
            userControl441.Visible = false;
            userControl451.Visible = false;
            userControl461.Visible = false;
            userControl471.Visible = false;
            userControl481.Visible = false;
            userControl491.Visible = false;
            userControl501.Visible = false;
            userControl511.Visible = false;
            userControl521.Visible = false;
            userControl531.Visible = false;
            userControl541.Visible = false;
            userControl551.Visible = false;
            userControl561.Visible = false;
            userControl571.Visible = false;
            userControl581.Visible = false;
            userControl591.Visible = false;
        }
    }
}

