using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TimeWebAI.Interfaces
{
    public interface IPageFactory
    {
        Page CreatePage(Type pageType);
    }
}
