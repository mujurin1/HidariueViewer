using HidariueViewer.Core;
using HidariueViewer.Modules.MyPageModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HidariueViewer.Modules.MyPageModule
{
    public class MyPageModuleModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MyPageModuleModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(
                RegionNames.ContentRegion, "MainPage");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<Profile>();
        }
    }
}