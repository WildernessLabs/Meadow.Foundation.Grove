using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    public class VibrationSensor 
    {
        public event EventHandler VibrationDetected = delegate { };

        public VibrationSensor(IDigitalInputPort signalPort)
        {
            signalPort.Changed += SignalPort_Changed;
        }

        private void SignalPort_Changed(object sender, DigitalPortResult e)
        {
            VibrationDetected?.Invoke(this, EventArgs.Empty);
        }

        public VibrationSensor(IDigitalInputController device, IPin inputPin) 
            : this(device.CreateDigitalInputPort(inputPin, InterruptMode.EdgeRising, ResistorMode.InternalPullUp, 0, 25))
        {

        }
    }
}