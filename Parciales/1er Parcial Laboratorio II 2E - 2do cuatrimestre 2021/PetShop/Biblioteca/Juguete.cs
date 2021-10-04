using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juguete : Producto
    {
        private EMaterial material;

        public Juguete( string marca, string nombre, string detalle, int stock, double precio, EMaterial material) : base( marca, nombre, detalle, stock, precio)
        {
            this.material = material;
        }


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


        public enum EMaterial
        {
            Plastico,
            Metal,
            Goma
        }
                 
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($" | {this.material}");
            return sb.ToString();
        }


    }
}
