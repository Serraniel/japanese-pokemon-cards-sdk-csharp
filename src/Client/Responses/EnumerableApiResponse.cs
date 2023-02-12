using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JpnCardsPokemonSdk.Client.Endpoints;

namespace JpnCardsPokemonSdk.Client.Responses;

public class EnumerableApiResponse<T> : IApiResponse<IEnumerable<T>>,
    IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>> where T : EndpointObject
{
    private string? RequestUri { get; set; }

    public int TotalPages => (int)Math.Ceiling((decimal)(
        (IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>)this).TotalCount / (
        (IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>)this).PageSize);

    public IEnumerable<T>? Data { get; set; }

    ApiClient? IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.CurrentApiClient { get; set; }

    int IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.Page { get; set; }

    int IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.PageSize { get; set; }

    int IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.Count { get; set; }

    int IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.TotalCount { get; set; }

    async Task<EnumerableApiResponse<T>> IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.
        FetchNextPageAsync()
    {
        return await ((IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>)this).FetchPageAsync((
            (IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>)this).Page + 1);
    }

    async Task<EnumerableApiResponse<T>?> IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.
        FetchPageAsync(int page)
    {
        var requestUri = RequestUri + "&page=" + page;

        return await ((IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>)this).CurrentApiClient
            ?.FetchDataAsync<EnumerableApiResponse<T>, IEnumerable<T>>(requestUri)!;
    }

    void IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>.RememberRequestUri(string requestUri)
    {
        // Remember full Uri without page
        RequestUri = Regex.Replace(requestUri, @"page=\d*&?", "");
    }
}