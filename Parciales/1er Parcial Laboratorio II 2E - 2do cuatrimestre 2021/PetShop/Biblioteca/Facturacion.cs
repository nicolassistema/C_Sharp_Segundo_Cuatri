using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
