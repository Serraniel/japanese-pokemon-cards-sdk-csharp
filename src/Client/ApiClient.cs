using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using JpnCardsPokemonSdk.Api;
using JpnCardsPokemonSdk.Client.Responses;
using JpnCardsPokemonSdk.Utils.QueryFilter;

namespace JpnCardsPokemonSdk.Client;

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

    public async Task<TResponseType?> FetchDataAsync<TResponseType, TResponseGeneric>(string requestUri)
        where TResponseType : IApiResponse<TResponseGeneric>, new()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            IncludeFields = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var response = await _client.GetFromJsonAsync<TResponseGeneric>(requestUri, options);

        // TODO: Find good way to handle pageable requests
        /*if (response is IPageableApiResponse<TResponseType, TResponseGeneric> pageAbleApiResponse)
        {
            pageAbleApiResponse.CurrentApiClient = this;
            pageAbleApiResponse.RememberRequestUri(requestUri);
        }*/

        var result = new TResponseType
        {
            Data = response
        };

        return result;
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

    /*
    public async Task<EnumerableApiResponse<T>?> FetchDataAsync<T>(string? query = null, int page = 1)
        where T : EndpointObject
    {
        var endpoint = EndpointFactory.GetApiEndpoint<T>();

        return await FetchDataAsync<EnumerableApiResponse<T>, IEnumerable<T>>($"{endpoint.ApiUri()}?page={page}");
    }

    public async Task<SingleApiResponse<T>?> FetchByIdAsync<T>(int id) where T : EndpointObject
    {
        var endpoint = EndpointFactory.GetApiEndpoint<T>();

        return await FetchDataAsync<SingleApiResponse<T>, T>($"{endpoint.ApiUri()}/id={id}");
    }

    public async Task<SingleApiResponse<T>?> FetchByUuidAsync<T>(int uuid) where T : EndpointObject
    {
        var endpoint = EndpointFactory.GetApiEndpoint<T>();

        return await FetchDataAsync<SingleApiResponse<T>, T>($"{endpoint.ApiUri()}/uuid={uuid}");
    }*/
}