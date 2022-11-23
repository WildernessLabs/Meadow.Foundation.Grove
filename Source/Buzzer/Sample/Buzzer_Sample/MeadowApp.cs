using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Audio;
using Meadow.Units;
using System;
using System.Threading.Tasks;

namespace Grove.Buzzer_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        Buzzer buzzer;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            buzzer = new Buzzer(Device, Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Playing A major triad starting at A4");
                await buzzer.PlayTone(new Frequency(440, Frequency.UnitType.Hertz), TimeSpan.FromMilliseconds(500)); //A
                await buzzer.PlayTone(new Frequency(554.37f, Frequency.UnitType.Hertz), TimeSpan.FromMilliseconds(500)); //C#
                await buzzer.PlayTone(new Frequency(659.25f, Frequency.UnitType.Hertz), TimeSpan.FromMilliseconds(500)); //E

                await Task.Delay(2500);
            }
        }

        //<!=SNOP=>
    }
}