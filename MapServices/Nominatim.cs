using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AreaDisplay.MapServices
{
    public class Nominatim : MapService
    {
        public override void InitializeClient()
        {
            _serviceUrl = @"https://nominatim.openstreetmap.org/search?";
            _apiClient = new RestClient(_serviceUrl);
        }

        public override async Task<bool> SavePointsAsync(string address, int everyN, string savePath)
        {
            RestRequest request = new RestRequest($@"{_serviceUrl}q={address}&format=json&polygon_geojson=1&limit=1", Method.GET);
            request.AddHeader("Accept", "application/json");
            IRestResponse response = await _apiClient.ExecuteAsync(request);
            if (response.Content == "[]" || response.StatusCode != HttpStatusCode.OK) return false;
            JToken result = JsonConvert.DeserializeObject<JArray>(response.Content)[0]["geojson"]["coordinates"];
            bool isMultiPolygon = JsonConvert.DeserializeObject<JArray>(response.Content)[0]["geojson"]["type"].ToString() == "MultiPolygon";
            StreamWriter streamWriter = new StreamWriter($"{savePath}", false, Encoding.Default);
            foreach (var item in result)
            {
                if (isMultiPolygon)
                {
                    foreach (var item2 in item[0].Where((c,i) => (i + 1) % everyN == 0))
                    {
                        streamWriter.WriteLine(item2.ToString());
                    }
                }
                else
                {
                    foreach (var item2 in item.Where((c,i) => (i + 1) % everyN == 0))
                    {
                        streamWriter.WriteLine(item2.ToString());
                    }
                }
                streamWriter.WriteLine("");
            }
            streamWriter.Dispose();
            return true;
        }
    }
}