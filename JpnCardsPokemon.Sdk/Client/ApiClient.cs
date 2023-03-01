using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using JpnCardsPokemon.Sdk.Api;
using JpnCardsPokemon.Sdk.Utils.QueryFilter;

namespace JpnCardsPokemon.Sdk.Client;

public class ApiClient
{
    private readonly HttpClient _client;

#if NETCOREAPP3_1_OR_GREATER
    public ApiClient(SocketsHttpHandler handler) : this(new HttpClient(handler))
    {
    }
#endif

    public ApiClient() : this(new HttpClient())
    {
    }

    public ApiClient(HttpClient client)
    {
        _client = client;

        _client.BaseAddress = new Uri("https://www.jpn-cards.com/v2/");
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(
            new ProductHeaderValue("JpnCardsPokemonSdkCS", GetType().Assembly.GetName().Version?.ToString())));
    }

    private async Task<T?> FetchInternalAsync<T>(string requestUri)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            IncludeFields = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        return await _client.GetFromJsonAsync<T>(requestUri, options);
    }

    private string SetQuery(string? filter)
    {
        return !string.IsNullOrEmpty(filter) ? $"set/{filter.TrimStart('/')}" : "set";
    }

    public async Task<IEnumerable<Set>> FetchSetsAsync()
    {
        return await FetchInternalAsync<IEnumerable<Set>>(SetQuery(null)) ?? Enumerable.Empty<Set>();
    }

    public async Task<Set?> FetchSetById(int id)
    {
        return await FetchInternalAsync<Set>(SetQuery(id.ToString()));
    }

    public async Task<Set?> FetchSetByUuid(int uuid)
    {
        return await FetchInternalAsync<Set>(SetQuery($"uuid/{uuid}"));
    }

    public async Task<IEnumerable<Card>> FetchCardsAsync(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new Exception("Query string required");

        // JSON response is wrapped into a data property, so we parse as JsonDocument first before deserialization.
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            IncludeFields = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var jsonData = await FetchInternalAsync<JsonDocument>($"card/{query}");
        return jsonData?.RootElement.GetProperty("data").Deserialize<IEnumerable<Card>>(options) ??
               Enumerable.Empty<Card>();
    }

    public async Task<IEnumerable<Card>?> FetchCardsAsync(IQueryFilterBuilder filterBuilder)
    {
        return await FetchCardsAsync(filterBuilder.BuildQueryString());
    }
}