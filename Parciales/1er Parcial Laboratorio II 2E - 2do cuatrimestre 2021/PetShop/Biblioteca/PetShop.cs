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
        static List<Producto> listaProductos;
        static List<Cliente> listaClientes;
        static List<Venta> listaVentas;




        static PetShop()
        {
            Usuario = new List<Usuario>();
            Producto = new List<Producto>();
            Cliente = new List<Cliente>();
            Ventas = new List<Venta>();
            HarcodearListas();
        }


        public static void HarcodearListas()
        {
            HardcodUsuarios();
            HardcodProductos();
            HardcodClientes();
            HardcodVentas();
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

        public static List<Producto> Producto
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

        public static List<Venta> Ventas
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



    

        private static void HardcodUsuarios()//diccionario
        {
            listaUsuarios.Add(new Usuario("20323205109", "Nicolas", "Letticugna", "pepe", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuarios.Add(new Usuario("20323205117", "Pedro", "Gomez", "pipo", "123",Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuarios.Add(new Usuario("20323205125", "lolo", "Lopez", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin));
            listaUsuarios.Add(new Usuario("20323205133", "Juan", "Lopez", "pupu", "123", Entidades.Usuario.EPerfilUsuario.Empleado));


        }

        public static List<Cliente> ObtenerListaCliente()
        {
            return listaClientes;
        }

        public static void AddCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);

        }



        public static List<Usuario> ObtenerListaUsuarios()
        {
            return listaUsuarios;
        }


        public static void AddUsuario(Usuario usuario)
        {
            listaUsuarios.Add(usuario);

        }


        private static void HardcodProductos()
        {
            listaProductos.Add(new Cama("Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.30, Cama.ETamanio.Grande));
            listaProductos.Add(new Cama( "Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.30, Cama.ETamanio.Chico));
            listaProductos.Add(new Juguete( "Marca pepito", "juguete  lalala", "juguete grande descripcion", 35, 12.30, Juguete.EMaterial.Plastico));
            listaProductos.Add(new Juguete( "Marca pepito", "juguete lalala", "juguete grande descripcion", 35, 12.30, Juguete.EMaterial.Goma));
            listaProductos.Add(new Alimento( "Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 0, 12.30, Alimento.ETipoAlimento.Natural));
            listaProductos.Add(new Alimento( "Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 0, 12.30, Alimento.ETipoAlimento.Balanceado));
            listaProductos.Add(new ArtCuidadoMascota( "Marca pepito", "Farmacia  lalala", "farmacia grande descripcion", 35, 12.30, ArtCuidadoMascota.ETipoCuidado.Farmacia));
            listaProductos.Add(new ArtCuidadoMascota("Marca pepito", "Farmacia  lalala", "Limpieza grande descripcion", 35, 12.30, ArtCuidadoMascota.ETipoCuidado.Limpieza));

        }


        private static void HardcodClientes()
        {
            listaClientes.Add(new Cliente("20323206008", "menagno", "lopez",  250
                //new List<Productos>()
                //{
                //    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                //    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                //}
                ));

            listaClientes.Add(new Cliente("20323206016", "sultano", "lopez",  250
                //  new List<Productos>()
                //{
                //    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                //    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                //}
                ));
            listaClientes.Add(new Cliente("20323205109", "lolo", "lopez",  250
                //     new List<Productos>()
                //{
                //    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                //    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                //}
                ));
            listaClientes.Add(new Cliente("20323206059", "fefe", "lopez",  250
                //         new List<Productos>()
                //{
                //    new Camas(1, "Marca pepito", "Cama lalala", "Cama grande descripcion", 1, 12.30, Camas.ETamanio.Grande),
                //    new Juguetes(4, "Marca pepito", "juguete lalala", "juguete grande descripcion", 1, 12.30, Juguetes.EMaterial.Goma)
                //}
                ));

        }


        private static void HardcodVentas()
        {
            //listaVentas.Add(new Venta(listaClientes[1], 300));
            //listaVentas.Add(new Venta(listaClientes[2], 300));
            //listaVentas.Add(new Venta(listaClientes[3], 300));
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



        public static List<Producto> ObtenerPorductos()
        {
            return listaProductos;
        }


        public static bool EliminarUsuario(Usuario usuario)
        {
            List<Usuario> auxList = PetShop.Usuario;
            foreach (var item in auxList)
            {
                if (item == usuario)
                {
                    auxList.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public static void LimpiarListaUsarios()
        {
            listaUsuarios.Clear();
        }


        public static void LimpiarListaClientes()
        {
            listaClientes.Clear();
        }





        public static List<Usuario> CargarListaNuevamente(List<Usuario> listaUsuariosAux)
        {
            if (!(listaUsuariosAux is null))
            {
                //List<Usuario> auxList = ObtenerListaUsuarios();
                LimpiarListaUsarios();

                foreach (var item in listaUsuariosAux)
                {
                    AddUsuario(item);
                }
                return ObtenerListaUsuarios();
            }
            return null;
        }


        public static List<Cliente> CargarListaNuevamenteClientes(List<Cliente> listaClienteAux)
        {
            if (!(listaClienteAux is null))
            {
                //List<Usuario> auxList = ObtenerListaUsuarios();
                LimpiarListaClientes();

                foreach (var item in listaClienteAux)
                {
                    AddCliente(item);
                }
                return ObtenerListaCliente();
            }
            return null;
        }

        public static  bool BuscarClientePorString(Cliente cliente, string palabra)
        {
            if (
                cliente.IdCliente.ToString().Contains(palabra) ||
                cliente.Cuit.ToString().Contains(palabra) ||
                cliente.Nombre.ToLower().Contains(palabra) ||
                cliente.Apellido.ToLower().Contains(palabra)
                )
            {
                return true;
            }
            return false;
        }

    }
}
