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

    bool HasNextPage()
    {
        return Page < TotalCount;
    }

    void RememberRequestUri(string requestUri);

    Task<TResponseType> FetchNextPageAsync();

    Task<TResponseType> FetchPageAsync(int page);
}