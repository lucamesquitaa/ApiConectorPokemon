using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Models.Response
{
    public class Abilityname
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
