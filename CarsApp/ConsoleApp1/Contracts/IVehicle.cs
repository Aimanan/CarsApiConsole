using System.Collections.Generic;
using CarsAppConsole.Contracts;

namespace CarsAppConsole.Core.Contracts
{
    public interface IVehicle
    {
        int Axes { get; set; }
        IList<ITyre> Tyres { get; }
    }
}