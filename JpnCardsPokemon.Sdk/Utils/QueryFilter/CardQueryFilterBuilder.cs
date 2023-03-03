using JpnCardsPokemon.Sdk.Api;

namespace JpnCardsPokemon.Sdk.Utils.QueryFilter;

/// <summary>
///     <see cref="IQueryFilterBuilder" /> for <see cref="Card" />.
/// </summary>
public class CardQueryFilterBuilder : AttributedQueryFilterBuilder
{
    /// <summary>
    ///     Sets a filter for the <see cref="Card.Id" />.
    /// </summary>
    [QueryFilterName("id")]
    public int? Id { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Name" />.
    /// </summary>
    /// <remarks>Must match the full name.</remarks>
    [QueryFilterName("name")]
    public string? Name { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Set" /> by <see cref="Set.Id" />.
    /// </summary>
    [QueryFilterName("set_id")]
    public int? SetId { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Artist" />.
    /// </summary>
    /// <remarks>Must match the full name.</remarks>
    [QueryFilterName("illustrator")]
    public string? Artist { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.PrintedNumber" />.
    /// </summary>
    [QueryFilterName("p_no")]
    public string? PrintedNumber { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Uuid" />.
    /// </summary>
    [QueryFilterName("uuid")]
    public int? Uuid { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Rarity/>.
    /// 
    /// </summary>
    [QueryFilterName("rarity")]
    public string? Rarity { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Subtypes" />.
    /// </summary>
    [QueryFilterName("subtype")]
    public string? Subtype { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Types" />.
    /// </summary>
    [QueryFilterName("type")]
    public string? Type { get; set; }

    /// <summary>
    ///     Sets a filter for the <see cref="Card.Set" /> by <see cref="Set.SetCode" />.
    /// </summary>
    [QueryFilterName("set_code")]
    public string? SetCode { get; set; }
}