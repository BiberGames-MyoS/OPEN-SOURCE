using System;
using System.Collections.Generic;
using System.Text;

namespace MyoS.bios
{
    class bios
    {
        public class render
        {
            public static void start()
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("MyoS -- BIOS -- Setup");
            }
        }
    }
}
