using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Linq;

namespace PTFLauncher
{
    public class classNetworking
    {
        public bool testWorldServer()
        {
            TcpClient tc = new TcpClient();
            try
            {
                tc.Connect(classVars.ip_worldserver, classVars.port_worldserver);
                bool stat = tc.Connected;
                if (stat)
                    return true;

                tc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            tc.Close();
            return false;
        }
        public static bool updateAvailable()//Needs a rework since it cant decide between 0094 alpha and 010 beta 
        {
            try
            {   
                WebClient wc = new WebClient();
                string s = wc.DownloadString(classVars.url_version);
                string s2 = classVars.appversion;
                classVars.version_server = s;

                if (s != s2)
                {
                    
                    int i = Convert.ToInt32(s.Replace(".", ""));//Server
                    int i2 = Convert.ToInt32(s2.Replace(".", ""));//Local

                    //MessageBox.Show("Server Version : " + i.ToString() + " Local Version : " + i2.ToString());
                    

                    string build;
                    /* Alpha 0.0.1
                     * Beta 0.1.0
                     * release 0.1.0
                     */

                    if (i > i2)
                    {
                        return true;
                    }
                    else if (i < i2)
                    {
                        classVars.b_devUpdate = true;
                        return false;
                    }
                    
                    return false;
                }
                
                return false;
            }
            catch
            {
                return false;
            }
        }
        public static bool checkConnection()
        {
            WebClient wc = new WebClient();
            try
            {
                wc.DownloadString(classVars.url_s_online);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
