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





        public static bool ValidateNumber(string number)
        {
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            number = number.Trim();
            number = number.Replace("-", string.Empty);

            if (number.Length != 11)
                return false;

            return ValidaCuit(number);
        }

        /// <summary>
        /// Compute the last digit´s CUIL
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns></returns>
        public static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;
            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        public static  bool ValidaCuit(string cuit)
        {
            if (cuit == null)
            {
                return false;
            }
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }





        public static bool ValidacionString(string nombre)
        {
            char[] arr;
            arr = nombre.ToCharArray();
            if (!(string.IsNullOrWhiteSpace(nombre)))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((arr[i] < 65 || arr[i] > 90) && (arr[i] < 97 || arr[i] > 122) && (arr[i] < 48 || arr[i] > 57))
                    {
                        return false;

                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }




    }


}
