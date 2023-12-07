using MVVM_implementacion_CARS_NEW.Datos;
using MVVM_implementacion_CARS_NEW.Modelo;
using MVVM_implementacion_CARS_NEW.Vistas.Pokemon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_CARS_NEW.VistaModelo.VMpokemon
{
    internal class VMeditarpokemon : BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mpokemon> _verpokemon;

        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;
        Mpokemon _PokeSeleccionado;
        #endregion
        #region CONSTRUCTOR
        /*
        public VMeditarpokemon(INavigation navigation)
        {
            Navigation = navigation;
        }*/
        public VMeditarpokemon(Mpokemon pokeSeleccion, INavigation navigation)
        {
            Navigation = navigation;
            _Txtcolorfondo = pokeSeleccion.ColorFondo.ToString();
            _Txtcolorpoder = pokeSeleccion.ColorPoder.ToString();
            _Txticono = pokeSeleccion.Icono.ToString();
            _Txtnombre = pokeSeleccion.Nombre.ToString();
            _Txtnro = pokeSeleccion.NroOrden.ToString();
            _Txtpoder = pokeSeleccion.Poder.ToString();
            _PokeSeleccionado = pokeSeleccion;
        }

        #endregion
        #region OBJETOS
        /*
        public ObservableCollection<Mpokemon> Verpokemon
        {
            get { return _verpokemon; }
            set
            {
                SetValue(ref _verpokemon, value);
                OnpropertyChanged();
            }
        }*/
        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }
        public string Txtcolorpoder
        {
            get { return _Txtcolorpoder; }
            set { SetValue(ref _Txtcolorpoder, value); }
        }
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }
        public string Txtnro
        {
            get { return _Txtnro; }
            set { SetValue(ref _Txtnro, value); }
        }
        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { SetValue(ref _Txtpoder, value); }
        }
        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }

        public Mpokemon PokeSeleccionado
        {
            get { return _PokeSeleccionado; }
            set { SetValue(ref _PokeSeleccionado, value); }
        }


        #endregion
        #region PROCESOS
        public async Task ModificarPokemon()
        {
            var funcion = new Dpokemon();
            PokeSeleccionado.Nombre = Txtnombre;
            PokeSeleccionado.Poder = Txtpoder;
            PokeSeleccionado.NroOrden = Txtnro;
            PokeSeleccionado.Icono = Txticono;
            PokeSeleccionado.ColorFondo = Txtcolorfondo;
            PokeSeleccionado.ColorPoder = Txtcolorpoder;
            await funcion.ModificarPokemon(PokeSeleccionado);
            await Volver();
        }


        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand EditarPokemoncommand => new Command(async () => await ModificarPokemon());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
