#### [JpnCardsPokemon.Sdk](index.md 'index')
### [JpnCardsPokemon.Sdk.Client](JpnCardsPokemon.Sdk.Client.md 'JpnCardsPokemon.Sdk.Client').[ApiClient](JpnCardsPokemon.Sdk.Client.ApiClient.md 'JpnCardsPokemon.Sdk.Client.ApiClient')

## ApiClient.FetchSetById(int) Method

Fetches a [Set](JpnCardsPokemon.Sdk.Api.Set.md 'JpnCardsPokemon.Sdk.Api.Set') by its id.

```csharp
public System.Threading.Tasks.Task<JpnCardsPokemon.Sdk.Api.Set?> FetchSetById(int id);
```
#### Parameters

<a name='JpnCardsPokemon.Sdk.Client.ApiClient.FetchSetById(int).id'></a>

`id` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Id of the [Set](JpnCardsPokemon.Sdk.Api.Set.md 'JpnCardsPokemon.Sdk.Api.Set') to fetch.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Set](JpnCardsPokemon.Sdk.Api.Set.md 'JpnCardsPokemon.Sdk.Api.Set')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
If existing returns the matching [Set](JpnCardsPokemon.Sdk.Api.Set.md 'JpnCardsPokemon.Sdk.Api.Set').