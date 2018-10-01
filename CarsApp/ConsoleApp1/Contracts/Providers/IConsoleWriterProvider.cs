using System.Text;

namespace CarsAppConsole.Contracts.Providers
{
    public interface IConsoleWriterProvider
    {
        void Write(string message);
        void WriteLine(string message);
        void WriteStringBuider(StringBuilder message);
    }
}