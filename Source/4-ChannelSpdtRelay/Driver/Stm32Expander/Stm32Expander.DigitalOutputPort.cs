using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Relays
{
    internal partial class Stm32Expander
    {
        /// <summary>
        /// A Stm32Expander FourChannelSptdRelay-specific implementation of the IDigitalOutputPort
        /// </summary>
        internal partial class DigitalOutputPort : DigitalOutputPortBase
        {
            internal event EventHandler Disposed = delegate { };

            /// <summary>
            /// The port's containing Stm32Expander
            /// </summary>
            public Stm32Expander Peripheral { get; }

            /// <summary>
            /// Creates a DigitalOutputPort instance
            /// </summary>
            public DigitalOutputPort(Stm32Expander peripheral, IPin pin, bool initialState, OutputType initialOutputType = OutputType.PushPull)
                : base(pin, (IDigitalChannelInfo)pin!.SupportedChannels![0], initialState, initialOutputType)
            {
                Peripheral = peripheral;

                State = initialState;
            }

            /// <inheritdoc/>
            protected override void Dispose(bool disposing)
            {
                base.Dispose(disposing);
                Disposed?.Invoke(this, EventArgs.Empty);
            }

            /// <inheritdoc/>
            public override bool State
            {

                get => Peripheral.GetPinState(Pin);
                set => Peripheral.SetPinState(Pin, value);
            }
        }
    }
}
