using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.Models;

namespace TimeWebAI.ViewModels
{
    public class FrameControlViewModel: ViewModelBase, IFrameControlViewModel
    {
        private readonly IFrameControlModel model;

        //IFrameControlViewModel
        public Page? CurrentPage => model.CurrentPage;
        public ObservableCollection<Page?>? Pages => model.Pages;


        public FrameControlViewModel(IFrameControlModel model)
        {
            this.model = model ?? throw new ArgumentNullException(nameof(model));
            this.model.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName ?? string.Empty);
        }

        //IFrameControlViewModel
        public ICommand NavigateTo => navigateTo ?? new RelayCommand(model.Execute_NavigateTo, model.CanExecute_NavigateTo);
        RelayCommand? navigateTo;


        //IViewModel
        public ICommand Loaded => loaded ??= new RelayCommand(model.Execute_Loaded, model.CanExecute_Loaded);
        RelayCommand? loaded;

        public ICommand Close => close ??= new RelayCommand(model.Execute_Close, model.CanExecute_Close);
        RelayCommand? close;

        public ICommand Closing => closing ??= new RelayCommand(model.Execute_Closing, model.CanExecute_Closing);
        RelayCommand? closing;

        public ICommand Closed => closed ??= new RelayCommand(model.Execute_Closed, model.CanExecute_Closed);
        RelayCommand? closed;

    }
}
