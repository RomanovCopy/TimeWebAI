using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TimeWebAI.Interfaces
{
    public interface IMainWindowModel:IModel,IWindowWithId
    {
        public double WindowWidth { get; set; }
        public double WindowHeight { get; set; }
        public double WindowTop { get; set; }
        public double WindowLeft { get; set; }
        public WindowState WindowState { get; set; }
    }
}
