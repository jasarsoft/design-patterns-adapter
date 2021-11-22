using DesignPatternsAdapter.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsAdapterTest
{
    public class ResultWrapperTest
    {
        private readonly ITestOutputHelper _output;

        public ResultWrapperTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task DisplayCharactersFromFile()
        {
            string filename = @"People.json";
            var service = new StarWarsCharacterDisplayService(
                new CharacterFileSourceAdapter(filename, new CharacterFileSource()));

            var result = await service.ListCharacters();

            _output.WriteLine(result);
        }

        [Fact]
        public async Task DisplayCharactersFromApi()
        {
            var service = new StarWarsCharacterDisplayService(
                new StarWarsApiCharacterSourceAdapter(new StarWarsApi()));

            var result = await service.ListCharacters();

            _output.WriteLine(result);
        }
    }
}
