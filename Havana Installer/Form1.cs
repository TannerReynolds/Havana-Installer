using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Havana_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progress.Visible = true;
            prg.Visible = true;
            System.IO.Directory.CreateDirectory(@"C:\Program Files (x86)\Havana\");
            System.IO.Directory.CreateDirectory(@"C:\Program Files (x86)\Havana\temp");
            progress.Value = 1;
            prg.Text = "Downloading NodeJS...";
            string nodejsURL = @"https://nodejs.org/dist/v10.15.1/node-v10.15.1-x64.msi";
            WebClient clientNode = new WebClient();
            clientNode.DownloadFileCompleted += new AsyncCompletedEventHandler(clientNode_DownloadNodeCompleted);
            clientNode.DownloadFileAsync(new Uri(nodejsURL), @"C:\Program Files (x86)\Havana\temp\nodejs.msi");
        }

        void clientNode_DownloadNodeCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progress.Value = 2;
            prg.Text = "Installing NodeJS...";
            string installerFilePath;
            installerFilePath = @"C:\Program Files (x86)\Havana\temp\nodejs.msi"; System.Diagnostics.Process installerProcess;
            installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
            while (installerProcess.HasExited == false)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(250);
            }
            progress.Value = 3;
            prg.Text = "NodeJS Successfully Installed...";
            string havanaURL = @"https://qoilo.com/havana.zip";
            WebClient clientQoilo = new WebClient();
            progress.Value = 4;
            prg.Text = "Downloading Havana...";
            clientQoilo.DownloadFileCompleted += new AsyncCompletedEventHandler(clientQoilo_DownloadHavanaCompleted);
            clientQoilo.DownloadFileAsync(new Uri(havanaURL), @"C:\Program Files (x86)\Havana\temp\havana.zip");

        }

        void clientQoilo_DownloadHavanaCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progress.Value = 5;
            prg.Text = "Successfully Downloaded Havana...";
            progress.Value = 6;
            prg.Text = "Extracting Havana...";
            string zipPath = @"C:\Program Files (x86)\Havana\temp\havana.zip";
            string extractPath = @"C:\Program Files (x86)\Havana\";

            ZipFile.ExtractToDirectory(zipPath, extractPath);
            progress.Value = 7;
            prg.Text = "Successfully extracted Havana...";

            FileStream fs1 = new FileStream(@"C:\Program Files (x86)\Havana\config.json", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            progress.Value = 8;
            prg.Text = "Creating Havana Config File...";
            writer.Write($"{{\"token\":\"{txt_token.Text}\",\"shardCount\":{txt_shard.Text},\"devs\":[\"{txt_owner.Text}\"],\"havana\":\"{txt_api.Text}\",\"steamToken\":\"{txt_steam.Text}\",\"guildStatChannel\":\"channel\",\"prefix\":\"{txt_prefix.Text}\",\"playing\":\"{txt_playing.Text}\",\"cooldown\":{txt_cooldown.Text},\"massCooldown\":{txt_mass.Text},\"debugMode\":false,\"adblock\":{{\"enabled\":false}},\"roleme\":{{\"enabled\":false,\"roleNames\":[\"role name 1\",\"role name 2\"]}},\"autoNick\":{{\"enabled\":false,\"nickname\":\"nickname to be auto - applied\"}},\"autoRole\":{{\"enabled\":false,\"roleName\":\"Role name(case-sensitive)\"}},\"linkBlocking\":{{\"enabled\":false,\"channels\":[\"channel ID 1\",\"channel ID 2\"]}},\"pollChannel\":{{\"enabled\":false,\"channel\":\"channel ID here\"}},\"modLogs\":{{\"enabled\":false,\"channel\":\"channel ID here\"}},\"welcomer\":{{\"enabled\":false,\"channel\":\"channel ID\"}},\"downVoteDeletes\":{{\"enabled\":false,\"channels\":[\"Channel IDs here\"],\"limit\":5}}}}");
            writer.Close();
            progress.Value = 9;
            prg.Text = "Finished Creating Config...";
            progress.Value = 10;
            prg.Text = "Finished Installing Havana!";
            progress.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void prg_Click(object sender, EventArgs e)
        {

        }
    }
}
