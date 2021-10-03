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
    public partial class FormAltaCliente : Form
    {

        Usuario userForm;

        public FormAltaCliente()
        {
            InitializeComponent();
        }


        public FormAltaCliente(Usuario usuario) : this()
        {
            this.userForm = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cancelar el alta del Cliente?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                this.Hide();
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            lblMensaje.Text = "";
            StringBuilder sb = new StringBuilder();
            List<Cliente> lista = new List<Cliente>();

            if (Validaciones.ValidateNumber(txtCuit.Text))
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
             //   lblCuit.ForeColor = Color.Green;
               // lblMensaje.Text = "Cuit Correcto";
            }


            if (Validaciones.ValidacionString(txtNombre.Text))
            {
                sb.AppendLine("*Formato de nombre incorrecto");
                lblMensaje.ForeColor = Color.Red;
                // lblMensaje.Text = "Formato de nombre incorrecto";
                lblMensaje.Visible = true;
            }
            else
            {
             //   lblMensaje.Visible = true;
              //  lblMensaje.ForeColor = Color.Green;
              //  lblMensaje.Text = "formato nombre correcto";
            }

            if (Validaciones.ValidacionString(txtApellido.Text))
            {
                sb.AppendLine("*Formato de apellido incorrecto");
                lblMensaje.ForeColor = Color.Red;
                // lblMensaje.Text = "Formato de nombre incorrecto";
                lblMensaje.Visible = true;
            }
            else
            {
             //   lblMensaje.Visible = true;
               // lblMensaje.ForeColor = Color.Green;
                //   lblMensaje.Text = "formato apellido correcto";
            }


          

            cliente = new Cliente(txtCuit.Text, txtNombre.Text, txtApellido.Text, 0);
            PetShop.AddCliente(cliente);

            this.Hide();
            this.Close();

        }
    }
}
