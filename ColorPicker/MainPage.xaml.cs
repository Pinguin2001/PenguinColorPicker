using System;
using Windows.ApplicationModel.Core;
using Windows.System.Profile;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace ColorPicker
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // If device is desktop load custom title bar
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Desktop") { TitleBarLoader(); }
            // Load Home Page
            contentFrame.Navigate(typeof(Pages.Home), null, new DrillInNavigationTransitionInfo());
        }
        private void TitleBarLoader()
        {
            // Load Title bar
            this.FindName("AppTitleBar");
            // Extend View into Titlebar
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            // Set Colors
            titleBar.BackgroundColor = Colors.Transparent;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.InactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }

        private void NavView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            // Get Invoked Item
            object pageTag = args.InvokedItemContainer.Tag;
            // Navigate to selected page with DrillIn Transition Animation
            contentFrame.Navigate(Type.GetType($"ColorPicker.Pages.{pageTag}"), null, new DrillInNavigationTransitionInfo());
        }
    }
}
