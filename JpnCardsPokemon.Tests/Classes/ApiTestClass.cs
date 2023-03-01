using JpnCardsPokemon.Sdk.Client;

namespace JpnCardsPokemon.Tests.Classes;

public class ApiTestClass
{
    protected readonly ApiClient Client = new();

    [SetUp]
    public void Setup()
    {
    }
}