using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorDolarApp.Services
{
    public class DolaresServices
    {
        private readonly HttpClient _httpClient;

        public DolaresServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDolarOficialAsync()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:7199/dolar/oficial");
            return response;
        }
    }
}
