using System;
using MyoS.driver.mouse;
//using MyoS.apps.gui.window;
using MyoS.driver.watermark;



namespace MyoS.apps.IDE
{
    class biveride
    {
        public static void start()
        {
            //Console.Clear();
            int x = 40;
            int y = 11;
            int end_up = 1;
            int end_down = 23;
            int end_left = 1;
            int end_right = 78;
            string mouse_curser = " ";


            build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
            Console.BackgroundColor
            = ConsoleColor.Red;
            mouse.DRAW(x, y, mouse_curser);
            Console.BackgroundColor
            = ConsoleColor.Black;


            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y == end_up)
                        {
                            break;
                        }
                        Console.Clear();

                        y = y - 1;
                        Console.BackgroundColor
                        = ConsoleColor.Red;
                        mouse.DRAW(x, y, mouse_curser);
                        build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                        Console.BackgroundColor
                        = ConsoleColor.Black;
                        break;

                    case ConsoleKey.DownArrow:
                        if (y == end_down)
                        {
                            break;
                        }
                        Console.Clear();

                        y = y + 1;
                        Console.BackgroundColor
                        = ConsoleColor.Red;
                        mouse.DRAW(x, y, mouse_curser);
                        build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                        Console.BackgroundColor
                        = ConsoleColor.Black;
                        break;
                    /////////////////////////////////////////////////
                    case ConsoleKey.LeftArrow:
                        if (x == end_left)
                        {
                            break;
                        }
                        Console.Clear();

                        x = x - 1;
                        Console.BackgroundColor
                        = ConsoleColor.Red;
                        mouse.DRAW(x, y, mouse_curser);
                        build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                        Console.BackgroundColor
                        = ConsoleColor.Black;
                        break;

                    case ConsoleKey.RightArrow:
                        if (x == end_right)
                        {
                            break;
                        }
                        Console.Clear();

                        x = x + 1;
                        Console.BackgroundColor
                        = ConsoleColor.Red;
                        mouse.DRAW(x, y, mouse_curser);
                        build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                        Console.BackgroundColor
                        = ConsoleColor.Black;

                        break;
                    case ConsoleKey.F12:
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Clear();
                        Cosmos.System.Power.Reboot();
                        break;



                }
            }
        }
    }
}

