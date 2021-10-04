using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Facturacion
    {
        DateTime fecha;
        double montoTotal;

        public Facturacion(double montoTotal)
        {
            this.fecha = DateTime.Now;
            this.montoTotal = montoTotal;
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
    }
}
