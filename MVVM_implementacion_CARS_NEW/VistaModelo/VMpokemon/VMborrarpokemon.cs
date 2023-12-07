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
    public class VMborrarpokemon: BaseViewModel 
    {

        #region VARIABLES
        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;
        Mpokemon _PokeSeleccionado;
        #endregion
        #region CONSTRUCTOR
        public VMborrarpokemon(Mpokemon pokeSeleccion, INavigation navigation)
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
        #region Procesos
        
        public async Task volver()
        {
            await Navigation.PushAsync(new Listapokemon());
        }
        public async Task EliminarPokemon()
        {
            var funcion = new Dpokemon();
            await funcion.BorrarPokemon(PokeSeleccionado.Idpokemon);
            //await DisplayAlert("Eliminado", $"El Pókemon {PokeSeleccionado.Nombre} ah sido eliminado", "OK");
            await volver();
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand volvercommand => new Command(async () => await volver());
        /*
        public ICommand Iraborrarcommand => new Command(async () => await Iraborrar());
        */
        public ICommand Eliminarcommand => new Command(async () => await EliminarPokemon());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
