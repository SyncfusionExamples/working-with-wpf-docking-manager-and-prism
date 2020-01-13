using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using Syncfusion.Windows.Tools.Controls;
using System.Windows;

namespace PrismTutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Toolbox.ToolboxModule>();
            containerRegistry.RegisterForNavigation<Program.ProgramModule>();
            containerRegistry.RegisterForNavigation<SolutionExplorer.SolutionExplorerModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(DockingManager), Container.Resolve<DockingManagerRegionAdapter.DockingManagerRegionAdapter>());
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof(Toolbox.ToolboxModule));
            catalog.AddModule(typeof(Program.ProgramModule));
            catalog.AddModule(typeof(SolutionExplorer.SolutionExplorerModule));
            return catalog;
        }
    }
}
