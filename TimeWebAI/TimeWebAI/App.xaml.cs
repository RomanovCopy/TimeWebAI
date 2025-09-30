using Autofac;

using System.Configuration;
using System.Data;
using System.Windows;

using TimeWebAI.Injections;
using TimeWebAI.Interfaces;

namespace TimeWebAI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application, IContainerProvider
    {
        public IContainer Container { get; private set; }
        public App()
        {
            var startup = new Startup();
            Container = startup.ConfigureServices(this);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            try
            {
                if(Container != null)
                {
                    // Разрешение и запуск главного окна
                    var winmanager = Container.Resolve<IWindowManager>();
                    var win = winmanager.CreateWindow<MainWindow>();
                    winmanager.ShowWindow<MainWindow>(((IWindowWithId)win.DataContext).WindowId);
                }

            } catch(Exception ex)
            {
                Shutdown();
            }


        }
    }

}
