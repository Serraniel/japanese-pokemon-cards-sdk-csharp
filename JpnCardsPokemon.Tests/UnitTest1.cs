using JpnCardsPokemonSdk.Api;
using JpnCardsPokemonSdk.Client;

namespace JpnCardsPokemon.Tests
{
    public class Tests
    {
        private ApiClient Client = new ApiClient();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestFetchSets()
        {
            var sets = await Client.FetchDataAsync<Set>();
            Assert.IsNotEmpty(sets?.Data);
            // Assert.Pass();
        }
    }
}