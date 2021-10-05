using System;
using System.Text;

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
            this.Cuit = String.Empty;
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
        }

        public Persona(string cuit, string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cuit = cuit;
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
        /// <summary>
        /// Mostrar el objeto
        /// </summary>
        /// <returns>Mostrar el objeto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Apellido} |");
            sb.Append($"{this.Nombre} |");

            return sb.ToString();
        }

        //public abstract string Mostrar();
    
        #endregion

    }
}
