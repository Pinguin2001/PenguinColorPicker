using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ColorPicker.Pages
{
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
            GetSettings();
        }

        private void GetSettings()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            string SpectrumShapeSetting = localSettings.Values["SpectrumShape"] as string;
            if (SpectrumShapeSetting == "Ring")
            {
                SetRingShapeRadioButton.IsChecked = true;
            }
            else
            {
                SetBoxShapeRadioButton.IsChecked = true;
            }
            string AlphaSetting = localSettings.Values["EnableAlpha"] as string;
            if (AlphaSetting == "true")
            {
                EnableAlphaCheckBox.IsChecked = true;
            }
        }

        private void SetBoxShape_Checked(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["SpectrumShape"] = "Box";
        }

        private void SetRingShape_Checked(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["SpectrumShape"] = "Ring";
        }

        private void EnableAlphaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["EnableAlpha"] = "true";
        }

        private void EnableAlphaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["EnableAlpha"] = "false";
        }
    }
}
