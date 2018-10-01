using System.Collections.Generic;

namespace CarsAppConsole.Commands
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
