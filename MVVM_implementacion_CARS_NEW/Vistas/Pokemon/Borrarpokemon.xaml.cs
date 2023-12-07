using MVVM_implementacion_CARS_NEW.Modelo;
using MVVM_implementacion_CARS_NEW.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_CARS_NEW.Vistas.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Borrarpokemon : ContentPage
	{
		public Borrarpokemon (Mpokemon pokemon)
		{
			InitializeComponent();
            BindingContext = new VMborrarpokemon(pokemon,Navigation);
        }
	}
}