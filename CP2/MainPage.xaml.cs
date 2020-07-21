using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CP2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {

            double monto = double.Parse(txtMONTO.Text);
            double taza = double.Parse(txtTASA.Text);

            var meses = pkTIEMPO.SelectedItem;
            int mesesPlazo = 0;

            if (meses == "1 Mes")
            {
                mesesPlazo = 1;
            }
            else if (meses == "2 Meses")
            {
                mesesPlazo = 2;
            }
            else if (meses == "3 Meses")
            {
                mesesPlazo = 3;
            }
            else if (meses == "4 Meses")
            {
                mesesPlazo = 4;
            }
            else if (meses == "5 Meses")
            {
                mesesPlazo = 5;
            }

            double t = taza / 1200;
            double b = Math.Pow((1 + t), mesesPlazo);
            
            double resultado = t * monto * b / (b - 1);
            
            await DisplayAlert("Resultado","Cuota del Prestamo: " + resultado,"OK");
        }

    }
}
