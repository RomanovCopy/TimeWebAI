using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.Models
{
    internal class MainWindowModel: ViewModelBase, IMainWindowModel
    {
        private readonly IWindowManager _windowManager;
        public Guid WindowId { get => windowId; private set => windowId = value; }
        Guid windowId;
        public double WindowWidth { get => windowWidth; set => SetProperty(ref windowWidth, value); }
        double windowWidth;
        public double WindowHeight { get => windowHeight; set => SetProperty(ref windowHeight, value); }
        double windowHeight;
        public double WindowTop { get => windowTop; set => SetProperty(ref windowTop, value); }
        double windowTop;
        public double WindowLeft { get => windowLeft; set => SetProperty(ref windowLeft, value); }
        double windowLeft;
        public WindowState WindowState { get => windowState; set => SetProperty(ref windowState, value); }
        WindowState windowState;

        public MainWindowModel(IWindowManager windowManager)
        {
            WindowId = Guid.NewGuid();
            _windowManager = windowManager;
        }


        public bool CanExecute_Loaded(object? obj)
        {
            return true;
        }
        public void Execute_Loaded(object? obj)
        {

        }

        public bool CanExecute_Close(object? obj)
        {
            return true;
        }
        public void Execute_Close(object? obj)
        {

        }

        public bool CanExecute_Closing(object? obj)
        {
            return true;
        }
        public void Execute_Closing(object? obj)
        {

        }

        public bool CanExecute_Closed(object? obj)
        {
            return true;
        }
        public void Execute_Closed(object? obj)
        {
        }
    }
}
