using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Retrobit.Games
{

    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("Net64+-win32-x64\\Net64+.exe");
            psi.WindowStyle = ProcessWindowStyle.Minimized;
            Process p = Process.Start(psi);
            Thread.Sleep(500);
            SetParent(p.MainWindowHandle, panel1.Handle);
            CenterToScreen();
            psi.WindowStyle = ProcessWindowStyle.Normal;

            ProcessStartInfo psi2 = new ProcessStartInfo("Project64\\Project64.exe");
            psi.WindowStyle = ProcessWindowStyle.Minimized;
            Process p2 = Process.Start(psi2);
            Thread.Sleep(500);
            SetParent(p.MainWindowHandle, panel2.Handle);
            CenterToScreen();
            psi2.WindowStyle = ProcessWindowStyle.Normal;
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
