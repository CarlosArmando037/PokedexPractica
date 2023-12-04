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
            string _Texto;
        //ObservableCollection<Mpokemon> _Listapokemon;
        #endregion
        #region CONSTRUCTOR
        public VMborrarpokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        /*
        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set
            {
                SetValue(ref _Listapokemon, value);
                OnpropertyChanged();
            }
        }*/
        #endregion
        #region 
        /*
        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        
        */
        public async Task volver()
        {
            await Navigation.PushAsync(new Listapokemon());
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
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
