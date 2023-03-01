using System.Text.Json.Serialization;
using JpnCardsPokemonSdk.Utils.JsonConverter;

namespace JpnCardsPokemonSdk.Api;

public class Set
{
    static Set()
    {
        EndpointFactory.RegisterTypeEndpoint<Set>(new SetEndpoint());
    }

    public string? Name { get; set; }

    public int Id { get; set; }

    [JsonPropertyName("source_url")]
    public string? SourceUrl { get; set; }

    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    public string? Language { get; set; }

    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonConverter(typeof(NoneIntJsonConverter))] // set hashes in card objects sometimes have "none" as year.
    public int Year { get; set; }

    // TODO: According to documentation the property currently is not supported.
    // public DateOnly? Date { get; set; }

    [JsonPropertyName("card_count")]
    public int TotalCardCount { get; set; }

    [JsonPropertyName("printed_count")]
    public int PrintedCardCount { get; set; }

    [JsonPropertyName("set_code")]
    public string? SetCode { get; set; }

    public int Uuid { get; set; }
}