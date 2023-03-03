using System.Collections.Generic;
using System.Text.Json.Serialization;
using JpnCardsPokemon.Sdk.Utils.JsonConverter;

namespace JpnCardsPokemon.Sdk.Api;

/// <summary>
///     Represents a card object from the web api.
/// </summary>
public class Card
{
    /// <summary>
    ///     The name of the card.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     The internal identification number that the card is given. Used to query for this single card.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Reduced information about the set the card belongs to.
    /// </summary>
    /// <remarks>May contain basic information only. It´s recommended to fetch the fully <see cref="Set" /> separately.</remarks>
    [JsonPropertyName("setData")]
    public Set? Set { get; set; }

    /// <summary>
    ///     The energy type of types the card is.
    /// </summary>
    /// <remarks>Almost always will be a single value.</remarks>
    public string[]? Types { get; set; }

    /// <summary>
    ///     The amount of HP the card has.
    /// </summary>
    /// <remarks>If the card does not have HP, the value will be -1.</remarks>
    public int Hp { get; set; } = -1;

    /// <summary>
    ///     If the card evolves from another card, this field will denote the name of the pre-evolution.
    /// </summary>
    public string? EvolvesFrom { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Effect? Effect { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Attack[]? Attacks { get; set; }

    /// <summary>
    ///     Describes rules the card is bound to. Mainly for cards with a rule box and certain Trainers.
    /// </summary>
    public string[]? Rules { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Weakness[]? Weaknesses { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Resistance[]? Resistances { get; set; }

    /// <summary>
    ///     A list of known prices for this card.
    /// </summary>
    /// <remarks>May contain entries from different sellers, versions and conditions.</remarks>
    [JsonConverter(typeof(CardPricesJsonConverter))]
    public IEnumerable<CardPrice>? Prices { get; set; }

    /// <summary>
    ///     List of the energies required to retreat.
    /// </summary>
    [JsonPropertyName("retreatCost")]
    public string[]? RetreatCosts { get; set; }

    /// <summary>
    ///     The total number of energies needed to retreat.
    /// </summary>
    public int? ConvertedRetreatCost { get; set; }

    /// <summary>
    ///     The supertype the card is.
    /// </summary>
    /// <remarks>Only possibilities are 'Pokemon', 'Trainer' or 'Energy'.</remarks>
    public string? Supertype { get; set; }

    /// <summary>
    ///     The subsets that the card falls into. For example 'Single Strike Pokemon', 'Pokemon VMAX', etc.
    /// </summary>
    public string[]? Subtypes { get; set; }

    /// <summary>
    ///     The rarity of the card.
    /// </summary>
    public string? Rarity { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Legality[]? Legalities { get; set; }

    /// <summary>
    ///     The card art's artist.
    /// </summary>
    public string? Artist { get; set; }

    /// <summary>
    ///     The url pointing to the card's image.
    /// </summary>
    /// <remarks>
    ///     If there is no card image, then this will instead point to
    ///     https://assets.tcgcollector.com/build/images/default-card-image.789f6232.png.
    /// </remarks>
    public string? ImageUrl { get; set; }

    /// <summary>
    ///     The URL which leads to the original card URL data.
    /// </summary>
    public string? CardUrl { get; set; }

    /// <summary>
    ///     The sequential number of the card (applicable to Secret Rares).
    /// </summary>
    [JsonPropertyName("sequenceNumber")]
    public int Number { get; set; }

    /// <summary>
    ///     The number printed on the card. Will be the same as <see cref="Number" /> almost always. Is relevant for
    ///     promotional cards, such as SWSH001.
    /// </summary>
    public string? PrintedNumber { get; set; }

    /// <summary>
    ///     A stable id for earch card. Output is an eight digit integer which is unique for each card. While the cards'
    ///     <see cref="Id" /> may change over time, the uuid should always remain stable and constant.
    /// </summary>
    public int Uuid { get; set; }
}