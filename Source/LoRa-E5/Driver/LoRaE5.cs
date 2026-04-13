using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Transceivers
{
    /// <summary>
    /// Represents the Seeed Studio Grove Lora-E5 LoRa transceiver module
    /// </summary>
    public class LoRaE5 : Meadow.Foundation.Transceivers.WioE5
    {
        /// <summary>
        /// Creates a new Grove Lora-E5 driver
        /// </summary>
        /// <param name="portName">The serial port the Grove UART connector is wired to</param>
        /// <param name="baudRate">Baud rate (default 9600)</param>
        public LoRaE5(SerialPortName portName, int baudRate = 9600)
            : base(portName, baudRate)
        {
        }
    }
}
