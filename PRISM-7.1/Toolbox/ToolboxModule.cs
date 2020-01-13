using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Toolbox
{
    public class ToolboxModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", typeof(ToolboxView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
           
        }
    }
}
