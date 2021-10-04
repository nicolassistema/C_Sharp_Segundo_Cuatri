using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Venta
    {
        List<Producto> productos;
        Cliente cliente;
        Usuario usuario;
        int numeroFactura;
        double montoTotal;

        public Venta()
        {
            productos = new List<Producto>();
        }

        public Venta(Usuario usuario, Cliente cliente, double monto, List<Producto> productos) : this()
        {
            this.NumeroFactura = IdFacturacionAutoIncremental();
            this.Cliente = cliente;
            this.MontoTotal = monto;
            this.Usuario = usuario;
            this.productos = productos;
        }


        public Venta(Usuario usuario, Cliente cliente, List<Producto> productos) : this()
        {
            this.NumeroFactura = IdFacturacionAutoIncremental();
            this.Cliente = cliente;
            this.MontoTotal = CalcularMontoTotal();
            this.Usuario = usuario;
            this.productos = productos;
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


        public List<Producto> Productos
        {
            get
            {
                return productos;
            }
            set
            {
                productos = value;
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
        /// <summary>
        /// Verifica que el producto se encuentre en la lista de ventas
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>Devuelve true si el prodcuto si se encuentra en la lista de venta</returns>
        public static bool operator ==(List<Venta> productos, Venta producto)
        {
            foreach (Venta auxProducto in PetShop.Ventas)
            {
                if (producto == auxProducto)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que el producto NO se encuentre en la lista de ventas
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>Devuelve true si el prodcuto NO se encuentre en la lista de venta</returns>
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
        /// <summary>
        /// Incrementea el id de la factura
        /// </summary>
        /// <returns>devuelve el id incrementado</returns>
        public int IdFacturacionAutoIncremental()
        {
            for (int i = 0; i <= 1; i++)
            {
                this.numeroFactura = i + 1;
            }
            return this.numeroFactura;
        }

        /// <summary>
        /// Muestra la venta
        /// </summary>
        /// <returns>Muestra la venta</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(usuario.ToString());

            sb.AppendLine(Cliente.Mostrar());
            foreach (var item in productos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($" {this.numeroFactura} | {this.montoTotal}");
            return sb.ToString();
        }

        /// <summary>
        /// Calcular el monto total de los importes
        /// </summary>
        /// <returns>devuelve el monto total</returns>
        public double CalcularMontoTotal()
        {
            double monto = 0;
            for (int i = 0; i < productos.Count; i++)
            {
                monto += productos[i].Precio;
            }
            return monto;
        }
        /// <summary>
        /// muestar el objetos
        /// </summary>
        /// <returns>muestra el objeto</returns>
        public string MostrarFactura()
        {
            return ToString();
        }

        #endregion
    }
}
