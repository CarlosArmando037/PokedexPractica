using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_implementacion_CARS_NEW.VistaModelo.VMpokemon;
using MVVM_implementacion_CARS_NEW.Vistas.Pokemon;
using MVVM_implementacion_CARS_NEW.Modelo;

namespace MVVM_implementacion_CARS_NEW.Vistas.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Listapokemon : ContentPage
	{
		public Listapokemon ()
		{
			InitializeComponent ();
			BindingContext = new VMlistapokemon(Navigation);
		}

		public async void ListViewName_ItemSelected(object sender,SelectedItemChangedEventArgs e)
		{
			await Navigation.PushAsync(new Editarpokemon(e.SelectedItem as Mpokemon));
		}



    }
}