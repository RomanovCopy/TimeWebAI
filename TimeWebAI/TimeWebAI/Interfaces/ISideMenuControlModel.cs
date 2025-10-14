using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWebAI.Interfaces
{
    public interface ISideMenuControlModel:IModel
    {
        public bool IsMenuOpen { get; }
        ObservableCollection<ISideMenuViewModel> Items { get; }
    }
}
