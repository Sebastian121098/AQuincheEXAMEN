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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;
        }

        private void txtNombreestudiante_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtedad_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtinicial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtApellido_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}