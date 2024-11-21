using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ContasAPagar.Util
{
    class BuscaCep
    {
        public CepInfo ConsultaCep(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
           
                using (WebClient client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;

                    string json = client.DownloadString(url);

                    var cepInfo = JsonConvert.DeserializeObject<CepInfo>(json);
                    
                    return cepInfo;
                }
        }
        
    }
    public class CepInfo
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string uf { get; set; }
    }

}

