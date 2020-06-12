using System;
using System.Collections.Generic;
using System.Text;

namespace MyoS.apps.gui.icons
{
    class desktop_foder
    {
        public class render
        {
            public static void folder(int Ax, int Ay, int By, int Cy, int namey, string name)
            {

                Console.BackgroundColor
                = ConsoleColor.Gray;
                Console.SetCursorPosition(Ax, Ay);
                Console.WriteLine("  ");
                Console.SetCursorPosition(Ax, By);
                Console.WriteLine("      ");
                Console.SetCursorPosition(Ax, Cy);
                Console.WriteLine("      ");
                Console.SetCursorPosition(Ax, namey);
                Console.BackgroundColor
                = ConsoleColor.Black;
                Console.Write(name);

            }
        }
    }
}