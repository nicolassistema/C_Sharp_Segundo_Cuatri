using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        #region "Atributos"
        string usuario;
        string password;
        EPerfilUsuario perfilUsuario;
        #endregion

        #region "Constructores"
        public Usuario() : base()
        {

        }

        public Usuario(string cuit, string nombre, string apellido, string usuario, string password, EPerfilUsuario perfilUsuario) : base(cuit, nombre, apellido)
        {
            this.usuario = usuario;
            this.password = password;
            this.perfilUsuario = perfilUsuario;
        }
        #endregion


        #region "Propiedades"
        public string NameUsuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }


        public string PassUsuario
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }


        public EPerfilUsuario PerfilUsuario
        {
            get
            {
                return this.perfilUsuario;
            }
            set
            {
                this.perfilUsuario = value;
            }
        }


        #endregion


        #region "Enumerados"
        public enum EPerfilUsuario
        {
            Admin,
            Empleado
        }
        #endregion


        #region "Operadores"
        public static List<Usuario> operator +(List<Usuario> usuarios, Usuario usuario)
        {
            if (usuarios != usuario)
            {
                PetShop.Usuario.Add(usuario);
                return PetShop.Usuario;
            }
            else
                return PetShop.Usuario;
        }

        public static List<Usuario> operator -(List<Usuario> usuarios, Usuario usuario)
        {

            if (usuarios == usuario)
            {
                PetShop.Usuario.Remove(usuario);
                return PetShop.Usuario;
            }
            else
                return PetShop.Usuario;
        }

        public static bool operator ==(List<Usuario> usuarios, Usuario usuario)
        {
            foreach (Usuario auxUsuarios in PetShop.Usuario)
            {
                if (usuario == auxUsuarios)
                    return true;
            }

            return false;
        }

        public static bool operator !=(List<Usuario> usuarios, Usuario usuario)
        {
            return !(usuarios == usuario);
        }
        #endregion

        #region "Utils"

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Apellido} {this.Nombre} {this.perfilUsuario}");
            return sb.ToString();
        }

        public static bool IsAdmin(Usuario usuario)
        {
            if (usuario.PerfilUsuario == EPerfilUsuario.Admin)
            {
                return true;
            }
            return false;
        }

        public static EPerfilUsuario StringToPerfil(string perfil)
        {
            if (EPerfilUsuario.Admin.ToString() == perfil)
            {
                return EPerfilUsuario.Admin;
            }
            return EPerfilUsuario.Empleado;
        }






        #endregion

    }
}
