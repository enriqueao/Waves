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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public void login(object sender, EventArgs args)
        {
            App.Current.MainPage = new Waves.Reproductor();
        }

        public void register(object sender, EventArgs args)
        {
            App.Current.MainPage = new Waves.Register();
        }
    }
}
