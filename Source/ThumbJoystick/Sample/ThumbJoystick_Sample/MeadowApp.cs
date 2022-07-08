using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Hid;
using Meadow.Peripherals.Sensors.Hid;
using Meadow.Units;
using System;
using System.Threading.Tasks;

namespace Grove.ThumbJoystick_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        ThumbJoystick joystick;

        public override Task Initialize()
        {
            Console.WriteLine("Initializing hardware...");

            joystick = new ThumbJoystick(
                Device.CreateAnalogInputPort(Device.Pins.A01, 1, TimeSpan.FromMilliseconds(10), new Voltage(3.3)),
                Device.CreateAnalogInputPort(Device.Pins.A02, 1, TimeSpan.FromMilliseconds(10), new Voltage(3.3)),
                null);

            joystick.Updated += JoystickUpdated;

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            await joystick.SetCenterPosition(); //fire and forget

            joystick.StartUpdating(TimeSpan.FromMilliseconds(20));
        }

        private void JoystickUpdated(object sender, IChangeResult<AnalogJoystickPosition> e)
        {
            Console.WriteLine($"Horizontal: {e.New.Horizontal:n2}, Vertical: {e.New.Vertical:n2}");
            Console.WriteLine($"Digital position: {joystick.DigitalPosition}");
        }

        //<!=SNOP=>
    }
}