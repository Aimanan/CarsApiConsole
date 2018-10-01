using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarsAppConsole.Core;

namespace CarsAppConsole.Commands.Tests
{
    [TestClass()]
    public class SetPressureCommandTests
    {
        [TestMethod]
        public void Execute_ShouldSetMinCorrectPressure_WhenPassedCommand()
        {
            new SetPressureCommand().Execute(new List<string>() { "0", "11", "110" });
            foreach (var tyre in Engine.Vehicles[0].Tyres)
            {
                Assert.AreEqual(11, tyre.MinPressure);
            }
        }

        [TestMethod]
        public void Execute_Execute_ShouldSetMaxCorrectPressure_WhenPassedCommand()
        {
            new SetPressureCommand().Execute(new List<string>() { "0", "11", "110" });
            foreach (var tyre in Engine.Vehicles[0].Tyres)
            {
                Assert.AreEqual(110, tyre.MaxPressure);
            }
        }
    }
}