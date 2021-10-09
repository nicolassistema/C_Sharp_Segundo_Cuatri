using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Entidades
{
    public class Venta
    {
        List<Producto> productos;
        Cliente cliente;
        Usuario usuario;
        Venta venta;
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
            this.productos = productos;
            this.MontoTotal = CalcularMontoTotal();
            this.Usuario = usuario;
           
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
            foreach (Venta auxProducto in productos)
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
                ventas.Add(venta);
                return ventas;
            }
            return ventas;
        }
        #endregion

        #region "Utils"
        /// <summary>
        /// Incrementea el id de la factura
        /// </summary>
        /// <returns>devuelve el id incrementado</returns>
        public int IdFacturacionAutoIncremental()
        {
            for (int i = 0; i <= PetShop.ObtenerListaVentas().Count; i++)
            {
                this.numeroFactura = i + 1;
            }
            return this.numeroFactura;
        }


        public double SumaTotalPorProducto(List<Producto> productos, Producto producto)
        {
            double aux = 0;
            foreach (var item in productos)
            {
                if (producto.Codigo == item.Codigo)
                {
                    aux += item.Precio;
                }
            }
            return aux;
        }

        public int CantidadPorProducto(List<Producto> productos, Producto producto)
        {
            int cantidad = 0;
            foreach (var item in productos)
            {
                if (producto.Codigo == item.Codigo)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }




        /// <summary>
        /// Muestra la venta
        /// </summary>
        /// <returns>Muestra la venta</returns>
        public override string ToString()
        {
            Venta venta = new Venta();
            int acum = 0;
            double acumDos;
            int cant;
            double total = 0;
            StringBuilder sb = new StringBuilder();
            //         sb.AppendLine(usuario.ToString());
            //          sb.AppendLine(Cliente.Mostrar());
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine("C.  CONCEPTO                PRECION     IMPORTE");
            sb.AppendLine("------------------------------------------------");
            foreach (var item in productos)
            {
                acumDos = 0;
                cant = 0;
                acum++;
                foreach (var itemDos in productos)
                {
                    if (itemDos.CodigoDos == acum)
                    {
                        acumDos += item.Precio;
                        cant++;
                    }
                }
                if (item.CodigoDos == acum)
                {
                    sb.AppendLine(" "+cant.ToString()+" "+ item.ToString()+"$"+"      "+ string.Format("{0:f2}", acumDos)+"$");
                }
                total += acumDos;
            }
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine("   TODOS LOS PROD. CON I.V.A. INCLUD.     ");
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine("                           TOTAL : $" + string.Format("{0:f2}", total));
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine($"Fue atendid@ por: {usuario.Nombre} {usuario.Apellido}");
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
