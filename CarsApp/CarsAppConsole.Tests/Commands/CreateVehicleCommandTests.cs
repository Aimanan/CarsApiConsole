using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarsAppConsole.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsAppConsole.Contracts.Providers;
using Moq;
using CarsAppConsole.Core;
using CarsAppConsole.Providers;

namespace CarsAppConsole.Commands.Tests
{
    [TestClass()]
    public class CreateVehicleCommandTests
    {
        [TestMethod]
        public void Execute_ShouldCreateNewVehicle_WhenPassedCorrectCommand()
        {
            var executionResult = new CreateVehicleCommand().Execute(new List<string>() {"4", "2"});
            Assert.AreEqual(1, Engine.Vehicles.Count());
        }

        [TestMethod]
        public void Execute_ShouldCreateTheCorrectNumberOfTyres_WhenPassedCommand()
        {
            var executionResult = new CreateVehicleCommand().Execute(new List<string>() { "4", "2" });
            Assert.AreEqual(4, Engine.Vehicles[1].Tyres.Count());
        }
    }
}