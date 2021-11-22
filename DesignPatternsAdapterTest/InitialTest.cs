using DesignPatternsAdapter.Initial;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsAdapterTest
{
    public class InitialTest
    {
        private readonly ITestOutputHelper _output;

        public InitialTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task DisplayCharacters()
        {
            var service = new StarWarsCharacterDisplayService();

            var result = await service.ListCharacters();

            _output.WriteLine(result);
        }
    }
}
