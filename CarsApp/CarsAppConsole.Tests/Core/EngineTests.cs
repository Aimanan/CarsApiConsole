using System;
using System.Collections.Generic;
using CarsAppConsole.Commands;
using CarsAppConsole.Contracts.Providers;
using CarsAppConsole.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CarsAppConsole.Core.Test
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public void Constructor_ShouldThrowArgumentNullException_WhenReaderIsNotPassed()
        {
            var writer = new Mock<IConsoleWriterProvider>();
            var parser = new Mock<ICommandParserProvider>();
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(null, writer.Object, parser.Object));
        }

        [TestMethod]
        public void Constructor_ShouldThrowArgumentNullException_WhenWriterIsNotPassed()
        {
            var reader = new Mock<IConsoleReaderProvider>();
            var parser = new Mock<ICommandParserProvider>();
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(reader.Object, null, parser.Object));
        }

        [TestMethod]
        public void Constructor_ShouldThrowArgumentNullException_WhenParserIsNotPassed()
        {
            var reader = new Mock<IConsoleReaderProvider>();
            var writer = new Mock<IConsoleWriterProvider>();
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(reader.Object, writer.Object, null));
        }

        [TestMethod, Timeout(3500)]
        public void Start_ShouldNotFallIntoInfiniteLoop_WhenPassedValidTerminationCommand()
        {
            var reader = new Mock<IConsoleReaderProvider>();
            var writer = new Mock<IConsoleWriterProvider>();
            var parser = new Mock<ICommandParserProvider>();
            var engine = new Engine(reader.Object, writer.Object, parser.Object);

            var terminationCommand = "End";
            reader.Setup(c => c.ReadLine()).Returns(terminationCommand);

            engine.Start();
        }

        //[DataRow("End")]
        //[DataTestMethod]
        //public void Start_ShouldEndTheProgram_WhenPassedTerminationCommand(string command)
        //{
        //    var reader = new Mock<IConsoleReaderProvider>();
        //    var writer = new Mock<IConsoleWriterProvider>();
        //    var parser = new Mock<ICommandParserProvider>();
        //    var com = new Mock<ICommand>();
        //    var engine = new Engine(reader.Object, writer.Object, parser.Object);

        //    reader.Setup(c => c.ReadLine()).Returns(command);

        //    engine.Start();

        //    writer.Verify(c => c.WriteLine(It.IsAny<string>()), Times.Exactly(0));
        //}

        //[DataRow("create 4 2")]
        //[DataRow("End")]
        //[DataTestMethod]
        //public void Start_ShouldCallWriteLineOnce_WhenPassedOneValidCommandAndOneTerminationCommand(string command)
        //{
        //    var reader = new Mock<IConsoleReaderProvider>();
        //    var writer = new Mock<IConsoleWriterProvider>();
        //    var parser = new Mock<ICommandParserProvider>();
        //    var com = new Mock<ICommand>();
        //    var mockedCreator = new Mock<CreateVehicleCommand>();

        //    reader.Setup(c => c.ReadLine()).Returns(command);
        //    parser.Setup(c => c.ParseCommand(command)).Returns(com.Object);
        //    parser.Setup(c => c.ParseParameters(command)).Returns(new List<string>() { "12", "8" });

        //    var engine = new Engine(reader.Object, writer.Object, parser.Object);
        //    mockedCreator.Object.Execute(new List<string>() { "12", "8" });
        //    Assert.AreEqual(Engine.Vehicles[1].Tyres.Count, 12);
        //}
    }
}


