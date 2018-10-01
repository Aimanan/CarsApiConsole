using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarsAppConsole.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAppConsole.Core.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void Execute_ShouldCreateCorrectNumberOfTyres_WhenPassedCorrectCommand()
        {
            var veh = new Vehicle(4, 10);
            veh.CreateTyres();
            Assert.AreEqual(4, veh.Tyres.Count());
            Assert.AreEqual(4, veh.NumberOfTyres);
        }

    }
}