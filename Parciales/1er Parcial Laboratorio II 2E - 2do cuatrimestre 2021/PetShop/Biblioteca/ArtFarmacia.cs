using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    sealed class ArtFarmacia : ArtCuidadoMascotas
    {


        public ArtFarmacia(int codigo, string nombre, string detalle, int cantidad, double precio) : base(codigo, nombre, detalle, cantidad, precio)
        {

        }



        public override ETipoCuidado TipoCuidado
        {
            get
            {
                return ETipoCuidado.Farmacia;
            }
        }
    }
}
