using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using Unach.InventarioApp.Core.Service;

namespace Unach.InventarioApp.Core.ViewModel
{
    public class RegistroViewModel:ViewModelBase
    {

        private string nombre;
        public string Nombre { get => nombre; set => Set(ref nombre, value); }


        RelayCommand registroCommand = null;
        public RelayCommand RegistroCommand
        {
            get => registroCommand ?? (registroCommand = new RelayCommand(async() =>
            {
                await Xamarin.Forms.DependencyService.Get<ICustomNavegation>().NavegarA("Registro", new object[] { $"Gerardo Lopez Ibañez{DateTime.Now}" });



            }, () => { return true; }));
        }
    }
}
