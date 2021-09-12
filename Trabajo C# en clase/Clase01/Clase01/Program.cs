using System;

namespace Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeritoString;
            int num1;
            int num2;



            //  int resultado = num1 + num2;

            Console.WriteLine("Ingrese un numero");

            numeritoString = Console.ReadLine();
            num1 = int.Parse(numeritoString);


            Console.WriteLine("Ingrese otro numero");

            numeritoString = Console.ReadLine();
            num2 = int.Parse(numeritoString);


            int resultado = num1 + num2;









            Console.ReadLine();

            Console.WriteLine("El resultado es : " + resultado);

            Console.WriteLine($"El resultado es {resultado}");

            Console.WriteLine("el resultador es {0}", resultado);











            Console.ReadKey();
        }
    }
}
