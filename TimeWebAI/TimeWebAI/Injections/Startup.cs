using Autofac;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.ViewModels;

namespace TimeWebAI.Injections
{
    public class Startup
    {
        public IContainer ConfigureServices(System.Windows.Application app)
        {
            ContainerBuilder builder = new();

            //App
            builder.RegisterInstance(app).As<System.Windows.Application>().SingleInstance();

            //Windows
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>().SingleInstance();
            builder.RegisterType<MainWindow>().SingleInstance();

            //Services
            builder.RegisterType<WindowManager>().As<IWindowManager>().SingleInstance();


            var container = builder.Build();

            return container;

        }
    }
}
