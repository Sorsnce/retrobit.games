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
using System.Configuration;

namespace Retrobit.Games
{
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            progressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ROMState = "00005.state";
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
                            try
                            {
                                client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/00005.srm", "RetroArch\\saves\\00005.srm");
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
                        client.DownloadFileCompleted += DownloadCompleted0005;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00005.n64"), "RetroArch\\roms\\00005.n64");
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

        private void UserControl7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ROMState = "00005.state";
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
                        try
                        {
                            client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/00005.srm", "RetroArch\\saves\\00005.srm");
                        }
                        catch (WebException tex)
                        {
                            if (((HttpWebResponse)tex.Response).StatusCode == HttpStatusCode.NotFound)
                            {
                                label1.Text = "No Save file found.";
                            }
                        }
                        // Configure the process using the StartInfo properties.
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
                        client.DownloadFileCompleted += DownloadCompleted00500;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/" + Login.getName() + "/ROM/00005.n64"), "RetroArch\\roms\\00005.n64");

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

        private void button3_Click(object sender, EventArgs e)
        {
            string ROMState = "00015.state";
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
                            try
                            {
                                client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/00015.srm", "RetroArch\\saves\\00015.srm");
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
                        client.DownloadFileCompleted += DownloadCompleted00015;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/ROM/Hacks/00015.z64"), "RetroArch\\roms\\00015.z64");
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
        void DownloadCompleted00500(object sender, AsyncCompletedEventArgs e)
        {
            string ROMState = "00005.state";
            using (var client = new WebClient())
            {

             client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/LoZOOT.cfg", "RetroArch\\retroarch-core-options.cfg");

            }
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\mupen64plus_libretro.dll RetroArch\\roms\\00005.n64";
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
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\saves\\00005.srm", "uploadfile", "application/vnd.ms-excel", nvc);
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
            if (File.Exists(@"RetroArch\\roms\\00005.n64"))
            {
                File.Delete(@"RetroArch\\roms\\00005.n64");
            }// Waits here for the process to exit.
        }
        void DownloadCompleted0005(object sender, AsyncCompletedEventArgs e)
        {
            string ROMState = "00005.state";
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\mupen64plus_libretro.dll RetroArch\\roms\\00005.n64";
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
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\saves\\00005.srm", "uploadfile", "application/vnd.ms-excel", nvc);
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
            if (File.Exists(@"RetroArch\\roms\\00005.n64"))
            {
                File.Delete(@"RetroArch\\roms\\00005.n64");
            }// Waits here for the process to exit.
        }
        void DownloadCompleted00015(object sender, AsyncCompletedEventArgs e)
        {
            string ROMState = "00015.state";
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\parallel_n64_libretro.dll RetroArch\\roms\\00015.z64";
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
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\saves\\00015.srm", "uploadfile", "application/vnd.ms-excel", nvc);
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
            if (File.Exists(@"RetroArch\\roms\\00015.z64"))
            {
                File.Delete(@"RetroArch\\roms\\00015.z64");
            }// Waits here for the process to exit.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ROMState = "00017.state";
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
                        try
                        {
                            client.DownloadFile("https://retrobit.games/storage/UserID/" + Login.getName() + "/SAVES/00017.srm", "RetroArch\\saves\\00017.srm");
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
                        client.DownloadFileCompleted += DownloadCompleted00017;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/ROM/Hacks/00017.z64"), "RetroArch\\roms\\00017.z64");
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
        void DownloadCompleted00017(object sender, AsyncCompletedEventArgs e)
        {
            string ROMState = "00017.state";
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\mupen64plus_libretro.dll RetroArch\\roms\\00017.z64";
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
                Post_File.HttpUploadFile("https://retrobit.games/save.php", @"RetroArch\\saves\\00017.srm", "uploadfile", "application/vnd.ms-excel", nvc);
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
            if (File.Exists(@"RetroArch\\roms\\00017.z64"))
            {
                File.Delete(@"RetroArch\\roms\\00017.z64");
            }// Waits here for the process to exit.
        }



        private void button5_Click(object sender, EventArgs e)
        {
            // A array of authors  
            string[] authors = { "OoTR_7LARAAALK2AGNKAA2B_2S3NE974AP.z64", "OoTR_BC2AKBANBJBAAKAJAA_B327QYAWU5.z64", "OoTR_LLAPAABLKLBCNKANJB_S6GHQYKK28.z64", "OoTR_NLAPABBLKLBCNKANJB_BV6Q0K1SUH.z64",
            "OoTR_QLAPAAALKLBCNKANJB_3NZJ97X6E6.z64", "OoTR_QLAPAABLKLBCNKANJB_EUPOKSNAUL.z64", "OoTR_QLAPABALKJBCNKANJB_EJAGP2IUAG.z64", "OoTR_QLAPABALKLBCNKANJB_9ZCZR9AOBN.z64",
            "OoTR_GLAPAABLKLBCNKANJB_IY6BVZCVLO.z64", "OoTR_ALCRSFALKLACNKAAKF_AXGILHARMJ.z64" };

            // Create a Random object  
            Random rand = new Random();
            // Generate a random index less than the size of the array.  
            int index = rand.Next(authors.Length);
            // Display the result.  
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

                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        client.DownloadFileCompleted += DownloadCompleted00018;
                        client.DownloadFileAsync(new Uri("https://retrobit.games/storage/UserID/ROM/Hacks/OOTR/" + $"{authors[index]}"), "RetroArch\\roms\\00018.z64");
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
        void DownloadCompleted00018(object sender, AsyncCompletedEventArgs e)
        {

            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "RetroArch\\retroarch.exe";
            process.StartInfo.Arguments = "-L RetroArch\\cores\\mupen64plus_libretro.dll RetroArch\\roms\\00018.z64";
            process.Start();
            label2.Text = "";
            process.WaitForExit();
            System.Threading.Thread.Sleep(1000);
            progressBar1.Visible = false;
            pictureBox3.Visible = false;
            if (File.Exists(@"RetroArch\\roms\\00018.z64"))
            {
                File.Delete(@"RetroArch\\roms\\00018.z64");
            }// Waits here for the process to exit.
            if (File.Exists(@"RetroArch\\saves\\00018.srm"))
            {
                File.Delete(@"RetroArch\\saves\\00018.srm");
            }// Waits here for the process to exit.
        }
    }
}
