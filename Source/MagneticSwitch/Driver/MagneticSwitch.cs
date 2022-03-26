using Meadow.Hardware;
using Meadow.Peripherals.Switches;
using System;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    public class MagneticSwitch : ISwitch
    {
        public bool IsOn => port.State;

        public event EventHandler Changed = delegate { };

        IDigitalInputPort port;

        public MagneticSwitch(IDigitalInputPort signalPort)
        {
            port = signalPort;
            
            signalPort.Changed += SignalPort_Changed;
        }

        private void SignalPort_Changed(object sender, DigitalPortResult e)
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public MagneticSwitch(IDigitalInputController device, IPin inputPin) 
            : this(device.CreateDigitalInputPort(inputPin, InterruptMode.EdgeBoth, ResistorMode.InternalPullUp, 0, 25))
        {
        }
    }
}