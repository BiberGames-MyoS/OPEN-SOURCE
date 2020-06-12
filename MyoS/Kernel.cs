using System;
using Sys = Cosmos.System;
using Cosmos.Core;
using Cosmos.System.ScanMaps;
using MyoS.apps.cowsay;
using MyoS.apps.gui;
using MyoS.apps.crash;
using MyoS.driverlist;
using MyoS.boot;
using System.IO;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;
using MyoS.driver.vga1;

namespace MyoS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            int minram = 64;
            SetKeyboardScanMap(new DE_Standard());
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            if (CPU.GetAmountOfRAM() < minram)
            {
                Console.BackgroundColor
                = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Not enough memory");
                Console.WriteLine("MyoS can't run of RAM DISK");
                Console.WriteLine("Press any key to shutdown");
                Console.ReadKey();
                Cosmos.System.Power.Shutdown();
            }
            Sys.FileSystem.CosmosVFS FS = new Sys.FileSystem.CosmosVFS(); Sys.FileSystem.VFS.VFSManager.RegisterVFS(FS);

        }


        protected override void Run()
        {


            Console.ForegroundColor
            = ConsoleColor.Yellow;
            Console.Write("Name; ");
            Console.ForegroundColor
            = ConsoleColor.White;
            var usr = Console.ReadLine();

            Console.ForegroundColor
            = ConsoleColor.Yellow;
            Console.Write("Password; ");
            Console.ForegroundColor
            = ConsoleColor.Black;
            var paswd = Console.ReadLine();
            Console.ForegroundColor
            = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine(" __   __  __   __  _______  _______ ");
            Console.WriteLine("|  |_|  ||  | |  ||       ||       |");
            Console.WriteLine("|       ||  |_|  ||   _   ||  _____|");
            Console.WriteLine("|       ||       ||  | |  || |_____ ");
            Console.WriteLine("|       ||_     _||  |_|  ||_____  |");
            Console.WriteLine("| ||_|| |  |   |  |       | _____| |");
            Console.WriteLine("|_|   |_|  |___|  |_______||_______|");
            Console.WriteLine("BENJAMIN F. -- BiberGames 2020");
            Console.Write("RAM: ");
            Console.Write(CPU.GetAmountOfRAM());
            Console.WriteLine(" MB");
            Console.WriteLine("MINIMUM: 64 MB!");
            Console.Write("Uhrzeit: "); 
            Console.WriteLine(DateTime.Now);
            Console.ForegroundColor
            = ConsoleColor.Green;
            Console.WriteLine("Done.");
            Console.ForegroundColor
            = ConsoleColor.White;
            Console.WriteLine("Type 'help' to get a list of commands.");
        start:
            Console.ForegroundColor
            = ConsoleColor.Blue;
            Console.Write("MyoS");

            Console.ForegroundColor
            = ConsoleColor.White;
            Console.Write("#");

            Console.ForegroundColor
            = ConsoleColor.Yellow;

            Console.Write(usr);

            Console.ForegroundColor
            = ConsoleColor.Yellow;
            Console.Write("; ");

            Console.ForegroundColor
            = ConsoleColor.White;
            var input = Console.ReadLine();            

            if (input == "ver")
            {
                Console.WriteLine("======MyoS=Version==========");
                Console.WriteLine("MyoS Kernal: 0.1.20a");
                Console.WriteLine("Writen by: Benjamin F. -- BiberGames-2020");


                goto start;
            }
            if (input == "help")
            {
                Console.WriteLine("===MyoS=help=======");
                Console.WriteLine("cls");
                Console.WriteLine("restart");
                Console.WriteLine("exit");
                Console.WriteLine("listdir");
                Console.WriteLine("mkdir");
                Console.WriteLine("colors");
                Console.WriteLine("gui");
                Console.WriteLine("apps");
                Console.WriteLine("crash");
                Console.WriteLine("time");
                Console.WriteLine("echo");
                Console.WriteLine("settings");
                Console.WriteLine("registry");
                goto start;
            }
            if (input == "cls")
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                goto start;
            }
            if (input == "restart")
            {
                Cosmos.System.Power.Reboot();
            }
            if (input == "exit")
            {
                Console.WriteLine("shutingdown...");
                Cosmos.System.Power.Shutdown();
            }
            if (input == "colors")
            {
                Console.WriteLine("List of colors:");
                Console.ForegroundColor
                = ConsoleColor.Black;
                Console.WriteLine("BLACK");
                Console.ForegroundColor
                = ConsoleColor.DarkBlue;
                Console.WriteLine("DARK BLUE");
                Console.ForegroundColor
                = ConsoleColor.DarkGreen;
                Console.WriteLine("DARK GREEN");
                Console.ForegroundColor
                = ConsoleColor.DarkCyan;
                Console.WriteLine("DARK CYAN");
                Console.ForegroundColor
                = ConsoleColor.DarkRed;
                Console.WriteLine("DARK RED");
                Console.ForegroundColor
                = ConsoleColor.DarkMagenta;
                Console.WriteLine("DARK MAGENTA");
                Console.ForegroundColor
                = ConsoleColor.DarkYellow;
                Console.WriteLine("DARK YELLOW");
                Console.ForegroundColor
                = ConsoleColor.DarkGray;
                Console.WriteLine("DARK GRAY");
                Console.ForegroundColor
                = ConsoleColor.Blue;
                Console.WriteLine("BLUE");
                Console.ForegroundColor
                = ConsoleColor.Green;
                Console.WriteLine("GREEN");
                Console.ForegroundColor
                = ConsoleColor.Cyan;
                Console.WriteLine("CYAN");
                Console.ForegroundColor
                = ConsoleColor.Red;
                Console.WriteLine("RED");
                Console.ForegroundColor
                = ConsoleColor.Magenta;
                Console.WriteLine("MAGENTA");
                Console.ForegroundColor
                = ConsoleColor.Yellow;
                Console.WriteLine("YELLOW");
                Console.ForegroundColor
                = ConsoleColor.Gray;
                Console.WriteLine("GRAY");
                Console.ForegroundColor
                = ConsoleColor.White;
                Console.WriteLine("WHITE");
                goto start;
            }
            if (input == "gui")
            {
                desktop.render.start();
            }
            if (input == "apps")
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor
                = ConsoleColor.Gray;
                Console.WriteLine("===================================MyoS=apps====================================");
                Console.BackgroundColor
                = ConsoleColor.Black;

                //    Console.WriteLine("*******************************");
                //    Console.WriteLine("*Snake                        *");
                //    Console.WriteLine("*kernel panic                 *");
                //    Console.WriteLine("*                             *");
                //    Console.WriteLine("*                             *");
                //    Console.WriteLine("*                             *");
                //    Console.WriteLine("*******************************");

                goto start;

            }
            if (input == "crash")
            {
                goto passwd;

            }
            if (input == "time")
            {
            Console.Write("Uhrzeit: ");
            Console.WriteLine(DateTime.Now);
            goto start;
            }
            if (input == "echo")
            {
                Console.Write("echo;");
                var sayit = Console.ReadLine();
                print.say_words.say(sayit);
                goto start;



            }
            if (input == "settings")
            {
                bios.bios.render.start();
                kernel_panic.render.panic("This program is not finished yet...");
            }
            if (input == "registry")
            {
                includelist.start();
                goto start;


            }
            if (input == "ls")
            {
                Directory.SetCurrentDirectory(@"0:\MYOS\");
                foreach (string i in Directory.GetDirectories(@"0:\MYOS\"))
                {
                    Console.WriteLine(@"0:\MYOS\" + i);
                    foreach (string x in Directory.GetFiles(@"0:\MYOS\" + i))
                    {
                        Console.WriteLine(@"0:\MYOS\" + i + x);
                    }
                }
                goto start;


            }
            if (input == "mkdir")
            {
                Console.ForegroundColor
= ConsoleColor.Blue;
                Console.Write("HD0");

                Console.ForegroundColor
                = ConsoleColor.White;
                Console.Write("#");

                Console.ForegroundColor
                = ConsoleColor.Yellow;

                Console.Write(usr);

                Console.ForegroundColor
                = ConsoleColor.Yellow;
                Console.Write("; ");

                Console.ForegroundColor
                = ConsoleColor.White;
                var inputfs = Console.ReadLine();
                Directory.SetCurrentDirectory(@"0:\MYOS\");
                Directory.CreateDirectory(inputfs);

                goto start;

            }
            if (input == "POKE 59458,62")
            {
                Console.WriteLine("Ready.");
                goto start;
            }
            if (input == "bootmnr")
            {
                select.render.start();


            }
            if (input == "files")
            {
               // fs.files.show();
                //files.start();
                goto start;


            }
            if (input == "vb.gui.extra")
            {
               // Bitmap bitmap = (Bitmap)Image.FromFile(@"mypath.bmp");
                //vga1.InitGUI();



            }
 
            else//syntax error//
            {
                Console.ForegroundColor
                = ConsoleColor.Blue;
                Console.Write("Try ");
                Console.ForegroundColor
               = ConsoleColor.Yellow;
                Console.Write("'help'");
                Console.ForegroundColor
                = ConsoleColor.Blue;
                Console.WriteLine(" to get more info!");
                Console.ForegroundColor
                = ConsoleColor.Blue;
                Console.ForegroundColor
                = ConsoleColor.White;
                goto start;
            } 
            passwd:
            Console.ForegroundColor
            = ConsoleColor.Red;
            Console.Write("PASSWORD; ");
            Console.ForegroundColor
            = ConsoleColor.Black;
            var pass = Console.ReadLine();
            Console.ForegroundColor
            = ConsoleColor.White;
//            var grund = "DEBUG";
            if (pass == paswd)
            {
                kernel_panic.render.panic("Debug");
            }
            else
            {
                Console.WriteLine("Incorect password! Try again");
                goto start;
            }





        }
    }


}
