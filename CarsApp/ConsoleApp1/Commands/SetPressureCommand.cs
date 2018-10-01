using CarsAppConsole.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsAppConsole.Commands
{
    public class SetPressureCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var minP = int.Parse(parameters[1]);
            var maxP = int.Parse(parameters[2]);
            var vehicleId = int.Parse(parameters[0]);


            if (Engine.Vehicles.ContainsKey(vehicleId))
            {
                var tyres=Engine.Vehicles[vehicleId].Tyres;
                foreach (var tyre in tyres)
                {
                    tyre.MinPressure = minP;
                    tyre.MaxPressure = maxP;
                }

                return $"The maxPressure is set to {maxP} and the minPressure is set to {minP} for {vehicleId}.";
            }

            return $"Vehicle with Id {vehicleId} doesn't exist";
        }
    }
}
