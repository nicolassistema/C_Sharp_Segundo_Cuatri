using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Validaciones
    {

        private static List<Usuario> acceso;


        static Validaciones()
        {
            acceso = PetShop.Usuario;
        }



        public static string SalidaMensajeValidacion(string usuario, string password)
        {

            if (!(acceso is null) && !(string.IsNullOrWhiteSpace(usuario)) && !(string.IsNullOrWhiteSpace(password)))
            {
                if (ValidacionUser(usuario))
                {
                    if (ValidacionPassword(password))
                    {
                        return "Bienvenido!";
                    }
                    else
                    {
                        return "Password Incorrecto!";
                    }
                }
                else
                {
                    return "Usuario Inexistente";
                }
            }
            return "Error al ingresar usuario y/o password";
        }



        public static bool ValidacionUser(string usuario)
        {
            foreach (var item in acceso)
            {
                if (item.NameUsuario == usuario)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool ValidacionPassword(string password)
        {
            foreach (var item in acceso)
            {
                if (item.PassUsuario == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
