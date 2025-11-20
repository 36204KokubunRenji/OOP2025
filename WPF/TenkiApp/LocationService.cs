using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TenkiApp
{
    public class LocationService {
        public async Task<LocationInfo?> GetLocationAsync() {
            string url = "https://ipinfo.io/json";

            using HttpClient client = new HttpClient();
            try {
                var json = await client.GetStringAsync(url);
                var doc = JsonDocument.Parse(json);
                var city = doc.RootElement.GetProperty("city").GetString();
                var region = doc.RootElement.GetProperty("region").GetString();
                string jmaCode = WeatherService.GetJmaCode(region);
                return new LocationInfo(city, region, jmaCode);
            }
            catch {
                return null;
            }
        }
    }

    public record LocationInfo(string City, string Region, string RegionCode);

}
