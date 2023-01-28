using JpnCardsPokemonSdk.Client.Endpoints;

namespace JpnCardsPokemonSdk.Client.Responses;

public class SingleApiResponse<T> : IApiResponse<T> where T : EndpointObject
{
    T? IApiResponse<T>.Data { get; set; }
}