using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;

namespace App01_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnEnter.Clicked += BuscarCEP;
		}

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = txbCEP.Text.Trim();

            try
            {
                if (isValidCEP(cep))
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        lblResultado.Text = "Resultados Encontrados:\n\n" +
                            "Endereço: " + end.logradouro + "\n" +
                            "Bairro: " + end.bairro + "\n" +
                            "Cidade: " + end.localidade + "\n" +
                            "U.F.: " + end.uf;
                    } else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado: " + cep, "OK");
                    }
                }
            } catch (Exception ex)
            {
                DisplayAlert("ERRO CRÍTICO", ex.Message, "OK");
            }
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP Inválido!\n\nO CEP deve conter 8 caracteres...", "OK");

                valido = false;
            }

            int novoCEP = 0;

            if(!int.TryParse(cep, out novoCEP))
            {
                DisplayAlert("ERRO", "CEP Inválido!\n\nDigitar somente números...", "OK");

                valido = false;
            }

            return valido;
        }
	}
}
