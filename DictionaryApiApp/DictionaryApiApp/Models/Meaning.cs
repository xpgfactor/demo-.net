using System.Text.Json.Serialization;

namespace DictionaryApiApp.Models
{
    public class Meaning
    {
        [JsonPropertyName("partOfSpeech")]
        public string PartOfSpeech { get; set; }
        [JsonPropertyName("definitions")]
        public List<DefinitionModel> Definitions { get; set; }
    }
}
