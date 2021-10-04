using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region "Atributos"
        private int idCliente;
        private double saldo;
        #endregion

        #region "Constructores"
        public Cliente() : base()
        {


        }

        public Cliente(string cuit, string nombre, string apellido, double saldo) : base(cuit, nombre, apellido)
        {
            this.idCliente = IdAutoIncremental();
            this.saldo = saldo;
        }
        #endregion

        #region "Propiedades"
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }


        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }
        #endregion

        #region "Enumerados"
        public enum ETipoPago
        {
            MercadoPago,
            Efectivo,
            TarjetaDebito
        }
        #endregion

        #region "Operadores"

        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente)
        {
            if (clientes != cliente)
            {
                PetShop.Cliente.Add(cliente);
                return PetShop.Cliente;
            }
            else
                return PetShop.Cliente;
        }

        public static List<Cliente> operator -(List<Cliente> clientes, Cliente cliente)
        {

            if (clientes == cliente)
            {
                PetShop.Cliente.Remove(cliente);
                return PetShop.Cliente;
            }
            else
                return PetShop.Cliente;
        }

        public static bool operator ==(List<Cliente> clientes, Cliente cliente)
        {
            foreach (Cliente auxCliente in PetShop.Cliente)
            {
                if (cliente == auxCliente)
                    return true;
            }

            return false;
        }

        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }

        #endregion

        #region "Utils"
        /// <summary>
        /// Muestra la informacion del cliente
        /// </summary>
        /// <returns>Devuelve un mensaje</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Muestra la informacion del cliente
        /// </summary>
        /// <returns>Devuelve un mensaje</returns>
        public string Mostrar()
        {
            return ToString();
        }

        /// <summary>
        /// Genera un id autoIncremental
        /// </summary>
        /// <returns>Devuelve el id autoincrementedo</returns>
        public int IdAutoIncremental()
        {
            for (int i = 0; i <= PetShop.ObtenerListaCliente().Count; i++)
            {
                IdCliente = i + 1;
            }
            return IdCliente;
        }
        #endregion
    }
}
