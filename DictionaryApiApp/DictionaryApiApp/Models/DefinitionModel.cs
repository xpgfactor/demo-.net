using System.Text.Json.Serialization;

namespace DictionaryApiApp.Models
{
    public class DefinitionModel
    {
        [JsonPropertyName("definition")]
        public string Definition { get; set; }
        [JsonPropertyName("example")]
        public string Example { get; set; }
        [JsonPropertyName("synonyms")]
        public List<object> Synonyms { get; set; }
        [JsonPropertyName("antonyms")]
        public List<object> Antonyms { get; set; }
    }
}
