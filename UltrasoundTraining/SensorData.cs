using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltrasoundTraining
{
    public class SensorData
    {
        public double Timestamp { get; set; }
        public double AccelerationX { get; set; }
        public double AccelerationY { get; set; }
        public double AccelerationZ { get; set; }
        public double GyroscopeX { get; set; }  
        public double GyroscopeY { get; set; }  
        public double GyroscopeZ { get; set; }  
    }
}
