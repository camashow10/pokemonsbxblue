using Newtonsoft.Json;
using Pokemon_Matheus.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Matheus.NovaPasta
{
    public class PokeLista
    {
        [JsonProperty("count")]
        public long quantidade { get; set; }
        [JsonProperty("next")]
        public string proximo { get; set; }
        [JsonProperty("previous")]
        public object anterior { get; set; }
        [JsonProperty("results")]

        public List<Pokemon> Listapokemons { get; set; }
    }
}
