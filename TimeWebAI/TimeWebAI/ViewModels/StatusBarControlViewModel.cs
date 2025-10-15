using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.Models;

namespace TimeWebAI.ViewModels
{
    public class StatusBarControlViewModel:ViewModelBase,IStatusBarControlViewModel
    {
        private readonly IStatusBarControlModel _model;
        public StatusBarControlViewModel(IStatusBarControlModel model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _model.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName ?? string.Empty);
        }

        public ICommand Loaded => loaded ??= new RelayCommand(_model.Execute_Loaded, _model.CanExecute_Loaded);
        RelayCommand? loaded;

        public ICommand Close => close ??= new RelayCommand(_model.Execute_Close, _model.CanExecute_Close);
        RelayCommand? close;

        public ICommand Closing => closing ??= new RelayCommand(_model.Execute_Closing, _model.CanExecute_Closing);
        RelayCommand? closing;

        public ICommand Closed => closed ??= new RelayCommand(_model.Execute_Closed, _model.CanExecute_Closed);
        RelayCommand? closed;
    }
}
