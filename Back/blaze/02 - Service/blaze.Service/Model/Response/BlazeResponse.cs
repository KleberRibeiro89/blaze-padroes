using System.Text.Json.Serialization;

namespace Blaze.Service.Model.Response;

public record BlazeResponse
{
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("records")]
    public List<BazeItem> Itens { get; set; }

    public record BazeItem 
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime DataCriacao { get; set; }

        [JsonPropertyName("color")]
        public string Cor { get; set; }

        [JsonPropertyName("roll")]
        public int Numero { get; set; }
    }
}
