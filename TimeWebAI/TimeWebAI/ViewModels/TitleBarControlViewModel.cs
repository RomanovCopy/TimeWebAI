using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.Models;

namespace TimeWebAI.ViewModels
{
    public class TitleBarControlViewModel:ViewModelBase, ITitleBarControlViewModel
    {
        private readonly TitleBarConterolModel model;
        public string IdAgent => throw new NotImplementedException();

        public TitleBarControlViewModel()
        {
            model=new TitleBarConterolModel();

        }




        public ICommand NewIdAgent => throw new NotImplementedException();

        public ICommand SavePage => throw new NotImplementedException();

        public ICommand LoadPage => throw new NotImplementedException();

        public ICommand DeletePage => throw new NotImplementedException();

        public ICommand Loaded => throw new NotImplementedException();

        public ICommand Close => throw new NotImplementedException();

        public ICommand Closing => throw new NotImplementedException();

        public ICommand Closed => throw new NotImplementedException();
    }
}
