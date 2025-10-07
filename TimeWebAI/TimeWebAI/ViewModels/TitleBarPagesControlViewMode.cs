using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.ViewModels
{
    public class TitleBarPagesControlViewModel:ViewModelBase, ITitleBarPagesControlViewModel
    {
        public TitleBarPagesControlViewModel()
        {
        }

        public ICommand Loaded => throw new NotImplementedException();

        public ICommand Close => throw new NotImplementedException();

        public ICommand Closing => throw new NotImplementedException();

        public ICommand Closed => throw new NotImplementedException();

    }
}
