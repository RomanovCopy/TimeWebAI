using Autofac;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.Pages;

namespace TimeWebAI.Models
{
    internal class FrameControlModel: ViewModelBase, IFrameControlModel
    {
        private readonly ILifetimeScope _scope;

        public Page? CurrentPage { get => currentPage; private set => SetProperty(ref currentPage, value); }
        Page? currentPage;

        public FrameControlModel(ILifetimeScope scope)
        {
            _scope = scope;
        }


        public bool CanExecute_Loaded(object? obj)
        {
            return true;
        }
        public void Execute_Loaded(object? obj)
        {
            CurrentPage=_scope.Resolve<WebViewPage>();
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
