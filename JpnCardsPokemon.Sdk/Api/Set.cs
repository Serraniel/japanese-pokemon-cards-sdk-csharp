using System.Text.Json.Serialization;
using JpnCardsPokemon.Sdk.Utils.JsonConverter;

namespace JpnCardsPokemon.Sdk.Api;

/// <summary>
///     Represents a set object from the web api.
/// </summary>
public class Set
{
    /// <summary>
    ///     The name of the set.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     The internal identification number that the set is given. Used to query for information about this single set or
    ///     for all cards in this single set.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     The URL to a page which has more information about the set.
    /// </summary>
    [JsonPropertyName("source_url")]
    public string? SourceUrl { get; set; }

    /// <summary>
    ///     A URL to the official set's image.
    /// </summary>
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    /// <summary>
    ///     The language that the cards in the set are printed in.
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    ///     The year the set was released.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonConverter(typeof(NoneIntJsonConverter))] // set hashes in card objects sometimes have "none" as year.
    public int Year { get; set; }

    // TODO: According to documentation the property currently is not supported.
    // public DateOnly? Date { get; set; }

    /// <summary>
    ///     The total number of cards in the set.
    /// </summary>
    [JsonPropertyName("card_count")]
    public int TotalCardCount { get; set; }

    /// <summary>
    ///     The number of cards in the set that is printed on the card. This differs from the set's
    ///     <see cref="TotalCardCount" /> in sets with Secret Rare cards.
    /// </summary>
    [JsonPropertyName("printed_count")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int PrintedCardCount { get; set; }

    /// <summary>
    ///     The shorthand code for the set.
    /// </summary>
    [JsonPropertyName("set_code")]
    public string? SetCode { get; set; }

    /// <summary>
    ///     A stable id for earch card. Output is an eight digit integer which is unique for each card. While the cards'
    ///     <see cref="Id" /> may change over time, the uuid should always remain stable and constant.
    /// </summary>
    public int Uuid { get; set; }
}