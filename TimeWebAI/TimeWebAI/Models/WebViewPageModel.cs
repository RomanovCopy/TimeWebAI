using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Infrastructure;

namespace TimeWebAI.Models
{
    internal class WebViewPageModel: ViewModelBase
    {
        public WebViewPageModel()
        {
        }



        internal bool CanExecute_PageLoaded(object? obj)
        {
            return true;
        }
        internal void Execute_PageLoaded(object? obj)
        {
        }

        internal bool CanExecute_PageClear(object? obj)
        {
            return true;
        }
        internal void Execute_PageClear(object? obj)
        {
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
