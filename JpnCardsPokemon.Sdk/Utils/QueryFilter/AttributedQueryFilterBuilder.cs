using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace JpnCardsPokemon.Sdk.Utils.QueryFilter;

/// <summary>
///     Abstract Implementation of an <see cref="IQueryFilterBuilder" /> which builts the filter string based on
///     <see cref="QueryFilterNameAttribute" /> attributed properties.
/// </summary>
public abstract class AttributedQueryFilterBuilder : IQueryFilterBuilder
{
    /// <inheritdoc cref="IQueryFilterBuilder.BuildQueryString" />
    public string BuildQueryString()
    {
        var filterBucket = new List<KeyValuePair<string, string>>();

        var properties = GetType().GetProperties();
        foreach (var propertyInfo in properties)
        {
            var attribute = propertyInfo.GetCustomAttribute<QueryFilterNameAttribute>();

            if (attribute == null)
                continue;

            var paramName = attribute.ParamName ?? propertyInfo.Name;
            var value = propertyInfo.GetValue(this)?.ToString();
            if (!string.IsNullOrEmpty(value)) filterBucket.Add(new KeyValuePair<string, string>(paramName, value!));
        }

        var filterBuilder = new StringBuilder();
        foreach (var keyValuePair in filterBucket)
            filterBuilder.Append($"&{keyValuePair.Key}={WebUtility.UrlEncode(keyValuePair.Value)}");

        return filterBuilder.ToString().TrimStart('&');
    }
}