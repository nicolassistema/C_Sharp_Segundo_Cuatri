using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    sealed class Cliente : Persona
    {
        #region "Atributos"
        private ETipoPago tipoPago;
        private int idCliente;
        private double saldo;
        #endregion


        #region "Construcotores"

        public Cliente(string nombre, string apellido, string cuit, ETipoPago tipoPago, double saldo) : base(nombre, apellido, cuit)
        {
            this.tipoPago = tipoPago;
            this.idCliente = IdAutoIncremental();
            this.saldo = saldo;
        }

        #endregion

        #region "Propiedades"
        public ETipoPago TipoPago
        {
            get
            {
                return this.tipoPago;
            }
            set
            {
                this.tipoPago = TipoPago;
            }
        }

        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }


        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        #endregion



        #region "Enumerados"
        public enum ETipoPago
        {
            MercadoPago,
            Efectivo,
            TarjetaDebito
        }
        #endregion



        #region "Utils"
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.Saldo}");
            return sb.ToString();
        }



        public int IdAutoIncremental()
        {
            for (int i = 0; i <= 1; i++)
            {
                this.idCliente = i + 1;
            }
            return this.idCliente;
        }

        #endregion


    }
}
