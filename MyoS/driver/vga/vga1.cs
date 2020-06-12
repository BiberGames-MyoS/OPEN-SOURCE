using System;
using System.Collections.Generic;
using System.Text;

namespace MyoS.driver.vga1
{
    class vga1
    {
        public static void InitGUI()
        {
            Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII driver = new Cosmos.HAL.Drivers.PCI.Video.VMwareSVGAII();
            driver.SetMode(1440, 900);
            driver.Clear(0x255);
        }
    }
}
