using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PetShop
    {

        static List<Usuario> listaUsuarios;
        static List<Productos> listaProductos;
        static List<Cliente> listaClientes;
        static List<Ventas> listaVentas;

        public static void HarcodearListas()
        {
            HardcodUsuarios();
            HardcodProductos();
            HardcodClientes();
            HardcodVentas();
        }


        static PetShop()
        {
            Usuario = new List<Usuario>();
            Producto = new List<Productos>();
            Cliente = new List<Cliente>();
            Ventas = new List<Ventas>();
            HarcodearListas();
        }

        public static List<Usuario> Usuario
        {
            get
            {
                return listaUsuarios;
            }
            set
            {
                listaUsuarios = value;
            }
        }

        public static List<Productos> Producto
        {
            get
            {
                return listaProductos;
            }
            set
            {
                listaProductos = value;
            }
        }

        public static List<Cliente> Cliente
        {
            get
            {
                return listaClientes;
            }
            set
            {
                listaClientes = value;
            }
        }

        public static List<Ventas> Ventas
        {
            get
            {
                return listaVentas;
            }
            set
            {
                listaVentas = value;
            }
        }



        private static void HardcodUsuarios()
        {
            listaUsuarios.Add(new Empleado("Nicolas", "Letticugna", "32320510", "pepe", "123", Empleado.EPerfilUsuario.Empleado));
            listaUsuarios.Add(new Empleado("Pedro", "Gomez", "32320511", "pipo", "123", Empleado.EPerfilUsuario.Empleado));
            listaUsuarios.Add(new Empleado("Juan", "Lopez", "32320512", "pupu", "123", Empleado.EPerfilUsuario.Empleado));
            listaUsuarios.Add(new Administrador("lolo", "Lopez", "32320513", "admin", "admin", Administrador.EPerfilUsuario.Admin));
            
        }


        private static void HardcodProductos()
        {
            listaProductos.Add(new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.30, Camas.ETamanio.Grande));
            listaProductos.Add(new Camas(2, "Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.30, Camas.ETamanio.Chico));
            listaProductos.Add(new Juguetes(3, "Marca pepito", "juguete  lalala", "juguete grande descripcion", 35, 12.30, Juguetes.EMaterial.Plastico));
            listaProductos.Add(new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 35, 12.30, Juguetes.EMaterial.Goma));
            listaProductos.Add(new Alimentos(5, "Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 0, 12.30, Alimentos.ETipoAlimento.Natural));
            listaProductos.Add(new Alimentos(6, "Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 0, 12.30, Alimentos.ETipoAlimento.Balanceado));
            listaProductos.Add(new ArtCuidadoMascotas(7, "Marca pepito", "Farmacia  lalala", "farmacia grande descripcion", 35, 12.30, ArtCuidadoMascotas.ETipoCuidado.Farmacia));
            listaProductos.Add(new ArtCuidadoMascotas(8, "Marca pepito", "Farmacia  lalala", "Limpieza grande descripcion", 35, 12.30, ArtCuidadoMascotas.ETipoCuidado.Limpieza));
         
        }


        private static void HardcodClientes()
        {
            listaClientes.Add(new Cliente("menagno", "lopez", "32320600", Entidades.Cliente.ETipoPago.Efectivo, 250,
                new List<Productos>()
                {
                    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                }
                ));

            listaClientes.Add(new Cliente("sultano", "lopez", "32320601", Entidades.Cliente.ETipoPago.Efectivo, 250,
                  new List<Productos>()
                {
                    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                }
                ));
            listaClientes.Add(new Cliente("lolo", "lopez", "32320602", Entidades.Cliente.ETipoPago.Efectivo, 250,
                     new List<Productos>()
                {
                    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                }
                ));
            listaClientes.Add(new Cliente("fefe", "lopez", "32320603", Entidades.Cliente.ETipoPago.Efectivo, 250,
                         new List<Productos>()
                {
                    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                }
                ));
           
        }


        private static void HardcodVentas()
        {
            listaVentas.Add(new Ventas(listaClientes[1], 300));
            listaVentas.Add(new Ventas(listaClientes[2], 300));
            listaVentas.Add(new Ventas(listaClientes[3], 300));
        }


        public static Usuario ObtenerUsuario(string usuarioNombre, string password)
        {
            List<Usuario> auxList = PetShop.Usuario;
            foreach (var item in auxList)
            {
                if (item.NameUsuario == usuarioNombre && item.PassUsuario == password)
                {
                    return item;
                }
            }
            return null;//TODO Consultar a Lucas por que no debo devulver null  segun Dense
        }

        //public static string Mostrar()
        //{
        //    return listaVentas[1].Cliente.Apellido;
        //}


      


    }
}
