using System;

namespace JpnCardsPokemon.Sdk.Utils.QueryFilter;

/// <summary>
///     Attribute which can be used to mark a property as a filter for the <see cref="AttributedQueryFilterBuilder" />.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class QueryFilterNameAttribute : Attribute
{
    /// <summary>
    ///     Creates a new query filter attribute with a custom filter name.
    /// </summary>
    /// <param name="paramName">Custom filter name for the web request.</param>
    public QueryFilterNameAttribute(string? paramName)
    {
        ParamName = paramName;
    }

    /// <summary>
    ///     Creates a new query filter attribute.
    /// </summary>
    public QueryFilterNameAttribute() : this(null)
    {
    }

    /// <summary>
    ///     Filter name for the web api.
    /// </summary>
    public string? ParamName { get; set; }
}