using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    sealed class Administrador : Usuario
    {

        public Administrador(string nombre, string apellido, string cuit, string usuario, string password, EPerfilUsuario perfilUsuario) : base(nombre, apellido, cuit, usuario, password, perfilUsuario)
        {
            
        }

       

  
    }
}
