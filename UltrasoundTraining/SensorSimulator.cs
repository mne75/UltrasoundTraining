using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltrasoundTraining
{
    public class SensorSimulator // Denne klasse erstatter sensoren midlertidigt. Laver én simuleret sensor-måling
    {
        private Random random = new Random();

        public SensorData GenerateData(double timestamp)
        {
            return new SensorData
            {
                Timestamp = timestamp,

                AccelerationX = random.NextDouble() * 0.2 - 0.1,
                AccelerationY = random.NextDouble() * 0.2 - 0.1,
                AccelerationZ = random.NextDouble() * 0.2 - 0.1,

                GyroscopeX = random.NextDouble() * 0.2 - 0.1,
                GyroscopeY = random.NextDouble() * 0.2 - 0.1,
                GyroscopeZ = random.NextDouble() * 0.2 - 0.1,
            };
        }
    }
}