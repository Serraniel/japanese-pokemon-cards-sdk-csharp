#### [JpnCardsPokemon.Sdk](index.md 'index')
### [JpnCardsPokemon.Sdk.Api](JpnCardsPokemon.Sdk.Api.md 'JpnCardsPokemon.Sdk.Api')

## Card Class

Represents a card object from the web api.

```csharp
public class Card
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Card

| Properties | |
| :--- | :--- |
| [Artist](JpnCardsPokemon.Sdk.Api.Card.Artist.md 'JpnCardsPokemon.Sdk.Api.Card.Artist') | The card art's artist. |
| [CardUrl](JpnCardsPokemon.Sdk.Api.Card.CardUrl.md 'JpnCardsPokemon.Sdk.Api.Card.CardUrl') | The URL which leads to the original card URL data. |
| [ConvertedRetreatCost](JpnCardsPokemon.Sdk.Api.Card.ConvertedRetreatCost.md 'JpnCardsPokemon.Sdk.Api.Card.ConvertedRetreatCost') | The total number of energies needed to retreat. |
| [EvolvesFrom](JpnCardsPokemon.Sdk.Api.Card.EvolvesFrom.md 'JpnCardsPokemon.Sdk.Api.Card.EvolvesFrom') | If the card evolves from another card, this field will denote the name of the pre-evolution. |
| [Hp](JpnCardsPokemon.Sdk.Api.Card.Hp.md 'JpnCardsPokemon.Sdk.Api.Card.Hp') | The amount of HP the card has. |
| [Id](JpnCardsPokemon.Sdk.Api.Card.Id.md 'JpnCardsPokemon.Sdk.Api.Card.Id') | The internal identification number that the card is given. Used to query for this single card. |
| [ImageUrl](JpnCardsPokemon.Sdk.Api.Card.ImageUrl.md 'JpnCardsPokemon.Sdk.Api.Card.ImageUrl') | The url pointing to the card's image. |
| [Name](JpnCardsPokemon.Sdk.Api.Card.Name.md 'JpnCardsPokemon.Sdk.Api.Card.Name') | The name of the card. |
| [Number](JpnCardsPokemon.Sdk.Api.Card.Number.md 'JpnCardsPokemon.Sdk.Api.Card.Number') | The sequential number of the card (applicable to Secret Rares). |
| [Prices](JpnCardsPokemon.Sdk.Api.Card.Prices.md 'JpnCardsPokemon.Sdk.Api.Card.Prices') | A list of known prices for this card. |
| [PrintedNumber](JpnCardsPokemon.Sdk.Api.Card.PrintedNumber.md 'JpnCardsPokemon.Sdk.Api.Card.PrintedNumber') | The number printed on the card. Will be the same as [Number](JpnCardsPokemon.Sdk.Api.Card.Number.md 'JpnCardsPokemon.Sdk.Api.Card.Number') almost always. Is relevant for<br/>promotional cards, such as SWSH001. |
| [Rarity](JpnCardsPokemon.Sdk.Api.Card.Rarity.md 'JpnCardsPokemon.Sdk.Api.Card.Rarity') | The rarity of the card. |
| [RetreatCosts](JpnCardsPokemon.Sdk.Api.Card.RetreatCosts.md 'JpnCardsPokemon.Sdk.Api.Card.RetreatCosts') | List of the energies required to retreat. |
| [Rules](JpnCardsPokemon.Sdk.Api.Card.Rules.md 'JpnCardsPokemon.Sdk.Api.Card.Rules') | Describes rules the card is bound to. Mainly for cards with a rule box and certain Trainers. |
| [Set](JpnCardsPokemon.Sdk.Api.Card.Set.md 'JpnCardsPokemon.Sdk.Api.Card.Set') | Reduced information about the set the card belongs to. |
| [Subtypes](JpnCardsPokemon.Sdk.Api.Card.Subtypes.md 'JpnCardsPokemon.Sdk.Api.Card.Subtypes') | The subsets that the card falls into. For example 'Single Strike Pokemon', 'Pokemon VMAX', etc. |
| [Supertype](JpnCardsPokemon.Sdk.Api.Card.Supertype.md 'JpnCardsPokemon.Sdk.Api.Card.Supertype') | The supertype the card is. |
| [Types](JpnCardsPokemon.Sdk.Api.Card.Types.md 'JpnCardsPokemon.Sdk.Api.Card.Types') | The energy type of types the card is. |
| [Uuid](JpnCardsPokemon.Sdk.Api.Card.Uuid.md 'JpnCardsPokemon.Sdk.Api.Card.Uuid') | A stable id for earch card. Output is an eight digit integer which is unique for each card. While the cards'<br/>[Id](JpnCardsPokemon.Sdk.Api.Card.Id.md 'JpnCardsPokemon.Sdk.Api.Card.Id') may change over time, the uuid should always remain stable and constant. |
