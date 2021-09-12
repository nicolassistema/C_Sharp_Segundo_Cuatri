using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I07___Recibo_de_sueldo
{
    public class Recibo
    {

        //atributos
        float valorHora;
        string nombre;
        int antiguedad;
        float totalACobrarEnBruto;
        float totalACobrarEnNeto;

        public Recibo(float valorHora, string nombre, int antiguedad, float totalACobrarEnBruto, float totalACobrarEnNeto)
        {
            this.valorHora = valorHora;
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.totalACobrarEnBruto = totalACobrarEnBruto;
            this.totalACobrarEnNeto = totalACobrarEnNeto;
        }



        //constructor


        //getter/setter
        public float SetValorHora(float valorHora)
        {
            return this.valorHora = valorHora;
        }

        public float GetValorHora()
        {
            return this.valorHora;
        }


        public string SetNombre(string nombre)
        {
            return this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }


        public int SetanTiguedad(int antiguedad)
        {
            return this.antiguedad = antiguedad;
        }

        public int GetanTiguedad()
        {
            return this.antiguedad;
        }

        public float SetTotalACobrarEnBruto(float totalACobrarEnBruto)
        {
            return this.totalACobrarEnBruto = totalACobrarEnBruto;
        }

        public float GetTotalACobrarEnBruto()
        {
            return this.totalACobrarEnBruto;
        }



        public float SetTotalACobrarEnNeto(float totalACobrarEnNeto)
        {
            return this.totalACobrarEnNeto = totalACobrarEnNeto;
        }

        public float GetTotalACobrarEnNeto()
        {
            return this.totalACobrarEnNeto;
        }




        public float CalculoImporteACobrar(float valorHora, int antiguedad, int cantidadHorasTrabajadas)
        {
            float totalNeto;
            totalNeto = valorHora * cantidadHorasTrabajadas;
            totalNeto += (float)(antiguedad *= 150);
            totalNeto -= totalNeto * 13 / 100;

            return totalNeto;
        }


        public void IngresarEmpleado()
        {

            string nombreAux;
            float valorHoraAux;
            int antiguedadAux;
            int cantidadHoraXMes;
            StringBuilder stringBuilder = new StringBuilder();

            Console.WriteLine("Ingresar Nombre del empleado:");
            nombreAux = Console.ReadLine();


            Console.WriteLine("Ingresar El valor hora:");
            valorHoraAux = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la antigüedad en años:");
            antiguedadAux = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar cantidad de horas trabajadas:");
            cantidadHoraXMes = int.Parse(Console.ReadLine());



            stringBuilder.Append(Recibo.GetNombre());
            stringBuilder.Append(" " + Comercio.GetCuit().ToString());
            stringBuilder.AppendLine(" " + Comercio.GetDireccion());
            stringBuilder.AppendFormat(" numero: {0} Fecha {1} ", this.numero, this.fecha.ToString("dd/MM/yyyy"));



        }





    }
}
