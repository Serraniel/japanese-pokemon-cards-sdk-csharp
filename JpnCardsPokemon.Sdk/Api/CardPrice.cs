using System;
using System.Text.Json.Serialization;
using JpnCardsPokemon.Sdk.Utils.JsonConverter;

namespace JpnCardsPokemon.Sdk.Api;

/// <summary>
///     Contains information about card price.
/// </summary>
public class CardPrice
{
    /// <summary>
    ///     Specifies the card version. Almost always will be 'Regular' but may contain other versions like 'Reverse Holo',
    ///     etc.
    /// </summary>
    [JsonPropertyName("variant")]
    public string? Version { get; set; }

    /// <summary>
    ///     Specifies the card condition. Often will be a rating in format of 'A+', 'A', etc. but also can be 'NM' or other
    ///     similar descriptive strings.
    /// </summary>
    public string? Condition { get; set; }

    /// <summary>
    ///     The actual price for the specified version and condition.
    /// </summary>
    [JsonPropertyName("priceAmount")]
    public decimal Price { get; set; }

    /// <summary>
    ///     The currency used for the <see cref="Price" />.
    /// </summary>
    /// <remarks>Almost always will be 'JYP' for Japanese Yen.</remarks>
    [JsonPropertyName("priceCurrency")]
    public string? Currency { get; set; }

    /// <summary>
    ///     Date when the price information was updated last.
    /// </summary>
    [JsonPropertyName("dateUpdated")]
    [JsonConverter(typeof(CustomDateTimeConverter))]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    ///     An URL to the listing.
    /// </summary>
    [JsonPropertyName("listingUrl")]
    public string? ListingUrl { get; set; }

    /// <summary>
    ///     Name of the seller who is listing the card.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? Seller { get; set; }
}