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
    public partial class frmAdministracion : Form
    {
        Usuario userForm;
        public frmAdministracion()
        {
            InitializeComponent();
        }

        public frmAdministracion(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblBienvenido.Text = "Bienvenido: " + usuario.Nombre +" "+ usuario.Apellido;
            if (!(Usuario.IsAdmin(userForm)))
            {
                btnEmpleados.Visible = false;
                btnFacturacion.Visible = false;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(this.userForm);
            this.Hide();
            venta.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente venta = new frmCliente(this.userForm);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleado venta = new FormEmpleado(this.userForm);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion venta = new frmFacturacion(this.userForm);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }

        private void lblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Dese cerrar session?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}