namespace Challenge.NewsApi.Domain.Interfaces
{
    public interface IFilterSpecification<T>
    {
        string ApplyFilter(T filter);
    }
}
