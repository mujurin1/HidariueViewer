using HidariueViewer.Modules.Header;
using HidariueViewer.Modules.Viewer;
using HidariueViewer.Services;
using HidariueViewer.Services.Interfaces;
using HidariueViewer.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace HidariueViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IHidariueService, HidariueService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ViewerModule>();
            moduleCatalog.AddModule<HeaderModule>();
        }
    }
}
