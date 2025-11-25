using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TenkiApp {
    public class AreaService {
        private readonly Dictionary<string, string> PrefToCode = new();

        public async Task LoadAsync() {
            string url = "https://www.jma.go.jp/bosai/common/const/area.json";
            using HttpClient client = new();

            var json = await client.GetStringAsync(url);
            var root = JsonDocument.Parse(json).RootElement;
            var offices = root.GetProperty("offices");

            foreach (var item in offices.EnumerateObject()) {
                string code = item.Name;
                string name = item.Value.GetProperty("name").GetString();
                PrefToCode[name] = code;
            }
        }

        public string GetCode(string prefecture) {
            if (PrefToCode.TryGetValue(prefecture, out string code))
                return code;

            return "130000"; // fallback: 東京
        }
    }
}
