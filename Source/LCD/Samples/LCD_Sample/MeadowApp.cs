using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Displays;
using System;
using System.Threading;

namespace Grove.LCD_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!-SNIP->

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var display = new LCD(Device.CreateI2cBus());

            display.Write("Hello Grove");

            Thread.Sleep(2000);

            for(byte i = 0; i < 16; i++)
            {
                display.SetCursorPosition(i, 0);
                display.Write("1");
                Thread.Sleep(250);

                display.SetCursorPosition(i, 1);
                display.Write("2");
                Thread.Sleep(250);
            }

            display.ClearLines();
        }

        //<!—SNOP—>
    }
}