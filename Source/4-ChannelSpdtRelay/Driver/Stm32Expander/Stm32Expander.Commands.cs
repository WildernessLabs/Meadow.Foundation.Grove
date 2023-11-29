namespace Meadow.Foundation.Grove.Relays
{
    internal partial class Stm32Expander
    {
        const byte CHANNEL_CONTROL = 0x10;
        const byte SAVE_I2C_ADDRESS = 0x11;
        const byte READ_I2C_ADDRESS = 0x12;
        const byte READ_FIRMWARE_VERSION = 0x13;
    }
}