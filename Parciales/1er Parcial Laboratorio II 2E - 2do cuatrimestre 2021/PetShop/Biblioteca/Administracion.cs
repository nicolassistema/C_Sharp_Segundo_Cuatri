using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Administracion
    {

        private static List<Empleado> listaEmpleados;
        private static List<Productos> listaProductos;


        static Administracion()
        {
            listaEmpleados = new List<Empleado>();
            listaEmpleados = Administracion.HardcodeoEmpleados();
            listaProductos = new List<Productos>();
            listaProductos = Administracion.HardcodeoProductos();
        }


        private static List<Empleado> HardcodeoEmpleados()
        {
            listaEmpleados.Add(new Usuario("Nicolas", "Letticugna", "32320510", 35, "pepe", "123"));
            listaEmpleados.Add(new Usuario("Pedro", "Gomez", "32320511", 25, "pipo", "123"));
            listaEmpleados.Add(new Usuario("Juan", "Lopez", "32320512", 30, "pupu", "123"));
            return listaEmpleados;
        }


        private static List<Productos> HardcodeoProductos()
        {
            listaProductos.Add(new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.30, Camas.ETamanio.Grande));
            listaProductos.Add(new Camas(2, "Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.30, Camas.ETamanio.Chico));
            listaProductos.Add(new Juguetes(3, "Marca pepito", "juguete  lalala", "juguete grande descripcion", 35, 12.30, Juguetes.EMaterial.Plastico));
            listaProductos.Add(new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 35, 12.30, Juguetes.EMaterial.Goma));
            listaProductos.Add(new Alimentos(5, "Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 35, 12.30, Alimentos.ETipoAlimento.Natural));
            listaProductos.Add(new Alimentos(6, "Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 35, 12.30, Alimentos.ETipoAlimento.Balanceado));
            listaProductos.Add(new ArtCuidadoMascotas(7, "Marca pepito", "Farmacia  lalala", "farmacia grande descripcion", 35, 12.30, ArtCuidadoMascotas.ETipoCuidado.Farmacia));
            listaProductos.Add(new ArtCuidadoMascotas(8, "Marca pepito", "Farmacia  lalala", "Limpieza grande descripcion", 35, 12.30, ArtCuidadoMascotas.ETipoCuidado.Limpieza));
            return listaProductos;
        }



        //Usuario usuario1 = new Usuario("Nicolas", "Letticugna", "32320510", 35, "pepe", "123");
        //Usuario usuario2 = new Usuario("Pedro", "Gomez", "32320511", 25, "pipo", "123");
        //Usuario usuario3 = new Usuario("Juan", "Lopez", "32320512", 30, "pupu", "123");


        //List<Empleado> listaEmpleados = new List<Empleado>();

        //listaE

        //List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();


        //listaEmpleados.Add(usuario1);



    }
}
