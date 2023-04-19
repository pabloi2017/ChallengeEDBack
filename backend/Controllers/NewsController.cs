using Challenge.NewsApi.Domain.Filters;
using Challenge.NewsApi.Domain.Interfaces.Repositories;
using Challenge.NewsApi.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.NewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        [Route("/api/news/search")]
        public async Task<IActionResult> GetNews([FromQuery] NewsFilter filter)
        {
            try
            {
                var news = await _newsService.FetchNewsAsync(filter);
                return Ok(news);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}

