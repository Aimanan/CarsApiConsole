namespace CarsAppConsole.Contracts
{
    public interface ISensor
    {
        double Pressure { get; set; }
        double Temperature { get; set; }

        double ReadPressure();
        double ReadTemperature();
    }
}