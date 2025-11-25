using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TenkiApp {
    public class LocationService {
        public async Task<LocationInfo?> GetLocationAsync() {
            using HttpClient client = new();
            try {
                var json = await client.GetStringAsync("https://ipinfo.io/json");
                var doc = JsonDocument.Parse(json);

                string city = doc.RootElement.GetProperty("city").GetString();
                string region = doc.RootElement.GetProperty("region").GetString();

                return new LocationInfo(city, region);
            }
            catch {
                return null;
            }
        }
    }

    public record LocationInfo(string City, string Region);
}
