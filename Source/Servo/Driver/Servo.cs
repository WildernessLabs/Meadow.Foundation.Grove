using Meadow.Foundation.Sensors.Buttons;
using Meadow.Foundation.Servos;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Servos
{
    public class Servo : Meadow.Foundation.Servos.Servo
    {
        public Servo(IPwmPort pwm)
            : base(pwm, NamedServoConfigs.SG90)
        {
        }

        public Servo(IPwmOutputController device, IPin pwm)
            : base(device, pwm, NamedServoConfigs.SG90)
        {
        }
    }
}