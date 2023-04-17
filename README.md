# Working with WPF DockingManager and Prism 

Prism is a practice of building loosely coupled applications in WPF. It is intended to provide flexibility for testing and maintaining applications that are maintained in long term.

## PRISM 6.1
Essential WPF controls are flexible with all the Prism versions. This section explains about creating a simple application using DockingManager in PRISM 6.1 pattern.

## Setting up WPF application
1. Create a WPF application and rename the file MainWindow.xaml as Shell.xaml and MainWindow.xaml.cs as Shell.xaml.cs.

2. Rename the class name MainWindow as Shell in all the occurrences.

3. Add reference to the following assemblies

* Prism
* Prism.WPF
* Prism.Unity.WPF
* Microsoft.Practices.ServiceLocation
* Microsoft.Practices.Unity
* Microsoft.Practices.Unity.Configuration
* Microsoft.Practices.Unity.RegistrationByConvention

4. In the Shell.xaml file, add the namespace definition for Prism Library as given below:

# XAML
    <Window x:Class="DockingManagerPrism.App.MainWindow "
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
        xmlns:prism="http://prismlibrary.com/"
        Title="MainWindow" Height="350" Width="525">
    </Window>

5. Create an instance of the control in Shell.xaml file and set the attached property RegionManager.RegionName for it. Here we have used DockingManager control.

# XAML
    <syncfusion:DockingManager prism:RegionManager.RegionName="MainRegion" UseDocumentContainer="True" DockFill="True" DockFillDocumentMode="Normal"/>

When we create an instance for Shell, it will resolve the value of the RegionManager.RegionName attached property and create a region for connecting it with the DockingManager.

# Configuring DockingManager with Prism 7.1

This section explains about creating a simple application using DockingManager in PRISM 7.1 pattern.

## Setting up WPF application

Step 1: Create a WPF application and rename the file MainWindow.xaml as Shell.xaml and MainWindow.xaml.cs as Shell.xaml.cs.

Step 2: Rename the class name MainWindow as Shell in all the occurrences.

Step 3: Add the following required assembly references to the project:

* Prism
* Prism.WPF
* Prism.Unity.WPF
* Microsoft.Practices.ServiceLocation
* Microsoft.Practices.Unity
* Microsoft.Practices.Unity.Configuration
* Microsoft.Practices.Unity.RegistrationByConvention

Step 4: In the Shell.xaml file, add the namespace definition for Prism Library as given below:

# XAML
    <Window x:Class="DockingManagerPrism.App.MainWindow "
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
        xmlns:prism="http://prismlibrary.com/"
        Title="MainWindow" Height="350" Width="525">
    </Window>

Step 5: Create an instance of the control in Shell.xaml file and set the attached property RegionManager.RegionName for it. Here we have used DockingManager control.

# XAML
    <syncfusion:DockingManager prism:RegionManager.RegionName="MainRegion" UseDocumentContainer="True" DockFill="True" DockFillDocumentMode="Normal"/>

When we create an instance for Shell, it will resolve the value of the RegionManager.RegionName attached property and create a region for connecting it with the DockingManager.

Step 6: Add the following required assembly references in App.xaml.cs file.

Step 7: Inherit the App class from PrismApplication in App.xaml.cs file.

Step 8: Override the methods CreateShell, RegisterTypes and CreateModuleCatalog