using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        Cliente cliente;
        int numeroFactura;
        double montoTotal;


        public Ventas(Cliente cliente, double montoTotal)
        {
            this.cliente = cliente;
            this.montoTotal = montoTotal;
            this.numeroFactura = IdFacturacionAutoIncremental();
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
            get { return cliente; }
            set { cliente = value; }
        }



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
