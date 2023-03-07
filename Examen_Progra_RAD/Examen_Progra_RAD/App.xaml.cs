using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_Progra_RAD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vistas.PageFormulario();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
