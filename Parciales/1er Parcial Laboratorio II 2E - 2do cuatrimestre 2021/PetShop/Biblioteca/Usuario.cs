using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Usuario : Empleado
    {

        public Usuario(string nombre, string apellido, string dni, int edad, string usuario, string password) : base(nombre, apellido, dni, edad, usuario, password)
        {

        }


        public override bool EsAdmin
        {
            get
            {
                return false;
            }
        }

    }
}
