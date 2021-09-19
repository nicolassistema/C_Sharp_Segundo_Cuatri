using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_01
{
    public class Cuenta
    {
        public string  nombre;
        public float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.nombre = titular;
            this.cantidad = cantidad;
        }


      
        public void Mostrar()
        {
            if (this.cantidad <0)
            {
                

                Console.WriteLine($"Nombre: {this.nombre}");
                Console.WriteLine("Cantidad: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(this.cantidad + "\n");


            }
            else
            {
                Console.WriteLine($"Nombre: {this.nombre} ");
                Console.WriteLine("Cantidad: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(this.cantidad + "\n");
           
            }
            
        }

        public void Ingresar(float cantidad)
        {
            if (cantidad >= 0 )
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(float retirar)
        {
                this.cantidad -= retirar;
        }










    }
}
