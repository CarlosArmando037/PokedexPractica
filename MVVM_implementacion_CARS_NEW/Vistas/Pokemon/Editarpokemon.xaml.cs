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
    public partial class Editarpokemon : ContentPage
    {
        public Editarpokemon()
        {
            InitializeComponent ();
            BindingContext = new VMeditarpokemon(Navigation);
        }

        //video
        public Editarpokemon(Mpokemon _pokemonModel)
        {
            InitializeComponent();
            BindingContext = new Editarpokemon(_pokemonModel);
        }
    }
}