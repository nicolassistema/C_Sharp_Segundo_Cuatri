using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        List<Producto> listaProductos;
        Cliente cliente;
        Usuario usuario;
        int numeroFactura;
        double montoTotal;


        public Venta()
        {
            listaProductos = new List<Producto>();
        }


        public Venta(Usuario usuario, Cliente cliente, double montoTotal, List<Producto> listaProductos ) : this()
        {
            this.NumeroFactura = IdFacturacionAutoIncremental();
            this.Cliente = cliente;
            this.MontoTotal = montoTotal;
            this.Usuario = usuario;
            this.ListaProductos = listaProductos;

        }

        public double MontoTotal
        {
            get
            {
                return this.montoTotal;
            }
            set
            {
                this.montoTotal = value;
            }
        }



        public int NumeroFactura
        {
            get
            {
                return this.numeroFactura;
            }
            set
            {
                this.numeroFactura = value;
            }
        }

        public Cliente Cliente
        {
            get 
            {
                return cliente;
            }
            set 
            {
                cliente = value;
            }
        }


        public List<Producto> ListaProductos
        {
            get
            {
                return listaProductos;
            }
            set
            {
                listaProductos = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }




        //public static implicit operator double(Venta unaVenta)
        //{
        //    return unaVenta.MontoTotal;
        //}


        public int IdFacturacionAutoIncremental()
        {
            for (int i = 0; i <= 1; i++)
            {
                this.numeroFactura = i + 1;
            }
            return this.numeroFactura;
        }





        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.cliente} | {this.montoTotal} | {this.numeroFactura}");
            sb.AppendLine(Cliente.Mostrar());
            return sb.ToString();
        }

        public string MostrarFactura()
        {
            return ToString();
        }






    }
}
