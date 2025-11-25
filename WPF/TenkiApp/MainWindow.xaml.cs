using System.Windows;

namespace TenkiApp
{
    public partial class MainWindow : Window
    {
        private readonly LocationService locationService = new();
        private readonly WeatherService weatherService = new();
        private readonly AreaService areaService = new();

        public MainWindow()
        {
            InitializeComponent();
            _ = areaService.LoadAsync();
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e) {
            LoadingProgress.Visibility = Visibility.Visible;

            // 位置情報の取得
            var loc = await locationService.GetLocationAsync();
            if (loc == null) {
                WeatherResult.Text = "現在地を取得できませんでした。";
                LoadingProgress.Visibility = Visibility.Collapsed;
                return;
            }

            string regionCode = areaService.GetCode(loc.Region);

            // 今日の天気
            var todayWeather = await weatherService.GetTodayWeatherAsync(regionCode);
            WeatherResult.Text = $"{loc.City} の天気";
            WeatherIcon.Text = WeatherService.WeatherCodeToIcon(todayWeather.Weather);
            Temp.Text = $"最高気温: {todayWeather.TempMax}℃ / 最低気温: {todayWeather.TempMin}℃";
            Precipitation.Text = $"降水確率: {todayWeather.Pop}%";

            // 一週間の天気
            var weekWeather = await weatherService.GetWeeklyWeatherAsync(regionCode);
            WeekWeatherList.ItemsSource = weekWeather;

            LoadingProgress.Visibility = Visibility.Collapsed;
        }

    }
}
