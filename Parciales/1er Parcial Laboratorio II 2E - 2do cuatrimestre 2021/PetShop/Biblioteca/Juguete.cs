using System.Text;

namespace Entidades
{
    public class Juguete : Producto
    {
        #region "Atributos"
        private EMaterial material;
        #endregion

        #region "Constructores"
        public Juguete(string marca, string nombre, string detalle, int stock, double precio, EMaterial material) : base(marca, nombre, detalle, stock, precio)
        {
            this.material = material;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Setea y devuelve el dato
        /// </summary>
        public EMaterial Material
        {
            get
            {
                return this.material;
            }
            set
            {
                this.material = value;
            }
        }
        #endregion

        #region "Enumerados"
        public enum EMaterial
        {
            Plastico,
            Metal,
            Goma
        }
        #endregion

        #region "Utils"
        /// <summary>
        /// Muestra informacion del juguete
        /// </summary>
        /// <returns> Muestra informacion del juguete</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($" {this.Nombre}| {this.Precio}");
            return sb.ToString();
        }
        #endregion
    }
}
