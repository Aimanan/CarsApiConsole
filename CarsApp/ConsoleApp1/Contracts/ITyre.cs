using CarsAppConsole.Core;

namespace CarsAppConsole.Contracts
{
    public interface ITyre
    {
        double MaxPressure { get; set; }
        double MaxTemperature { get; set; }
        double MinPressure { get; set; }
        double MinTemperature { get; set; }
        double Pressure { get; set; }
        double Temperature { get; set; }
        ISensor Sensors { get; set; }
    }
}