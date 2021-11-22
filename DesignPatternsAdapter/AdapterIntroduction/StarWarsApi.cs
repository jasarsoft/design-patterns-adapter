using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesignPatternsAdapter.AdapterIntroduction
{
    public class StarWarsApi
    {
        public async Task<List<Person>> GetCharacters()
        {
            using (var client = new HttpClient())
            {
                string url = "https://swapi.dev/api/people";
                string result = await client.GetStringAsync(url);
                var people = JsonConvert.DeserializeObject<ApiResult<Person>>(result).Results;

                return people;
            }
        }
    }

    public class StarWarsApiCharacterSourceAdapter : ICharacterSourceAdapter
    {
        private StarWarsApi _starWarsApi = new StarWarsApi();

        public async Task<IEnumerable<Person>> GetCharacters()
        {
            return await _starWarsApi.GetCharacters();
        }
    }
}
