using System.Text.Json.Serialization;

namespace Challenge.NewsApi.Entities
{
    public class Source
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
