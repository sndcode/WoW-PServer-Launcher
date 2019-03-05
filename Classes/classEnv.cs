using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTFLauncher
{
    public class classEnv
    {

        public static string pcUsername()
        {
            string s = System.Environment.UserName;
            return s;
        }

        //TODO : Add checks for OS(Operating System) prolly with switch case

    }
}
