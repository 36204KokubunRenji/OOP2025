using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace TenkiApp {
    public partial class MainWindow : Window {
        private readonly LocationService locationService = new();
        private readonly WeatherService weatherService = new();

        public MainWindow() {
            InitializeComponent();
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e) {
            LoadingProgress.Visibility = Visibility.Visible;
            WeatherResult.Text = "";

            var location = await locationService.GetLocationAsync();
            if (location == null) {
                WeatherResult.Text = "位置情報の取得に失敗しました。";
                LoadingProgress.Visibility = Visibility.Collapsed;
                return;
            }

            string weather = await weatherService.GetWeatherDetailsAsync(location.RegionCode);
            WeatherResult.Text = $"{location.City} の天気\n{weather}";
            LoadingProgress.Visibility = Visibility.Collapsed;
        }
    }
}
