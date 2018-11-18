using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultaCEP.Servico.Modelo;
using App01_ConsultaCEP.Servico;

namespace App01_ConsultaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        //Rotina que identifica a ocorrência de evento de apertar o botão
        //Para isso os argumentos informados são OBRIGATÓRIOS para a linguagem C#
        private void BuscarCEP(object sender, EventArgs args)
        {
            //Atribuição do valor de texto da variável CEP (tela) para variável cep local
            //Trim() remove espaço em branco do teto passado
            string cep = CEP.Text.Trim();

            if (IsValidCEP(cep))
            {
                //try -> tenta executar, caso contrário, captura o texto de exception
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCep(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {1} de {2}, {3} / {0}", end.cep, end.logradouro, end.localidade, end.uf);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para este CEP informado" + cep, "OK");
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("EERRO CRÍTICO", e.Message, "OK");
                }
            }
        }

        private bool IsValidCEP(string cep)
        {
            bool valido = true;
            int NovoCEP = 0;                 //Para conversão do formato de cep 99999-999 p/ 99999999

            if (cep.Length != 8)
            {
                //Este metodo apresenta uma mensagem na tela do usuário no formato:
                //Título: "Erro"
                //Mensagem: CEP inválido! O CEP deve conter 8 caracteres
                //Botão: "OK"
                DisplayAlert("Erro", "CEP inválido! O CEP deve conter 8 caracteres", "OK");
                valido = false;
            }
            
            //Este metodo TryParse tentará converter o valor de cep no formato desejado, externando o valor em NovoCEP.
            //O retorno caso a conversão seja bem sucedida será TRUE.
            if (!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("Erro", "CEP inválido! O CEP deve ser composto apenas por números", "OK");
                valido = false;
            }

            return valido;

        }
    }
}
