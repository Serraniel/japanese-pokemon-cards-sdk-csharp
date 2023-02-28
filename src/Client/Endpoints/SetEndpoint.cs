namespace JpnCardsPokemonSdk.Client.Endpoints;

internal class SetEndpoint : IApiEndpoint
{
    string IApiEndpoint.ApiUri()
    {
        return "set";
    }

    string IApiEndpoint.IdQuery(int id)
    {
        return $"{((IApiEndpoint)this).ApiUri()}/{id}";
    }

    string IApiEndpoint.UuidQuery(int uuid)
    {
        return $"{((IApiEndpoint)this).ApiUri()}/uuid/{uuid}";
    }