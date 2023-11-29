using Meadow.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Meadow.Foundation.Grove.Relays
{
    internal partial class Stm32Expander : IDigitalOutputController, II2cPeripheral
    {
        /// <summary>
        ///  Four Channel Spdt Relay pin definitions
        /// </summary>
        public PinDefinitions Pins { get; }

        /// <summary>
        /// The number of IO pins available on the device
        /// </summary>
        public int NumberOfPins { get; } = 4;

        /// <inheritdoc/>
        public byte DefaultI2cAddress => 0x12;

        /// <summary>
        /// The I2C Communications object
        /// </summary>
        protected II2cCommunications i2CCommunications;

        private readonly List<IPin> pinsInUse = new();

        private byte relayStates = 0x00;

        /// <summary>
        /// Creates a new FourChannelSpdtRelay Stm32Expander driver
        /// </summary>
        /// <param name="i2cBus">The I2C bus the peripheral is connected to</param>
        /// <param name="address">The bus address of the peripheral</param>
        public Stm32Expander(II2cBus i2cBus, byte address = 0x11)
        {
            i2CCommunications = new I2cCommunications(i2cBus, address);

            Pins = new PinDefinitions(this)
            {
                Controller = this
            };
        }

        /// <summary>
        /// Get the firmware version
        /// </summary>
        /// <returns>The firmware version as a byte</returns>
        public byte GetFirmwareVersion()
        {
            return i2CCommunications.ReadRegister(READ_FIRMWARE_VERSION);
        }

        /// <summary>
        /// Set a new I2C address
        /// </summary>
        /// <param name="address"></param>
        public void SetI2cAddress(byte address)
        {
            i2CCommunications.WriteRegister(SAVE_I2C_ADDRESS, address);
            i2CCommunications = new I2cCommunications(i2CCommunications.Bus, address);
        }

        /// <inheritdoc/>
        public IDigitalOutputPort CreateDigitalOutputPort(IPin pin, bool initialState = false, OutputType initialOutputType = OutputType.PushPull)
        {
            if (IsValidPin(pin))
            {
                lock (pinsInUse)
                {
                    if (pinsInUse.Contains(pin))
                    {
                        throw new PortInUseException($"{GetType().Name} pin {pin.Name} is already in use");
                    }
                    var port = new DigitalOutputPort(this, pin, initialState);

                    pinsInUse.Add(pin);

                    port.Disposed += (s, e) =>
                    {
                        lock (pinsInUse)
                        {
                            pinsInUse.Remove(pin);
                        }
                    };

                    return port;
                }
            }

            throw new Exception("Pin is out of range");
        }

        /// <inheritdoc/>
        protected IPin GetPin(string pinName)
        {
            return Pins.AllPins.FirstOrDefault(p => p.Name == pinName || p.Key.ToString() == p.Name);
        }

        /// <summary>
        /// Checks if a pin exists on the 4-Channel SPDT Relay
        /// </summary>
        protected bool IsValidPin(IPin pin) => Pins.AllPins.Contains(pin);

        /// <summary>
        /// Convenience method to turn all outputs off
        /// </summary>
        public void SetAllOff()
        {
            i2CCommunications.WriteRegister(CHANNEL_CONTROL, relayStates = 0x00);
        }

        /// <summary>
        /// Convenience method to turn all outputs on
        /// </summary>
        public void SetAllOn()
        {
            i2CCommunications.WriteRegister(CHANNEL_CONTROL, relayStates = 0x0F);
        }

        /// <summary>
        /// Retrieves the state of a pin
        /// </summary>
        /// <param name="pin">The pin to query</param>
        protected bool GetPinState(IPin pin)
        {
            return true;
        }

        /// <summary>
        /// Sets the state of a pin
        /// </summary>
        /// <param name="pin">The pin to update</param>
        /// <param name="state"><b>True</b> to set the pin state high, <b>False</b> to set it low</param>
        protected void SetPinState(IPin pin, bool state)
        {
            if (state)
            {
                relayStates |= (byte)pin.Key;
            }
            else
            {
                relayStates &= (byte)~(byte)pin.Key;
            }

            i2CCommunications.WriteRegister(CHANNEL_CONTROL, relayStates);
        }
    }
}