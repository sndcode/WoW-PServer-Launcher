using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Linq;
using System.Text.RegularExpressions;

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
        public static bool serverbranchnewer;
        public static bool updateAvailable()
        {
            try
            {
                WebClient wc = new WebClient();
                string serverversion = wc.DownloadString(classVars.url_version).Replace(".", "");
                string localversion = classVars.appversion.Replace(".", "");
                classVars.version_server = serverversion;
                classVars.version_local = localversion;
                //Init branches
                string serverbranch     = "";
                string localbranch      = "";
                
                ///////////////////////// Branch checks
                if (serverversion.Contains("a"))
                {
                    serverbranch = "alpha";
                }
                else if(serverversion.Contains("b"))
                {
                    serverbranch = "beta";
                }
                else if (serverversion.Contains("r"))
                {
                    serverbranch = "release";
                }
                if (localversion.Contains("a"))
                {
                    localbranch = "alpha";
                }
                else if (localversion.Contains("b"))
                {
                    localbranch = "beta";
                }
                else if (localversion.Contains("r"))
                {
                    localbranch = "release";
                }

                if(serverbranch == "alpha" && localbranch == "alpha")
                {
                    serverbranchnewer = true;
                }
                else if (serverbranch == "alpha" && localbranch == "beta")
                {
                    serverbranchnewer = false;
                }
                else if (serverbranch == "alpha" && localbranch == "release")
                {
                    serverbranchnewer = false;
                }
                else if (serverbranch == "beta" && localbranch == "alpha")
                {
                    serverbranchnewer = true;
                }

                else if (serverbranch == "release" && localbranch == "alpha")
                {
                    serverbranchnewer = true;
                }
                else if (serverbranch == "beta" && localbranch == "beta")
                {
                    serverbranchnewer = true;
                }
                else if (serverbranch == "release" && localbranch == "beta")
                {
                    serverbranchnewer = true;
                }

                //Also Store publicly
                classVars.s_localbranch     = localbranch;
                classVars.s_serverbranch    = serverbranch;

                //////////////////////////////////// detail check
                if (serverversion != localversion)
                {
                    string serverversion02  = Regex.Replace(serverversion.Replace("0", ""), "[^.0-9]", "");
                    string localversion02   = Regex.Replace(localversion.Replace("0", ""), "[^.0-9]", "");

                    int iserver = Convert.ToInt32(serverversion02);//Server
                    int ilocal = Convert.ToInt32(localversion02);//Local

                    if (iserver > ilocal && serverbranchnewer)
                    {
                        return true;
                    }
                    else if (iserver < ilocal && !serverbranchnewer)
                    {
                        //classVars.b_devUpdate = true;
                        return false;
                    }
                    else if (iserver < ilocal && serverbranchnewer)
                    {
                        //classVars.b_devUpdate = true;
                        return true;
                    }

                    // return false;
                }

                return false;
            }

            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public static bool checkConnection()
        {
            //WebClient wc = new WebClient();
            //try
            //{
            //    wc.DownloadString(classVars.url_s_online);
            //    return true;
            //}
            //catch
            //{   //TODO : add GLOBAL check to make sure Launcher works in LAN mode without internet.
            //    return false;
            //}
            return true;
        }

    }
}
