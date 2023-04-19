using Challenge.NewsApi.Domain.DTO;
using Challenge.NewsApi.Domain.Filters;
using Challenge.NewsApi.Domain.Interfaces;
using Challenge.NewsApi.Domain.Interfaces.Repositories;
using System.Text.Json;

namespace Challenge.NewsApi.Infraestructure.Data
{
    public class NewsRepository : INewsRepository
    {
        private readonly HttpClient _client;

        public NewsRepository()
        {
            _client = new HttpClient();
        }

        public async Task<NewsDTO> FetchNewsAsync(NewsFilter filter)
        {
            
            string apiKey = "xxxxxxxxxxxxxxxxxxxxx";
            string url = "https://newsapi.org/v2/everything";

            var filterSpecification = new FilterSpecification<NewsFilter>();
            var filterQueryString = filterSpecification.ApplyFilter(filter);

            var request = new HttpRequestMessage(HttpMethod.Get, $"{url}?{filterQueryString}");
            request.Headers.Add("x-api-key", apiKey);

            HttpResponseMessage response;
            try
            {
                response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                // Handle exception according to your application's requirements
                throw new ApplicationException($"Error fetching news: {ex.Message}");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<NewsDTO>(jsonResponse);
        }
    }
}
