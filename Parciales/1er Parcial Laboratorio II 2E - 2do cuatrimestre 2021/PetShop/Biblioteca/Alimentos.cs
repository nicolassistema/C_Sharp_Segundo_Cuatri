using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Alimentos : Productos
    {

        private ETipoAlimento tipoAlimento;
       

        public Alimentos(int codigo, string marca, string nombre, string detalle, int cantidad, double precio, ETipoAlimento tipoAlimento) : base(codigo, marca, nombre, detalle, cantidad, precio)
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
            set
            {
                this.tipoAlimento = TipoAlimento;
            }
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipoAlimento} | {this.Cantidad}");
            return sb.ToString();
        }



    }
}
