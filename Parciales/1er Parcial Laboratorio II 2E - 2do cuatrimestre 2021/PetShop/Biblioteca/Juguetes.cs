using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Juguetes : Productos
    {
        private EMaterial material;

        public Juguetes(int codigo , string nombre, string detalle, int cantidad, double precio, EMaterial material) : base(codigo, nombre, detalle, cantidad, precio)
        {
            this.material = material;
        }


        public enum EMaterial
        {
            Plastico,
            Metal,
            Goma
       }

        public EMaterial Material
        {
            get
            {
                return this.material;
            }
        }





    }
}
