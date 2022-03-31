using Meadow.Hardware;
using Meadow.Peripherals.Switches;
using System;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    public class MagneticSwitch : ISwitch
    {
        IDigitalInputPort port;

        public bool IsOn => port.State;

        public event EventHandler Changed = delegate { };

        public MagneticSwitch(IDigitalInputPort signalPort)
        {
            port = signalPort;

            signalPort.Changed += SignalPort_Changed;
        }

        public MagneticSwitch(
            IDigitalInputController device, 
            IPin inputPin)
            : this(
                  device.CreateDigitalInputPort(
                      inputPin, 
                      InterruptMode.EdgeBoth, 
                      ResistorMode.InternalPullUp, 
                      0, 
                      25))
        { }

        private void SignalPort_Changed(object sender, DigitalPortResult e)
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}