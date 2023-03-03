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

    [Test]
    public async Task TestGetPrices()
    {
        // Radiant charizard from Go may have prices in different conditions
        var card = (await Client.FetchCardsAsync(new CardQueryFilterBuilder { Uuid = 48495360 })).FirstOrDefault();
        Assert.IsNotNull(card);
        Assert.IsNotEmpty(card.Prices);

        // Zubat, common from Dark Phantasma may have prices for different versions (regular + reverse holo)
        card = (await Client.FetchCardsAsync(new CardQueryFilterBuilder { Uuid = 95800678 })).FirstOrDefault();
        Assert.IsNotNull(card);
        Assert.IsNotEmpty(card.Prices);
    }
}