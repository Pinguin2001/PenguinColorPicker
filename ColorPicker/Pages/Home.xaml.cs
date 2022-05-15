using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace ColorPicker.Pages
{
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            string SpectrumShapeSetting = localSettings.Values["SpectrumShape"] as string;
            if (SpectrumShapeSetting == "Ring")
            {
                ColorSpectrum.ColorSpectrumShape = Microsoft.UI.Xaml.Controls.ColorSpectrumShape.Ring;
            }
            else
            {
                ColorSpectrum.ColorSpectrumShape = Microsoft.UI.Xaml.Controls.ColorSpectrumShape.Box;
            }
            string AlphaSetting = localSettings.Values["EnableAlpha"] as string;
            if (AlphaSetting == "true")
            {
                ColorSpectrum.IsAlphaEnabled = true;
                ColorSpectrum.IsAlphaSliderVisible = true;
                ColorSpectrum.IsAlphaTextInputVisible = true;
            }
        }
    }
}
