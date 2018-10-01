using CarsAppConsole.Contracts;
using CarsAppConsole.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAppConsole.Core
{
    public class Vehicle : IVehicle
    {
        //private readonly ITyre tyre;
        //private int numberOftyres;
        //private int numberOfAxes;

        public Vehicle(int numberOftyres, int numberOfAxes)
        {
            this.NumberOfTyres = numberOftyres;
            this.Axes = numberOfAxes;
            this.Tyres = new List<ITyre>();
        }

        public int Axes { get; set; }

        public int NumberOfTyres { get; set; }

        public IList<ITyre> Tyres { get; set; }

        public void CreateTyres(double minPressure=10, double maxPressure=70, double minTemp = 0, double maxTemp = 120)
        {
            for (int i = 0; i < this.NumberOfTyres; i++)
            {
                Tyres.Add(new Tyre(minPressure, maxPressure, minTemp, maxTemp));
            }
        }

    }
}
