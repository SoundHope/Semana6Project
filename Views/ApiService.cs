using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Semana6Project.Services
{
    public class ApiService
    {
        private HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:8080/");
        }

        public async Task<string> GetRegionsAsync()
        {
            var response = await _httpClient.GetAsync("region");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}