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
    public partial class frmCliente : Form
    {
        Usuario userForm;

        public frmCliente()
        {
            InitializeComponent();
        }

        public frmCliente(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            CargarDataGrid();
        }



        public void CargarDataGrid()
        {
            dvgListaClientes.Refresh();
            dvgListaClientes.DataSource = null;
            int i = 0;

            dvgListaClientes.RowCount = PetShop.ObtenerListaCliente().Count;
            foreach (var item in PetShop.ObtenerListaCliente())
            {
                dvgListaClientes.Rows[i].Cells[0].Value = item.IdCliente;
                dvgListaClientes.Rows[i].Cells[0].ReadOnly = true;
                dvgListaClientes.Rows[i].Cells[1].Value = item.Cuit;
                dvgListaClientes.Rows[i].Cells[2].Value = item.Nombre;
                dvgListaClientes.Rows[i].Cells[3].Value = item.Apellido;
                i++;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dvgListaClientes.Rows.Clear();
            dvgListaClientes.DataSource = null;
            //Limpio el datagrid
            List<Cliente> lista = new List<Cliente>();
            lista = PetShop.ObtenerListaCliente();
            foreach (var item in lista)
            {
                if (BuscarPorString(item, txtBuscar.Text.ToLower()))
                {
                    dvgListaClientes.Rows.Add(item.IdCliente, item.Cuit, item.Nombre, item.Apellido);
                    MakeReadOnly();
                }
            }
        }


        private void MakeReadOnly()
        {
            dvgListaClientes.AllowUserToAddRows = false;
            dvgListaClientes.AllowUserToDeleteRows = false;
            dvgListaClientes.ReadOnly = true;
        }



        public bool BuscarPorString(Cliente cliente, string palabra)
        {
            if (
                cliente.IdCliente.ToString().Contains(palabra) ||
                cliente.Cuit.ToString().Contains(palabra) ||
                cliente.Nombre.ToLower().Contains(palabra) ||
                cliente.Apellido.ToLower().Contains(palabra)
                )
            {
                return true;
            }
            return false;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            // pnlBuscar.Enabled = false;
            ///btnEliminar.Enabled = false;
            //  panelAltaUsuario.Visible = true;
            //dgvListaEmpleados.Enabled = true;

            FormAltaCliente cliente = new FormAltaCliente(this.userForm);
            cliente.ShowDialog();
            this.CargarDataGrid();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> auxList = new List<Cliente>();
            for (int i = 0; i < dvgListaClientes.RowCount; i++)
            {
 
                Cliente cliente = new Cliente(dvgListaClientes.Rows[i].Cells[0].Value.ToString(),
                                                         dvgListaClientes.Rows[i].Cells[1].Value.ToString(),
                                                         dvgListaClientes.Rows[i].Cells[2].Value.ToString(),
                                                         0);
                                                          
                    auxList.Add(cliente);
              

                PetShop.LimpiarListaClientes();
                PetShop.CargarListaNuevamenteClientes(auxList);
            }

        }

        private void btnCancelarMoficiacion_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }
    }
}
