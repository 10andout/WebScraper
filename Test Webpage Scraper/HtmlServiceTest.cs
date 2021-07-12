using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebPageScraper.Services;

namespace Test_Webpage_Scraper
{
    [TestClass]
    public class HtmlServiceTest
    {
        private string _testHtml = WebPageScraper.Static.SampleHtml.TestHtml;

        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestMethod]
        public void TestGetPageSourceFromUrl_ValidUrl()
        {
            var service = new HtmlService();
            var source = service.GetPageSourceFromUrl("https://customhockeysticks.ca/privacy-policy/");

            Assert.IsTrue(!string.IsNullOrWhiteSpace(source));
        }

        [TestMethod]
        public void TestGetPageSourceFromUrl_InvalidUrl()
        {
            var service = new HtmlService();
            var source = service.GetPageSourceFromUrl("https://customhockeysticks/privacy-policy/");

            Assert.IsTrue(string.IsNullOrWhiteSpace(source));
        }

        [TestMethod]
        public void TestGetAllImages()
        {
            var service = new HtmlService();
            var baseUrl = "https://test.com";
            var images = service.GetAllImages(_testHtml, baseUrl);

            var count = images.Count();

            Assert.IsTrue(count == 3);
        }

        [TestMethod]
        public void TestGetWords()
        {
            var service = new HtmlService();
            var words = service.GetWords(_testHtml);

            var count = words.Count();

            Assert.IsTrue(count == 18);
        }

        [TestMethod]
        public void TestGetWords_TopWord()
        {
            var service = new HtmlService();
            var words = service.GetWords(_testHtml);

            var topWord = words.OrderByDescending(x=>x.Value.Count).FirstOrDefault();

            Assert.IsTrue(topWord.Value?.Word == "top");
        }
    }
}
