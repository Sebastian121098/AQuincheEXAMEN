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
    public partial class Registro : ContentPage
         
        
      
    {
        string user;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            user = usuario;

        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime selectedDate = e.NewDate;
        }

        private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnPagomensual_Clicked(object sender, EventArgs e)
        {

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(user));
        }
    }
}