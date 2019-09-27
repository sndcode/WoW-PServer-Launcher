using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Net;

namespace PTFLauncher
{
    public class classEnv
    {
        
        public static void clearCacheFolder()
        {
            var ini = new ini(classVars.s_settingspath);
            string path = ini.Read("path");
            if (path != null)
            {
                try
                {
                    Directory.Delete(path.Replace("Wow.exe", "") + "Cache", true);
                }
                catch
                {

                }
            }
        }
        public static bool GameIsRunning()
        {
            Process[] pname = Process.GetProcessesByName("Wow");
            if (pname.Length > 0)
            {
                classVars.b_gamerunning = true;
                return true;
            }
            else
            {
                classVars.b_gamerunning = false;
                return false;
            }
        }
        public static void KillProcess(string processtokill)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName(processtokill))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int RandomGen()
        {
            int randomint;
            Random rnd = new Random();
            randomint = rnd.Next(9999);
            return randomint;
        }

        public static string pcUsername()
        {
            string s = System.Environment.UserName;
            return s;
        }
        
        public static void takeScreenshot()
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);

            string randy = RandomGen().ToString();
            bmpScreenshot.Save("Screenshot"+"_" + randy + ".png", ImageFormat.Png);
            MessageBox.Show("Screenshot taken. Saved to : " + Application.StartupPath + "\\Screenshot" + "_" + randy + ".png");
        }

        public static void downloadUpdate()
        {
            WebClient dc = new WebClient();
            dc.DownloadFile(classVars.url_latestLauncher, Application.StartupPath + "\\LauncherNEW.exe");

        }

    }
}
