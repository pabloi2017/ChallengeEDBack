namespace Challenge.NewsApi.Domain.Filters
{
    public class NewsFilter
    {
        public string? DateFrom { get; set; }
        public string? DateTo { get; set; }
        public string? Keywords { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
