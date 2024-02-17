using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using Unach.InventarioApp.Core.Models;
using Unach.InventarioApp.Core.Service;


namespace Unach.InventarioApp.Core.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {

        private Users user=new Users();
        public Users User { get => user; set => Set(ref user, value); }

        private string mensaje;
        public string Mensaje{ get => mensaje; set => Set(ref mensaje, value); }

        RelayCommand loginCommand = null;
        public RelayCommand LoginCommand
        {
            get => loginCommand ?? (loginCommand = new RelayCommand(async() =>
            {
                if (user.Usuario=="Glopez" && user.Password=="123") {
                    this.Mensaje = "Iniciaste sesión correctamente";
                    await Xamarin.Forms.DependencyService.Get<ICustomNavegation>().NavegarA("Principal");
                }
                else {
                    this.Mensaje = "Usuario y/o Contraseña Incorrecta";
                }
            }, () => { return true; }));
        }


        RelayCommand saludarCommand = null;
        public RelayCommand SaludarCommand
        {
            get => saludarCommand ?? (saludarCommand = new RelayCommand(() =>
            {
             Mensaje=   Xamarin.Forms.DependencyService.Get<ISaludar>().Saludando();
            }, () => { return true; }));
        }
    }
}


 
