using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_poo_01
{
    public class Empresa
    {
        public string nombreEmpresa;
        public Conductor[] conductores;


        public Empresa(string nombreEmpresa)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.conductores = new Conductor[3];
        }

        //public Empresa(Conductor[] conductor)
        //{
        //    this.conductor = conductor;
        //}





        public void ConductorConMasKms(Conductor[] conductores)
        {
            float suma;
            float acum = 0;
            Conductor maxConductor = null;
            bool flag = true;
            for (int i = 0; i < conductores.Length; i++)
            {
                suma = 0;
                for (int j = 0; j < conductores[i].kms.Length; j++)
                {
                    suma += conductores[i].kms[j];
                }

                if (suma > acum || flag)
                {
                    acum = suma;
                    maxConductor = null;
                    maxConductor = conductores[i];
                    flag = false;
                }
            }

            Console.WriteLine("el condcutor que mas hizo kms en la semana es :" + maxConductor.nombre);
        }

        public void ConductorConMasKmsDia3(Conductor[] conductores)
        {
            float suma;
            float acum = 0;
            Conductor maxConductor = null;
            bool flag = true;
            for (int i = 0; i < conductores.Length; i++)
            {
                suma = 0;
                for (int j = 0; j < conductores[i].kms.Length; j++)
                {
                    if (j == 2)
                    {
                        suma += conductores[i].kms[j];
                        break;
                    }

                }

                if (suma > acum || flag)
                {
                    acum = suma;
                    maxConductor = null;
                    maxConductor = conductores[i];
                    flag = false;
                }
            }

            Console.WriteLine("el condcutor que mas hizo kms el terecer dia  la semana es :" + maxConductor.nombre);

        }

        public void ConductorConMasKmsDia5(Conductor[] conductores)
        {
            float suma;
            float acum = 0;
            Conductor maxConductor = null;
            bool flag = true;
            for (int i = 0; i < conductores.Length; i++)
            {
                suma = 0;
                for (int j = 0; j < conductores[i].kms.Length; j++)
                {
                    if (j == 4)
                    {
                        suma += conductores[i].kms[j];
                        break;
                    }
                }
                if (suma > acum || flag)
                {
                    acum = suma;
                    maxConductor = null;
                    maxConductor = conductores[i];
                    flag = false;
                }
            }

            Console.WriteLine("el condcutor que mas hizo kms el quinto dia  la semana es :" + maxConductor.nombre);

        }

        public void CargarConductor(Conductor conductor)
        {
          for (int i = 0; i < this.conductores.Length; i++)
            {
                if (conductores[i] != null)
                {
                    conductores[i] = conductor;
                }
            }
        }



    }
}
