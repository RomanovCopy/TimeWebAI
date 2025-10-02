using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TimeWebAI.Interfaces
{
    public interface ITitleBarControlViewModel: IViewModel
    {
        string IdAgent { get; }
        ICommand NewIdAgent { get; }
        ICommand SavePage { get; }
        ICommand LoadPage { get; }
        ICommand DeletePage { get; }
    }
}
