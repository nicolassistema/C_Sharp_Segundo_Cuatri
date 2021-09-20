using System;

namespace Biblioteca
{
    public class Productos
    {
        #region "Atributos"
        private int codigo;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private double precio;
        #endregion

        #region "Constructores"
        public Productos(int codigo, string nombre, string descripcion, int cantidad, double precio)
        {
            this.codigo = codigo;
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



    }
}
