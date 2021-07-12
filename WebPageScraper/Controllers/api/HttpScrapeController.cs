using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPageScraper.Services;

namespace WebPageScraper.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpScrapeController : ControllerBase
    {
        private readonly IHtmlService _htmlService;

        public HttpScrapeController(IHtmlService htmlService)
        {
            _htmlService = htmlService;
        }

    public async Task<ActionResult<string>>  Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var source = _htmlService.GetPageSourceFromUrl(id);

            if (string.IsNullOrWhiteSpace(source))
            {
                return NotFound();
            }

            return source;
        }
    }
}
