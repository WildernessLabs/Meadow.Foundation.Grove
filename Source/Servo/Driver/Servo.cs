using Meadow.Foundation.Servos;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Servos
{
    /// <summary>
    /// Represents a Grove Servo
    /// </summary>
    public class Servo : Sg90
    {
        /// <summary>
        /// Creates a Servo driver
        /// </summary>
        /// <param name="pwmPort">The PWM port for the servo</param>
        public Servo(IPwmPort pwmPort) : base(pwmPort)
        {
        }

        /// <summary>
        /// Creates a Servo driver
        /// </summary>
        /// <param name="pwmPin">The PWM pin connected to the servo</param>
        public Servo(IPin pwmPin) : base(pwmPin)
        { }
    }
}