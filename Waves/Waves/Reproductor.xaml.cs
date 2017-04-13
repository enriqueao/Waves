using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Waves
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reproductor : ContentPage
    {
        public Reproductor()
        {
            InitializeComponent();
        }

        public void btnReproducir_Clicked(Object sender, EventArgs e)
        {
            DisplayAlert("Reproduciendo","Enrique Lo Hizo","Aceptar");
        }
    }
}
