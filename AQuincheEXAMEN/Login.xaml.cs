using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AQuincheEXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "Estudiante2023";
            string password = "uisrael2023";

            if (txtUsuario.Text == usuario && txtPassword.Text == password)
            {
                Navigation.PushAsync(new Registro(usuario));
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                DisplayAlert("ERROR", "Usuario o Contraseña incorrectos", "Cancelar");
            }
        }
    }
}