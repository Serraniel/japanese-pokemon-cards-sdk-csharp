namespace JpnCardsPokemonSdk.Client.Endpoints;

internal class CardEndpoint : IApiEndpoint
{
    string IApiEndpoint.ApiUri()
    {
        return "card";
    }
}