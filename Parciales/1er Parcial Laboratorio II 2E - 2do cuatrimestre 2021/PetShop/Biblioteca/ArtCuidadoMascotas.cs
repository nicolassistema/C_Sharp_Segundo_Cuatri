using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class ArtCuidadoMascotas : Productos
    {

        private ETipoCuidado tipoCuidado;

        public ArtCuidadoMascotas(int codigo, string marca, string nombre, string detalle, int cantidad, double precio, ETipoCuidado tipoCuidado) : base(codigo, marca, nombre, detalle, cantidad, precio)
        {

        }


        public enum ETipoCuidado
        {
            Farmacia,
            Limpieza
        }

        public  ETipoCuidado TipoCuidado
        {
            get
            {
                return this.tipoCuidado;
            }
        }

    }

}

