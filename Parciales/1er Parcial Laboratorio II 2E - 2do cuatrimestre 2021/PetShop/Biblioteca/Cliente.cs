using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    sealed class Cliente : Persona
    {

        private TipoPago tipoPago;

        public Cliente(string nombre, string apellido, string dni, int edad, TipoPago tipoPago) : base(nombre, apellido, dni, edad)
        {
            this.tipoPago = tipoPago;
        }


        public enum TipoPago
        {
            TarjetaCredito,
            Efectivo,
            TarjetaDebito
        }


        public TipoPago FormaPago
        {
            get
            {
                return this.tipoPago;
            }
        }






    }
}
