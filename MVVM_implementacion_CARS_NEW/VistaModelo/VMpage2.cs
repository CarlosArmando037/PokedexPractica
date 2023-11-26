﻿using MVVM_implementacion_CARS.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_CARS_NEW.Modelo;

namespace MVVM_implementacion_CARS_NEW.VistaModelo
{
    public class VMpage2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre = "frank",
                    Imagen = "https://i.ibb.co/chSH3x2/gato.png"
                },
                new Musuarios
                {
                    Nombre = "Juan",
                    Imagen = "https://i.ibb.co/KL7d5KP/barra-de-chocolate.png"
                },
                new Musuarios
                {
                    Nombre = "Carlos",
                    Imagen = "https://i.ibb.co/zr23yd0/zombi.png"
                }
            };
        } 
        public void ProcesoSimple()
        {

        }
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "OK");
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
