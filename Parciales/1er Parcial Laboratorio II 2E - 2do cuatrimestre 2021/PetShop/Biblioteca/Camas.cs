using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Camas : Productos
    {

        private ETamanio tamanio;

        public Camas(string marca, string nombre, string detalle, int cantidad, double precio, ETamanio tamanio) : base(marca, nombre, detalle, cantidad, precio)
        {
            this.tamanio = tamanio;

        }

        #region "Propiedades"

        public ETamanio Tamanio
        {
            get
            {
                return this.tamanio;
            }
            set
            {
                this.tamanio = value;
            }
        }

        #endregion

        #region "Enumerados"
        public enum ETamanio
        {
            Grande,
            Chico
        }
        #endregion

        #region "Utils"
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append($"{base.ToString() } | {this.tamanio}");

            return sb.ToString();
        }



        #endregion
    }
}
