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
    public partial class frmLogin : Form
    {

        Usuario userForm;

        public frmLogin()
        {
            InitializeComponent();
            this.userForm = new Usuario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            label3.Text = Validaciones.SalidaMensajeValidacion(txtUser.Text, txtPass.Text);
            if (label3.Text == "Bienvenido!")
            {
                label3.ForeColor = Color.Green;
                this.userForm = PetShop.ObtenerUsuario(txtUser.Text, txtPass.Text);
                if (!(this.userForm is null))
                {
                    frmAdministracion administracion = new frmAdministracion(this.userForm);
                    this.Hide();
                    administracion.ShowDialog();
                    this.Close();
                }
                else
                {
                    label3.Text = "Usuario no registrado";
                }
            }
            else
            {
                label3.ForeColor = Color.Red;
            }
            label3.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (boton == DialogResult.Yes)
            {
                Dispose();
            }
        }

    }
}
