# Working with WPF DockingManager and Prism 

This repository contains a sample that shows how to use the Syncfusion WPF DockingManager in MVVM applications built with Prism 6.1 and Prism 7.1. Since DockingManager is not an ItemsControl, the sample demonstrates how to integrate it with Prism by using region mapping and a custom region adapter.

The sample follows the documented approach of creating a Shell, assigning RegionManager.RegionName to the DockingManager, registering modules in the module catalog, and loading views into the main region. It also shows how docked panes and document panes can be added through Prism modules instead of direct control initialization.

This approach is useful for building modular WPF applications that need document tabs, docked tool windows, and maintainable MVVM structure while using Prism with Syncfusion DockingManager.

Prism 6.1 - https://help.syncfusion.com/wpf/docking/pattern-and-practices#configuring-dockingmanager-with-prism-61
Prism 7.1 - https://help.syncfusion.com/wpf/docking/pattern-and-practices#configuring-dockingmanager-with-prism-71