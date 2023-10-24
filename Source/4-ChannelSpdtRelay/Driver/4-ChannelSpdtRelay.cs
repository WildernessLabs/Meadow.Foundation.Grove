using Meadow.Foundation.Relays;
using Meadow.Hardware;
using Meadow.Peripherals.Relays;

namespace Meadow.Foundation.Grove.Relays
{
    /// <summary>
    /// Represents a Grove Four Channel Spdt Relay
    /// </summary>
    public partial class FourChannelSpdtRelay : II2cPeripheral
    {
        /// <summary>
        /// The relays
        /// </summary>
        public readonly Relay[] Relays = new Relay[4];

        /// <inheritdoc/>
        public byte DefaultI2cAddress => 0x12;

        /// <summary>
        /// The digital output ports for the relays
        /// </summary>
        protected readonly IDigitalOutputPort[] ports = new IDigitalOutputPort[4];

        private readonly Stm32Expander ioExpander;

        /// <summary>
        /// Creates a new FourChannelSpdtRelay driver
        /// </summary>
        /// <param name="i2cBus">The I2C bus the peripheral is connected to</param>
        /// <param name="address">The bus address of the peripheral</param>
        public FourChannelSpdtRelay(II2cBus i2cBus, byte address = 0x11)
        {
            ioExpander = new Stm32Expander(i2cBus, address);

            Initialize();
        }

        void Initialize()
        {
            ports[0] = ioExpander.Pins.SW1.CreateDigitalOutputPort(false);
            ports[1] = ioExpander.Pins.SW2.CreateDigitalOutputPort(false);
            ports[2] = ioExpander.Pins.SW3.CreateDigitalOutputPort(false);
            ports[3] = ioExpander.Pins.SW4.CreateDigitalOutputPort(false);

            Relays[0] = new Relay(ports[0], RelayType.NormallyOpen);
            Relays[1] = new Relay(ports[1], RelayType.NormallyOpen);
            Relays[2] = new Relay(ports[2], RelayType.NormallyOpen);
            Relays[3] = new Relay(ports[3], RelayType.NormallyOpen);
        }

        /// <summary>
        /// Get the firmware version
        /// </summary>
        /// <returns>The firmware version as a byte</returns>
        public byte GetFirmwareVersion()
        {
            return ioExpander.GetFirmwareVersion();
        }

        /// <summary>
        /// Set a new I2C address
        /// </summary>
        /// <param name="address"></param>
        public void SetI2cAddress(byte address)
        {
            ioExpander.SetI2cAddress(address);
        }

        /// <summary>
        /// Convenience method to turn all outputs off
        /// </summary>
        public void SetAllOff()
        {
            ioExpander.SetAllOff();
        }

        /// <summary>
        /// Convenience method to turn all outputs on
        /// </summary>
        public void SetAllOn()
        {
            ioExpander.SetAllOn();
        }
    }
}