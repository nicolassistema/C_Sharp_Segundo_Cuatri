using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Alimentos : Productos
    {

        private ETipoAlimento tipoAlimento;

        public Alimentos(int codigo, string nombre, string detalle, int cantidad, double precio, ETipoAlimento tipoAlimento) : base(codigo, nombre, detalle, cantidad, precio)
        {
            this.tipoAlimento = tipoAlimento;
        }


        public enum ETipoAlimento
        {
            Balanceado,
            Natural
        }

        public ETipoAlimento TipoAlimento
        {
            get
            {
                return this.tipoAlimento;
            }
        }


    }
}
