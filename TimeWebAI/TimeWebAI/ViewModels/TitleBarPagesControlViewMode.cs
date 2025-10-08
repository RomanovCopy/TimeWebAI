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
        private readonly ITitleBarPagesControlModel model;
        public TitleBarPagesControlViewModel(ITitleBarPagesControlModel model)
        {
            this.model = model;
        }

        public ICommand NavigateTo => navigateTo??new RelayCommand(model.Execute_NavigateTo, model.CanExecute_NavigateTo);
        RelayCommand? navigateTo;


        public ICommand Loaded => throw new NotImplementedException();

        public ICommand Close => throw new NotImplementedException();

        public ICommand Closing => throw new NotImplementedException();

        public ICommand Closed => throw new NotImplementedException();

    }
}
