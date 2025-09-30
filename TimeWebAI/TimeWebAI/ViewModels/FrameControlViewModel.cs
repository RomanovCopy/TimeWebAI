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
    public class FrameControlViewModel:ViewModelBase,IFrameControlViewModel
    {
        private readonly FrameControlModel model;


        public FrameControlViewModel()
        {
            this.model = new FrameControlModel();
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
