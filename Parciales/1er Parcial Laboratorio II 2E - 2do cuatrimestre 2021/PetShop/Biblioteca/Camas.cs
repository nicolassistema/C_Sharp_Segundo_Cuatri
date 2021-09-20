using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    sealed class Camas : Productos
    {

        private ETamanio tamanio;

        public Camas(int codigo, string nombre, string detalle, int cantidad, double precio, ETamanio tamanio) : base(codigo, nombre, detalle, cantidad, precio)
        {
            this.tamanio = tamanio;
        }


        public enum ETamanio
        {
            Grande,
            Chico
        }

        public ETamanio Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

    }
}
