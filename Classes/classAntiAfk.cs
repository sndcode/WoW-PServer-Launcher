using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PTFLauncher
{
    public class classAntiAfk
    {
        private const uint WM_KEYDOWN   = 0x0100;
        private const uint WM_KEYUP     = 0x0101;
        private const uint WM_CHAR      = 0x0102;
        private const int VK_RETURN     = 0x0D;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        public static void launchAntiAfk()
        {
            AllocConsole();
            //! Find the running WoW process.
            Process[] processes = Process.GetProcessesByName("Wow");
            List<Process> processesList = new List<Process>();

            if (processes.Length == 0)
            {
                Console.WriteLine("There's no WoW process running.");
                Console.ReadKey();
                return;
            }

            string answer = String.Empty;

            if (processes.Length > 1)
            {
                Console.Write("There's more than one WoW process running. Do you wish to Anti-AFK on all of them? Answer with 'Y' or 'N': ");
                answer = Console.ReadLine().ToUpper();

                while (answer != "Y" && answer != "N")
                {
                    Console.Write("This option does not exist. Try again: ");
                    answer = Console.ReadLine().ToUpper();
                }

                if (answer == "N")
                {
                    Console.WriteLine("\nThe WoW process that was started first will now be targeted.");
                    processesList.Add(processes[0]);
                }
                else
                {
                    Console.WriteLine("\nAll the WoW processes will now be targeted.");
                    processesList = processes.ToList();
                }
            }
            else
                processesList.Add(processes[0]);

            bool antiAfkBattleground = false;

            //Console.Write("Do you wish to never go AFK (useful in battlegrounds) or never let your character(s) go offline? Answer with 'A' or 'B': ");
            answer = "A";//Console.ReadLine().ToUpper();

            while (answer != "A" && answer != "B")
            {
                Console.Write("This option does not exist. Try again: ");
                answer = Console.ReadLine().ToUpper();
            }

            antiAfkBattleground = answer == "A";

            Console.WriteLine("Entering whisper loop now. Your character(s) won't go AFK.");

            //! Make sure the return key is released for each process before continuing. Not the cleanest, but it has to be made sure.
            foreach (Process process in processesList)
            {
                for (int i = 0; i < 2; ++i)
                {
                    SendMessage(process.MainWindowHandle, WM_KEYDOWN, new IntPtr(VK_RETURN), IntPtr.Zero);
                    SendMessage(process.MainWindowHandle, WM_KEYUP, new IntPtr(VK_RETURN), IntPtr.Zero);
                }
            }

            //! Sleep for X minutes (~28 / ~4) before the first whisper.
            Thread.Sleep(antiAfkBattleground ? 290000 : 1700000);

            while (true)
            {
                foreach (Process process in processesList)
                {
                    try
                    {

                        string antiAfkString = "/w Namethatdoesnotexistatall looking for group";

                        //! Send the message
                        SendMessage(process.MainWindowHandle, WM_KEYDOWN, new IntPtr(VK_RETURN), IntPtr.Zero);
                        SendMessage(process.MainWindowHandle, WM_KEYUP, new IntPtr(VK_RETURN), IntPtr.Zero);

                        Thread.Sleep(100);

                        //! Write out the message above (slash opens chatbox automatically)
                        for (int i = 0; i < antiAfkString.Length; ++i)
                        {
                            SendMessage(process.MainWindowHandle, WM_CHAR, new IntPtr(antiAfkString[i]), IntPtr.Zero);
                            Thread.Sleep(50);
                        }

                        //! Send the message
                        SendMessage(process.MainWindowHandle, WM_KEYDOWN, new IntPtr(VK_RETURN), IntPtr.Zero);
                        //SendMessage(process.MainWindowHandle, WM_KEYUP, new IntPtr(VK_RETURN), IntPtr.Zero);

                        Thread.Sleep(1000);

                        if (!antiAfkBattleground)
                        {
                            string goAfkString = "/afk";

                            //! Let the player go AFK visually again so players won't bother them
                            for (int i = 0; i < goAfkString.Length; ++i)
                            {
                                SendMessage(process.MainWindowHandle, WM_CHAR, new IntPtr(goAfkString[i]), IntPtr.Zero);
                                Thread.Sleep(50);
                            }

                            SendMessage(process.MainWindowHandle, WM_KEYDOWN, new IntPtr(VK_RETURN), IntPtr.Zero);
                            SendMessage(process.MainWindowHandle, WM_KEYUP, new IntPtr(VK_RETURN), IntPtr.Zero);
                        }
                    }
                    catch
                    {

                    }
                }

                //! Sleep for ~28.3 minutes so we don't log to the char screen unless the user
                //! wants to never go AFK. In that case, we run this anti-AFK line every ~4 min.
                Thread.Sleep(antiAfkBattleground ? 290000 : 1700000);
            }
        }
    }
}
