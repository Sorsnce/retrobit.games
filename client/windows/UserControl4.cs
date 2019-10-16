﻿using System;
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
using System.Configuration;

namespace Retrobit.Games
{

    public partial class UserControl3 : UserControl
    {

        public UserControl3()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            progressBar1.Visible = false;
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ROMState = "00004.state";
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
                                client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/00004.srm", "RetroArch\\saves\\00004.srm");
                            }
                            catch (WebException tex)
                            {
                                if (((HttpWebResponse)tex.Response).StatusCode == HttpStatusCode.NotFound)
                                {
                                    label1.Text = "No Save file found.";
                                }
                            }
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
                        client.DownloadFileCompleted += DownloadCompleted00004;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00004.n64"), "RetroArch\\roms\\00004.n64");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ROMState = "00004.state";
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
                                client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/00004.srm", "RetroArch\\saves\\00004.srm");
                            }
                            catch (WebException tex)
                            {
                                if (((HttpWebResponse)tex.Response).StatusCode == HttpStatusCode.NotFound)
                                {
                                    label1.Text = "No Save file found.";
                                }
                            }
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
                        client.DownloadFileCompleted += DownloadCompleted00004;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00004.n64"), "RetroArch\\roms\\00004.n64");

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
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void DownloadCompleted00004(object sender, AsyncCompletedEventArgs e)
        {
            string ROMState = "00004.state";
            using (var client = new WebClient())
            {

                client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/LoZMM.cfg", "RetroArch\\retroarch-core-options.cfg");

            }
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\mupen64plus_libretro.dll RetroArch\\roms\\00004.n64";
            process.Start();
            label2.Text = "";
            process.WaitForExit();
            System.Threading.Thread.Sleep(1000);
            progressBar1.Visible = false;
            pictureBox3.Visible = false;
            var N64 = ConfigurationManager.AppSettings["N64"];

            if (N64 == "High")
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/N64-High-retroarch-core-options.cfg", "RetroArch\\retroarch-core-options.cfg");
                }
            }
            if (N64 == "Medium")
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/N64-Medium-retroarch-core-options.cfg", "RetroArch\\retroarch-core-options.cfg");
                }
            }
            if (N64 == "Low")
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/N64-Low-retroarch-core-options.cfg", "RetroArch\\retroarch-core-options.cfg");
                }
            }
            try
            {
                NameValueCollection nvc = new NameValueCollection();
                //nvc.Add("id", "TTR");
                nvc.Add("id", Login.getName());
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\saves\\00004.srm", "uploadfile", "application/vnd.ms-excel", nvc);
            }
            catch
            {
                label1.Text = "Save File did not sync!";
            }
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
            if (File.Exists(@"RetroArch\\roms\\00004.n64"))
            {
                File.Delete(@"RetroArch\\roms\\00004.n64");
            }// Waits here for the process to exit.
        }
        void DownloadCompleted0004(object sender, AsyncCompletedEventArgs e)
        {
            string ROMState = "00004.state";
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\mupen64plus_libretro.dll RetroArch\\roms\\00004.n64";
            process.Start();
            label2.Text = "";
            process.WaitForExit();
            System.Threading.Thread.Sleep(1000);
            progressBar1.Visible = false;
            pictureBox3.Visible = false;
            try
            {
                NameValueCollection nvc = new NameValueCollection();
                //nvc.Add("id", "TTR");
                nvc.Add("id", Login.getName());
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\saves\\00004.srm", "uploadfile", "application/vnd.ms-excel", nvc);
            }
            catch
            {
                label1.Text = "Save File did not sync!";
            }
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
            if (File.Exists(@"RetroArch\\roms\\00004.n64"))
            {
                File.Delete(@"RetroArch\\roms\\00004.n64");
            }// Waits here for the process to exit.
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
