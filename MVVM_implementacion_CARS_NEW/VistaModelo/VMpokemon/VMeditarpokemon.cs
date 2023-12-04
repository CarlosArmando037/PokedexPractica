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

        #endregion
        #region CONSTRUCTOR
        public VMeditarpokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        public VMeditarpokemon(Mpokemon _pokemonmodel)
        {
            _Txtcolorfondo = _pokemonmodel.ColorFondo;
            _Txtcolorpoder= _pokemonmodel.ColorPoder;
            _Txtnombre = _pokemonmodel.Nombre;
            _Txtnro = _pokemonmodel.NroOrden;
            _Txtpoder = _pokemonmodel.Poder;
            _Txticono = _pokemonmodel.Icono;
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
        #endregion
        #region PROCESOS
      
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region
        public ICommand Volvercommand => new Command(async () => await Volver());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
