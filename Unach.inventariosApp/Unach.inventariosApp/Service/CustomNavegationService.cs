using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<bool> NavegarA(string Pagina)
        {
            switch (Pagina)
            {
                case "Login":
                    App.Current.MainPage = new NavigationPage(new Vistas.LoginPage());
                    break;
                case "Principal":
                    //App.Current.MainPage.Navigation.PushAsync (new Vistas.PrincipalPage());
                  await  ExistePagina(new Vistas.PrincipalPage());
                    break;
                case "Registro":
                    await ExistePagina(new Vistas.PrincipalPage());
                    break;
                    
                default:
                    break;
            }
            return await Task.FromResult(true);
        }

        public async Task NavegarA(string Pagina, object[] parameters)
        {
            switch (Pagina)
            {
                case "Registro":
                    await App.Current.MainPage.Navigation.PushAsync(new Vistas.RegistroPage(parameters));
                    break;
                default:
                    break;
            }
        }

        public async Task ExistePagina(Page pagina)
        {
            //Mostrar las páginas apiladas
            List<Page> ListaDePaginas = App.Current.MainPage.Navigation.NavigationStack.ToList();
            //Buscar la pantalla enviada, llamada "pagina" 
            short PaginasSimilaresApiladas = (short)ListaDePaginas.Where(p => p.GetType() == pagina.GetType()).Count();
            if (PaginasSimilaresApiladas < 1)
                await App.Current.MainPage.Navigation.PushAsync(pagina, true);
        }
    }
}
