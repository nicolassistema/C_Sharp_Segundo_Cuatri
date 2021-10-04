using System.Text;

namespace Entidades
{
    class Alimento : Producto
    {

        private ETipoAlimento tipoAlimento;


        public Alimento(string marca, string nombre, string detalle, int cantidad, double precio, ETipoAlimento tipoAlimento) : base(marca, nombre, detalle, cantidad, precio)
        {
            this.tipoAlimento = tipoAlimento;

        }


        public enum ETipoAlimento
        {
            Balanceado,
            Natural
        }

        /// <summary>
        /// setea y devuelve el dato
        /// </summary>
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


        /// <summary>
        /// muestra informacion del objeto
        /// </summary>
        /// <returns>muestra informacion del objeto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipoAlimento} | {this.Cantidad}");
            return sb.ToString();
        }



    }
}
