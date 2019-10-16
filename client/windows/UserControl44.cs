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
using System.Diagnostics;
using System.Collections.Specialized;
using System.IO;

namespace Retrobit.Games
{
    public partial class UserControl44 : UserControl
    {
        public UserControl44()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            progressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                label1.Text = "";
                label2.Text = "";
                try
                {


                    try
                    {
                        pictureBox3.BringToFront();
                        pictureBox3.Visible = true;
                        progressBar1.BringToFront();
                        progressBar1.Visible = true;
                        string ROMState = "00058.state";
                        try
                        {
                            client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/" + ROMState, "RetroArch\\states\\" + ROMState);
                        }
                        catch (WebException tex1)
                        {
                            if (((HttpWebResponse)tex1.Response).StatusCode == HttpStatusCode.NotFound)
                            {
                                label1.Text = "";
                            }
                        }
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
                        client.DownloadFileCompleted += DownloadCompleted00058;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00058.nes"), "RetroArch\\roms\\00058.nes");
                    }
                    catch
                    {
                        label1.Text = "You DO NOT own this Game!";
                    }
                }
                catch (WebException wex)
                {
                    if (((HttpWebResponse)wex.Response).StatusCode == HttpStatusCode.NotFound)
                    {

                    }
                }

            }
        }
        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void DownloadCompleted00058(object sender, AsyncCompletedEventArgs e)
        {
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\retrobit_nes.dll RetroArch\\roms\\00058.nes";
            process.Start();
            label2.Text = "";
            process.WaitForExit();
            System.Threading.Thread.Sleep(1000);
            progressBar1.Visible = false;
            pictureBox3.Visible = false;
            string ROMState = "00058.state";
            try
            {
                NameValueCollection nvc = new NameValueCollection();
                //nvc.Add("id", "TTR");
                nvc.Add("id", Login.getName());
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\states\\" + ROMState, "uploadfile", "application/vnd.ms-excel", nvc);
            }
            catch
            {
                label1.Text = "State File did not sync!";
            }
            if (File.Exists(@"RetroArch\\states\\" + ROMState))
            {
                File.Delete(@"RetroArch\\states\\" + ROMState);
            }
            if (File.Exists(@"RetroArch\\roms\\00058.nes"))
            {
                File.Delete(@"RetroArch\\roms\\00058.nes");
            }// Waits here for the process to exit.
        }

    }

}
