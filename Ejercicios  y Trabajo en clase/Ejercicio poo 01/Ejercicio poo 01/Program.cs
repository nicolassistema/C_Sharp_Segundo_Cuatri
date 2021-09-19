using System;
using System.Text;


namespace Ejercicio_poo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ejercicio 1

            //Alumno[] lista = new Alumno[3];

            //Alumno a1 = new Alumno("pepe", "sarasa", 8, 9);
            //Alumno a2 = new Alumno("pipi", "sarasa", 8, 9);
            //Alumno a3 = new Alumno("pupu", "sarasa", 8, 9);



            //lista[0] = a1;
            //lista[1] = a2;
            //lista[2] = a3;


            //for (int i = 0; i < lista.Length; i++)
            //{
            //    lista[i].Mostrar();
            //}

            #endregion

            #region ejercicio 2
            //Persona p1 = new Persona("nicolas", 25, 323220);
            //Persona p2 = new Persona("pepe", 20, 323220);
            //Persona p3 = new Persona("lolo", 15, 323220);

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(p1.EsMayorDeEdad());

            #endregion

            #region ejercicio 3
            //bool flag = true;
            //Cuenta persona1 = new Cuenta("nicolas", 50);

            //do
            //{

            //    persona1.Mostrar();
            //    Console.ForegroundColor = ConsoleColor.White;
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendLine ( "Opciones");
            //    sb.AppendLine("1 Ingresar");
            //    sb.AppendLine("2 Retirar");
            //    sb.AppendLine("3 Salir");
            //    Console.WriteLine(sb.ToString());


            //    switch (int.Parse(Console.ReadLine()))
            //    {
            //        case 1:
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine("Ingrese dinero:");
            //            persona1.Ingresar(float.Parse(Console.ReadLine()));
            //            Console.Clear();
            //            break;
            //        case 2:
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine("Retire dinero:");
            //            persona1.Retirar(float.Parse(Console.ReadLine()));
            //            Console.Clear();
            //            break;
            //        case 3:
            //           flag = false;
            //            break;
            //        default:
            //            Console.Clear();
            //            Console.WriteLine("Opcion incorrecta");
            //            Console.ReadKey();
            //            Console.Clear();

            //            break;
            //    }


            //} while (flag);


            #endregion

            #region Ejercicio 4

            Empresa unaEmpresa = new Empresa("Empresa uno");
            Conductor c1 = new Conductor("pepe", new float[] { 9, 23, 12, 12, 13, 12, 12 });
            Conductor c2 = new Conductor("pipi", new float[] { 10, 24, 56, 12, 12, 12, 12 });
            Conductor c3 = new Conductor("popo", new float[] { 10, 23, 57, 12, 12, 12, 12 });
            Conductor[] lista = new Conductor[]{ c1, c2 ,c3 };

            // Empresa empresa = new Empresa(lista);

            unaEmpresa.ConductorConMasKms(lista);
            unaEmpresa.ConductorConMasKmsDia3(lista);
            unaEmpresa.ConductorConMasKmsDia5(lista);







            #endregion



        }
    }
}
