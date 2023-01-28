namespace JpnCardsPokemonSdk.Client.Endpoints;

internal class SetEndpoint : IApiEndpoint
{
    string IApiEndpoint.ApiUri()
    {
        return "card";
    }
}