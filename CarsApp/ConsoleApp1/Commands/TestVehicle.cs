using CarsAppConsole.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsAppConsole.Commands
{
    public class TestVehicle : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var vehicleId = int.Parse(parameters[0]);

            if (Engine.Vehicles.ContainsKey(vehicleId))
            {
                var tyres = Engine.Vehicles[vehicleId].Tyres;
                StringBuilder message = new StringBuilder();
                int counter = 1;
                foreach (var tyre in tyres)
                {
                    
                    tyre.Pressure=tyre.Sensors.ReadPressure();
                    if (tyre.Pressure < tyre.MinPressure)
                    {
                        message.AppendLine($"Low pressure in tyre number {counter} of vehicle {vehicleId}");
                    }

                    if (tyre.Pressure > tyre.MaxPressure)
                    {
                        message.AppendLine($"High pressure in tyre number {counter} of vehicle {vehicleId}");
                    }

                    tyre.Sensors.ReadTemperature();
                    if (tyre.Temperature < tyre.MinTemperature)
                    {
                        message.AppendLine($"Low pressure in tyre number {counter} of vehicle {vehicleId}");
                    }

                    if (tyre.Temperature > tyre.MaxTemperature)
                    {
                        message.AppendLine($"High pressure in tyre number {counter} of vehicle {vehicleId} ");
                    }
                    counter++;
                }
                if (message.Length==0)
                {
                    return $"No problems with the tyres of vehicle {vehicleId}";
                }
                return message.ToString();
            }

            return $"Vehicle with Id {vehicleId} doesn't exist";
        }
    }
}
