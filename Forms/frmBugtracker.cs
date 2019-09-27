using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace PTFLauncher
{
    public partial class frmBugtracker : Form
    {
        public frmBugtracker()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && classVars.b_upl_filesize_ok)
            {
                try
                {
                    int rng;
                    rng                 = classEnv.RandomGen();
                    var ini             = new ini(classVars.s_settingspath);
                    string username     = ini.Read("user");
                    string path         = "C:\\users\\public\\" 
                        + username + "_" + rng + "_bugreport.txt";
                    File.WriteAllText(path, "\n" + DateTime.Now.ToString() + " Account Name: " + textBox1.Text + " Ort: " + textBox2.Text +
                       " Was genau : " + textBox3.Text + " Sonstiges : " + textBox4.Text + "\n");
                    WebClient uploader    = new WebClient();
                    uploader.Headers.Add("Content-Type", "binary/octet-stream");
                    byte[] result       = uploader.UploadFile(classVars.url_upl_bugreport , "POST", path);
                    
                    if (attatchedfilepath != "")
                    {
                        long length = new System.IO.FileInfo(attatchedfilepath).Length;
                        int filesize = Convert.ToInt32(length);
                        if (classVars.b_upl_filesize_ok)
                        {
                            WebClient up2 = new WebClient();
                            up2.Headers.Add("Content-Type", "image/jpeg");
                            string final = username + "_" + rng + "_" + attachedfileName;

                            try { File.Delete("C:\\users\\public\\" + final); } catch { }

                            File.Copy(attatchedfilepath, "C:\\users\\public\\" + final);
                            MessageBox.Show("Now uploading the attatchment..");
                            new Thread(() =>
                            {
                                Thread.CurrentThread.IsBackground = false;
                                byte[] result2 = up2.UploadFile(classVars.url_upl_bugreport_att, "POST", "C:\\users\\public\\" + final);

                            }).Start();
                            
                        }
                        else
                        {

                        }
                    }
                }
                catch(Exception ex)  { MessageBox.Show("Something went wrong, please try again later \n" + ex); }
                MessageBox.Show("Thank you for your help! " +
                    "\n" +
                    "A gamemaster will take care now");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.\nAlso please do not attach large file bigger than 9MB.");
            }
        }

        private void frmBugtracker_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            try
            { 
                var ini = new ini(classVars.s_settingspath);
                string username = ini.Read("user");
                textBox1.Text = username;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(classVars.url_base + "wow/files/bugs/tickets.php");
        }

        public string attatchedfilepath;
        public string attachedfileName;
        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            attatchedfilepath = "";
            attachedfileName = "";

            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Application.StartupPath;
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new
                    System.IO.StreamReader(ofd.FileName);
                    attatchedfilepath = ofd.FileName;
                    attachedfileName = ofd.SafeFileName;
                    sr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            long length = new System.IO.FileInfo(attatchedfilepath).Length;
            double finalsize = ConvertBytesToMegabytes(length);
            int filesize = Convert.ToInt32(finalsize);

            if (filesize <= classVars.i_maxuploadsize)
            {
                label5.ForeColor = System.Drawing.Color.Green;
                label5.Text = "File attatched!" /*+ filesize*/;
                classVars.b_upl_filesize_ok = true;
            }
            else
            {
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "File too big!" /*+ " " + filesize*/;
                MessageBox.Show("Your selected file is too big ! (" + filesize + " MB)");
                classVars.b_upl_filesize_ok = false;
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to take a screenshot?", "Take screenshot?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                classEnv.takeScreenshot();
            }
        }
    }
}
