using ApiConectorPokemon.Models.Response;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Services
{
    public interface IPokemonApiServices
    {
       
        public Task<PokemonApiResponse> GetPokeApi([Path] string pokemonName);
    }
}
