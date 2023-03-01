namespace JpnCardsPokemonSdk.Utils.QueryFilter;

public class CardQueryFilter : AttributedQueryFilter
{
    [QueryFilter("id")] public int? Id { get; set; }

    [QueryFilter("name")] public string? Name { get; set; }

    [QueryFilter("set_id")] public int? SetId { get; set; }

    [QueryFilter("illustrator")] public string? Artist { get; set; }

    [QueryFilter("p_no")] public string? PrintedNumber { get; set; }

    [QueryFilter("uuid")] public int? Uuid { get; set; }

    [QueryFilter("rarity")] public string? Rarity { get; set; }

    [QueryFilter("subtype")] public string? Subtype { get; set; }

    [QueryFilter("type")] public string? Type { get; set; }

    [QueryFilter("set_code")] public string? SetCode { get; set; }
}