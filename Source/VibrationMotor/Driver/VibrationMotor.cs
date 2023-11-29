using Meadow.Hardware;

namespace Meadow.Foundation.Grove.HID
{
    /// <summary>
    /// Represents a VibrationMotor
    /// </summary>
    public class VibrationMotor
    {
        readonly IDigitalOutputPort port;

        /// <summary>
        /// Gets/Sets vibration motor status
        /// </summary>
        public bool IsVibrating
        {
            get => isVibrating;
            set
            {
                isVibrating = value;
                port.State = isVibrating;
            }
        }
        bool isVibrating;

        /// <summary>
        /// Creates a VibrationMotor driver
        /// </summary>
        /// <param name="port"></param>
        public VibrationMotor(IDigitalOutputPort port)
        {
            this.port = port;
        }

        /// <summary>
        /// Creates a VibrationMotor driver
        /// </summary>
        /// <param name="pin"></param>
        public VibrationMotor(IPin pin)
            : this(pin.CreateDigitalOutputPort(false))
        { }
    }
}