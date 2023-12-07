using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_CARS_NEW.Modelo;
using MVVM_implementacion_CARS_NEW.Vistas.Pokemon;
using MVVM_implementacion_CARS_NEW.Datos;
using System.Collections.ObjectModel;

namespace MVVM_implementacion_CARS_NEW.VistaModelo.VMpokemon
{
    public class VMlistapokemon: BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mpokemon> _Listapokemon;
        //ObservableCollection<Mpokemon> _Obtenerpokemon;
        Mpokemon _PokemonSeleccionado;

        #endregion
        #region CONSTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPokemons();
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value);
                OnpropertyChanged();
            }
        }
        /*
        public ObservableCollection<Mpokemon> Obtenerpokemon
        {
            get { return _Obtenerpokemon; }
            set
            {
                SetValue(ref _Obtenerpokemon, value);
                OnpropertyChanged();
            }
        }*/
        public Mpokemon PokemonSeleccionado
        {
            get { return _PokemonSeleccionado; }
            set
            {
                if (_PokemonSeleccionado != value)
                {
                    _PokemonSeleccionado = value;
                }
            }
        }

        #endregion
        #region PROCESOS
        public async Task MostrarPokemons()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Resgistrarpokemon());
        }
        /*
        public async Task Iramodificar()
        {
            await Navigation.PushAsync(new Editarpokemon());
            //esto puedde ser para obtener los datos del pokemon
            var funcion = new Dpokemon();
            //necesitro una funcio que este en Dpokemon para obtener los dfatos
            Obtenerpokemon = await funcion.MostrarPokemones();
        }*/
        public async Task Iramodificar()
        {
            await Navigation.PushAsync(new Editarpokemon(PokemonSeleccionado));
        }

        public async Task Iraborrar()
        {
            await Navigation.PushAsync(new Borrarpokemon(PokemonSeleccionado));
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand Iraborrarcommand => new Command(async () => await Iraborrar());
        public ICommand Modificarcommand => new Command(async () => await Iramodificar());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
