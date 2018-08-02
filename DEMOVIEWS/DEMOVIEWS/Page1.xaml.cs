using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DEMOVIEWS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}
         void pickSelect(object sender,System.EventArgs e)
        {
            var elementoseleccionado = pickMusic.SelectedItem.ToString();
            DisplayAlert("Genero Música", elementoseleccionado, "Aceptar");
        }
        void btnSimular_Clicked(object sender, System.EventArgs e)
        {
            var progreso = progressNum.Progress;
            if (progreso == 1)
            {
                progressNum.ProgressTo(0, 250, Easing.SpringOut);
            }
            else
            {
                progressNum.ProgressTo(30, 300, Easing.Linear);
            }
        }
        
            void Handle_SearchButtonPressed(object sender, System.EventArgs e)
            {
                DisplayAlert("Buscando", "Buscando Resultado", "Aceptar");
            }
            void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
            {
                DisplayAlert("Cambiando", "Este texto esta cambiando", "Aceptar");
            }
        void Handle_ValueChanged(object sender, Xamarin.Forms.ItemVisibilityEventArgs e)
        {
            labCambio.Text = slider.Value.ToString();
        }
        void stepEvent(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            lbDisplay.Text = steeper.Value.ToString();

        }
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var estado = this.swtEstado.IsToggled;
            if(this.swtEstado.IsToggled)
            {
                DisplayAlert(
                    "Switch",
                    "Estoy encendido",
                    "Aceptar");
            }
            else
            {
                DisplayAlert(
                    "Switch",
                    "Estoy apagado",
                    "Aceptar");

            }
        }


        }

    }

