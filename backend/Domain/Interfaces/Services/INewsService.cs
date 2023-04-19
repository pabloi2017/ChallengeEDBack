using Challenge.NewsApi.Domain.DTO;
using Challenge.NewsApi.Domain.Filters;

namespace Challenge.NewsApi.Domain.Interfaces.Services
{
    public interface INewsService
    {
        Task<NewsDTO> FetchNewsAsync(NewsFilter filter);
    }
}
