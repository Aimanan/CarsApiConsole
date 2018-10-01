using CarsAppConsole.Contracts.Providers;
using System;

namespace CarsAppConsole.Providers
{
    public class ConsoleReaderProvider : IConsoleReaderProvider
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}

