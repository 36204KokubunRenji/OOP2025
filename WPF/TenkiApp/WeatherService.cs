using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TenkiApp {
    public class WeatherService {
        public static string WeatherCodeToIcon(string code) {
            return code switch {
                { } c when c.StartsWith("1") => "☀",
                { } c when c.StartsWith("2") => "☁",
                { } c when c.StartsWith("3") => "🌧",
                { } c when c.StartsWith("4") => "⛄",
                { } c when c.StartsWith("5") => "⛈",
                _ => "❓"
            };
        }

        private async Task<JsonElement> LoadForecastJson(string regionCode) {
            string url = $"https://www.jma.go.jp/bosai/forecast/data/forecast/{regionCode}.json";
            using HttpClient client = new();

            var json = await client.GetStringAsync(url);
            return JsonDocument.Parse(json).RootElement;
        }

        // -------------------------------
        // 今日の天気を取得（天気・降水確率・温度）
        // -------------------------------
        public async Task<TodayWeather> GetTodayWeatherAsync(string regionCode) {
            var root = await LoadForecastJson(regionCode);

            var dayRoot = root[0];

            // 天気
            var ts0 = dayRoot.GetProperty("timeSeries")[0];
            string weather = ts0.GetProperty("areas")[0].GetProperty("weathers")[0].GetString();

            // 降水確率
            var ts1 = dayRoot.GetProperty("timeSeries")[1];
            string pop = ts1.GetProperty("areas")[0].GetProperty("pops")[0].GetString();

            // 気温（存在しない地域もあるので安全に取得）
            string tempMin = "-";
            string tempMax = "-";

            var ts2 = dayRoot.GetProperty("timeSeries")[2];
            var temps = ts2.GetProperty("areas")[0];

            if (temps.TryGetProperty("tempsMin", out var tMinArr) && tMinArr.GetArrayLength() > 0)
                tempMin = tMinArr[0].GetString();

            if (temps.TryGetProperty("tempsMax", out var tMaxArr) && tMaxArr.GetArrayLength() > 0)
                tempMax = tMaxArr[0].GetString();

            return new TodayWeather {
                Weather = weather,
                Pop = pop,
                TempMin = tempMin,
                TempMax = tempMax
            };
        }

        // -------------------------------
        // 一週間予報
        // -------------------------------
        public async Task<List<WeekWeather>> GetWeeklyWeatherAsync(string regionCode) {
            var root = await LoadForecastJson(regionCode);

            JsonElement weekRoot = root.GetArrayLength() > 1 ? root[1] : root[0];
            var timeSeries = weekRoot.GetProperty("timeSeries");
            JsonElement weekSeries = timeSeries.GetArrayLength() > 1 ? timeSeries[1] : timeSeries[0];

            var dates = weekSeries.GetProperty("timeDefines");
            var areas = weekSeries.GetProperty("areas")[0];

            JsonElement weatherCodes = areas.TryGetProperty("weatherCodes", out var wc) ? wc : default;
            JsonElement weathers = areas.TryGetProperty("weathers", out var wth) ? wth : default;
            JsonElement tempsMin = areas.TryGetProperty("tempsMin", out var tMin) ? tMin : default;
            JsonElement tempsMax = areas.TryGetProperty("tempsMax", out var tMax) ? tMax : default;

            List<WeekWeather> result = new();

            for (int i = 0; i < dates.GetArrayLength(); i++) {
                string date = dates[i].GetString() ?? "----/--/--";

                // 天気コード優先、なければ weathers から生成
                string code = (weatherCodes.ValueKind != JsonValueKind.Undefined && weatherCodes.GetArrayLength() > i)
                    ? weatherCodes[i].GetString() ?? "???"
                    : (weathers.ValueKind != JsonValueKind.Undefined && weathers.GetArrayLength() > i)
                        ? MapWeatherTextToCode(weathers[i].GetString())
                        : "???";

                string icon = WeatherCodeToIcon(code);

                string minT = (tempsMin.ValueKind != JsonValueKind.Undefined && tempsMin.GetArrayLength() > i)
                    ? tempsMin[i].GetString() ?? "-"
                    : "-";

                string maxT = (tempsMax.ValueKind != JsonValueKind.Undefined && tempsMax.GetArrayLength() > i)
                    ? tempsMax[i].GetString() ?? "-"
                    : "-";

                result.Add(new WeekWeather {
                    Date = date,
                    WeatherCode = code,
                    Icon = icon,
                    TempMin = minT,
                    TempMax = maxT
                });
            }

            return result;
        }

        // 天気文字列からコードを生成（☀や☁に変換用）
        private string MapWeatherTextToCode(string? weatherText) {
            if (string.IsNullOrEmpty(weatherText)) return "???";

            if (weatherText.Contains("晴")) return "100";
            if (weatherText.Contains("曇")) return "200";
            if (weatherText.Contains("雨")) return "300";
            if (weatherText.Contains("雪")) return "400";
            if (weatherText.Contains("雷")) return "500";

            return "???";
        }




    }

    public class TodayWeather {
        public string Weather { get; set; }
        public string Pop { get; set; }
        public string TempMin { get; set; }
        public string TempMax { get; set; }
    }

    public class WeekWeather {
        public string Date { get; set; }
        public string WeatherCode { get; set; }
        public string Icon { get; set; }
        public string TempMin { get; set; }
        public string TempMax { get; set; }
    }
}
