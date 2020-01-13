﻿using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Controls;

namespace DockingManagerRegionAdapter
{
    public class DockingManagerRegionAdapter : RegionAdapterBase<DockingManager>
    {
        public DockingManagerRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            : base(regionBehaviorFactory)
        {

        }

        protected override void Adapt(IRegion region, DockingManager regionTarget)
        {
            region.Views.CollectionChanged += delegate
            {
                foreach (var child in region.Views.Cast<UserControl>())
                {
                    if (!regionTarget.Children.Contains(child))
                    {
                        regionTarget.BeginInit();
                        regionTarget.Children.Add(child);
                        regionTarget.EndInit();
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
    }
}
