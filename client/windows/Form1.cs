using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Retrobit.Games
{
    public partial class home : Form
    {
        public object MyNamespace { get; private set; }

        public home()
        {
            InitializeComponent();
            userControl221.Visible = false;
            userControl231.Visible = false;
            userControl401.Visible = false;
            userControl21.BringToFront();
            userControl51.Visible = false;
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;
            webBrowser1.IsWebBrowserContextMenuEnabled = true;
            webBrowser1.Navigate("https://retrobit.games/windows.html");
            webBrowser1.BringToFront();


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (IsHorizontalScrollbarPresent)
            {
                webBrowser1.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
                ActiveForm.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
            }
        }

        public bool IsHorizontalScrollbarPresent
        {
            get
            {
                var widthofScrollableArea = webBrowser1.Document.Body.ScrollRectangle.Width;
                var widthofControl = webBrowser1.Document.Window.Size.Width;

                return widthofScrollableArea > widthofControl;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl11.BringToFront();
            userControl11.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl231.Visible = false;
            userControl231.BringToFront();
            userControl231.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl401.Visible = false;
            userControl401.BringToFront();
            userControl401.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl211.Visible = false;
            userControl211.BringToFront();
            userControl211.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void userControl22_Load(object sender, EventArgs e)
        {

        }

        private void userControl51_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControl51.BringToFront();
            userControl51.Visible = true;
        }

        private void userControl22_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl51_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl221.BringToFront();
            userControl221.Visible = true;
            userControl11.Visible = false;
            userControl51.Visible = false;
        }


    }
}
