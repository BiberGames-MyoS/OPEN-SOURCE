using System;

using MyoS.driver.watermark;
using MyoS.driver.mouse;
using MyoS.boot;
using MyoS;

namespace MyoS.apps.gui.files
{
   
        public class files
    {
        public static void start()
        {

            Console.Clear();
            int sel = 1;
            int x = 1;
            int y = 1;
            int end_up = 1;
            int end_down = 4;
            string mouse_curser = "[>]";
            Console.SetCursorPosition(x, y);
            boot_list.start(x, y);
            build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
            mouse.DRAW(x, y, mouse_curser);
            Console.BackgroundColor
            = ConsoleColor.Black;


        draw:
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
                        boot_list.start(x, y);
                        sel = sel - 1;
                        y = y - 1;
                        mouse.DRAW(x, y, mouse_curser);
                        build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                        Console.SetCursorPosition(x, y);
                        Console.BackgroundColor
                        = ConsoleColor.Black;
                        break;

                    case ConsoleKey.DownArrow:
                        if (y == end_down)
                        {
                            break;
                        }
                        Console.Clear();
                        boot_list.start(x, y);
                        sel = sel + 1;
                        y = y + 1;
                        mouse.DRAW(x, y, mouse_curser);
                        build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                        Console.SetCursorPosition(x, y);
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
                    case ConsoleKey.F1:
                        Console.WriteLine("MyoS -- RESCUE");
                        break;
                    case ConsoleKey.Enter:
                        if (sel == 1)
                        {
                            Console.WriteLine("1");

                        }
                        if (sel == 2)
                        {
                            Console.WriteLine("2");

                        }
                        if (sel == 3)
                        {
                            Console.WriteLine("3");

                        }
                        if (sel == 4)
                        {
                            Console.WriteLine("4");

                        }


                        break;
                    case ConsoleKey.E:
                        break;

                }
            }
            Console.BackgroundColor
                        = ConsoleColor.White;
            mouse.DRAW(x, y, "!");
            Console.BackgroundColor
            = ConsoleColor.Black;

            goto draw;

        }
    }
}

