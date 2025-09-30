using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.Models;

namespace TimeWebAI.ViewModels
{
    public class MainWindowViewModel:ViewModelBase, IMainWindowViewModel
    {
        private readonly MainWindowModel model;
        public Guid WindowId => model.WindowId;

        public double WindowWidth { get => model.WindowWidth; set => model.WindowWidth = value; }
        public double WindowHeight { get => model.WindowHeight; set => model.WindowHeight = value; }
        public double WindowTop { get => model.WindowTop; set => model.WindowTop = value; }
        public double WindowLeft { get => model.WindowLeft; set => model.WindowLeft = value; }
        public WindowState WindowState { get => model.WindowState; set => model.WindowState = value; }

        public MainWindowViewModel(IWindowManager windowManager)
        {
            model = new MainWindowModel(windowManager);
            model.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName ?? string.Empty);
        }



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
