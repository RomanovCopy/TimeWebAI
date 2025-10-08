using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWebAI.Interfaces
{
    public interface ITitleBarPagesControlModel:IModel
    {
        bool CanExecute_NavigateTo(object? obj);
        void Execute_NavigateTo(object? obj);
    }
}
