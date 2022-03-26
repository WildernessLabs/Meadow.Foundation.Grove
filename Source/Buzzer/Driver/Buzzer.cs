using Meadow.Foundation.Audio;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Audio
{
    public class Buzzer : PiezoSpeaker
    {
        public Buzzer(IPwmOutputController device, IPin pin, float frequency = 100, float dutyCycle = 0)
            : base(device, pin, frequency, dutyCycle)
        {
        }

        public Buzzer(IPwmPort port)
            : base(port)
        {
        }
    }
}