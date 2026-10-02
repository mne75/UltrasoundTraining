using global::RaspberryPiNetCore.ADC;
using global::RaspberryPiNetCore.JoySticks;
using global::RaspberryPiNetCore.LCD;
using global::RaspberryPiNetCore.TWIST;
using System;
using System.Collections.Generic;


namespace UltrasoundTraining //Raspberry_Pi_Dot_Net_Core_Console_Application3
{
    public class Program
    {
        static void Main(string[] args)
        {
            SensorSimulator simulator = new SensorSimulator();
            List<SensorData> data = new List<SensorData>();

            for (int i = 0; i < 100; i++)
            {
                double timestamp = i * 0.01;

                SensorData measurement = simulator.GenerateData(timestamp);
                data.Add(measurement);
            }

            foreach (SensorData measurement in data)
            {
                Console.WriteLine(
                    $"{measurement.Timestamp:F2}s | " +
                    $"Acc: X={measurement.AccelerationX:F2}, " +
                    $"Y={measurement.AccelerationY:F2}, " +
                    $"Z={measurement.AccelerationZ:F2}"
                );
            }
        }
    }
}
