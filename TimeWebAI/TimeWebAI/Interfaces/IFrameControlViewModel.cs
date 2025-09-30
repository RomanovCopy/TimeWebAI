using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using TimeWebAI.Infrastructure;

namespace TimeWebAI.Interfaces
{
    public interface IFrameControlViewModel:IViewModel
    {
        public Page? CurrentPage {  get; }
    }
}
