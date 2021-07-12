using System.Collections.Generic;
using System.Threading.Tasks;
using WebPageScraper.Models;

namespace WebPageScraper.Services
{
    public interface IHtmlService
    {
        string GetPageSourceFromUrl(string url);
        IEnumerable<string> GetAllImages(string html, string imageBaseUrl);
        Dictionary<string, WordModel> GetWords(string html);
    }
}