using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConectorPokemon.Models.Response
{
    public class Sprites
    {
        [JsonProperty("front_default")]
        public string Picture { get; set; }
        [JsonProperty("back_default")]
        public string BackPicture { get; set; }
    }
}
