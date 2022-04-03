using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Hid;
using Meadow.Peripherals.Sensors.Hid;
using Meadow.Units;
using System;

namespace Grove.ThumbJoystick_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        //<!—SNIP—>

        ThumbJoystick joystick;

        public MeadowApp()
        {
            Initialize();

            // assume that the stick is in the center when it starts up
            _ = joystick.SetCenterPosition(); //fire and forget

            joystick.Updated += JoystickUpdated;

            joystick.StartUpdating(TimeSpan.FromMilliseconds(20));
        }

        void Initialize()
        {
            Console.WriteLine("Initializing hardware...");

            //==== Joystick
            // these are pretty fast updates (40ms in total), if you need more time to process, you can
            // increase the sample interval duration and/or standby duration.
            joystick = new ThumbJoystick(
                Device.CreateAnalogInputPort(Device.Pins.A01, 1, TimeSpan.FromMilliseconds(10), new Voltage(3.3)),
                Device.CreateAnalogInputPort(Device.Pins.A02, 1, TimeSpan.FromMilliseconds(10), new Voltage(3.3)),
                null, false);

            Console.WriteLine("Hardware initialization complete.");
        }

        void JoystickUpdated(object sender, IChangeResult<JoystickPosition> e)
        {
            Console.WriteLine($"Horizontal: {e.New.Horizontal:n2}, Vertical: {e.New.Vertical:n2}");
            Console.WriteLine($"Digital position: {joystick.DigitalPosition}");
        }

        //<!—SNOP—>
    }
}