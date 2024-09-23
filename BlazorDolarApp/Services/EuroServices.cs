namespace BlazorDolarApp.Services
{
    public class EuroServices
    {
        private readonly HttpClient _httpClient;

        public EuroServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetEuroAsync()
        {
            var response = await _httpClient.GetStringAsync("v1/cotizaciones/eur");
            return response;
        }
    }
}
