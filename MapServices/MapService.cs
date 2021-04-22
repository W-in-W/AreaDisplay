
using RestSharp;

namespace AreaDisplay.MapServices
{
    public abstract class MapService
    {
        protected static string _serviceUrl;
        protected static RestClient  _apiClient { get; set; }
        public abstract void InitializeClient();
        public abstract bool SavePoints(string address, int everyN, string savePath);
    }
}