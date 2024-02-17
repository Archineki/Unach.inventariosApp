using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using Unach.InventarioApp.Core.Service;

namespace Unach.InventarioApp.Core.ViewModel
{
    public class PrincipalPageViewModel:ViewModelBase
    {

        RelayCommand regresarCommand = null;
        public RelayCommand RegresarCommand
        {
            get => regresarCommand ?? (regresarCommand = new RelayCommand(async() =>
            {
                await Xamarin.Forms.DependencyService.Get<ICustomNavegation>().Regresar();
                await Xamarin.Forms.DependencyService.Get<ICustomNavegation>().Regresar();
            }, () => { return true; }));
        }
    }
}
