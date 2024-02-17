using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Unach.InventarioApp.Core.Service;
using Unach.inventariosApp.iOS.Service;

[assembly: Xamarin.Forms.Dependency(typeof(Saludar))]

namespace Unach.inventariosApp.iOS.Service
{
    public class Saludar : ISaludar
    {
        public string Saludando()
        {
            return "Hola desde iOS";
        }
    }
}