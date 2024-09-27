namespace BlazorDolarApp.Services
{
    public class MonedasServices
    {
        private readonly HttpClient _httpClient;

        public MonedasServices(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DolarApiClient");
        }

        public async Task<string> GetMonedasAsync()
        {
            var response = await _httpClient.GetStringAsync("v1/cotizaciones");
            return response;
        }
    }
}
