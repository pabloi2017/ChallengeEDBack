using Challenge.NewsApi.Entities;
using System.Text.Json.Serialization;

namespace Challenge.NewsApi.Domain.DTO
{
    public class NewsDTO
    {
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }
        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }
    }
}
