using DictionaryApiApp.Models;
using DictionaryApiApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DictionaryApiApp.Controllers
{
    public class DictionaryController : Controller
    {
        private readonly ILogger<DictionaryController> _logger;
        private IWordInformationService _wordInformationService;

        public DictionaryController(ILogger<DictionaryController> logger, IWordInformationService wordInformationService)
        {
            _logger = logger;
            _wordInformationService = wordInformationService;
        }

        public async Task<IActionResult> GetWordInfo(InputWord model)
        {
            var response = "";
            try
            {
                if (string.IsNullOrEmpty(model?.Word))
                    return View();

                response = await _wordInformationService.GetWordInfoAsync(model?.Word);

                var wordInfo = new WordInfo()
                {
                    WordInfoElements = JsonSerializer.Deserialize<List<WordInfoElement>>(response)
                };
                return View(wordInfo);
            }
            catch (JsonException ex)
            {
                var errorInfo = JsonSerializer.Deserialize<ErrorViewModel>(response);
                _logger.LogDebug("Error: {0}  Message: {1}", errorInfo.Title, errorInfo.Message);
                return View("Error", errorInfo);
            }
            catch (Exception ex)
            {
                _logger.LogDebug("Error: {0}  Message: {1}", ex, ex.Message);
                var errorInfo = new ErrorViewModel() { Title = "Unknown error", Message = ex.Message};
                return View("Error", errorInfo);
            }
        }

        public IActionResult About()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
