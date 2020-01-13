using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace SolutionExplorer
{
    public class SolutionExplorerModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", typeof(SolutionExplorerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
