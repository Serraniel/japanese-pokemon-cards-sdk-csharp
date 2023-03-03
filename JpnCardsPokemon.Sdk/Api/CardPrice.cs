using System;
using System.Text.Json.Serialization;

namespace JpnCardsPokemon.Sdk.Api;

public class CardPrice
{
    public string? Version { get; set; }

    public string? Condition { get; set; }

    [JsonPropertyName("priceAmount")] public decimal Price { get; set; }

    [JsonPropertyName("priceCurrency")] public string? Currency { get; set; }

    [JsonPropertyName("dateUpdated")] public DateTime? UpdatedDate { get; set; }

    public string? ListingUrl { get; set; }

    public string? Seller { get; set; }
}