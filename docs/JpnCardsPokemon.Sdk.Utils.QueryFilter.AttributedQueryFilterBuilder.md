#### [JpnCardsPokemon.Sdk](index.md 'index')
### [JpnCardsPokemon.Sdk.Utils.QueryFilter](JpnCardsPokemon.Sdk.Utils.QueryFilter.md 'JpnCardsPokemon.Sdk.Utils.QueryFilter')

## AttributedQueryFilterBuilder Class

Abstract Implementation of an [IQueryFilterBuilder](JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder.md 'JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder') which builts the filter string based on  
[QueryFilterNameAttribute](JpnCardsPokemon.Sdk.Utils.QueryFilter.QueryFilterNameAttribute.md 'JpnCardsPokemon.Sdk.Utils.QueryFilter.QueryFilterNameAttribute') attributed properties.

```csharp
public abstract class AttributedQueryFilterBuilder :
JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AttributedQueryFilterBuilder

Derived  
&#8627; [CardQueryFilterBuilder](JpnCardsPokemon.Sdk.Utils.QueryFilter.CardQueryFilterBuilder.md 'JpnCardsPokemon.Sdk.Utils.QueryFilter.CardQueryFilterBuilder')

Implements [IQueryFilterBuilder](JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder.md 'JpnCardsPokemon.Sdk.Utils.QueryFilter.IQueryFilterBuilder')

| Methods | |
| :--- | :--- |
| [BuildQueryString()](JpnCardsPokemon.Sdk.Utils.QueryFilter.AttributedQueryFilterBuilder.BuildQueryString().md 'JpnCardsPokemon.Sdk.Utils.QueryFilter.AttributedQueryFilterBuilder.BuildQueryString()') | Builds the query filter to use for the api request. |
