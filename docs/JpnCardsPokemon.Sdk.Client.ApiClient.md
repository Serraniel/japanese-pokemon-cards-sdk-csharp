#### [JpnCardsPokemon.Sdk](index.md 'index')
### [JpnCardsPokemon.Sdk.Client](JpnCardsPokemon.Sdk.Client.md 'JpnCardsPokemon.Sdk.Client')

## ApiClient Class

A client to interact with the web api.

```csharp
public class ApiClient
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ApiClient

| Constructors | |
| :--- | :--- |
| [ApiClient()](JpnCardsPokemon.Sdk.Client.ApiClient.ApiClient().md 'JpnCardsPokemon.Sdk.Client.ApiClient.ApiClient()') | Creates a new instance of the ApiClient. |
| [ApiClient(HttpClient)](JpnCardsPokemon.Sdk.Client.ApiClient.ApiClient(System.Net.Http.HttpClient).md 'JpnCardsPokemon.Sdk.Client.ApiClient.ApiClient(System.Net.Http.HttpClient)') | Creates a new instance of the ApiClient. |

| Methods | |
| :--- | :--- |
| [FetchCardsAsync(IQueryFilterBuilder)](JpnCardsPokemon.Sdk.Client.ApiClient.FetchCardsAsync(JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder).md 'JpnCardsPokemon.Sdk.Client.ApiClient.FetchCardsAsync(JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder)') | Fetches [Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card') from a search query. |
| [FetchCardsAsync(string)](JpnCardsPokemon.Sdk.Client.ApiClient.FetchCardsAsync(string).md 'JpnCardsPokemon.Sdk.Client.ApiClient.FetchCardsAsync(string)') | Fetches [Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card') from a search query. |
| [FetchSetById(int)](JpnCardsPokemon.Sdk.Client.ApiClient.FetchSetById(int).md 'JpnCardsPokemon.Sdk.Client.ApiClient.FetchSetById(int)') | Fetches a [Set](JpnCardsPokemon.Sdk.Api.Set.md 'JpnCardsPokemon.Sdk.Api.Set') by its id. |
| [FetchSetByUuid(int)](JpnCardsPokemon.Sdk.Client.ApiClient.FetchSetByUuid(int).md 'JpnCardsPokemon.Sdk.Client.ApiClient.FetchSetByUuid(int)') | Fetches a [Set](JpnCardsPokemon.Sdk.Api.Set.md 'JpnCardsPokemon.Sdk.Api.Set') by its uuid. |
| [FetchSetsAsync()](JpnCardsPokemon.Sdk.Client.ApiClient.FetchSetsAsync().md 'JpnCardsPokemon.Sdk.Client.ApiClient.FetchSetsAsync()') | Fetches all [Set](JpnCardsPokemon.Sdk.Api.Set.md 'JpnCardsPokemon.Sdk.Api.Set'). |
