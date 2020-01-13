using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

namespace Program
{
    public class ProgramModule: IModule
    {
        private readonly IRegionManager regionManager;
        public ProgramModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(ProgramView));
        }
    }
}
