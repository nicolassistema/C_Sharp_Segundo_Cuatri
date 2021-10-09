using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class PetShop
    {
        static List<Usuario> listaUsuarios;
        static List<Producto> listaProductos;
        static List<Cliente> listaClientes;
        public static List<Venta> listaVentas;
        public static List<Facturacion> listaFacturas;
        static Usuario usuario;

        static PetShop()
        {
            Usuario = new List<Usuario>();
            Producto = new List<Producto>();
            Cliente = new List<Cliente>();
            Ventas = new List<Venta>();
            usuario = new Usuario();
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
            listaProductos += (new Cama("Cama pepito           ", "Cama lalala", "Cama grande descripcion", 35, 11.11, Cama.ETamanio.Grande));
            listaProductos += (new Cama("Cama  pepito          ", "Cama lalala", "Cama grande descripcion", 35, 22.22, Cama.ETamanio.Chico));
            listaProductos += (new Juguete("juguete pepito        ", "juguete  lalala", "juguete grande descripcion", 35, 33.33, Juguete.EMaterial.Plastico));
            listaProductos += (new Juguete("juguete pepito        ", "juguete lalala", "juguete grande descripcion", 35, 44.44, Juguete.EMaterial.Goma));
            listaProductos += (new Alimento("Alimento pepito       ", "Alimento  lalala", "Alimento grande descripcion", 35, 55.55, Alimento.ETipoAlimento.Natural));
            listaProductos += (new Alimento("Alimento pepito       ", "Alimento  lalala", "Alimento grande descripcion", 35, 66.66, Alimento.ETipoAlimento.Balanceado));
            listaProductos += (new ArtCuidadoMascota("Farmacia pepito       ", "Farmacia  lalala", "farmacia grande descripcion", 35, 77.77, ArtCuidadoMascota.ETipoCuidado.Farmacia));
            listaProductos += (new ArtCuidadoMascota("Farmacia pepito      ", "Farmacia  lalala", "Limpieza grande descripcion", 35, 88.0588, ArtCuidadoMascota.ETipoCuidado.Limpieza));
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
            Producto prod1 = new Producto(1, "Dog Chow", "Dog Chow", 4000);

            listaVentas += (new Venta(new Usuario("123456789", "Lucas", "Rodriguez", "lrodriguez", "lucas2021", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "Lucas", "Rodriguez", "lrodriguez", "lucas2021", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "Lucas", "Rodriguez", "lrodriguez", "lucas2021", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "Lucas", "Rodriguez", "lrodriguez", "lucas2021", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
        }




        public static List<Venta> ObtenerListaVentas()
        {
            return listaVentas;
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
