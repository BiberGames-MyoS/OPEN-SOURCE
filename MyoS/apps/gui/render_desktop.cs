
using MyoS.driver.vga;
using MyoS.apps.gui.icons;
//using MyoS.apps.gui.window;
//using MyoS.driver.watermark;



namespace MyoS.apps.gui
{
    class render_desktop
    {
        public class render
        {

            public static void gui()
            {
                //////////menubar//////////
                var m1 = "[#]";
                var m2 = "[File]";
                var m3 = "[Edit]";
                var m4 = "[View]";
                var m5 = "[Scripts]";
                menubar.render.menubar(5, m1, m2, m3, m4, m5);
                desktop_bin.render.bin(2, 4, 5, 6, 7, "Bin");
                desktop_foder.render.folder(6, 4, 5, 6, 7, "Folder");
            }
        }
    }
}
