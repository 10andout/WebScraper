using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebPageScraper.Helpers;
using WebPageScraper.Models;

namespace WebPageScraper.Services
{
    public class HtmlService : IHtmlService
    {
        public string GetPageSourceFromUrl(string url)
        {
            var finalUrl = UrlHelper.ValidateUrl(url);
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                try
                {
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                    return wc.DownloadString(new Uri(finalUrl));
                }
                catch (System.Exception ex)
                {
                    return "";
                }
            }
        }

        public IEnumerable<string> GetAllImages(string html, string imageBaseUrl)
        {
            var returnImgs = new List<string>();
            var baseUri = new Uri(UrlHelper.ValidateUrl(imageBaseUrl));
            var baseUrl = $"{baseUri.Scheme}://{baseUri.Host}";

            if (!string.IsNullOrWhiteSpace(html))
            {
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                returnImgs = doc.DocumentNode.Descendants("img")
                    .Select(node => node.GetAttributeValue("src", null))
                    .Where(src => !string.IsNullOrWhiteSpace(src))
                    .ToList();

                for(var i = 0; i<returnImgs.Count(); i++)
                {
                    if (returnImgs[i].StartsWith("/"))
                    {
                        returnImgs[i] = UrlHelper.RelativeUrlToFull(returnImgs[i], baseUrl);
                    }
                }

            }
            return returnImgs;
        }

        public Dictionary<string, WordModel> GetWords(string html)
        {
            var returnWords = new Dictionary<string, WordModel>();

            if (!string.IsNullOrWhiteSpace(html))
            {
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                foreach (var node in doc.DocumentNode.SelectNodes("//body//text()[not(parent::script)]"))
                {
                    MatchCollection matches = Regex.Matches(node.InnerText, @"\b(?:[a-z]{2,}|[ai])\b", RegexOptions.IgnoreCase);
                    foreach (var match in matches)
                    {
                        var word = match.ToString();
                        if (string.IsNullOrWhiteSpace(word))
                        {
                            continue;
                        }
                        if (returnWords.ContainsKey(word.ToLower()))
                        {
                            var foundWord = returnWords[word.ToLower()];
                            if (foundWord != null)
                            {
                                foundWord.Count++;
                            }
                            continue;
                        }
                        returnWords.Add(word.ToLower(), new WordModel { Word = word.ToLower(), Count = 1 });
                    }
                }

            }
            return returnWords;
        }
    }
}
