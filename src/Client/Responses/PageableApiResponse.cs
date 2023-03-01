using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JpnCardsPokemonSdk.Client.Endpoints;

namespace JpnCardsPokemonSdk.Client.Responses;

public class PageableApiResponse<T> : EnumerableApiResponse<T>,
    IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>
    where T : EndpointObject
{
    private string? RequestUri { get; set; }

    public int TotalPages => (int)Math.Ceiling((decimal)(
        (IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>)this).TotalCount / (
        (IPageableApiResponse<EnumerableApiResponse<T>, IEnumerable<T>>)this).PageSize);

    ApiClient? IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.CurrentApiClient { get; set; }

    int IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.Page { get; set; }

    int IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.PageSize { get; set; }

    int IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.Count { get; set; }

    int IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.TotalCount { get; set; }


#if !(NETCOREAPP3_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
    bool IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.HasNextPage()
    {
        return ((IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>)this).Page <
               ((IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>)this).TotalCount;
    }
#endif

    async Task<PageableApiResponse<T>> IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.
        FetchNextPageAsync()
    {
        return await ((IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>)this).FetchPageAsync((
            (IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>)this).Page + 1);
    }

    async Task<PageableApiResponse<T>?> IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.
        FetchPageAsync(int page)
    {
        var requestUri = RequestUri + "&page=" + page;

        return await ((IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>)this).CurrentApiClient
            ?.FetchDataAsync<PageableApiResponse<T>, IEnumerable<T>>(requestUri)!;
    }

    void IPageableApiResponse<PageableApiResponse<T>, IEnumerable<T>>.RememberRequestUri(string requestUri)
    {
        // Remember full Uri without page
        RequestUri = Regex.Replace(requestUri, @"page=\d*&?", "");
    }
}