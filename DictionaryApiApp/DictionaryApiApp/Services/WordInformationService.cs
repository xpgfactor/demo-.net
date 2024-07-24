namespace DictionaryApiApp.Services
{
    public class WordInformationService: IWordInformationService
    {
        HttpClient _httpClient;
        string _url;
        public WordInformationService()
        {
             _httpClient = new HttpClient();
             _url = "https://api.dictionaryapi.dev/api/v2/entries/en/";
        }
        public async Task<string> GetWordInfoAsync(string word)
        {
            var url = _url + word;
            var response = await (await _httpClient.GetAsync(url)).Content.ReadAsStringAsync();
            return response;
        }
    }
}
