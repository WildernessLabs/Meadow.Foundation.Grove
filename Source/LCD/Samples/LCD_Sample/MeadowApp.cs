using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Displays;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Grove.LCD_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        LCD display;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            display = new LCD(Device.CreateI2cBus());

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            display.Write("Hello Grove");

            await Task.Delay(2000);

            for (byte i = 0; i < 16; i++)
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

        //<!=SNOP=>
    }
}