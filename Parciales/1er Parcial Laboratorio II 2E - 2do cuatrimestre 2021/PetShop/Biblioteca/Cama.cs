using System.Text;

namespace Entidades
{
    public sealed class Cama : Producto
    {
        #region "Atributo"
        private ETamanio tamanio;
        #endregion

        #region "Constructor"
        public Cama(string marca, string nombre, string detalle, int cantidad, double precio, ETamanio tamanio) : base(marca, nombre, detalle, cantidad, precio)
        {
            this.tamanio = tamanio;
        }
        #endregion

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
        /// <summary>
        /// muestra informacion del objeto
        /// </summary>
        /// <returns>muestra informacion del objeto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString() } | {this.tamanio}");
            return sb.ToString();
        }



        #endregion
    }
}
