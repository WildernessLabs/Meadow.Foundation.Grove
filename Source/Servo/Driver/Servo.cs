using Meadow.Foundation.Servos;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Servos
{
    /// <summary>
    /// Represents a Servo
    /// </summary>
    public class Servo : Foundation.Servos.Servo
    {
        /// <summary>
        /// Creates a Servo driver
        /// </summary>
        /// <param name="pwm"></param>
        public Servo(IPwmPort pwm)
            : base(pwm, NamedServoConfigs.SG90)
        { }

        /// <summary>
        /// Creates a Servo driver
        /// </summary>
        /// <param name="pwmPin"></param>
        public Servo(IPin pwmPin)
            : base(pwmPin, NamedServoConfigs.SG90)
        { }
    }
}