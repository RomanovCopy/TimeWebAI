using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.Models
{
    public class TitleBarPagesControlModel:ViewModelBase,ITitleBarPagesControlModel
    {
        private readonly ICommand navigateTo;

        public TitleBarPagesControlModel(ICommandService commandService)
        {
            navigateTo = commandService.GetCommand(CommandKey.FrameControl_NavigateTo) ?? throw new NotImplementedException();
        }


        public bool CanExecute_NavigateTo(object? obj)
        {
            return navigateTo.CanExecute(obj);
        }

        public void Execute_NavigateTo(object? obj)
        {
            navigateTo.Execute(obj);
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
