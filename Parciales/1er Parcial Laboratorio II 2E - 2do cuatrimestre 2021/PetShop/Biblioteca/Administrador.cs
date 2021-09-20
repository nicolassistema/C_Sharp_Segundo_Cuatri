using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    sealed class Administrador : Empleado
    {

        public Administrador(string nombre, string apellido, string dni, int edad, string usuario, string password) : base(nombre, apellido, dni, edad, usuario, password)
        {
        }


        public override bool EsAdmin
        {
            get
            {
                return true;
            }
        }

    }
}
