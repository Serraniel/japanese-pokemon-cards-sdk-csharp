#### [JpnCardsPokemon.Sdk](index.md 'index')
### [JpnCardsPokemon.Sdk.Api](JpnCardsPokemon.Sdk.Api.md 'JpnCardsPokemon.Sdk.Api').[Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card')

## Card.Uuid Property

A stable id for earch card. Output is an eight digit integer which is unique for each card. While the cards'  
[Id](JpnCardsPokemon.Sdk.Api.Card.Id.md 'JpnCardsPokemon.Sdk.Api.Card.Id') may change over time, the uuid should always remain stable and constant.

```csharp
public int Uuid { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')