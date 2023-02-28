namespace JpnCardsPokemonSdk.Client.Endpoints;

public interface IApiEndpoint
{
    string ApiUri();

    string IdQuery(int id);

    string UuidQuery(int uuid);
}