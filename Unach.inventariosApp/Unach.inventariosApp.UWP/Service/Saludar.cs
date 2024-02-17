using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unach.InventarioApp.Core.Service;
using Unach.inventariosApp.UWP.Service;

[assembly: Xamarin.Forms.Dependency(typeof(Saludar))]

namespace Unach.inventariosApp.UWP.Service
{
    public class Saludar : ISaludar
    {
        public string Saludando()
        {
            return "Hola desde Windows";
        }
    }
}
