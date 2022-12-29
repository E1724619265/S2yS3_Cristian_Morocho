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
    public partial class notas : ContentPage
    {
        public notas(string usuario)
        {
            InitializeComponent();

            lblusuario.Text = usuario;
        }
        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            double notauno = Convert.ToDouble(txtnotaUno.Text);
            double notaDos = Convert.ToDouble(txtnotaDos.Text);

            double nota1 = Convert.ToDouble(txtnota1.Text);
            double nota2 = Convert.ToDouble(txtnota2.Text);

            double np1 = notauno * 0.3;
            double np2 = notaDos * 0.2;

            Double respuestap1 = np1 + np2;
            txtpromedio1.Text = respuestap1.ToString();

            double npUno = nota1 * 0.3;
            double npDos = nota2 * 0.2;

            Double resp = npUno + npDos;
            txtpromedio2.Text = resp.ToString();

            Double final = respuestap1 + resp;
            txtnotaFinal.Text = final.ToString();

            if (final <= 4.9)
            {
                DisplayAlert("Su nota final es " + final + " Perdio el semestre", " revise con el tutor", "cerrar");
            }
            else if (final == 5 || final == 6.9)
            {
                DisplayAlert("Su nota final es " + final + " Complementario", " averigue la fecha del exmane", "cerrar");
            }
            else if (final >= 7)
            {
                DisplayAlert("Su nota final es " + final + " Aprobado", "felicidades", "cerrar");
            }
        }

        private void TxtnotaUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            double notauno = Convert.ToDouble(txtnotaUno.Text);

            try
            {

                if (notauno < 0 || notauno > 10)
                {
                    DisplayAlert("El numero ingresado", " no es valido", "cerrar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }

        }

        private void TxtnotaDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            double notaDos = Convert.ToDouble(txtnotaDos.Text);

            try
            {

                if (notaDos < 0 || notaDos > 10)
                {
                    DisplayAlert("El numero ingresado", " no es valido", "cerrar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }

        private void Txtnota1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1 = Convert.ToDouble(txtnota1.Text);

            try
            {

                if (nota1 < 0 || nota1 > 10)
                {
                    DisplayAlert("El numero ingresado", " no es valido", "cerrar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }

        private void Txtnota2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota2 = Convert.ToDouble(txtnota2.Text);

            try
            {

                if (nota2 < 0 || nota2 > 10)
                {
                    DisplayAlert("El numero ingresado", " no es valido", "cerrar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }
    }
}