using System.Threading.Tasks;

namespace JpnCardsPokemonSdk.Client.Responses;

public interface IPageableApiResponse<TResponseType, TResponseGeneric>
    where TResponseType : IApiResponse<TResponseGeneric>
{
    ApiClient? CurrentApiClient { get; set; }

    int Page { get; set; }

    int PageSize { get; set; }

    int Count { get; set; }

    int TotalCount { get; set; }

#if NETCOREAPP3_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
    bool HasNextPage()
    {
        return Page < TotalCount;
    }
#else
    bool HasNextPage();
#endif

    void RememberRequestUri(string requestUri);

    Task<TResponseType> FetchNextPageAsync();

    Task<TResponseType> FetchPageAsync(int page);
}