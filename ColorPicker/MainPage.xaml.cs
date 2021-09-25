using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ColorPicker
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OpenAbout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AboutPage), null);
        }
    }
}
