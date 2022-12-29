using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S2_Cristian_Morocho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btniniciar_Clicked_1(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string password = "uisrael2022";

            if (usuario == txtusuario.Text && password == txtpassword.Text)
            {
                Navigation.PushAsync(new notas(usuario));
            }
            else
            {
                DisplayAlert("ALERTA", "USUARIO O CONTRASEÑA INCORRECTOS", "CERRAR");
            }
        }
    }
}