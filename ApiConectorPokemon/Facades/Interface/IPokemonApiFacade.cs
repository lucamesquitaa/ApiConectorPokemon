using ApiConectorPokemon.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Facades
{
    public interface IPokemonApiFacade
    {
        public Task<PokemonApiResponse> GetPokemonApi(string pokemon);
    }
}
