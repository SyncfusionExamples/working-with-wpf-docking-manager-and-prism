# Working with WPF DockingManager and Prism

This repository contains samples that demonstrate how to integrate the **Syncfusion WPF DockingManager** with the **Prism framework** using an MVVM‑friendly architecture. The samples follow the official Syncfusion pattern‑and‑practices guidance for configuring DockingManager with **Prism 6.1** and **Prism 7.1**.

## Overview
DockingManager is not an ItemsControl, which means it does not support direct ItemsSource binding. When building Prism‑based MVVM applications, this limitation is addressed by creating a **custom region adapter** that maps Prism regions to the DockingManager and its document container.

This repository demonstrates how to configure DockingManager as a Prism region host, inject views dynamically, and synchronize active documents while maintaining a clean Prism MVVM architecture. Separate samples are provided for Prism 6.1 and Prism 7.1 to reflect framework differences.

## What This Repository Demonstrates
- How to integrate Syncfusion DockingManager with Prism MVVM architecture
- How to configure DockingManager as a Prism region
- How to create a custom DockingManager region adapter
- How to inject docked panes and documents using Prism modules
- How to synchronize active documents between DockingManager and Prism regions
- How to support both Prism 6.1 and Prism 7.1 applications

## Repository Structure
- **PRISM‑6.1**  
  Demonstrates DockingManager integration using Prism 6.1 with custom region adapters and module configuration.
- **PRISM‑7.1**  
  Demonstrates DockingManager integration using Prism 7.1, including updated bootstrapping and region behaviors.

Each folder contains a complete, runnable sample targeted for the respective Prism version. [2](https://github.com/SyncfusionExamples/working-with-wpf-docking-manager-and-prism)

## Key Components Used
- **DockingManager**: Manages docked panes and document windows
- **DocumentContainer**: Hosts document‑style views
- **Prism Framework**: Provides modularity, dependency injection, and region management
- **RegionManager**: Injects and activates views inside DockingManager
- **Custom Region Adapter**: Bridges Prism regions to DockingManager
- **Region Behaviors**: Synchronize active documents with Prism’s ActiveViews

## How It Works
1. A Prism Shell hosts the DockingManager.
2. A region name is assigned to the DockingManager.
3. A custom region adapter maps the Prism region to DockingManager.
4. Prism modules register views with the RegionManager.
5. Views are injected as docked panes or documents.
6. Active document changes are synchronized through region behaviors.

This approach follows Syncfusion’s recommended Prism integration pattern for DockingManager.

## Benefits
- Enables true MVVM‑compliant DockingManager usage
- Supports modular and scalable Prism applications
- Eliminates direct UI manipulation from code‑behind
- Works across multiple Prism versions
- Ideal for IDE‑style and document‑centric WPF applications

## Documentation References
- Prism 6.1 integration:  
  https://help.syncfusion.com/wpf/docking/pattern-and-practices#configuring-dockingmanager-with-prism-61 [2](https://github.com/SyncfusionExamples/working-with-wpf-docking-manager-and-prism)
- Prism 7.1 integration:  
  https://help.syncfusion.com/wpf/docking/pattern-and-practices#configuring-dockingmanager-with-prism-71 [2](https://github.com/SyncfusionExamples/working-with-wpf-docking-manager-and-prism)