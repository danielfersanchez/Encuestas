using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Encuestas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class detalleencuesta : ContentPage
	{
        private readonly string[] equipos = { "Colombia", "Peru", "Brasil", "Rusia", "Alemania", "Argentina" };
		public detalleencuesta ()
		{
			InitializeComponent ();
            BtAgregarEq.Clicked += BtAgregarEq_Clicked;
            BtnAceptar.Clicked += BtnAceptar_Clicked;
		}

        private async BtnAceptar_Clicked(object sender, EventArgs e)
        {
         if (string.IsNullOrEmpty(EntNombre.Text) || string.IsNullOrEmpty(LbEquipoFav.Text)){
                await DisplayAlert("datos incompletos","por favor ingrese los campos","aceptar");
                return;
            }
            var enc = new encuesta()
            {
                Nombre = EntNombre.Text,
                EquipoFavorito = LbEquipoFav.Text,
                FechaNacimiento = DtNac.Date
            };
            MessagingCenter.Send((ContentPage) this,)
        }

        private async void BtAgregarEq_Clicked(object sender, EventArgs e)
        {
            var Equipofavorito = await DisplayActionSheet(literal.TituloEqFav, null, null, equipos);
            if(!string.IsNullOrEmpty(Equipofavorito)){
                LbEquipoFav.Text = Equipofavorito;
            }
        }
    }
}