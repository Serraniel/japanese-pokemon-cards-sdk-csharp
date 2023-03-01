using JpnCardsPokemon.Sdk.Utils.QueryFilter;
using JpnCardsPokemon.Tests.Classes;

namespace JpnCardsPokemon.Tests;

public class CardTests : ApiTestClass
{
    [Test]
    public async Task TestFetchCards()
    {
        var cards = await Client.FetchCardsAsync(new CardQueryFilterBuilder { Name = "morpeko" });
        Assert.IsNotEmpty(cards);
    }
}