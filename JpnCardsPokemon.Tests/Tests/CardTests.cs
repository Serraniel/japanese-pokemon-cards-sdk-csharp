using JpnCardsPokemon.Tests.Classes;
using JpnCardsPokemonSdk.Utils.QueryFilter;

namespace JpnCardsPokemon.Tests.Tests.Tests;

public class CardTests : ApiTestClass
{
    [Test]
    public async Task TestFetchCards()
    {
        var cards = await Client.FetchCardsAsync(new CardQueryFilterBuilder { Name = "morpeko" });
        Assert.IsNotEmpty(cards);
    }
}