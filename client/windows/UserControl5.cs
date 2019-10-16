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
using System.Configuration;

namespace Retrobit.Games
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
            var N64 = ConfigurationManager.AppSettings["N64"];

            if (N64 == "High")
            {
                comboBox2.SelectedIndex = 2;
            }
            if (N64 == "Medium")
            {
                comboBox2.SelectedIndex = 1;
            }
            if (N64 == "Low")
            {
                    comboBox2.SelectedIndex = 0;    
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Visible = false;
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox2.SelectedItem.ToString() == "Low")
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["N64"].Value = "Low";
                config.Save(ConfigurationSaveMode.Minimal);
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/N64-Low-retroarch-core-options.cfg", "RetroArch\\retroarch-core-options.cfg");
                }
                Visible = false;
            }
                if (comboBox2.SelectedItem.ToString() == "Medium")
                {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["N64"].Value = "Medium";
                config.Save(ConfigurationSaveMode.Minimal);
                using (var client = new WebClient())
                    {
                    client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/N64-Medium-retroarch-core-options.cfg", "RetroArch\\retroarch-core-options.cfg");
                }
                    Visible = false;
                    
            }
            if (comboBox2.SelectedItem.ToString() == "High")
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["N64"].Value = "High";
                config.Save(ConfigurationSaveMode.Minimal);

                using (var client = new WebClient())
                {
                    client.DownloadFile("https://retrobit.games/storage/Settings/Graphics/N64/N64-High-retroarch-core-options.cfg", "RetroArch\\retroarch-core-options.cfg");
                }
                Visible = false;

            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
