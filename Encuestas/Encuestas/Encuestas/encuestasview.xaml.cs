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
	public partial class encuestasview : ContentPage
	{
		public encuestasview ()
		{
			InitializeComponent ();
            Botonmas.Clicked += Botonmas_Clicked;
            MessagingCenter.Subscribe<ContentPage, encuesta>(this, mensaje.encuestacompleta, (Sender, args)
                =>
            { panel.Children.Add(new Label()
            {
                Text = args.ToString()


            });
            }

        private async void Botonmas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new detalleencuesta());
        }
    }
}