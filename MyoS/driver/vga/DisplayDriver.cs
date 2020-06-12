using Cosmos.HAL;
using Sys = Cosmos.System;
using System;

namespace MyoS.driver.vga
{
    class menubar
    {
        public class render
        {
            public static void menubar(int enterys, string one, string tow, string three, string four, string five)
            {
                Console.Clear();
                Console.SetCursorPosition(1, 1);
                Console.BackgroundColor
                = ConsoleColor.Gray;
                Console.Write("                                                                              ");

                Console.SetCursorPosition(1, 1);
                Console.Write(" ");

                Console.Write(one);
                Console.BackgroundColor
                = ConsoleColor.Gray;

                Console.BackgroundColor
                = ConsoleColor.Gray;
                Console.Write(" ");

                Console.Write(tow);
                Console.BackgroundColor
                = ConsoleColor.Gray;

                Console.BackgroundColor
                = ConsoleColor.Gray;
                Console.Write(" ");
                Console.Write(three);
                Console.BackgroundColor
                = ConsoleColor.Gray;

                Console.BackgroundColor
                = ConsoleColor.Gray;
                Console.Write(" ");
                Console.Write(four);
                Console.BackgroundColor
                = ConsoleColor.Gray;

                Console.BackgroundColor
                = ConsoleColor.Gray;
                Console.Write(" ");
                Console.Write(five);
                Console.BackgroundColor
                = ConsoleColor.Gray;

                Console.BackgroundColor
                = ConsoleColor.Black;
            }
        }
    }
}