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
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;

namespace Retrobit.Games
{
    public partial class UserControl19 : UserControl
    {
        public UserControl19()
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

                    //label2.Text = "Loading ROM File Now...";
                    try
                    {
                        pictureBox3.BringToFront();
                        pictureBox3.Visible = true;
                        progressBar1.BringToFront();
                        progressBar1.Visible = true;
                            try
                            {
                                client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/00025.srm", "RetroArch\\saves\\00025.srm");
                            }
                            catch (WebException tex)
                            {
                                if (((HttpWebResponse)tex.Response).StatusCode == HttpStatusCode.NotFound)
                                {
                                    label1.Text = "No Save file found.";
                                }
                            }
                        string ROMState = "00025.state";
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
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        client.DownloadFileCompleted += DownloadCompleted0025;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00025.n64"), "RetroArch\\roms\\00025.n64");
                    }
                    catch
                    {

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
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void DownloadCompleted0025(object sender, AsyncCompletedEventArgs e)
        {
            
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\mupen64plus_libretro.dll RetroArch\\roms\\00025.n64";
            process.Start();
            //label2.Text = "";
            process.WaitForExit();
            System.Threading.Thread.Sleep(1000);
            progressBar1.Visible = false;
            pictureBox3.Visible = false;
            try
            {
                NameValueCollection nvc = new NameValueCollection();
                //nvc.Add("id", "TTR");
                nvc.Add("id", Login.getName());
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\saves\\00025.srm", "uploadfile", "application/vnd.ms-excel", nvc);
            }
            catch
            {
                label1.Text = "Save File did not sync!";
            }
            string ROMState = "00025.state";
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
            if (File.Exists(@"RetroArch\\roms\\00025.n64"))
            {
                File.Delete(@"RetroArch\\roms\\00025.n64");
            }// Waits here for the process to exit.
        }
    }
}
