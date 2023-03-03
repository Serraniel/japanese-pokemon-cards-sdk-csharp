# japanese-pokemon-cards-sdk-csharp

[![nuget](https://img.shields.io/nuget/vpre/JpnCardsPokemon.Sdk?style=flat-square)](https://www.nuget.org/packages/JpnCardsPokemon.Sdk/) [![downloads](https://img.shields.io/nuget/dt/JpnCardsPokemon.Sdk?style=flat-square)](https://www.nuget.org/packages/JpnCardsPokemon.Sdk/) ![license](https://img.shields.io/github/license/serraniel/japanese-pokemon-cards-sdk-csharp?style=flat-square) ![vulnerabilities](https://img.shields.io/snyk/vulnerabilities/github/serraniel/japanese-pokemon-cards-sdk-csharp?style=flat-square) ![dependencies](https://img.shields.io/librariesio/github/serraniel/japanese-pokemon-cards-sdk-csharp?style=flat-square) 


Dependency-free C# SDK for interaction with [jpn-cards.com](https://jpn-cards-site.readthedocs.io/en/latest/home/). With the SDK you can gather information about Japanese Pokémon TCG. This includes information about sets and cards, including current price information if available. 
The data is provided by an external API. Please check the above link for more information. The SDK only fetches their current JSON data and wraps them into object. 

## Documentation
You can find full documentation [here](docs/index.md).

## Examples

Fetch all sets:
```csharp
var client = new ApiClient();
// fetch all set information
var sets = await client.FetchSetsAsync();

// fetch cards from set
var vmaxClimaxCards = await Client.FetchCardsAsync(new CardQueryFilterBuilder { SetCode = "s12a" });

// fetch all morpeko cards
var morpekoCards = await Client.FetchCardsAsync(new CardQueryFilterBuilder { Name = "morpeko" });

// fetch all Charizard drawn by Arita
var artiaCharizardCards = await Client.FetchCardsAsync(new CardQueryFilterBuilder { Name = "charizard", Artist = "mitsuhiro arita" });
```