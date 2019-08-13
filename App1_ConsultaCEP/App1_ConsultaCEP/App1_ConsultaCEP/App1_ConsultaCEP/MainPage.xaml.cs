using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1_ConsultaCEP.Servico.Modelo;
using App1_ConsultaCEP.Servico;




namespace App1_ConsultaCEP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
            
        }


        private void BuscarCEP(object sender, EventArgs args)
        {
            // TODO - Logica do programa

            string cep = CEP.Text.Trim();

            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = "Endereço: " + end.logradouro + ", " + end.bairro + " " + end.localidade + " - " + end.uf;

        }
    }
}
