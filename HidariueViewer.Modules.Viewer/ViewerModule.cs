using HidariueViewer.Core;
using HidariueViewer.Modules.Viewer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HidariueViewer.Modules.Viewer
{
    public class ViewerModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ViewerModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(
                RegionNames.ContentRegion, "Pack");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Pack>();
        }
    }
}