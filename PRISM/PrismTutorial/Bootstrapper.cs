using System;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Prism.Modularity;
using Syncfusion.Windows.Tools.Controls;
using Prism.Regions;

namespace PrismTutorial
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override Prism.Regions.RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            RegionAdapterMappings regionAdapterMappings = base.ConfigureRegionAdapterMappings();

            if (regionAdapterMappings != null)
            {
                regionAdapterMappings.RegisterMapping(typeof(DockingManager), Container.Resolve<DockingManagerRegionAdapter.DockingManagerRegionAdapter>());
            }
            return regionAdapterMappings;
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(SolutionExplorer.SolutionExplorerModule));
            catalog.AddModule(typeof(Toolbox.ToolboxModule));
            catalog.AddModule(typeof(Program.ProgramModule));
        }
    }
}
