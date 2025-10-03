using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWebAI.Interfaces
{
    internal interface ITitleBarControlModel: IModel
    {
        bool CanExecute_NewIdAgent(object? obj);
        void Execute_NewIdAgent(object? obj);

        bool CanExecute_SavePage(object? obj);
        void Execute_SavePage(object? obj);

        bool CanExecute_LoadPage(object? obj);
        void Execute_LoadPage(object? obj);

        bool CanExecute_DeletePage(object? obj);
        void Execute_DeletePage(object? obj);
    }
}
