using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Models.Response
{
    public class Ability
    {
        [JsonProperty("ability")]
        public Abilityname AbilityPokemon { get; set; }
    }
}
