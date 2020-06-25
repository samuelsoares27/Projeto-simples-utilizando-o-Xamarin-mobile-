using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MeuPrimeiroApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<String> itens = new List<String>();
        public MainPage()
        {
            InitializeComponent(); //testeaa
        }

        protected void OnClicked(object sender, EventArgs e)
        {
            string Nome = "";
            string Email = "";

            if (this.NomeCliente.Text != null)
            {
                Nome = this.NomeCliente.Text;
            }
            if (this.EmailCliente.Text != null)
            {
                Email = this.EmailCliente.Text;
            }

            if ((Nome != "") && (Email != ""))
            { 
                             
                itens.Add(Nome);

                Lista.ItemsSource = "";
                Lista.ItemsSource = itens;
            }
            else
            {
                DisplayAlert("Alerta", "Campos vazios", "Ok");
            }

        }
    }

}
