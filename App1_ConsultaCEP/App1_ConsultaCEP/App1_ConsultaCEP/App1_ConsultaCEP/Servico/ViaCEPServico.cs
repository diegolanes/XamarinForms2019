using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1_ConsultaCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App1_ConsultaCEP.Servico
{
    class ViaCEPServico
    {
        private static string enderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(enderecoURL, cep);

            WebClient wc = new WebClient();

            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            return end;
        }
    }
}
