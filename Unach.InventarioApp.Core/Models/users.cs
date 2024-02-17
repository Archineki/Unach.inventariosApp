using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Unach.InventarioApp.Core.Models
{
    public class Users : ViewModelBase
    {
        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set { Set(ref usuario, value); }
        }


        private string password;
        public string Password { get => password; set => Set(ref password, value); }
    }
}
