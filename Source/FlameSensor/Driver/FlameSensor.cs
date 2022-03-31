using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Environmental
{
    public class FlameSensor 
    {
        public event EventHandler<bool> FlameDetected = delegate { };

        public FlameSensor(IDigitalInputPort signalPort)
        {
            signalPort.Changed += SignalPortChanged;
        }

        public FlameSensor(IDigitalInputController device, IPin inputPin) 
            : this(device.CreateDigitalInputPort(inputPin, InterruptMode.EdgeBoth, ResistorMode.InternalPullUp, 0, 25))
        { }

        private void SignalPortChanged(object sender, DigitalPortResult e)
        {
            FlameDetected?.Invoke(this, !e.New.State);
        }
    }
}