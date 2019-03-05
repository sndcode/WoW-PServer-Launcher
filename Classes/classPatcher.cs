using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PTFLauncher
{
    public class classPatcher
    {

        public static void PatchRealmlist(int i)
        {
            switch (i)
            {
                case 1121:
                    //1.12.1 // WoW/realmlist.wtf
                    try
                    {
                        File.WriteAllText(classVars.s_path.Replace("Wow.exe", "realmlist.wtf"), classVars.s_realmlistFullContent);
                    }
                    catch
                    {

                    }
                    break;
                case 243:
                    //2.4.3 // WoW/realmlist.wtf
                    try
                    {
                        File.WriteAllText(classVars.s_path.Replace("Wow.exe", "realmlist.wtf"), classVars.s_realmlistFullContent);
                    }
                    catch
                    {

                    }
                    break;
                case 335:
                    //335a // WoW/Data/deDE/realmlist.wtf 
                    try
                    {
                        File.WriteAllText(classVars.s_path.Replace("Wow.exe", "\\Data\\deDE\\realmlist.wtf"), classVars.s_realmlistFullContent);
                        File.WriteAllText(classVars.s_path.Replace("Wow.exe", "\\Data\\enUS\\realmlist.wtf"), classVars.s_realmlistFullContent);
                    }
                    catch
                    {

                    }
                    break;
                case 434:
                    try
                    {
                       
                    }
                    catch
                    {

                    }
                    break;
                case 510:
                    try
                    {
                        
                    }
                    catch
                    {

                    }
                    break;
                case 710:
                    try
                    {
                        
                    }
                    catch
                    {

                    }
                    break;
                default:
                    try
                    {
                        File.WriteAllText(classVars.s_path.Replace("Wow.exe", "realmlist.wtf"), classVars.s_realmlistFullContent);
                    }
                    catch
                    {

                    }
                    break;
            }

            
        }
    }
}
