using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TimeWebAI.Interfaces
{
    public interface ICommandService
    {
        void Register(CommandKey key, ICommand command);
        ICommand? GetCommand(CommandKey key);
    }
}
