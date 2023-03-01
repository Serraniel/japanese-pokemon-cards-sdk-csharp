namespace JpnCardsPokemonSdk.Utils.QueryFilter;

public class CardQueryFilterBuilder : AttributedQueryFilterBuilder
{
    [QueryFilterName("id")] public int? Id { get; set; }

    [QueryFilterName("name")] public string? Name { get; set; }

    [QueryFilterName("set_id")] public int? SetId { get; set; }

    [QueryFilterName("illustrator")] public string? Artist { get; set; }

    [QueryFilterName("p_no")] public string? PrintedNumber { get; set; }

    [QueryFilterName("uuid")] public int? Uuid { get; set; }

    [QueryFilterName("rarity")] public string? Rarity { get; set; }

    [QueryFilterName("subtype")] public string? Subtype { get; set; }

    [QueryFilterName("type")] public string? Type { get; set; }

    [QueryFilterName("set_code")] public string? SetCode { get; set; }
}