using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_01
{
    public class Alumno
    {


        string nombre;
        string apellido;
        int nota1;
        int nota2;

        public Alumno(string nombre, string apellido, int nota1, int nota2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nota de alumno{this.nombre}: " +(this.nota1 + (float)this.nota2)/2);
        }


    }
}
