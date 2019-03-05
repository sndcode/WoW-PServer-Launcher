using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace PTFLauncher
{
    public partial class frmDownload : Form
    {
        public frmDownload()
        {
            InitializeComponent();
        }
        public static string s_dlpath;
        WebClient webClient;               
        Stopwatch sw = new Stopwatch();
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            label2.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            progressBar1.Value = e.ProgressPercentage;
            label3.Text = e.ProgressPercentage.ToString() + "%";
            label1.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }
        
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                MessageBox.Show("Download completed!");
                button1.Enabled = true;
            }
        }
        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);
                
                sw.Start();

                try
                {
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Download WoW TBC 2.4.3 ? \n" +
                "Downloading cannot be paused , you have to completely stop and restart the application.", "Download", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.BringToFront();
                button3.Enabled = true;
                string downloadfolder;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                downloadfolder = sfd.FileName + ".zip";
                s_dlpath = downloadfolder;
                button2.Enabled = false;
                label1.Text = "preparing ..";
                try
                {
                    File.Delete(downloadfolder);

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }

                try
                {
                    DownloadFile(classVars.url_download_file, downloadfolder);
                    this.Text += " - " + downloadfolder;
                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.ToString());
                }
            }
            else if (result == DialogResult.No)
            {

            }
            
        }

        private void frmDownload_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label1.Text = "";
            this.TopMost = true;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sw.Reset();
            try
            {
                File.Delete(s_dlpath);

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            MessageBox.Show("Download cant be canceled without the application to exit. We are sorry but you have to restart this program manually.");
            System.Windows.Forms.Application.Restart();
            System.Windows.Forms.Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\users\\public\\tbc.zip");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click on the tbc.zip file which is wow 2.4.3 Burning Crusade.");
            Process.Start(classVars.url_download_folder);
        }
    }
}
