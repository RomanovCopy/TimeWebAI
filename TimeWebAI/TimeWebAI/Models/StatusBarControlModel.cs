using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.Models
{
    internal class StatusBarControlModel: ViewModelBase, IStatusBarControlModel
    {
        internal StatusBarControlModel()
        {
        }

        public bool CanExecute_Close(object? obj)
        {
            return true;
        }
        public void Execute_Loaded(object? obj)
        {
        }

        public bool CanExecute_Loaded(object? obj)
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
