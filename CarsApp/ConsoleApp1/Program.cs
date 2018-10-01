using CarsAppConsole.Core;
using CarsAppConsole.Providers;
using System;

namespace CarsAppConsole
{
    class Program
    {
        static void Main()
        {
            var reader = new ConsoleReaderProvider();
            var writer = new ConsoleWriterProvider();
            var parser = new CommandParserProvider();

            var engine = new Engine(reader, writer, parser);
            engine.Start();
        }
    }
}
