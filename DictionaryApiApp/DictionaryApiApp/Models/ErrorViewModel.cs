using System.Text.Json.Serialization;

namespace DictionaryApiApp.Models
{
    public class ErrorViewModel
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }
    }
}
