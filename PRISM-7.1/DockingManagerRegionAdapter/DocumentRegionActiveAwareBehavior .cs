using Prism.Regions;
using Prism.Regions.Behaviors;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;

namespace DockingManagerRegionAdapter
{
    public class DocumentRegionActiveAwareBehavior : RegionBehavior, IHostAwareRegionBehavior
    {
        public const string BehaviorKey = "DocumentRegionActiveAwareBehavior";
        DependencyObject _hostControl;
        public DependencyObject HostControl
        {
            get { return _hostControl; }
            set { _hostControl = value as DockingManager; }
        }

        protected override void OnAttach()
        {
            ((HostControl as DockingManager).DocContainer as DocumentContainer).AddTabDocumentAtLast = true;
            ((HostControl as DockingManager).DocContainer as DocumentContainer).ActiveDocumentChanged += DocumentRegionActiveAwareBehavior_ActiveDocumentChanged;
        }

        private void DocumentRegionActiveAwareBehavior_ActiveDocumentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue != null)
            {
                var item = e.OldValue;

                //are we dealing with a ContentPane directly
                if (Region.Views.Contains(item) && Region.ActiveViews.Contains(item))
                {
                    Region.Deactivate(item);
                }
                else
                {
                    //now check to see if we have any views that were injected
                    var contentControl = item as ContentControl;
                    if (contentControl != null)
                    {
                        var injectedView = contentControl.Content;
                        if (Region.Views.Contains(injectedView) && Region.ActiveViews.Contains(injectedView))
                            Region.Deactivate(injectedView);
                    }
                }
            }

            if (e.NewValue != null)
            {
                var item = e.NewValue;

                //are we dealing with a ContentPane directly
                if (Region.Views.Contains(item) && !this.Region.ActiveViews.Contains(item))
                {
                    Region.Activate(item);
                }
                else
                {
                    //now check to see if we have any views that were injected
                    var contentControl = item as ContentControl;
                    if (contentControl != null)
                    {
                        var injectedView = contentControl.Content;
                        if (Region.Views.Contains(injectedView) && !this.Region.ActiveViews.Contains(injectedView))
                            Region.Activate(injectedView);
                    }
                }
            }
        }
    }
}

