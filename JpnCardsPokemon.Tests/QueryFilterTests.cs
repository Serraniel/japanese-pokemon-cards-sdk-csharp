using JpnCardsPokemon.Sdk.Utils.QueryFilter;

namespace JpnCardsPokemon.Tests;

public class QueryFilterTests
{
    [Test]
    public void TestCardQueryFilterBuilder()
    {
        Assert.That("name=charizard&set_code=s12a",
            Is.EqualTo(new CardQueryFilterBuilder { Name = "charizard", SetCode = "s12a" }.BuildQueryString()));
    }
}