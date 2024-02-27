using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Graphics;
using Meadow.Foundation.Grove.Displays;
using Meadow.Peripherals.Displays;
using System.Threading.Tasks;

namespace Grove.OLEDDisplay1_12inch_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        OLEDDisplay1_12inch display;
        MicroGraphics graphics;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            display = new OLEDDisplay1_12inch(Device.CreateI2cBus(), OLEDDisplayVersion.Version3x);

            graphics = new MicroGraphics(display)
            {
                CurrentFont = new Font8x8(),
                Rotation = RotationType._180Degrees
            };

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            graphics.Clear();
            graphics.DrawRectangle(0, 0, graphics.Width, graphics.Height, false);
            graphics.DrawTriangle(10, 10, 50, 50, 10, 50, false);
            graphics.DrawRectangle(20, 15, 40, 20, true);
            graphics.DrawText(5, 5, "SH1107");
            graphics.Show();

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
