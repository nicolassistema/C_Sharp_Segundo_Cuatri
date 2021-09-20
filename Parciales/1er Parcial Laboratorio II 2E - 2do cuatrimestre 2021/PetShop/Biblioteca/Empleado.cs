using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Empleado : Persona
    {

        private string usuario;
        private string password;

        public Empleado(string nombre, string apellido, string dni, int edad, string usuario, string password) : base(nombre, apellido, dni, edad)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public abstract bool EsAdmin
        {
            get;
        }


        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }


    }
}
