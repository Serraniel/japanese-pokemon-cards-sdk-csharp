using System;

namespace JpnCardsPokemonSdk.Utils.QueryFilter;

[AttributeUsage(AttributeTargets.Property)]
public class QueryFilterAttribute : Attribute
{
    public QueryFilterAttribute(string? paramName)
    {
        ParamName = paramName;
    }

    public QueryFilterAttribute() : this(null)
    {
    }

    public string? ParamName { get; set; }
}