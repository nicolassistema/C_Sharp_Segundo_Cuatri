using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_01
{
    public class Conductor
    {


        public string nombre;
        public float[] kms;


        public Conductor(string nombre)
        {
            this.nombre = nombre;
            kms = new float[7];

            for (int i = 0; i < this.kms.Length; i++)
            {
                this.kms[i] = -1;
            }
        }


        public Conductor(string nombre, float[] kms)
        {
            this.nombre = nombre;
            this.kms = kms;
        }



        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public float[] GetKms()
        {
            return this.kms;
        }




      




    }
}
