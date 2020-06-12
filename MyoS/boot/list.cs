using System;
using System.Collections.Generic;
using System.Text;

namespace MyoS.boot
{
    class boot_list
    {
        public static void start(int x, int y)
        {
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("[ ]  MyoS       --    BiberGames");
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("[ ]  Linux      --    The Linux Foundation");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("[ ]  Windows    --    Microsoft");
            Console.SetCursorPosition(1, 4);
            Console.WriteLine("[ ]  MyoS       --    SEVEMODE");
            Console.SetCursorPosition(1, 23);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("F1 HELP | F11 DEBUG | F12 REBOOT | ENTER SELECT");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x, y);

        }
    }
}
