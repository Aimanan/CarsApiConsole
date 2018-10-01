using System;
using System.Text;
using CarsAppConsole.Contracts.Providers;

namespace CarsAppConsole.Providers
{
    public class ConsoleWriterProvider : IConsoleWriterProvider
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteStringBuider(StringBuilder message)
        {
            Console.WriteLine(message);
        }
    }
}
