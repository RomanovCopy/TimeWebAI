using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.Models
{
    internal class TitleBarControlModel: ViewModelBase, ITitleBarControlModel
    {
        internal TitleBarControlModel()
        {
        }

        public bool CanExecute_NewIdAgent(object? obj)
        {
            return true;
        }
        public void Execute_NewIdAgent(object? obj)
        {
        }

        public bool CanExecute_SavePage(object? obj)
        {
            return true;
        }
        public void Execute_SavePage(object? obj)
        {
        }

        public bool CanExecute_LoadPage(object? obj)
        {
            return true;
        }
        public void Execute_LoadPage(object? obj)
        {
        }

        public bool CanExecute_DeletePage(object? obj)
        {
            return true;
        }
        public void Execute_DeletePage(object? obj)
        {
        }

        public bool CanExecute_Close(object? obj)
        {
            return true;
        }
        public void Execute_Close(object? obj)
        {
        }

        public bool CanExecute_Loaded(object? obj)
        {
            return true;
        }
        public void Execute_Loaded(object? obj)
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
