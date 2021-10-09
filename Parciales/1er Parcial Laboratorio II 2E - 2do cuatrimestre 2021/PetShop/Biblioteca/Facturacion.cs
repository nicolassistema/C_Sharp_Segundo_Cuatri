using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;

namespace Entidades
{
    public class Facturacion
    {

        DateTime fecha;
        double montoTotal;
        List<Venta> listaVenta;

        public Facturacion()
        {

        }

        public Facturacion(double montoTotal) : this()
        {
            this.fecha = DateTime.Now;
            this.montoTotal = montoTotal;
        }

        public Facturacion(List<Venta> listaVenta) : this()
        {
            this.fecha = DateTime.Now;
            this.montoTotal = ((Facturacion)listaVenta).montoTotal;
            this.listaVenta = listaVenta;
        }

        /// <summary>
        /// setea y devuelve el dato
        /// </summary>
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        /// <summary>
        /// setea y devuelve el dato
        /// </summary>
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

        /// <summary>
        /// Convierte una lista de ventas en una facturacion final
        /// </summary>
        /// <param name="listaVenta"></param>
        public static explicit operator Facturacion(List<Venta> listaVenta)
        {
            double acum = 0;
            foreach (var item in listaVenta)
            {
                acum += item.MontoTotal;
            }
            return new Facturacion(acum);
        }

        public override string ToString()
        {

            Facturacion facturacion = new Facturacion(((Facturacion)listaVenta).montoTotal);
            string fechaActual = (facturacion.Fecha).ToString("d", CultureInfo.CreateSpecificCulture("es-ES"));
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {fechaActual}");
            sb.AppendLine($"Facturación del dia: ${string.Format("{0:f2}", facturacion.MontoTotal)}");


           
            return sb.ToString();
        }





    }
}
