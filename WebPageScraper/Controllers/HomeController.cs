using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebPageScraper.Models;
using WebPageScraper.Services;

namespace WebPageScraper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHtmlService _htmlService;

        public HomeController(ILogger<HomeController> logger, IHtmlService htmlService)
        {
            _logger = logger;
            _htmlService = htmlService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GetSource(string url)
        {
            return _htmlService.GetPageSourceFromUrl(url);
        }

        [HttpPost]
        public ActionResult GetImages(string html, string imageBase)
        {
            return PartialView("GetImages", _htmlService.GetAllImages(html, imageBase));
        }

        [HttpPost]
        public ActionResult GetWords(string html)
        {
            return PartialView("GetWords", _htmlService.GetWords(html));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
