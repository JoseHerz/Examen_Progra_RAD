using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_Progra_RAD.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageFormulario : ContentPage
    {
        public PageFormulario()
        {
            InitializeComponent();
        }

        private void Telefono_invalido(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                if (!int.TryParse(e.NewTextValue, out int result))
                {
                    Telefono.TextColor = Color.Red;
                    DisplayAlert("Error", "Este campo solo admite números.", "OK");
                }
                else
                {
                    Telefono.TextColor = Color.Default;
                }
            }
        }
        private void Limpiar(object sender, EventArgs e)
        {

            Nombre.Text = "";
            Telefono.Text = "";
            Edad.Text = "";
            Nota.Text = "";
            Seleccion.SelectedIndex = -1;
        }

    }
}