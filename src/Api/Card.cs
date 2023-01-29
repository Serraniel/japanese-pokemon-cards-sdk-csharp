﻿using System.Text.Json.Serialization;
using JpnCardsPokemonSdk.Client.Endpoints;

namespace JpnCardsPokemonSdk.Api;

public class Card : EndpointObject
{
    public string? Name { get; set; }

    public int Id { get; set; }

    [JsonPropertyName("setData")]
    public Set? Set { get; set; }

    public string[]? Types { get; set; }

    public int Hp { get; set; } = -1;

    public string? EvolvesFrom { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Effect? Effect { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Attack[]? Attacks { get; set; }

    public string[]? Rules { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Weakness[]? Weaknesses { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Resistance[]? Ressistences { get; set; }

    [JsonPropertyName("retreatCost")]
    public string[]? RetreatCosts { get; set; }

    public int? ConvertedRetreadCost { get; set; }

    public string? Supertype { get; set; }

    public string[]? Subtypes { get; set; }

    public string? Rarity { get; set; }

    // TODO: Type of property is not documented. Has to be evaluated at a later time.
    // public Legality[]? Legalities { get; set; }

    public string? Artist { get; set; }

    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    [JsonPropertyName("card_url")]
    public string? CardUrl { get; set; }

    [JsonPropertyName("sequenceNumber")]
    public int Number { get; set; }

    public string? PrintedNumber { get; set; }

    public int Uuid { get; set; }
}