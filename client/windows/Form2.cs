using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Retrobit.Games
{

    public partial class Login : Form
    {
        string path = Directory.GetCurrentDirectory();
        MySqlConnection con = new MySqlConnection(@"Data Source=retrobit.games;port=3306;Initial Catalog=sys;User Id=admin;password='hortonanthony'");
        int il;
        int it;
        int it1;
        public MySqlConnection databaseCon;
        public static string UserID;
        public static string getName()
        {
            return UserID;
        }
        public static string UserHash;
        public static string SubscriberID;
        public static string getName1()
        {
            return UserHash;
        }
        public object GlobalVariable { get; }


        public Login()
        {
            InitializeComponent();
            GlobalVariable = textBox1.Text;
            this.ActiveControl = textBox1;
        }



        public void button8_Click(object sender, EventArgs e)
        {
            if (File.Exists(path + "\\RetroArch\\content_image_history.lpl"))
            {
                File.Delete(path + "\\RetroArch\\content_image_history.lpl");
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { path + "\\RetroArch\\screenshots\\Controls-N64.jpg" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "builtin" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "imageviewer" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "" });
            }
            else
            {
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { path + "\\RetroArch\\screenshots\\Controls-N64.jpg" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "builtin" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "imageviewer" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "" });
                File.AppendAllLines(path + "\\RetroArch\\content_image_history.lpl", new[] { "" });
            }
            try
            {
                con.Open();
                //string password = textBox2.Text;
                //string cryptedPassword = Crypter.Blowfish.Crypt(password);

                it = 0;
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT password FROM users WHERE username='" + textBox1.Text + "'";
                cmd2.ExecuteNonQuery();
                DataTable dtll = new DataTable();
                MySqlDataAdapter dall = new MySqlDataAdapter(cmd2);
                dall.Fill(dtll);
                it = Convert.ToInt32(dtll.Rows.Count.ToString());

                it1 = 0;
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "SELECT subscriber FROM users WHERE username='" + textBox1.Text + "'";
                cmd3.ExecuteNonQuery();
                DataTable dtll2 = new DataTable();
                MySqlDataAdapter dall2 = new MySqlDataAdapter(cmd3);
                dall2.Fill(dtll2);
                it1 = Convert.ToInt32(dtll2.Rows.Count.ToString());

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

                MySqlDataReader reader1 = cmd2.ExecuteReader();
                while (reader1.Read())
                {

                    UserHash = Convert.ToString(reader1["password"].ToString());

                }
                con.Close();
                con.Open();

                MySqlDataReader reader2 = cmd3.ExecuteReader();
                while (reader2.Read())
                {

                SubscriberID = Convert.ToString(reader2["subscriber"].ToString());

                }
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(textBox2.Text);
                string subid = SubscriberID;
                try
                {
                    bool validPassword = BCrypt.Net.BCrypt.Verify(textBox2.Text, UserHash);
                    if (validPassword == false)
                    {
                        label5.Text = "You have enterred an invalid Username or Password";
                    }
                    else
                    {

                        if (subid == "True")
                        {
                            this.Hide();
                            home fm = new home();
                            fm.Show();
                        }
                        else
                        {
                            label5.Text = "Please purchase a Retro Pass subscription";
                        }
                    }
                }
                catch
                {
                    label5.Text = "You have enterred an invalid Username or Password";
                }
                con.Close();

                con.Open();
                il = 0;
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT ID FROM users WHERE username='" + textBox1.Text + "'";
                cmd1.ExecuteNonQuery();
                DataTable dtl = new DataTable();
                MySqlDataAdapter dal = new MySqlDataAdapter(cmd1);
                dal.Fill(dtl);
                il = Convert.ToInt32(dtl.Rows.Count.ToString());

                MySqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {

                    UserID = Convert.ToString(reader["ID"].ToString());

                }

                var cmd = new MySqlCommand("SELECT 1 FROM table WHERE id = 1", databaseCon);
                //int id = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch
            {
                label5.Text = "RetroBit.Games was unable to connect to the Internet";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }

}
