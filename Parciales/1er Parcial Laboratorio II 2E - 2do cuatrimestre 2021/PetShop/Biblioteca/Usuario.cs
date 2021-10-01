﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        #region "Atributos"
        private string usuario;
        private string password;
        private EPerfilUsuario perfilUsuario;
        #endregion

        #region "Constructores"
        public Usuario() : base()
        {

        }

        public Usuario(string nombre, string apellido, string cuit, string usuario, string password, EPerfilUsuario perfilUsuario) : base(nombre, apellido, cuit)
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


        #region "Utils"

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Apellido} | {this.Nombre} | {this.perfilUsuario}");
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



        #endregion

    }
}