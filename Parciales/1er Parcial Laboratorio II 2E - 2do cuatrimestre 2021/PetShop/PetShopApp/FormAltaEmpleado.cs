using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShopApp
{
    public partial class frmAltaEmpleado : Form
    {
        Usuario userForm;

        public frmAltaEmpleado()
        {
            InitializeComponent();
        }



        public frmAltaEmpleado(Usuario usuario) : this()
        {
            this.userForm = usuario;

            //   lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cancelar el alta de empleado?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                this.Hide();
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            lblMensaje.Text = "";
            StringBuilder sb = new StringBuilder();
            List<Usuario> lista = new List<Usuario>();


            if (!(Validaciones.ValidateNumber(txtCuit.Text)))
            {
                sb.AppendLine("*Cuit Incorrecto");
                // validaciones.Add("Cuit Incorrecto");
                lblMensaje.ForeColor = Color.Red;
                //  lblCuit.Text = "Cuit Incorrecto";
                lblMensaje.Visible = true;
            }
            else
            {
                lblMensaje.Visible = true;
                lblCuit.ForeColor = Color.Green;
                lblMensaje.Text = "Cuit Correcto";
            }


            if (!(Validaciones.ValidacionString(txtNombre.Text)))
            {
                sb.AppendLine("*Formato de nombre incorrecto");
                lblMensaje.ForeColor = Color.Red;
                // lblMensaje.Text = "Formato de nombre incorrecto";
                lblMensaje.Visible = true;
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "formato nombre correcto";
            }

            if (!(Validaciones.ValidacionString(txtApellido.Text)))
            {
                sb.AppendLine("*Formato de apellido incorrecto");
                lblMensaje.ForeColor = Color.Red;
                // lblMensaje.Text = "Formato de nombre incorrecto";
                lblMensaje.Visible = true;
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Green;
                //   lblMensaje.Text = "formato apellido correcto";
            }


            //Agregar Validacion para usuario y pasword
            //txtPassword.Text;
            //txtUsuario.Text;


            if (string.IsNullOrWhiteSpace(cmbPerfil.Text.ToString()))
            {
                sb.AppendLine("*Seleccionar un perfil");
            }

            usuario = new Usuario(txtCuit.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtPassword.Text, Entidades.Usuario.EPerfilUsuario.Admin);
            PetShop.AddUsuario(usuario);

            this.Hide();
            this.Close();
        }

















    }
}
