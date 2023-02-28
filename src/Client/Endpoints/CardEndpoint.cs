namespace JpnCardsPokemonSdk.Client.Endpoints;

internal class CardEndpoint : IApiEndpoint
{
    string IApiEndpoint.ApiUri()
    {
        return "card";
    }

    string IApiEndpoint.IdQuery(int id)
    {
        return $"{((IApiEndpoint)this).ApiUri()}/id={id}";
    }

    string IApiEndpoint.UuidQuery(int uuid)
    {
        return $"{((IApiEndpoint)this).ApiUri()}/uuid={uuid}";
    }
}