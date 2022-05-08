using ApiConectorPokemon.Models.Response;
using ApiConectorPokemon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Facades
{
    public class PokemonApiFacade : IPokemonApiFacade
    {
       
        public async Task<PokemonApiResponse> GetPokemonApi(string pokemon)
        {
            int pokemonnumberLimit = 898;
            Random rnd = new Random();
            if (pokemon == "aleatorio")
            {
                pokemon = rnd.Next(pokemonnumberLimit).ToString();

            }

            var _pokemonApiService = new PokemonApiServices();
            var PokemonInfo = await _pokemonApiService.GetPokeApi(pokemon);

            

            return PokemonInfo;

        }
    }
}
