using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArtCuidadoMascotas : Productos
    {

        private ETipoCuidado tipoCuidado;

        public ArtCuidadoMascotas(string marca, string nombre, string detalle, int stock, double precio, ETipoCuidado tipoCuidado) : base( marca, nombre, detalle, stock, precio)
        {
            this.tipoCuidado = tipoCuidado;
        }


        public enum ETipoCuidado
        {
            Farmacia,
            Limpieza
        }

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



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipoCuidado}");
            return sb.ToString();
        }



    }

}

