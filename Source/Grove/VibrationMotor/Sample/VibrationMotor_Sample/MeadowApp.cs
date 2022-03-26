using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.HID;
using System;
using System.Threading;

namespace Grove.VibrationMotor_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var vibrationMotor = new VibrationMotor(Device, Device.Pins.D13);

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Motor on");
                vibrationMotor.StartVibration();
                Thread.Sleep(1000);

                Console.WriteLine("Motor off");
                vibrationMotor.StopVibration();
                Thread.Sleep(1000);


            }
        }
    }
}