using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TenkiApp {
    public class WeatherService {
        // 都道府県 → 気象庁コード
        public static string GetJmaCode(string prefecture) {
            return prefecture switch {
                "東京都" => "130000",
                "大阪府" => "270000",
                // 他の都道府県も追加
                _ => "130000", // デフォルト東京
            };
        }

        public async Task<string> GetWeatherDetailsAsync(string regionCode) {
            string url = $"https://www.jma.go.jp/bosai/forecast/data/forecast/{regionCode}.json";

            using HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(url);
            var root = JsonDocument.Parse(json).RootElement[0];

            // サンプルとして天気だけ取得
            string date = root.GetProperty("timeSeries")[0].GetProperty("timeDefines")[0].GetString();
            string weather = root.GetProperty("timeSeries")[0].GetProperty("areas")[0].GetProperty("weathers")[0].GetString();

            return $"{date}\n天気：{weather}";
        }
    }
}
