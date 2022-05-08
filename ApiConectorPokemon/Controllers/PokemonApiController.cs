using ApiConectorPokemon.Facades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Controllers
{
    public class PokemonApiController : ControllerBase
    {
        private readonly IPokemonApiFacade _pokemonsFacade;

        public PokemonApiController(IPokemonApiFacade pokemonsFacade)
        {
            _pokemonsFacade = pokemonsFacade;
        }

        [HttpGet("{pokemonName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetConsultaPokemon([FromRoute] string pokemonName)
        {
            var pokemonInfo = await _pokemonsFacade.GetPokemonApi(pokemonName);

            return Ok(pokemonInfo);
        }

    }
}
