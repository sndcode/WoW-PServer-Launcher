using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Net;

namespace PTFLauncher
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        public static string setPath;
        public static string realmlistPath;
        public static string username;
        public static string password;
        public static string s_show_pw          = "false";
        public static string s_update_checks    = "false";
        public static string s_playandclose     = "false";
        public static string s_autologin        = "false";
        public static string s_autoclear        = "true";


        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fullPath = ofd.FileName;
                string fileName = ofd.SafeFileName;
                string path = fullPath.Replace(fileName, "");
                txtPath.Text = fullPath;
                setPath = fullPath;
                realmlistPath = path + "\\realmlist.wtf";
            }
            var ini = new ini(classVars.s_settingspath);
            ini.Write("path", setPath);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            
            //if(classVars.b_debug)
            //{
                
            //}
            //else
            //{
               
            //}
            
            this.TopMost = true;

            if(File.Exists(classVars.s_settingspath))
            {
                try
                { 
                    var ini                     = new ini(classVars.s_settingspath);
                    string path                 = ini.Read("path");
                    string user                 = ini.Read("user");
                    string pass                 = ini.Read("pass");
                    string show_pw              = ini.Read("show_pw");
                    string autologin            = ini.Read("autologin");
                    string playandclose         = ini.Read("playandclose");
                    string update_checks        = ini.Read("update_checks");
                    string rl                   = path.Replace("Wow.exe", "realmlist.wtf");
                    string realmlistPath        = rl;
                    string autoclear            = ini.Read("autoclear");
                    string clientversion        = ini.Read("clVersion");
                    string lanmode              = ini.Read("lanmode");
                    string s_fullrealmlist      = ini.Read("fullrealmlist");
                    classVars.s_lanmode         = lanmode;
                    classVars.cl_version        = clientversion;
                    comboBox1.Text              = classVars.cl_version;
                    classVars.s_realmlistFullContent = s_fullrealmlist;
                    setPath                     = path;
                    s_show_pw                   = show_pw;
                    s_autologin                 = autologin;
                    s_update_checks             = update_checks;
                    s_playandclose              = playandclose;
                    s_autoclear                 = autoclear;
                    string input                = pass;
                    string decoded              = Crypto.Atom128.Decode(pass);
                    pass                        = decoded;

                    txtPath.Text                = path;
                    textBox1.Text               = user;
                    textBox2.Text               = pass;
                    textBox3.Text               = classVars.s_realmlistFullContent;

                    if (s_show_pw == "true")
                    {
                        checkBox1.Checked = true;
                    }
                    else if(s_show_pw == "false")
                    {
                        checkBox1.Checked = false;
                    }
                    if (s_update_checks == "true")
                    {
                        checkBox2.Checked = true;
                    }
                    else if (s_update_checks == "false")
                    {
                        checkBox2.Checked = false;
                    }
                    if (s_playandclose == "true")
                    {
                        checkBox3.Checked = true;
                    }
                    else if (s_playandclose == "false")
                    {
                        checkBox3.Checked = false;
                    }
                    if (s_autologin == "true")
                    {
                        checkBox4.Checked = true;
                    }
                    else if (s_autologin == "false")
                    {
                        checkBox4.Checked = false;
                    }
                    if(s_autoclear == "true")
                    {
                        checkBox5.Checked = true;
                    }
                    else if(s_autoclear == "false")
                    {
                        checkBox5.Checked = false;
                    }
                    if(lanmode == "true")
                    {
                        chk_OfflineMode.Checked = true;
                    }
                    else if (lanmode == "false")
                    {
                        chk_OfflineMode.Checked = false;
                    }
                    checkPatch();
                }
                catch { MessageBox.Show("Settings file found but empty"); }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                s_show_pw = "true";
            }
            else
            {
                s_show_pw = "false";
            }
            if (checkBox4.Checked == true)
            {
                s_autologin = "true";
            }
            else
            {
                s_autologin = "false";
            }
            if (checkBox5.Checked == true)
            {
                s_autoclear = "true";
            }
            else
            {
                s_autoclear = "false";
            }
            if (chk_OfflineMode.Checked == true)
            {
                classVars.s_lanmode = "true";
            }
            else if(chk_OfflineMode.Checked == false)
            {
                classVars.s_lanmode = "false";
            }
            if(checkBox3.Checked == true)
            {
                s_playandclose = "true";
            }
            else if (checkBox3.Checked == false)
            {
                s_playandclose = "false";
            }

            string input            = textBox2.Text;
            string encoded          = Crypto.Atom128.Encode(input);
            var ini = new ini(classVars.s_settingspath);
            classVars.s_realmlistFullContent = textBox3.Text;
            classVars.cl_version = comboBox1.Text;
            ini.Write("path", setPath);
            ini.Write("user", textBox1.Text);
            ini.Write("pass", encoded);
            ini.Write("show_pw", s_show_pw);
            ini.Write("update_checks", s_update_checks);
            ini.Write("playandclose", s_playandclose);
            ini.Write("autologin", s_autologin);
            ini.Write("autoclear", s_autoclear);
            ini.Write("clVersion", classVars.cl_version);
            ini.Write("lanmode", classVars.s_lanmode);
            ini.Write("fullrealmlist", classVars.s_realmlistFullContent);
            MessageBox.Show("Settings saved!");
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = char.Parse("\0");
            else
                textBox2.PasswordChar = char.Parse("*");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                s_update_checks = "true";
            else
                s_update_checks = "false";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                s_playandclose = "true";
            else
                s_playandclose = "false";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(classVars.s_settingspath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(classVars.s_settingspath);
        
    }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("1. Checks for updates available while starting up" +
                "\n\n2.The launcher will close automatically when you click the play button." +
                "\n\n3. The launcher will use writeprocessmemory methods to send your account login " +
                "data you entered at the settings form letter by letter into the game and press enter." +
                "\n\n4. Deletes the entire Cache folder from the games installation folder after clicking play." +
                "\n\n5. Enable the LAN Mode when you want to skip the server is offline notification and connect to " +
                "servers on your local network even when they use custom ports." +
                "\n\nOther help and informations:" +
                "\nThe path to .exe textbox should contain the complete path as one string with single slashes , " +
                "use the [...] button next to it " +
                "to open the Wow.exe manually and set the string automatically." +
                "\n\nUser name and password should contain your game account data. You can choose if the launcher is " +
                "allowed to show your password " +
                "or hide the letters with a * sign. (If you are a streamer you should turn this off!." +
                "\n\nWoW Patch means the server version of the gameserver. Classic wow has 1.12.1 , Burning Crusade is 2.4.3 " +
                "and so on. Use the dropdown box to choose." +
                "\n\nYou can open your settings file with the button at the bottom to make manual changes or check settings. " +
                "The password is encrypted to have a basic protection " +
                "against file stealers. There are multiple encryption methods available but currently it is using Atom128 algorythm.");
        }//HELP

        private void checkPatch()
        {
            string s = comboBox1.Text;
            switch (s)
            {
                case "1.12.1":
                    label3.Text = "Classic";
                    break;
                case "2.4.3":
                    label3.Text = "Burning Crusade";
                    break;
                case "3.3.5":
                    label3.Text = "WotlK";
                    break;
                default:
                    label3.Text = "-";
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPatch();
        }
    }
}
