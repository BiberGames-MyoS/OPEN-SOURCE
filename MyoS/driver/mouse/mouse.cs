using System;
using System.Drawing;
using Cosmos.Core.IOGroup;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;

namespace MyoS.driver.mouse
{
    class mouse
    {
        public static void DRAW(int X, int Y, string icon)
        {

            Console.CursorVisible = false;
            Console.SetCursorPosition(X, Y);
            Console.Write(icon);
            Console.SetCursorPosition(X, Y);
            
        }
    }
}
