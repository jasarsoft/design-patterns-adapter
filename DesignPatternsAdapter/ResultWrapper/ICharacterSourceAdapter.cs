using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsAdapter.ResultWrapper
{
    public interface ICharacterSourceAdapter
    {
        Task<IEnumerable<Person>> GetCharacters();
    }
}
