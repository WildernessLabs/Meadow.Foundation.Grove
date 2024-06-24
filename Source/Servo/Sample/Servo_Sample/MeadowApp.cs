using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Servos;
using Meadow.Units;
using System.Threading.Tasks;
using AU = Meadow.Units.Angle.UnitType;

namespace Grove.Servo_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        Servo servo;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            servo = new Servo(Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            servo.RotateTo(servo.MaximumAngle);

            while (true)
            {
                for (int i = 0; i <= servo.MaximumAngle.Degrees; i++)
                {
                    servo.RotateTo(new Angle(i, AU.Degrees));
                    Resolver.Log.Info($"Rotating to {i}");
                    await Task.Delay(40);
                }

                await Task.Delay(2000);

                for (int i = 180; i >= servo.MinimumAngle.Degrees; i--)
                {
                    servo.RotateTo(new Angle(i, AU.Degrees));
                    Resolver.Log.Info($"Rotating to {i}");
                    await Task.Delay(40);
                }

                await Task.Delay(2000);
            }
        }

        //<!=SNOP=>
    }
}