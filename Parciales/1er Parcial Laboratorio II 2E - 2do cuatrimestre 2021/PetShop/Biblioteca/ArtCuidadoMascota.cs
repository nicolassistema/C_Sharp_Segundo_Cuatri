using System.Text;

namespace Entidades
{
    public class ArtCuidadoMascota : Producto
    {
        #region "Atributos"
        private ETipoCuidado tipoCuidado;
        #endregion

        #region "Constructor"
        public ArtCuidadoMascota(string marca, string nombre, string detalle, int stock, double precio, ETipoCuidado tipoCuidado) : base(marca, nombre, detalle, stock, precio)
        {
            this.tipoCuidado = tipoCuidado;
        }
        #endregion

        #region "Enumerados"
        public enum ETipoCuidado
        {
            Farmacia,
            Limpieza
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// setea y devuelve un dato
        /// </summary>
        public ETipoCuidado TipoCuidado
        {
            get
            {
                return this.tipoCuidado;
            }
            set
            {
                this.tipoCuidado = value;
            }
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
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipoCuidado}");
            return sb.ToString();
        }
        #endregion
    }
}

