using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        #region "Atributos"
        private int codigo;
        private string marca;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private double precio;
        #endregion

        #region "Constructores"
        public Productos(int codigo, string marca, string nombre, string descripcion, int cantidad, double precio)
        {
            this.codigo = codigo;
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

        #region "Utils"
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.codigo} | {this.marca} | {this.nombre} | {this.cantidad} | {this.precio}");

            return sb.ToString();
        }
        #endregion

    }
}
