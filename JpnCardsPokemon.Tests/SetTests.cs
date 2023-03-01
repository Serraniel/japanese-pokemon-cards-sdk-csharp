using JpnCardsPokemon.Tests.Classes;

namespace JpnCardsPokemon.Tests;

public class SetTests : ApiTestClass
{
    [Test]
    public async Task TestFetchSets()
    {
        var sets = await Client.FetchSetsAsync();
        Assert.IsNotEmpty(sets);
    }

    [Test]
    public async Task TestFetchSetById()
    {
        // 1 should be Incandescent Arcana (s11a). Hopefully this won't change (:
        var set = await Client.FetchSetById(1);
        Assert.IsNotNull(set);
        Assert.That(set?.SetCode, Is.EqualTo("s11a"));
    }

    [Test]
    public async Task TestFetchSetByUuid()
    {
        // 72218005 should be Incandescent Arcana (s11a). Hopefully this won't change (:
        var set = await Client.FetchSetByUuid(72218005);
        Assert.IsNotNull(set);
        Assert.That(set?.SetCode, Is.EqualTo("s11a"));
    }
}