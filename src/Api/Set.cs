namespace JpnCardsPokemonSdk.Api;

public class Set
{
    public string Name { get; set; }

    public int Id { get; set; }

    public string? SourceUrl { get; set; }

    public string? ImageUrl { get; set; }

    public string Language { get; set; }

    public int Year { get; set; }

    // TODO: According to documentation the property currently is not supported.
    // public DateOnly? Date { get; set; }

    public int TotalCardCount { get; set; }

    public int PrintedCardCount { get; set; }

    public string SetCode { get; set; }

    public int Uuid { get; set; }
}