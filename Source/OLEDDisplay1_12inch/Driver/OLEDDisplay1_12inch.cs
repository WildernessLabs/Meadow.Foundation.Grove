using Meadow.Foundation.Displays;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Displays
{
    /// <summary>
    /// The display version
    /// </summary>
    public enum OLEDDisplayVersion
    {
        /// <summary>
        /// Version 1.0 to 1.9
        /// </summary>
        Version1x,
        /// <summary>
        /// Version 2.0 to 2.9
        /// </summary>
        Version2x,
        /// <summary>
        /// Version 3.0 or higher
        /// </summary>
        Version3x
    }

    /// <summary>
    /// Represents a Grove OLED 1.12inch display
    /// </summary>
    public class OLEDDisplay1_12inch : Sh1107
    {
        /// <summary>
        /// Creates a Grove OLEDDisplay1_12inch display object
        /// </summary>
        /// <param name="i2cBus">The I2C bus connected to the display</param>
        /// <param name="displayType">The I2C address</param>
        public OLEDDisplay1_12inch(II2cBus i2cBus,
            OLEDDisplayVersion displayType)
            : base(i2cBus, (byte)Sh110x.Addresses.Address_0x3C, 128, 128)
        {
            if (displayType == OLEDDisplayVersion.Version1x)
            {
                throw new System.NotImplementedException("Driver does not currently support version 1.x displays");
            }
        }
    }
}