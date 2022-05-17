using Newtonsoft.Json;
using Pokemon_Matheus.NovaPasta;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Matheus
{
    public class ApiRequest
    {
        public string url { get; set; }
        private int atual = 0;
        public ApiRequest()
        {
            url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=";
        }

        public PokeLista ObterLista()
        {
            var consulta = (HttpWebRequest)WebRequest.Create(url + atual);
            consulta.Method = "GET";
            consulta.ContentType = "application/json";
            consulta.Accept = "application/json";

            try
            {
                using (WebResponse response = consulta.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())

                    {
                        if (stream == null)
                        {
                            return null;
                        }
                        using (StreamReader leitor = new StreamReader(stream))
                        {
                            string responsetexto = leitor.ReadToEnd();

                            PokeLista pokelista = JsonConvert.DeserializeObject<PokeLista>(responsetexto);
                            atual += 10;
                            return pokelista;
                        }
                    }
                }
            } 
            catch (Exception)
            {
                throw;
            }
        }
    }
}
