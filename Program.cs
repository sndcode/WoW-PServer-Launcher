using System;
using System.Windows.Forms;

namespace PTFLauncher
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)//Args
        {

            bool activeDev = false;

            if (args.Length > 0 && args[0].Equals("-admin"))//When devmode appears in the params
                activeDev = true;

            if (activeDev)
            {
                classVars.b_debug = true;
            }//my prof said devs were lazy

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLauncher("",""));
        }
    }
}
