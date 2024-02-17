using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Unach.InventarioApp.Core.Service
{
    public interface ICustomNavegation
    {
        Task Regresar();
        Task Inicio();
        Task NavegarA(string Pagina);
        Task NavegarA(string Pagina, object[] parameters);
    }
}
