using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unach.inventariosApp.Service;
using Xamarin.Forms;

[assembly:Xamarin.Forms.Dependency(typeof(CustomNavegationService))]

namespace Unach.inventariosApp.Service
{
    public class CustomNavegationService : InventarioApp.Core.Service.ICustomNavegation
    {
        public async Task Inicio()
        {
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }
       public async Task Regresar()
        {
            await App.Current.MainPage.Navigation.PopAsync(true);
        }
        public Task NavegarA(string Pagina)
        {
            switch (Pagina)
            {
                case "Login":
                    App.Current.MainPage = new NavigationPage(new Vistas.LoginPage());
                    break;
                case "Principal":
                    App.Current.MainPage.Navigation.PushAsync (new Vistas.PrincipalPage());
                    break;
                default:
                    break;
            }
            return new Task(() => { });
        }

        public Task NavegarA(string Pagina, object[] parameters)
        {
            throw new NotImplementedException();
        }

 
    }
}
