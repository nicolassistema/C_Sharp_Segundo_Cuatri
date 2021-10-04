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
      //  private ETipoPago tipoPago;
        private int idCliente;
        private double saldo;
    //   List<Productos> listaProductos;
        #endregion


        #region "Constructores"

        public Cliente() : base()
        {
        }

        //public Cliente(string cuit, string nombre, string apellido) : base()
        //{
        //    this.idCliente = IdAutoIncremental();
        //}

        public Cliente(string cuit, string nombre, string apellido,  double saldo) : base(cuit, nombre, apellido)
        {
            this.idCliente = IdAutoIncremental();
            this.saldo = saldo;
        }


        #endregion

        #region "Propiedades"
        //public ETipoPago TipoPago
        //{
        //    get
        //    {
        //        return this.tipoPago;
        //    }
        //    set
        //    {
        //        this.tipoPago = value;
        //    }
        //}

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

        //public List<Productos> Producto
        //{
        //    get { return this.listaProductos; }
        //    set { this.listaProductos = value; }
        //}



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
          //  sb.Append($" {this.saldo} \n");

            //foreach (var item in listaProductos)
            //{
            //    sb.AppendLine($"{item}");
            //}


            return sb.ToString();
        }

        public string Mostrar()
        {
            return ToString();

        }



        public int IdAutoIncremental()
        {

            for (int i = 0; i <= PetShop.ObtenerListaCliente().Count; i++)
            {
                IdCliente = i + 1;
            }

            return IdCliente;
        }

        #endregion


    }
}
