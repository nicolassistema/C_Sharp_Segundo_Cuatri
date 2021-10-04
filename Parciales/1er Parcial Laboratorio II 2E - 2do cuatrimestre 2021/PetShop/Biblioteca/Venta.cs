using System.Collections.Generic;
using System.Text;

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

        public Venta(Usuario usuario, Cliente cliente, double monto, List<Producto> productos) : this()
        {
            this.NumeroFactura = IdFacturacionAutoIncremental();
            this.Cliente = cliente;
            this.MontoTotal = monto;
            this.Usuario = usuario;
            this.ListaProductos = listaProductos;
        }


        public Venta(Usuario usuario, Cliente cliente, List<Producto> listaProductos) : this()
        {
            this.NumeroFactura = IdFacturacionAutoIncremental();
            this.Cliente = cliente;
            this.MontoTotal = CalcularMontoTotal();
            this.Usuario = usuario;
            this.ListaProductos = listaProductos;
        }
        #region "Propiedades"

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
        #endregion

        #region "Operadores"
        public static bool operator ==(List<Venta> productos, Venta producto)
        {
            foreach (Venta auxProducto in PetShop.Ventas)
            {
                if (producto == auxProducto)
                    return true;
            }
            return false;
        }

        public static bool operator !=(List<Venta> productos, Venta producto)
        {
            return !(productos == producto);
        }
        public static List<Venta> operator +(List<Venta> ventas, Venta venta)
        {
            if (ventas != venta)
            {
                PetShop.Ventas.Add(venta);
                return PetShop.Ventas;
            }
            return PetShop.Ventas;
        }
        #endregion

        #region "Utils"
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

            sb.AppendLine(usuario.ToString());

            sb.AppendLine(Cliente.Mostrar());
            foreach (var item in listaProductos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($" {this.numeroFactura} | {this.montoTotal}");
            return sb.ToString();
        }

        public double CalcularMontoTotal()
        {
            double monto = 0;
            for (int i = 0; i < ListaProductos.Count; i++)
            {
                monto += ListaProductos[i].Precio;
            }
            return monto;
        }

        public string MostrarFactura()
        {
            return ToString();
        }

        #endregion
    }
}
