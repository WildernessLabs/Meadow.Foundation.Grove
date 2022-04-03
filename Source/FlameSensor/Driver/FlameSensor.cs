using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Environmental
{
    /// <summary>
    /// Represents a Flame Proximity Sensor
    /// </summary>
    public class FlameSensor 
    {
        /// <summary>
        /// Event triggered when flame source is detected
        /// </summary>
        public event EventHandler<bool> FlameDetected = delegate { };

        /// <summary>
        /// Creates a Flame Sensor driver
        /// </summary>
        /// <param name="signalPort"></param>
        public FlameSensor(IDigitalInputPort signalPort)
        {
            signalPort.Changed += SignalPortChanged;
        }

        /// <summary>
        /// Creates a Flame Sensor driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="inputPin"></param>
        public FlameSensor(IDigitalInputController device, IPin inputPin) 
            : this(
                  device.CreateDigitalInputPort(
                      inputPin, 
                      InterruptMode.EdgeBoth, 
                      ResistorMode.InternalPullUp, 
                      0, 
                      25))
        { }

        private void SignalPortChanged(object sender, DigitalPortResult e)
        {
            FlameDetected?.Invoke(this, !e.New.State);
        }
    }
}