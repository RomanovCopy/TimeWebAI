using Autofac;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.AppControls;
using TimeWebAI.Factories;
using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.Models;
using TimeWebAI.Pages;
using TimeWebAI.Services;
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

            //Controls
            builder.RegisterType<TitleBarControl>().SingleInstance();
            builder.RegisterType<FrameControl>().SingleInstance();
            builder.RegisterType<WebViewControl>().SingleInstance();
            builder.RegisterType<StatusBarControl>().SingleInstance();
            builder.RegisterType<TitleBarPagesControl>().SingleInstance();

            //Models
            builder.RegisterType<WebViewControlModel>().As<IWebViewControlModel>().SingleInstance();
            builder.RegisterType<FrameControlModel>().As<IFrameControlModel>().SingleInstance();
            builder.RegisterType<TitleBarControlModel>().As<ITitleBarControlModel>().SingleInstance();
            builder.RegisterType<MainWindowModel>().As<IMainWindowModel>().SingleInstance();
            builder.RegisterType<StatusBarControlModel>().As<IStatusBarControlModel>().SingleInstance();
            builder.RegisterType<WebViewPageModel>().As<IWebViewPageModel>().SingleInstance();
            builder.RegisterType<TitleBarPagesControlModel>().As<ITitleBarPagesControlModel>().SingleInstance();

            //ViewModels
            builder.RegisterType<TitleBarControlViewModel>().As<ITitleBarControlViewModel>().SingleInstance();
            builder.RegisterType<FrameControlViewModel>().As<IFrameControlViewModel>().SingleInstance();
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>().SingleInstance();
            builder.RegisterType<WebViewControlViewModel>().As<IWebViewControlViewModel>().SingleInstance();
            builder.RegisterType<WebViewPageViewModel>().As<IWebViewPageViewModel>().SingleInstance();
            builder.RegisterType<StatusBarControlViewModel>().As<IStatusBarControlViewModel>().SingleInstance();
            builder.RegisterType<TitleBarPagesControlViewModel>().As<ITitleBarPagesControlViewModel>().SingleInstance();

            //Factories
            builder.RegisterType<PageFactory>().As<IPageFactory>();


            //Pages
            builder.RegisterType<WebViewPage>().SingleInstance();

            //Services
            builder.RegisterType<WindowManager>().As<IWindowManager>().SingleInstance();
            builder.RegisterType<WebViewService>().As<IWebViewService>().SingleInstance();
            builder.RegisterType<CommandService>().As<ICommandService>().SingleInstance();



            var container = builder.Build();

            return container;

        }
    }
}
