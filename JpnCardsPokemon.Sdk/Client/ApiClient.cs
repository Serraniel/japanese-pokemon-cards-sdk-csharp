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

/// <summary>
///     A client to interact with the web api.
/// </summary>
public class ApiClient
{
    private readonly HttpClient _client;

#if NETCOREAPP3_1_OR_GREATER
    /// <summary>
    ///     Creates a new instance of the ApiClient.
    /// </summary>
    /// <param name="handler">Can pass a <see cref="SocketsHttpHandler" /> to use for the internal http client.</param>
    public ApiClient(SocketsHttpHandler handler) : this(new HttpClient(handler))
    {
    }
#endif

    /// <summary>
    ///     Creates a new instance of the ApiClient.
    /// </summary>
    public ApiClient() : this(new HttpClient())
    {
    }

    /// <summary>
    ///     Creates a new instance of the ApiClient.
    /// </summary>
    /// <param name="client">Can pass a http client to use.</param>
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

    /// <summary>
    ///     Fetches all <see cref="Set" />.
    /// </summary>
    /// <returns>Returns an enumerable containing all <see cref="Set" />.</returns>
    public async Task<IEnumerable<Set>> FetchSetsAsync()
    {
        return await FetchInternalAsync<IEnumerable<Set>>(SetQuery(null)) ?? Enumerable.Empty<Set>();
    }

    /// <summary>
    ///     Fetches a <see cref="Set" /> by its id.
    /// </summary>
    /// <param name="id">Id of the <see cref="Set" /> to fetch.</param>
    /// <returns>If existing returns the matching <see cref="Set" />.</returns>
    public async Task<Set?> FetchSetById(int id)
    {
        return await FetchInternalAsync<Set>(SetQuery(id.ToString()));
    }

    /// <summary>
    ///     Fetches a <see cref="Set" /> by its uuid.
    /// </summary>
    /// <param name="uuid">Uuid of the <see cref="Set" /> to fetch.</param>
    /// <returns>If existing returns the matching <see cref="Set" />.</returns>
    public async Task<Set?> FetchSetByUuid(int uuid)
    {
        return await FetchInternalAsync<Set>(SetQuery($"uuid/{uuid}"));
    }

    /// <summary>
    ///     Fetches <see cref="Card" /> from a search query.
    /// </summary>
    /// <param name="query">The search query.</param>
    /// <returns>Returns an enumerable of <see cref="Card" /> matching the <see cref="query" />.</returns>
    /// <exception cref="Exception">Thrown if the <see cref="query" /> is empty.</exception>
    /// <remarks>
    ///     At least one filter query must be specified. More information about the query format can be found at
    ///     https://jpn-cards-site.readthedocs.io/en/latest/api_docs/pokemon/v2/v2_api/#card-queries.
    /// </remarks>
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

    /// <summary>
    ///     Fetches <see cref="Card" /> from a search query.
    /// </summary>
    /// <param name="filterBuilder">Configured query builder to generate the search query.</param>
    /// <returns>Returns an enumerable of <see cref="Card" /> matching the <see cref="query" />.</returns>
    /// <remarks> At least one filter must be specified.</remarks>
    public async Task<IEnumerable<Card>?> FetchCardsAsync(IQueryFilterBuilder filterBuilder)
    {
        return await FetchCardsAsync(filterBuilder.BuildQueryString());
    }
}