using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS3GallardoF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                //almacenando en varibales lo que usuario ingresa
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
                //Permite abrir la ventana(ViewDos)
                await Navigation.PushAsync(new ViewDos(usuario, clave));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }

        }
    }
}
