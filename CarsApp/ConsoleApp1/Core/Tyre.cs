using CarsAppConsole.Contracts;

namespace CarsAppConsole.Core
{
    public class Tyre : ITyre
    {
        public Tyre(double minPressure, double maxPressure, double minTemp, double maxTemp)
        {
            this.MinPressure = minPressure;
            this.MaxPressure = maxPressure;
            this.MinTemperature = minTemp;
            this.MaxTemperature = maxTemp;
            this.Sensors= new Sensor();
        }

        public double MinPressure { get; set; }
        public double MaxPressure { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        //for extendability
        public double Pressure { get; set; }
        public double Temperature { get; set; }
        public ISensor Sensors { get; set; }
    }
}