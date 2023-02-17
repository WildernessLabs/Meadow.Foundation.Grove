using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    /// <summary>
    /// Represents a Vibration Sensor
    /// </summary>
    public class VibrationSensor 
    {
        /// <summary>
        /// Event triggered when vibration is detected
        /// </summary>
        public event EventHandler VibrationDetected = delegate { };

        /// <summary>
        /// Creates a VibrationSensor driver
        /// </summary>
        /// <param name="signalPort"></param>
        public VibrationSensor(IDigitalInputPort signalPort)
        {
            signalPort.Changed += SignalPortChanged;
        }

        /// <summary>
        /// Creates a VibrationSensor driver
        /// </summary>
        /// <param name="inputPin"></param>
        public VibrationSensor(IPin inputPin) 
            : this(
                inputPin.CreateDigitalInputPort(
                    InterruptMode.EdgeRising, 
                    ResistorMode.InternalPullUp,
                    TimeSpan.Zero,
                    TimeSpan.FromMilliseconds(25)))
        { }

        private void SignalPortChanged(object sender, DigitalPortResult e)
        {
            VibrationDetected?.Invoke(this, EventArgs.Empty);
        }
    }
}