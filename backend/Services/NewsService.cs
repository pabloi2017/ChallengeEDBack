using Challenge.NewsApi.Domain.Interfaces.Repositories;
using Challenge.NewsApi.Domain.DTO;
using Challenge.NewsApi.Domain.Filters;
using Challenge.NewsApi.Domain.Interfaces.Services;

namespace Challenge.NewsApi.Interfaces
{
    public class NewsService : INewsService
    {
        public readonly INewsRepository _newsRepository;

        public NewsService(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }
        public async Task<NewsDTO> FetchNewsAsync(NewsFilter filter)
        {

            return await _newsRepository.FetchNewsAsync(filter);

        }
       
    }
}

