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
    internal class MainWindowModel:ViewModelBase,IWindowWithId
    {
        private readonly IWindowManager _windowManager;
        public Guid WindowId { get => windowId; private set => windowId = value; }
        Guid windowId;
        public double WindowWidth { get=>windowWidth; internal set=>SetProperty(ref windowWidth, value); }
        double windowWidth;
        public double WindowHeight { get=>windowHeight; internal set=>SetProperty(ref windowHeight, value); }
        double windowHeight;
        public double WindowTop { get=>windowTop; internal set=> SetProperty(ref windowTop, value); }
        double windowTop;
        public double WindowLeft { get=>windowLeft; internal set=> SetProperty(ref windowLeft, value); }
        double windowLeft;
        public WindowState WindowState { get=>windowState; internal set=>SetProperty(ref windowState, value); }
        WindowState windowState;

        public MainWindowModel(IWindowManager windowManager)
        {
            WindowId=Guid.NewGuid();
            _windowManager=windowManager;
        }


        internal bool CanExecute_Loaded(object? obj)
        {
            return true;
        }
        internal void Execute_Loaded(object? obj)
        {

        }

        internal bool CanExecute_Close(object? obj)
        {
            return true;
        }
        internal void Execute_Close(object? obj)
        {

        }

        internal bool CanExecute_Closing(object? obj)
        {
            return true;
        }
        internal void Execute_Closing(object? obj)
        {

        }

        internal bool CanExecute_Closed(object? obj)
        {
            return true;
        }
        internal void Execute_Closed(object? obj)
        {
        }
    }
}
