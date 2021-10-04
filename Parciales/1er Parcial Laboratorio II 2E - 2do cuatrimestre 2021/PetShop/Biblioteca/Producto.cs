using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region "Atributos"
        int codigo;
        string marca;
        string nombre;
        string descripcion;
        int cantidad;
        double precio;
        #endregion

        #region "Constructores"


        public Producto()
        {
        }

        public Producto(string marca, string nombre, string descripcion, int cantidad, double precio) : this()
        {
            this.codigo = IdAutoIncremental();
            this.marca = marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;

        }
        #endregion

        #region "Propiedades"


        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }


        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }


        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        #endregion

        #region "Operadores"


        public static bool operator ==(List<Producto> productos, Producto producto)
        {
            foreach (Producto productoAux in PetShop.Producto)
            {
                if (producto == productoAux)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }

        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            if (productos != producto)
            {
                PetShop.Producto.Add(producto);
                return PetShop.Producto;
            }
            else
            {
                return PetShop.Producto;
            }

        }

        public static List<Producto> operator -(List<Producto> productos, Producto producto)
        {
            if (productos == producto)
            {
                PetShop.Producto.Remove(producto);
                return PetShop.Producto;
            }
            else
            {
                return PetShop.Producto;
            }
        }

        #endregion

        #region "Utils"
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.codigo} | {this.marca} | {this.nombre} | {this.cantidad} | {this.precio}");

            return sb.ToString();
        }




        public int IdAutoIncremental()
        {
            for (int i = 0; i <= PetShop.ObtenerPorductos().Count; i++)
            {
                codigo = i + 1;
            }
            return codigo;
        }





        #endregion

    }
}
