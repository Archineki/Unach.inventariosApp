using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unach.InventarioApp.Core.Service;
using Unach.inventariosApp.Droid.Service;

[assembly:Xamarin.Forms.Dependency(typeof(Saludar))]

namespace Unach.inventariosApp.Droid.Service
{
    public class Saludar : ISaludar
    {
        public string Saludando()
        {
            return "Hola desde Android";
        }
    }
}