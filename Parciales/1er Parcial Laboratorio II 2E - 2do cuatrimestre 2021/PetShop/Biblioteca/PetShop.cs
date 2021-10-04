using System.Collections.Generic;

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
            listaUsuarios += (new Usuario("20323205109", "Nicolas", "Letticugna", "pepe", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuarios += (new Usuario("20323205109", "Nicolas", "Letticugna", "pepe", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuarios += (new Usuario("20323205117", "Pedro", "Gomez", "pipo", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuarios += (new Usuario("20323205125", "lolo", "Lopez", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin));
            listaUsuarios += (new Usuario("20323205133", "Juan", "Lopez", "pupu", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
        }

        private static void HardcodProductos()
        {
            listaProductos += (new Cama("Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.78, Cama.ETamanio.Grande));
            listaProductos += (new Cama("Marca pepito", "Cama lalala", "Cama grande descripcion", 35, 12.50, Cama.ETamanio.Chico));
            listaProductos += (new Juguete("Marca pepito", "juguete  lalala", "juguete grande descripcion", 35, 12.12, Juguete.EMaterial.Plastico));
            listaProductos += (new Juguete("Marca pepito", "juguete lalala", "juguete grande descripcion", 35, 12.14, Juguete.EMaterial.Goma));
            listaProductos += (new Alimento("Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 0, 12.98, Alimento.ETipoAlimento.Natural));
            listaProductos += (new Alimento("Marca pepito", "Alimento  lalala", "Alimento grande descripcion", 0, 12.36, Alimento.ETipoAlimento.Balanceado));
            listaProductos += (new ArtCuidadoMascota("Marca pepito", "Farmacia  lalala", "farmacia grande descripcion", 35, 12.85, ArtCuidadoMascota.ETipoCuidado.Farmacia));
            listaProductos += (new ArtCuidadoMascota("Marca pepito", "Farmacia  lalala", "Limpieza grande descripcion", 35, 12.05, ArtCuidadoMascota.ETipoCuidado.Limpieza));
        }


        private static void HardcodClientes()
        {
            listaClientes += (new Cliente("20323206008", "menagno", "lopez", 0));
            listaClientes += (new Cliente("20323206016", "sultano", "lopez", 0));
            listaClientes += (new Cliente("20323205109", "Fernando", "Talarga", 0));
            listaClientes += (new Cliente("20323206059", "fefe", "lopez", 0));
        }


        private static void HardcodVentas()
        {
            listaVentas += (new Venta(listaUsuarios[0], listaClientes[0],listaProductos));
            listaVentas += (new Venta(listaUsuarios[0], listaClientes[0],listaProductos));
            listaVentas += (new Venta(listaUsuarios[0], listaClientes[0],listaProductos));
            listaVentas += (new Venta(listaUsuarios[0], listaClientes[0],listaProductos));
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
            return null;
        }

        public static Producto ObtenerProductoByID(int id)
        {
            List<Producto> auxList = PetShop.Producto;
            foreach (var item in auxList)
            {
                if (item.Codigo == id)
                {
                    return item;
                }
            }
            return null;
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
                LimpiarListaClientes();
                foreach (var item in listaClienteAux)
                {
                    AddCliente(item);
                }
                return ObtenerListaCliente();
            }
            return null;
        }

        public static bool BuscarClientePorString(Cliente cliente, string palabra)
        {
            if (cliente.IdCliente.ToString().Contains(palabra) ||
                cliente.Cuit.ToString().Contains(palabra) ||
                cliente.Nombre.ToLower().Contains(palabra) ||
                cliente.Apellido.ToLower().Contains(palabra))
            {
                return true;
            }
            return false;
        }

    }
}
