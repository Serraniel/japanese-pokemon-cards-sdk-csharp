using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using JpnCardsPokemonSdk.Client.Endpoints;

namespace JpnCardsPokemonSdk.Client.Responses;

public class EnumerableApiResponse<T> : IApiResponse<IEnumerable<T>>, IEnumerable<T> where T : EndpointObject
{
    [JsonPropertyName("")] public IEnumerable<T>? Data { get; set; }

    public IEnumerator<T> GetEnumerator()
    {
        return Data?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}