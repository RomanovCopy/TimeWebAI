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
    public class TitleBarWebViewControlViewModel:ViewModelBase, ITitleBarWebViewControlViewModel
    {
        private readonly ITitleBarWebViewControlModel model;

        public TitleBarWebViewControlViewModel(ITitleBarWebViewControlModel model)
        {
            this.model = model;
        }

        public ICommand NewAgent => newAgent??=new RelayCommand(model.Execute_NewAgent, model.CanExecute_NewAgent);
        RelayCommand? newAgent;

        public ICommand Loaded => loaded??=new RelayCommand(model.Execute_Loaded, model.CanExecute_Loaded);
        RelayCommand? loaded;

        public ICommand Close => close??=new RelayCommand(model.Execute_Close, model.CanExecute_Close);
        RelayCommand? close;

        public ICommand Closing =>closing??=new RelayCommand(model.Execute_Closing, model.CanExecute_Closing);
        RelayCommand? closing;

        public ICommand Closed => closed??=new RelayCommand(model.Execute_Closed, model.CanExecute_Closed);
        RelayCommand? closed;

    }
}
