#### [JpnCardsPokemon.Sdk](index.md 'index')
### [JpnCardsPokemon.Sdk.Client](JpnCardsPokemon.Sdk.Client.md 'JpnCardsPokemon.Sdk.Client').[ApiClient](JpnCardsPokemon.Sdk.Client.ApiClient.md 'JpnCardsPokemon.Sdk.Client.ApiClient')

## ApiClient.FetchCardsAsync(IQueryFilterBuilder) Method

Fetches [Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card') from a search query.

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<JpnCardsPokemon.Sdk.Api.Card>?> FetchCardsAsync(JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder filterBuilder);
```
#### Parameters

<a name='JpnCardsPokemon.Sdk.Client.ApiClient.FetchCardsAsync(JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder).filterBuilder'></a>

`filterBuilder` [IQueryFilterBuilder](JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder.md 'JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder')

Configured query builder to generate the search query.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns an enumerable of [Card](JpnCardsPokemon.Sdk.Api.Card.md 'JpnCardsPokemon.Sdk.Api.Card') matching the [query](https://docs.microsoft.com/en-us/dotnet/api/query 'query').

### Remarks
At least one filter must be specified.