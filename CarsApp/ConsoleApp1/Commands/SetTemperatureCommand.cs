using CarsAppConsole.Core;
using System.Collections.Generic;

namespace CarsAppConsole.Commands
{
    public class SetTemperatureCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var minT = int.Parse(parameters[1]);
            var maxT = int.Parse(parameters[2]);
            var vehicleId = int.Parse(parameters[0]);

            if (Engine.Vehicles.ContainsKey(vehicleId))
            {
                var tyres = Engine.Vehicles[vehicleId].Tyres;
                foreach (var tyre in tyres)
                {
                    tyre.MinPressure = minT;
                    tyre.MaxPressure = maxT;
                }
                return $"The maxTemperature is set to {maxT} and the minTemperature is set to {minT} for vehicle with id {vehicleId}.";
            }

            return $"Vehicle with Id {vehicleId} doesn't exist";


        }
    }
}
