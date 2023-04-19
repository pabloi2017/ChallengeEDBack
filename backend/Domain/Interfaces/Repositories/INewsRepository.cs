using Challenge.NewsApi.Domain.DTO;
using Challenge.NewsApi.Domain.Filters;

namespace Challenge.NewsApi.Domain.Interfaces.Repositories
{
    public interface INewsRepository
    {
        Task<NewsDTO> FetchNewsAsync(NewsFilter filter);
    }

}
