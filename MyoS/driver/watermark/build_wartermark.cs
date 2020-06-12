using System;
using System.Collections.Generic;
using System.Text;

namespace MyoS.driver.watermark
{
    class build_wartermark
    {
        public static void show(string name, string version, string other, string enabled, int x, int y)
        {
            if (enabled == "true")
            {
                Console.BackgroundColor
                = ConsoleColor.Black;
                Console.SetCursorPosition(0, 0);
                Console.Write(name);
                Console.Write(version);
                Console.Write(other);
                Console.SetCursorPosition(x, y);
            }
        }
    }
}
