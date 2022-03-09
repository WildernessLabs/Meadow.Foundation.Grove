using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Audio;
using System;
using System.Threading.Tasks;

namespace Grove.Buzzer_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        readonly Speaker speaker;

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            speaker = new Speaker(Device.CreatePwmPort(Device.Pins.D13));

            _ = PlayTriad();
        }

        async Task PlayTriad()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Playing A major triad starting at A4");
                await speaker.PlayTone(440, 500); //A
                await speaker.PlayTone(554.37f, 500); //C#
                await speaker.PlayTone(659.25f, 500); //E
                
                await Task.Delay(2500);
            }
        }
    }
}