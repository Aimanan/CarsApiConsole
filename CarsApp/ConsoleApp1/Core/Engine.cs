using CarsAppConsole.Contracts.Providers;
using CarsAppConsole.Core.Contracts;
using CarsAppConsole.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsAppConsole.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "End";
        private const string NullProvidersExceptionMessage = "cannot be null.";

        private readonly IConsoleReaderProvider reader;
        private readonly IConsoleWriterProvider writer;
        private readonly ICommandParserProvider parser;

        //There is no task for specific DATA layer, so a data structure is used intead of DB
        public Engine(IConsoleReaderProvider readerProvider, IConsoleWriterProvider writerProvider, ICommandParserProvider parserProvider)
        {
            if (readerProvider == null)
            {
                throw new ArgumentNullException($"Reader {NullProvidersExceptionMessage}");
            }

            if (writerProvider == null)
            {
                throw new ArgumentNullException($"Writer {NullProvidersExceptionMessage}");
            }

            if (parserProvider == null)
            {
                throw new ArgumentNullException($"Parser {NullProvidersExceptionMessage}");
            }
            this.reader = readerProvider;
            this.writer = writerProvider;
            this.parser = parserProvider;

            Vehicles = new Dictionary<int, IVehicle>();
        }

        public static IDictionary<int, IVehicle> Vehicles { get; set; }

        public void Start()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine("CarsConsoleApp");
            menu.AppendLine("Available commands:");
            menu.AppendLine("-create {number of tyres} {number od axes} -creates a vehicle");
            menu.AppendLine("-setp {vehicleId} {min pressure} {max pressure} -sets new range for the pressure in the tyres of vehicle with the given Id");
            menu.AppendLine("-sett {vehicleId} {min temperature} {max temperature} -sets new range for the temperature in the tyres of vehicle with the given Id");
            menu.AppendLine("-test {vehicleId} -test the tyres of vehicle with the given Id");
            menu.AppendLine("-End -exit the program");
            this.writer.WriteStringBuider(menu);
            //set sample data
            //ProcessCommand("create 4 2");

            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString == TerminationCommand)
                    {
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }

        private void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.parser.ParseCommand(commandAsString);
            var parameters = this.parser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            this.writer.WriteLine(executionResult);
        }
    }
}
