using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAdapter.ResultWrapper
{
    public class CharacterFileSourceAdapter : ICharacterSourceAdapter
    {
        private string _fileName;
        private readonly CharacterFileSource _characterFileSource;

        public CharacterFileSourceAdapter(string fileName, CharacterFileSource characterFileSource)
        {
            _fileName = fileName;
            _characterFileSource = characterFileSource;
        }

        public async Task<IEnumerable<Person>> GetCharacters() => (await _characterFileSource
                .GetCharactersFromFile(_fileName))
            .Select(character => new CharacterToPersonAdapter(character));
    }
}
