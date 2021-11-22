﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsAdapter.AdapterIntroduction
{
    public interface ICharacterSourceAdapter
    {
        Task<IEnumerable<Person>> GetCharacters();
    }
}
