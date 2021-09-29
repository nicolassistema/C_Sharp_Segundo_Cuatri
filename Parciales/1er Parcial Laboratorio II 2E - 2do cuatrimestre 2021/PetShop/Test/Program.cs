using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Camas unaCama = new Camas(1,"lalal","lalala","llala", 2,2.23, Camas.ETamanio.Grande);
            Cliente unCliente =  new Cliente("menagno", "lopez", "32320600", Entidades.Cliente.ETipoPago.Efectivo, 250,
                new List<Productos>()
                {
                    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                }
                );


            Console.WriteLine(unaCama.ToString());


            Console.WriteLine(unCliente.ToString());



    

            

        }
    }
}
