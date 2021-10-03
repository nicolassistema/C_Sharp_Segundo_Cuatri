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




        static PetShop()
        {
            Usuario = new List<Usuario>();
            Producto = new List<Productos>();
            Cliente = new List<Cliente>();
            Ventas = new List<Ventas>();
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



        public static void Test()
        {
            double precio = Ventas[0];

        }

        private static void HardcodUsuarios()
        {
            listaUsuarios.Add(new Empleado("20323205109", "Nicolas", "Letticugna", "pepe", "123", Empleado.EPerfilUsuario.Empleado));
            listaUsuarios.Add(new Empleado("20323205117", "Pedro", "Gomez", "pipo", "123", Empleado.EPerfilUsuario.Empleado));
            listaUsuarios.Add(new Administrador("20323205125", "lolo", "Lopez", "admin", "admin", Administrador.EPerfilUsuario.Admin));
            listaUsuarios.Add(new Empleado("20323205133", "Juan", "Lopez", "pupu", "123", Empleado.EPerfilUsuario.Empleado));


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



        public static List<Productos> ObtenerPorductos()
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
