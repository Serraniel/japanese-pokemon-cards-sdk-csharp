using System;

namespace JpnCardsPokemonSdk.Utils.QueryFilter;

[AttributeUsage(AttributeTargets.Property)]
public class QueryFilterNameAttribute : Attribute
{
    public QueryFilterNameAttribute(string? paramName)
    {
        ParamName = paramName;
    }

    public QueryFilterNameAttribute() : this(null)
    {
    }

    public string? ParamName { get; set; }
}