using Autofac;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using TimeWebAI.Interfaces;

namespace TimeWebAI.Factories
{
    public class PageFactory:IPageFactory
    {

        private readonly ILifetimeScope _scope;

        public PageFactory(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public Page CreatePage(Type pageType) => (Page)_scope.Resolve(pageType);
    }
}
