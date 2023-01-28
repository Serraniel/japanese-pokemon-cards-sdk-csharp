namespace JpnCardsPokemonSdk.Client.Responses;

public interface IApiResponse<T>
{
    T? Data { get; set; }
}