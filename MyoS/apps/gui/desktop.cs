using System;
using MyoS.driver.mouse;
//using MyoS.apps.gui.window;
using MyoS.driver.watermark;




namespace MyoS.apps.gui
{
    class desktop
    {
        public class render
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

                render_desktop.render.gui();
                build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                Console.BackgroundColor
                = ConsoleColor.Red;
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
                            render_desktop.render.gui();
                            y = y - 1;
                            Console.BackgroundColor
                            = ConsoleColor.Red;
                            mouse.DRAW(x, y, mouse_curser);
                            build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                            Console.BackgroundColor
                            = ConsoleColor.Black;
                            position.get(x ,y, 10, 10);
                            break;

                        case ConsoleKey.DownArrow:
                            if (y == end_down)
                            {
                                break;
                            }
                            Console.Clear();
                            render_desktop.render.gui();
                            y = y + 1;
                            Console.BackgroundColor
                            = ConsoleColor.Red;
                            mouse.DRAW(x, y, mouse_curser);
                            build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                            Console.BackgroundColor
                            = ConsoleColor.Black;
                            position.get(x, y, 10, 10);
                            break;
                        /////////////////////////////////////////////////
                        case ConsoleKey.LeftArrow:
                            if (x == end_left)
                            {
                                break;
                            }
                            Console.Clear();
                            render_desktop.render.gui();
                            x = x - 1;
                            Console.BackgroundColor
                            = ConsoleColor.Red;
                            mouse.DRAW(x, y, mouse_curser);
                            build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                            Console.BackgroundColor
                            = ConsoleColor.Black;
                            position.get(x, y, 10, 10);
                            break;

                        case ConsoleKey.RightArrow:
                            if (x == end_right)
                            {
                                break;
                            }
                            Console.Clear();
                            render_desktop.render.gui();
                            x = x + 1;
                            Console.BackgroundColor
                            = ConsoleColor.Red;
                            mouse.DRAW(x, y, mouse_curser);
                            build_wartermark.show("TEST -- VERSION ", "0.0.1 ", "Made by BENJAMIN F.", "true", x, y);
                            Console.BackgroundColor
                            = ConsoleColor.Black;
                            position.get(x, y, 10, 10);
                            break;

                        case ConsoleKey.F12:
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Clear();
                            
                            Cosmos.System.Power.Reboot();
                            break;
                        case ConsoleKey.F1:
                            Console.Beep();
                            Console.Clear();
                            Console.WriteLine("MyoS gui help.");
                            break;
                        case ConsoleKey.F11:
                            Console.Beep();
                            Console.WriteLine("MyoS gui debug mode....");
                            break;
                        case ConsoleKey.E:
                            crash.kernel_panic.render.panic("NOOOOOOOOOOOOOOOOO");
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
}
