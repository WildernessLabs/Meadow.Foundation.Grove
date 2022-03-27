using Meadow.Foundation.Displays.Lcd;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Displays
{
    /// <summary>
    /// Represents a Grove LCD display
    /// </summary>
    public class LCD : CharacterDisplay
    {
        /// <summary>
        /// Creates a Grove LCD display object
        /// </summary>
        /// <param name="i2cBus"></param>
        /// <param name="address"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public LCD(II2cBus i2cBus,
            byte address = (byte)I2cCharacterDisplay.Addresses.Grove,
            byte rows = 2, byte columns = 16)
            :base(i2cBus,
                 address,
                 rows,
                 columns,
                 true)
        {
        }
    }
}