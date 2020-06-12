using System;
using System.Collections.Generic;
using System.Text;

namespace MyoS.apps.crash
{
    class kernel_panic
    {
        public class render
        {
            public static void panic(string grund)
            {
                Console.BackgroundColor
             = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("MyoS kernal panic:");
                Console.Write("If this is the first time you've seen this error screen, press any key to      ");
                Console.WriteLine(" restart your computer.");
                Console.WriteLine("");
                Console.WriteLine("If this screen appears again, contact BiberGames support for help.");
                Console.WriteLine("");
                Console.Write("Error code: ");
                Console.WriteLine(grund);
                Console.WriteLine("");
                Console.WriteLine("Press any key to restart...");
                Console.ReadKey();
                Cosmos.System.Power.Reboot();
            }
        }
    }
}

