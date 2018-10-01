using CarsAppConsole.Contracts;
using System;

namespace CarsAppConsole.Core
{
    public class Sensor : ISensor
    {
        private static readonly Random getrandom = new Random();

        public Sensor()
        {
        }

        public double Temperature { get; set; }

        public double Pressure { get; set; }

        public double ReadPressure()
        {
            this.Pressure = GetRandomNumber(1, 20);
            return this.Pressure;
        }

        public double ReadTemperature()
        {
            this.Temperature = GetRandomNumber(0, 150);
            return this.Temperature;
        }

        private static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) 
            {
                return getrandom.Next(min, max);
            }
        }
    }
}