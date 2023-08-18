using Meadow.Hardware;
using Meadow.Peripherals.Switches;
using System;
using System.Threading.Tasks;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    /// <summary>
    /// Represents a Magnetic Switch
    /// </summary>
    public class MagneticSwitch : ISwitch
    {
        IDigitalInputPort port;

        /// <summary>
        /// Returns the state of the switch
        /// </summary>
        public bool IsOn => port.State;

        /// <summary>
        /// Event triggered when status has changed
        /// </summary>
        public event EventHandler Changed = delegate { };

        /// <summary>
        /// Creates a MagneticSwitch driver
        /// </summary>
        /// <param name="signalPort"></param>
        public MagneticSwitch(IDigitalInterruptPort signalPort)
        {
            port = signalPort;

            signalPort.Changed += SignalPortChanged;
        }

        /// <summary>
        /// Creates a MagneticSwitch driver
        /// </summary>
        /// <param name="inputPin"></param>
        public MagneticSwitch(IPin inputPin)
            : this(inputPin.CreateDigitalInterruptPort(
                    InterruptMode.EdgeBoth,
                    ResistorMode.InternalPullUp,
                    TimeSpan.Zero,
                    TimeSpan.FromMilliseconds(25)))
        { }

        private void SignalPortChanged(object sender, DigitalPortResult e)
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Returns the state of the switch
        /// </summary>
        /// <returns></returns>
        public Task<bool> Read()
        {
            return Task.FromResult(IsOn);
        }
    }
}