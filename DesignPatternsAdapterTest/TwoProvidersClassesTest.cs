using DesignPatternsAdapter.TwoProvidersClasses;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsAdapterTest
{
    public class TwoProvidersClassesTest
    {
        private readonly ITestOutputHelper _output;

        public TwoProvidersClassesTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task DisplayCharactersFromFile()
        {
            var service = new StarWarsCharacterDisplayService();

            var result = await service.ListCharacters(StarWarsCharacterDisplayService.CharacterSource.File);

            _output.WriteLine(result);
        }

        [Fact]
        public async Task DisplayCharactersFromApi()
        {
            var service = new StarWarsCharacterDisplayService();

            var result = await service.ListCharacters(StarWarsCharacterDisplayService.CharacterSource.Api);

            _output.WriteLine(result);
        }
    }
}
