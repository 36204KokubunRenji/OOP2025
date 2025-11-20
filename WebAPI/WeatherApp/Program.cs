using System.Net.Http.Json;

namespace WeatherApp {
    internal class Program {
        //   F     i ܓx 35.0,  o x 139.0 j ̌  ݂̋C   Ȃǂ 擾
        private const string Url =
            "https://api.open-meteo.com/v1/forecast?latitude=35.0&longitude=139.0&current=temperature_2m,wind_speed_10m";

        static async Task Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Open-Meteo API  T サンプル ===");

            using var http = new HttpClient();

            try {
                // JSON  f V   A   C Y
                var weather = await http.GetFromJsonAsync<WeatherResponse>(Url);

                if (weather?.current != null) {
                    Console.WriteLine($"取得時刻：{weather.current.time}");
                    Console.WriteLine($"気温：{weather.current.temperature_2m}℃");
                    Console.WriteLine($"風速：{weather.current.wind_speed_10m} m/s");
                } else {
                    Console.WriteLine("データが取得できませんでした");
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"エラー{ex.Message}");
            }
        }
    }
}
