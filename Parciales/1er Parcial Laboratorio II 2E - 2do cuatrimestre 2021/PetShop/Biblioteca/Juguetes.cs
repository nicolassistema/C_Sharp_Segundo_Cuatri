using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juguetes : Productos
    {
        private EMaterial material;

        public Juguetes(int codigo, string marca, string nombre, string detalle, int stock, double precio, EMaterial material) : base(codigo, marca, nombre, detalle, stock, precio)
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
