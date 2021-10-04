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
    public partial class frmVenta : Form
    {
        Usuario userForm;

        public frmVenta()
        {
            InitializeComponent();
        }


        public frmVenta(Usuario usuario) : this()
        {
            this.userForm = usuario;
            // MessageBox.Show(this.userForm.ToString());

            //mapear "Bienvenido con el el nombre del usuario"
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            //agregar validaciones de visualizacion por perfil

            CargarLisBox();
        }



        public void CargarLisBox()
        {
            lstProductos.Refresh();
            lstProductos.DataSource = null;
            int i = 0;

           
                
               
            foreach (var item in PetShop.ObtenerPorductos())
            {

                lstProductos.Items.Add(item);
            }
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

        private void lblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Dese Volver a la pantalla principal", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                frmAdministracion administracion = new frmAdministracion(this.userForm);
                this.Hide();
                administracion.ShowDialog();
                this.Close();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = new List<Cliente>();
            lista = PetShop.ObtenerListaCliente();

            if (!(Validaciones.ValidateNumber(txtCuit.Text)))
            {
                //  lblMensajeCliente.ForeColor = Color.Red;
                lblMensajeCliente.Text = "Cuit Incorrecto";
                lblMensajeCliente.Visible = true;

                lblCuit.Visible = false;
                lblNombre.Visible = false;
                lblApellido.Visible = false;

            }
            else
            {
                foreach (var item in lista)
                {
                    if (item.Cuit.ToString() == txtCuit.Text)
                    {
                        if (PetShop.BuscarClientePorString(item, txtCuit.Text.ToLower()))
                        {
                            lblMensajeCliente.Visible = false;
                            lblCuit.Text = item.Cuit.ToString();
                            lblCuit.Visible = true;
                            lblNombre.Text = item.Nombre.ToString();
                            lblNombre.Visible = true;
                            lblApellido.Text = item.Apellido.ToString();
                            lblApellido.Visible = true;
                        }
                    }
                }
            }




        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string curItem = lstProductos.SelectedItem.ToString();
            lstProductoSeleccionado.Items.Add(curItem);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            lstProductoSeleccionado.Items.Remove(lstProductoSeleccionado.SelectedItem);
        }
    }
}
