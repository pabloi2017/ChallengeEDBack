using System.Text;

namespace Challenge.NewsApi.Domain.Interfaces
{
    public class FilterSpecification<T> : IFilterSpecification<T>
    {
        public string ApplyFilter(T filter)
        {
            var queryString = new StringBuilder();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(filter);

                if (value != null)
                {
                    queryString.Append($"{property.Name}={Uri.EscapeDataString(value.ToString())}&");
                }
            }

            // Remove the last '&' character
            if (queryString.Length > 0)
            {
                queryString.Length -= 1;
            }

            return queryString.ToString();
        }
    }
}
