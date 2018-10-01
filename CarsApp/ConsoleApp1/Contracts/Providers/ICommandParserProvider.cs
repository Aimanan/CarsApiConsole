using System.Collections.Generic;
using CarsAppConsole.Commands;

namespace CarsAppConsole.Providers
{
    public interface ICommandParserProvider
    {
        ICommand ParseCommand(string fullCommand);
        IList<string> ParseParameters(string fullCommand);
    }
}