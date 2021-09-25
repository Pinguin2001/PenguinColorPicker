using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ColorPicker
{
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void CloseAbout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}