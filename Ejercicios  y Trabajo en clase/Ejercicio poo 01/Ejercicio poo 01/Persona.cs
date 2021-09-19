using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_01
{
    class Persona
    {
        string nombre;
        int edad;
        int dni;

        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
             this.nombre = nombre;
        }


        public int GetEdad()
        {
            return this.edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }


        public void Mostrar()
        {
            Console.WriteLine(this.nombre +" "+ this.edad+ " "+ this.dni);
        }

        public string EsMayorDeEdad()
        {

            if (this.edad > 18)
            {
                return "es mayor";
            }
            else
            {
                return "es menor";
            }
           
        }

    }
}
