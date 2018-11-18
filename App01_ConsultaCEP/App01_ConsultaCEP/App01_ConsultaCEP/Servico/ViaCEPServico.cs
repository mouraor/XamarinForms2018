using System;
using System.Collections.Generic;
using System.Text;
using System.Net;                            //biblioteca .Net para pesquisas na internet
using App01_ConsultaCEP.Servico.Modelo;      //Nossa classe App, que será utilizada para formatação dos dados buscados na web
using Newtonsoft.Json;                       //biblioteca NuGet instalada como dependencia do projeto para conversão de dados json

namespace App01_ConsultaCEP.Servico
{
    public class ViaCEPServico
    {
        //site de consula da informação de CEP. o campo {0} é um parâmetro de entrada na url definida abaixo
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        //Objeto do tipo "Endereco", existente na classe App01
        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            //nova URL com parâmetro cep passado pelo usuário
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            //objeto para consultas na web.
            WebClient WC = new WebClient();

            //Metodo síncrono, não permite que haja operações na tela quanto a consulto não acabar.
            string conteudo = WC.DownloadString(NovoEnderecoURL);

            //O retorno da consulta armazenado na variavel conteudo, será convertido no tipo Endereco, definido no arquivo
            //Endereco.css e armazenado na variável end
            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            //Se retorno do formato json com erro, então retorna nulo
            if (end.cep == null) return null;

            return end;
        }
    }
}
