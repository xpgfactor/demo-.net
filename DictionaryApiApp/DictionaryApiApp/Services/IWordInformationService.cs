namespace DictionaryApiApp.Services
{
    public interface IWordInformationService
    {
        public Task<string> GetWordInfoAsync(string word);
    }
}
