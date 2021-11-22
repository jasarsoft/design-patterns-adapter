using DesignPatternsAdapter;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsAdapterTest
{
    public class TestRunner1
    {
        private readonly ITestOutputHelper _output;

        public TestRunner1(ITestOutputHelper output)
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
