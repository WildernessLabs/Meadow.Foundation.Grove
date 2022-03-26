using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Light
{
    /// <summary>
    /// Represents a line finder sensor
    /// </summary>
    public class LineFinder 
    {
        IDigitalInputPort inputPort;

        /// <summary>
        /// Returns Line Color
        /// </summary>
        public enum LineColor { White, Black }

        /// <summary>
        /// Last state of the Line Finder
        /// </summary>
        public LineColor Color => inputPort.State ? LineColor.Black : LineColor.White;

        /// <summary>
        /// Event when line color changed
        /// </summary>
        public event EventHandler<LineColor> ColorChanged = delegate { };

        /// <summary>
        /// Creates a new LineFinder driver
        /// </summary>
        /// <param name="signalPort"></param>
        public LineFinder(IDigitalInputPort signalPort)
        {
            inputPort = signalPort;
            signalPort.Changed += SignalPortChanged;
        }

        /// <summary>
        /// Creates a new LineFinder driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="inputPin"></param>
        public LineFinder(IDigitalInputController device, IPin inputPin) 
            : this(device.CreateDigitalInputPort(inputPin, InterruptMode.EdgeBoth, ResistorMode.InternalPullUp, 0, 25))
        { }

        private void SignalPortChanged(object sender, DigitalPortResult e)
        {
            ColorChanged?.Invoke(this, e.New.State? LineColor.Black : LineColor.White);
        }
    }
}