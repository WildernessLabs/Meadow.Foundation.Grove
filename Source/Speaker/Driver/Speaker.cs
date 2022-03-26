using Meadow.Foundation.Audio;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Audio
{
    public class Speaker : PiezoSpeaker
    {
        public Speaker(IPwmOutputController device, IPin pin, float frequency = 100, float dutyCycle = 0)
            : base(device, pin, frequency, dutyCycle)
        {
        }

        public Speaker(IPwmPort port)
            : base(port)
        {
        }
    }
}