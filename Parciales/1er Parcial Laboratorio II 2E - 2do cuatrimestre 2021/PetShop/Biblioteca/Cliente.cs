using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region "Atributos"
        private ETipoPago tipoPago;
        private int idCliente;
        private double saldo;
        List<Productos> listaProductos;
        #endregion


        #region "Constructores"

        public Cliente() : base()
        {
        }

        public Cliente(string nombre, string apellido, string cuit, ETipoPago tipoPago, double saldo, List<Productos> listaProductos) : base(nombre, apellido, cuit)
        {
            this.tipoPago = tipoPago;
            this.idCliente = IdAutoIncremental();
            this.saldo = saldo;
            this.listaProductos = listaProductos;
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
                this.tipoPago = value;
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

        public List<Productos> Producto
        {
            get { return this.listaProductos; }
            set { this.listaProductos = value; }
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
            sb.Append(base.ToString());
            sb.Append($"{this.idCliente} | {this.saldo} | {this.tipoPago} \n");

            foreach (var item in listaProductos)
            {
                sb.AppendLine($"{item}");
            }


            return sb.ToString();
        }

        public string Mostrar()
        {
            return ToString();

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
