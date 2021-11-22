using DesignPatternsAdapter.AdapterIntroduction;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsAdapterTest
{
    public class AdapterIntroductionTest
    {
        private readonly ITestOutputHelper _output;

        public AdapterIntroductionTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task DisplayCharactersFromFile()
        {
            var service = new StarWarsCharacterDisplayService();

            var result = await service.ListCharacters(CharacterSource.File);

            _output.WriteLine(result);
        }

        [Fact]
        public async Task DisplayCharactersFromApi()
        {
            var service = new StarWarsCharacterDisplayService();

            var result = await service.ListCharacters(CharacterSource.Api);

            _output.WriteLine(result);
        }
    }
}
