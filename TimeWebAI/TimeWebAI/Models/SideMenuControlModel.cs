using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.Models
{
    public class SideMenuControlModel: ViewModelBase,ISideMenuControlModel
    {

        public bool IsMenuOpen { get => _isMenuOpen; private set => SetProperty(ref _isMenuOpen, value); }
        bool _isMenuOpen;

        public ObservableCollection<ISideMenuItemViewModel> Items { get => _items; private set => SetProperty(ref _items, value); }
        ObservableCollection<ISideMenuItemViewModel> _items;

        public SideMenuControlModel()
        {
            _isMenuOpen = false;
            _items = new ObservableCollection<ISideMenuItemViewModel>();
        }


        public void Execute_Loaded(object? obj)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute_Loaded(object? obj)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute_Close(object? obj)
        {
            throw new NotImplementedException();
        }
        public void Execute_Close(object? obj)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute_Closing(object? obj)
        {
            throw new NotImplementedException();
        }

        public void Execute_Closing(object? obj)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute_Closed(object? obj)
        {
            throw new NotImplementedException();
        }

        public void Execute_Closed(object? obj)
        {
            throw new NotImplementedException();
        }

    }
}
