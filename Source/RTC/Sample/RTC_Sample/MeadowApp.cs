using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.RTCs;
using System;

namespace Grove.RTC_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        public MeadowApp()
        {
            Console.WriteLine("Initializing...");

            var rtc = new RTC(Device.CreateI2cBus());

            Console.WriteLine("rtc created");

            var running = rtc.IsRunning;

            Console.WriteLine($"{(running ? "is running" : "is not running")}");

            if (!running)
            {
                Console.WriteLine(" Starting RTC...");
                rtc.IsRunning = true;
            }

            var dateTime = rtc.GetTime();
            Console.WriteLine($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

            Console.WriteLine($" Setting RTC to : {dateTime:MM/dd/yy HH:mm:ss}");
            dateTime = new DateTime(2030, 2, 15);
            rtc.SetTime(dateTime);

            dateTime = rtc.GetTime();
            Console.WriteLine($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

            Random rand = new Random();

            var data = new byte[56];

            for (int i = 0; i < 56; i++)
            {
                data[i] = (byte)rand.Next(256);
            }

            Console.WriteLine($" Writing to RTC RAM   : {BitConverter.ToString(data)}");
            rtc.WriteRAM(0, data);
            Console.Write($" Reading from RTC RAM : ");
            data = rtc.ReadRAM(0, 56);
            Console.WriteLine(BitConverter.ToString(data));
        }

        //<!=SNOP=>
    }
}
