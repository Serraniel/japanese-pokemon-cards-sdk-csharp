namespace JpnCardsPokemon.Sdk.Utils.QueryFilter;

/// <summary>
///     Defines an interface for a filter builder.
/// </summary>
public interface IQueryFilterBuilder
{
    /// <summary>
    ///     Builds the query filter to use for the api request.
    /// </summary>
    /// <returns>Returns the built query filter.</returns>
    string BuildQueryString();
}