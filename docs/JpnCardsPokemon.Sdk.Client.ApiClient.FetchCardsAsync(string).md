#### [JpnCardsPokemon.Sdk](index.md 'index')
### [JpnCardsPokemon.Sdk.Client](JpnCardsPokemon.Sdk.Client.md 'JpnCardsPokemon.Sdk.Client').[ApiClient](JpnCardsPokemon.Sdk.Client.ApiClient.md 'JpnCardsPokemon.Sdk.Client.ApiClient')

## ApiClient.FetchCardsAsync(string) Method

Fetches [Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card') from a search query.

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<JpnCardsPokemon.Sdk.Api.Card>> FetchCardsAsync(string query);
```
#### Parameters

<a name='JpnCardsPokemon.Sdk.Client.ApiClient.FetchCardsAsync(string).query'></a>

`query` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The search query.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns an enumerable of [Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card') matching the [query](https://docs.microsoft.com/en-us/dotnet/api/query 'query').

#### Exceptions

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
Thrown if the [query](https://docs.microsoft.com/en-us/dotnet/api/query 'query') is empty.

### Remarks
At least one filter query must be specified. More information about the query format can be found at  
https://jpn-cards-site.readthedocs.io/en/latest/api_docs/pokemon/v2/v2_api/#card-queries.