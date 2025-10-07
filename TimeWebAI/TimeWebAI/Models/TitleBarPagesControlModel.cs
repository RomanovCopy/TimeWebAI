using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.Models
{
    public class TitleBarPagesControlModel:ViewModelBase,ITitleBarPagesControlModel
    {


        public TitleBarPagesControlModel()
        {
        }

        public bool CanExecute_Close(object? obj)
        {
            throw new NotImplementedException();
        }

        public void Execute_Loaded(object? obj)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute_Loaded(object? obj)
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
