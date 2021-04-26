using System.Threading.Tasks;
using RestSharp;

namespace AreaDisplay.MapServices
{
    public abstract class MapService
    {
        protected string _serviceUrl;
        protected RestClient _apiClient;
        public abstract void InitializeClient();
        public virtual async Task<bool> SavePointsAsync(string address, int everyN, string savePath) => false;
    }
}