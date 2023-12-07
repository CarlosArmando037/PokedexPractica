using System;
using System.Collections.Generic;
using System.Text;
using MVVM_implementacion_CARS_NEW.Modelo;
using MVVM_implementacion_CARS_NEW.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace MVVM_implementacion_CARS_NEW.Datos
{
    public class Dpokemon
    { 
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    
                    ColorFondo = parametros.ColorFondo,
                    ColorPoder = parametros.ColorPoder,
                    Icono = parametros.Icono,
                    Nombre = parametros.Nombre,
                    NroOrden = parametros.NroOrden,
                    Poder = parametros.Poder,
                    Idpokemon = Guid.NewGuid(),
                    //Idpokemon = parametros.Idpokemon,

                });
        }
        /*
        public async Task ObtenerDatosPoke()
        {
            var data = await Task.Run(() => Cconexion.firebase
            .Child("Pokemon").OnceSingleAsync<Mpokemon>();
        } */

        public async Task ModificarPokemon(Mpokemon datosActualizados)
        {
            var actualizar = (await Cconexion
                .firebase.Child("Pokemon")
                .OnceAsync<Mpokemon>())
                .Where(a => a.Object.Idpokemon == datosActualizados.Idpokemon).FirstOrDefault();

            await Cconexion.firebase
                .Child("Pokemon")
                .Child(actualizar.Key)
                .PutAsync(new Mpokemon()
                {
                    Idpokemon = datosActualizados.Idpokemon,
                    ColorFondo = datosActualizados.ColorFondo,
                    ColorPoder = datosActualizados.ColorPoder,
                    NroOrden = datosActualizados.NroOrden,
                    Icono = datosActualizados.Icono,
                    Nombre = datosActualizados.Nombre,
                    Poder = datosActualizados.Poder
                });
        }

        public async Task<ObservableCollection<Mpokemon>> MostrarPokemones()
        {
            //return (await Cconexion.firebase
            //    .Child("Pokemon")
            //    .OnceAsync<Mpokemon>())
            //    .Select(item => new Mpokemon
            //    {
            //        Idpokemon=item.Key,
            //        Nombre = item.Object.Nombre,
            //        ColorFondo=item.Object.ColorFondo,
            //        ColorPoder=item.Object.ColorPoder,
            //        Icono=item.Object.Icono,
            //        NroOrden = item.Object.NroOrden,
            //        Poder=item.Object.Poder

            //    }).ToList();
            var data = await Task.Run(() => Cconexion.firebase
                .Child("Pokemon")
                .AsObservable<Mpokemon>()
                .AsObservableCollection());
                return data;
        }
        public async Task BorrarPokemon(Guid idPokemon)
        {
            var pokemonABorrar = (await Cconexion.firebase
                .Child("Pokemon")
                .OnceAsync<Mpokemon>()).Where(a => a.Object.Idpokemon == idPokemon).FirstOrDefault();

            await Cconexion.firebase.Child("Pokemon").Child(pokemonABorrar.Key).DeleteAsync();
        }
    }
}
