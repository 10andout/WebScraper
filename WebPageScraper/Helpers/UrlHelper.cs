using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPageScraper.Helpers
{
    public static class UrlHelper
    {
        public static string ValidateUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return "";
            }

            var lcUrl = url.ToLower();

            if(lcUrl.StartsWith("https://") || lcUrl.StartsWith("http://"))
            {
                return lcUrl;
            }

            return "https://" + lcUrl;
        }

        public static string RelativeUrlToFull(string url, string baseUrl)
        {
            if(string.IsNullOrWhiteSpace(baseUrl) || string.IsNullOrWhiteSpace(url))
            {
                return url;
            }

            return url.StartsWith("/") && !url.StartsWith("//") ? baseUrl + url : url;
        }
    }
}
