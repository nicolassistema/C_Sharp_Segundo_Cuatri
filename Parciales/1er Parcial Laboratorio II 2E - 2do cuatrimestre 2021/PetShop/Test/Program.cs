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


            //Usuario empleado =new Empleado("Nicolas", "Letticugna", "32320510", "pepe", "123", Empleado.EPerfilUsuario.Empleado);
            //Usuario admin =  new Administrador("lolo", "Lopez", "32320513", "admin", "admin", Administrador.EPerfilUsuario.Admin);

            //Camas unaCama = new Camas(1,"lalal","lalala","llala", 2,2.23, Camas.ETamanio.Grande);
            //Cliente unCliente =  new Cliente("menagno", "lopez", "32320600", Entidades.Cliente.ETipoPago.Efectivo, 250,
            //    new List<Productos>()
            //    {
            //        new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
            //        new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
            //    }
            //    );


            List<Cliente> listaCliente = new List<Cliente>()
              {

            new Cliente("menagno", "lopez", "32320600", Entidades.Cliente.ETipoPago.Efectivo, 250,
                  new List<Producto>()
                  {
                      new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Cama.ETamanio.Grande),
                      new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguete.EMaterial.Goma)
                  }),
             new Cliente("dfdfdf", "lopeuuuu", "32320600", Entidades.Cliente.ETipoPago.Efectivo, 250,
                  new List<Producto>()
                  {
                      new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Cama.ETamanio.Grande),
                      new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguete.EMaterial.Goma)
                  })


            //  };

                //      Console.WriteLine(unaCama.ToString());


                //     Console.WriteLine(unCliente.ToString());


                //if (empleado.PerfilUsuario == Usuario.EPerfilUsuario.Admin)
                //{
                //    Console.WriteLine("****************Correcto");
                //}


            foreach (var item in listaCliente)
            {
                Console.WriteLine(item.Mostrar());
            }


        }
    }
}
