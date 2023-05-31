using System.Text.Json.Serialization;

namespace MVCWebAPIClient.Models
{
    public class IPResponse
    {
        [JsonPropertyName("ip")]
        public string IP { get; set; }
    }
}