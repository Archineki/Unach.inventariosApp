using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unach.InventarioApp.Core.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unach.inventariosApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPage : ContentPage
    {

        RegistroViewModel VM { get { return BindingContext as RegistroViewModel; } }
        public RegistroPage(object[] parameters)
        {
            InitializeComponent();

            VM.Nombre = parameters[0].ToString();   

        }
    }
}