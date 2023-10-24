using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.RTCs;
using System;
using System.Threading.Tasks;

namespace Grove.RTC_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        RTC rtc;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            rtc = new RTC(Device.CreateI2cBus());

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            var running = rtc.IsRunning;

            Resolver.Log.Info($"{(running ? "is running" : "is not running")}");

            if (!running)
            {
                Resolver.Log.Info(" Starting RTC...");
                rtc.IsRunning = true;
            }

            var dateTime = rtc.GetTime();
            Resolver.Log.Info($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

            Resolver.Log.Info($" Setting RTC to : {dateTime:MM/dd/yy HH:mm:ss}");
            dateTime = new DateTime(2030, 2, 15);
            rtc.SetTime(dateTime);

            dateTime = rtc.GetTime();
            Resolver.Log.Info($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

            var rand = new Random();

            var data = new byte[56];

            for (int i = 0; i < 56; i++)
            {
                data[i] = (byte)rand.Next(256);
            }

            Resolver.Log.Info($" Writing to RTC RAM   : {BitConverter.ToString(data)}");
            rtc.WriteRAM(0, data);
            Resolver.Log.Info($" Reading from RTC RAM : ");
            data = rtc.ReadRAM(0, 56);
            Resolver.Log.Info(BitConverter.ToString(data));

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}