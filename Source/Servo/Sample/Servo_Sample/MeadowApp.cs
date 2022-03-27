using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Servos;
using Meadow.Units;
using System;
using System.Threading;
using AU = Meadow.Units.Angle.UnitType;

namespace Grove.Servo_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var servo = new Servo(Device.CreatePwmPort(Device.Pins.D13));

            servo.RotateTo(new Angle(0, AU.Degrees));

            while (true)
            {
                for (int i = 0; i <= servo.Config.MaximumAngle.Degrees; i++)
                {
                    servo.RotateTo(new Angle(i, AU.Degrees));
                    Console.WriteLine($"Rotating to {i}");
                    Thread.Sleep(40);
                }
                Thread.Sleep(2000);
                for (int i = 180; i >= servo.Config.MinimumAngle.Degrees; i--)
                {
                    servo.RotateTo(new Angle(i, AU.Degrees));
                    Console.WriteLine($"Rotating to {i}");
                    Thread.Sleep(40);
                }
                Thread.Sleep(2000);
            }
        }
    }
}