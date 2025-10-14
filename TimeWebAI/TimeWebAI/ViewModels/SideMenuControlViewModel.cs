using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.ViewModels
{
    public class SideMenuControlViewModel: ViewModelBase, ISideMenuControlViewModel
    {
        private readonly ISideMenuControlModel _model;

        public bool IsMenuOpen => _model.IsMenuOpen;



        public SideMenuControlViewModel(ISideMenuControlModel model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _model.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName??string.Empty);
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
