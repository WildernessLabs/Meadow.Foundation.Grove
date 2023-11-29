using Meadow.Hardware;
using System.Collections;
using System.Collections.Generic;

namespace Meadow.Foundation.Grove.Relays
{
    internal partial class Stm32Expander
    {
        /// <summary>
        /// Pin definitions for the Grove 4-ChannelSpdtRelay
        /// </summary>
        public class PinDefinitions : IPinDefinitions
        {
            /// <summary>
            /// The controller for the pins
            /// </summary>
            public IPinController Controller { get; set; }

            /// <summary>
            /// List of pins
            /// </summary>
            public IList<IPin> AllPins { get; } = new List<IPin>();

            /// <summary>
            /// Pin SW1
            /// </summary>
            public IPin SW1 => new Pin(
                Controller,
                "SW1", (byte)0x01,
                new List<IChannelInfo> {
                    new DigitalChannelInfo("SW1"),
                }
            );

            /// <summary>
            /// Pin SW2
            /// </summary>
            public IPin SW2 => new Pin(
                Controller,
                "SW2", (byte)0x02,
                new List<IChannelInfo> {
                    new DigitalChannelInfo("SW2"),
                }
            );

            /// <summary>
            /// Pin SW3
            /// </summary>
            public IPin SW3 => new Pin(
                Controller,
                "SW3", (byte)0x04,
                new List<IChannelInfo> {
                    new DigitalChannelInfo("SW3"),
                }
            );

            /// <summary>
            /// Pin SW4
            /// </summary>
            public IPin SW4 => new Pin(
                Controller,
                "SW4", (byte)0x08,
                new List<IChannelInfo> {
                    new DigitalChannelInfo("SW4"),
                }
            );

            /// <summary>
            /// Create a new PinDefinitions object
            /// </summary>
            public PinDefinitions(Stm32Expander controller)
            {
                Controller = controller;
                InitAllPins();
            }

            /// <summary>
            /// Initialize all pins
            /// </summary>
            protected void InitAllPins()
            {
                // add all our pins to the collection
                AllPins.Add(SW1);
                AllPins.Add(SW2);
                AllPins.Add(SW3);
                AllPins.Add(SW4);
            }

            /// <summary>
            /// Get Pins
            /// </summary>
            /// <returns>IEnumerator of IPin with all pins</returns>
            public IEnumerator<IPin> GetEnumerator() => AllPins.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}