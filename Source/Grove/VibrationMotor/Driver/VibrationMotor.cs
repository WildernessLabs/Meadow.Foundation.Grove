using Meadow.Foundation.Leds;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.HID
{
    public class VibrationMotor
    {
        public bool IsOn => port.State;

        readonly IDigitalOutputPort port;

        public VibrationMotor(IDigitalOutputController device, IPin pin) 
            : this(device.CreateDigitalOutputPort(pin, false))
        {
        }

        public VibrationMotor(IDigitalOutputPort port)
        {
            this.port = port;
        }

        public void StartVibration()
        {
            port.State = true;
        }

        public void StopVibration()
        {
            port.State = false;
        }
    }
}