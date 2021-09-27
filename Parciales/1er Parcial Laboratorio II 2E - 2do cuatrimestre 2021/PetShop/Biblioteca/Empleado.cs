using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Empleado : Usuario
    {


        public Empleado() : base()
        {

        }

        public Empleado(string nombre, string apellido, string cuit, string usuario, string password, EPerfilUsuario perfilUsuario) : base(nombre, apellido, cuit, usuario, password, perfilUsuario)
        {
          
        }

    



    }
}
