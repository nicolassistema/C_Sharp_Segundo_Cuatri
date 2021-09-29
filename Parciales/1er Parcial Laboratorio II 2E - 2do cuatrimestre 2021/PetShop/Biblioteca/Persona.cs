using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public abstract class Persona
    {
        #region "Atributos"
        private string nombre;
        private string apellido;
        private string cuit;
        #endregion

        #region "Constructor"

        public Persona()
        {
            this.cuit = String.Empty;
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
        }

        public Persona(string nombre, string apellido, string cuit)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuit = cuit;
        }
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Cuit
        {
            get
            {
                return this.cuit;
            }
            set
            {
                this.cuit = value;
            }
        }

        #endregion

        #region "utils"
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Apellido} |");
            sb.Append($"{this.Nombre} |");
            sb.Append($"{this.cuit}|");

            return sb.ToString();
        }

        #endregion

    }
}
