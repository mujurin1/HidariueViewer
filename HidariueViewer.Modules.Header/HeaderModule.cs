using HidariueViewer.Core;
using HidariueViewer.Modules.Header.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HidariueViewer.Modules.Header
{
    public class HeaderModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public HeaderModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(
                RegionNames.HeaderRegion, "Pack");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Pack>();
        }
    }
}