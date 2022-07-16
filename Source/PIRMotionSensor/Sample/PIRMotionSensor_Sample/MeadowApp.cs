using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using Meadow.Hardware;
using System;
using System.Threading.Tasks;

namespace Grove.PIRMotionSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        PIRMotionSensor motionSensor;

        public override Task Initialize()
        {
            motionSensor = new PIRMotionSensor(
                Device.CreateDigitalInputPort(
                    Device.Pins.D13, 
                    InterruptMode.EdgeBoth, 
                    ResistorMode.Disabled));

            motionSensor.OnMotionStart += (sender) => 
            { 
                Console.WriteLine($"Motion start  {DateTime.Now}"); 
            };

            motionSensor.OnMotionEnd += (sender) => 
            { 
                Console.WriteLine($"Motion end  {DateTime.Now}"); 
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}