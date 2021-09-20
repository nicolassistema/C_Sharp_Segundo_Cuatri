using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class ArtCuidadoMascotas : Productos
    {


        public ArtCuidadoMascotas(int codigo, string nombre, string detalle, int cantidad, double precio) : base(codigo, nombre, detalle, cantidad, precio)
        {

        }


        public enum ETipoCuidado
        {
            Farmacia,
            Limpieza
        }

        public abstract ETipoCuidado TipoCuidado
        {
            get;
        }

    }

}
}
