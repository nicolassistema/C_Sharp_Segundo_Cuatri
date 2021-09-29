using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Empleado : Usuario
    {


        public Empleado() : base()
        {

        }

        public Empleado(string nombre, string apellido, string cuit, string usuario, string password, EPerfilUsuario perfilUsuario) : base(nombre, apellido, cuit, usuario, password, perfilUsuario)
        {
            this.PerfilUsuario = EPerfilUsuario.Empleado;
        }

    



    }
}
