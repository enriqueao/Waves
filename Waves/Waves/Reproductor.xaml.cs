using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks


using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Waves
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reproductor : ContentPage
    {
        public Reproductor()
        {
            InitializeComponent();
            defineTempo();
        }

        public void defineTempo()
        {
            tempo.Maximum = 423;
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            Slider slider = (Slider)sender;
            label.Text = String.Format("Slider = {0}", slider.Value);
        }

        public void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            DisplayAlert("Alert", "Este boton te enviara a la playList", "OK");
        }

        public void prev(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            DisplayAlert("Alert", "Anterior", "OK");
        }

        public void play(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            DisplayAlert("Alert", "Este boton te enviara a la playList", "OK");
        }

        public void next(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            DisplayAlert("Alert", "Este boton te enviara a la playList", "OK");
        }
    }
}
