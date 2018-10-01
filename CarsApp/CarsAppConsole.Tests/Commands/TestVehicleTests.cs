using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarsAppConsole.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsAppConsole.Core;
using Moq;

namespace CarsAppConsole.Commands.Tests
{
    [TestClass()]
    public class TestVehicleTests
    {
        [TestMethod]
        public void Execute_ShouldTest_WhenPassedCommand()
        {
            var testSystem=new TestVehicle().Execute(new List<string>() { "0" });
            foreach (var tyre in Engine.Vehicles[0].Tyres)
            {
                Assert.IsTrue(testSystem.Contains("of vehicle 0"));
            }
        }
    }
}
