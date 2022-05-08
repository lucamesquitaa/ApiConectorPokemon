using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Models.Response
{
    public class PokemonApiResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sprites")]
        public Sprites BasicPictures { get; set; }

        [JsonProperty("abilities")]
        public IEnumerable<Ability> PokemonAbilities { get; set; }
    }
}
