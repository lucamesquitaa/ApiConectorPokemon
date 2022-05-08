using ApiConectorPokemon.Models.Response;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Services
{
    public class PokemonApiServices : IPokemonApiServices
    {
        static HttpClient client = new HttpClient();
        public async Task<PokemonApiResponse> GetPokeApi([Path] string pokemonName)
        {
            PokemonApiResponse pokemon = null;
            HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + pokemonName);
            if (response.IsSuccessStatusCode)
            {
                pokemon = await response.Content.ReadAsAsync<PokemonApiResponse>();
            }
            return pokemon;
        }
    }
}
