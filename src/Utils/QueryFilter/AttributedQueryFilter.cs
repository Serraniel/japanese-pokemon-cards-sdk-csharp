using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace JpnCardsPokemonSdk.Utils.QueryFilter;

public abstract class AttributedQueryFilter : IQueryFilter
{
    public string BuildQueryString()
    {
        var filterBucket = new List<KeyValuePair<string, string>>();

        var properties = GetType().GetProperties();
        foreach (var propertyInfo in properties)
        {
            var attribute = propertyInfo.GetCustomAttribute<QueryFilterAttribute>();

            if (attribute == null)
                continue;

            var paramName = attribute.ParamName ?? propertyInfo.Name;
            var value = propertyInfo.GetValue(this).ToString();
            if (!string.IsNullOrEmpty(value)) filterBucket.Add(new KeyValuePair<string, string>(paramName, value));
        }

        var filterBuilder = new StringBuilder();
        foreach (var keyValuePair in filterBucket)
            filterBuilder.Append($"&{keyValuePair.Key}={WebUtility.UrlEncode(keyValuePair.Value)}");

        return filterBuilder.ToString().TrimStart('&');
    }
}