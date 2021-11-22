using DesignPatternsAdapter.Initial;
using System;
using System.Threading.Tasks;

namespace DesignPatternsAdapter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Run 1
            var service1 = new StarWarsCharacterDisplayService();
            var people1 = await service1.ListCharacters();
            
            Console.WriteLine(people1);

            Console.ReadKey();
        }
    }
}
