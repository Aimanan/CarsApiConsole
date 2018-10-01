using CarsAppConsole.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsAppConsole.Commands
{
    public class CreateVehicleCommand : ICommand
    {
        private static int currentVehicleId = 0;

        public string Execute(IList<string> parameters)
        {
            var numberOftyres = int.Parse(parameters[0]);
            var numberOfAxes = int.Parse(parameters[1]);

            var vehicle = new Vehicle(numberOftyres, numberOfAxes);
            Engine.Vehicles.Add(currentVehicleId, vehicle);
            vehicle.CreateTyres();

            return $"A new vehicle with {numberOftyres} tyres, {numberOfAxes} axes and ID {currentVehicleId++} was created." +
                $"The default values of the pressure and temperature in the tyres are: minPressure=10, maxPressure=70, minTemperature=0, maxTemperature=120";
        }
    }
}
