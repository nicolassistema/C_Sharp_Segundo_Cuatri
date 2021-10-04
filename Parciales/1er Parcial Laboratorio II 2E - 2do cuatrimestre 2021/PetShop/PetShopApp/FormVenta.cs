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
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            CargarDataGridProducto();
        }


        public void CargarDataGridProducto()
        {
            dgvListaProductos.Refresh();
            dgvListaProductos.DataSource = null;

            int i = 0;

            dgvListaProductos.RowCount = PetShop.ObtenerPorductos().Count;

            foreach (var item in PetShop.ObtenerPorductos())
            {
                dgvListaProductos.Rows[i].Cells[0].Value = item.Codigo;
                dgvListaProductos.Rows[i].Cells[1].Value = item.Marca;
                dgvListaProductos.Rows[i].Cells[2].Value = item.Nombre;
                dgvListaProductos.Rows[i].Cells[3].Value = item.Cantidad;
                dgvListaProductos.Rows[i].Cells[4].Value = item.Precio;
                i++;
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
            btnSacar.Enabled = true;
            double acum = 0;
            int stock = 0;
            Producto productoAux = new Producto();
            int aux = Convert.ToInt32(dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[0].Value);
            productoAux = PetShop.ObtenerProductoByID(aux);
            dgvListaProdSelecc.Rows.Add(new[] { productoAux.Codigo.ToString(), productoAux.Nombre.ToString(), productoAux.Marca.ToString(), productoAux.Precio.ToString() });
            dgvListaProdSelecc.AllowUserToAddRows = false;
            for (int i = 0; i < dgvListaProdSelecc.RowCount; i++)
            {
                acum += double.Parse(dgvListaProdSelecc.Rows[i].Cells[3].Value.ToString());
            }
            lblMostrarTotal.Text = string.Format("{0:f2}", acum);

            stock = Convert.ToInt32(dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[3].Value);
            stock -= 1;
            dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[3].Value = stock.ToString();
        }



        private void btnSacar_Click(object sender, EventArgs e)
        {
            int idAux = Convert.ToInt32(dgvListaProdSelecc.Rows[dgvListaProdSelecc.CurrentCell.RowIndex].Cells[0].Value);
            int stock = 0;
            double acumDos = double.Parse(lblMostrarTotal.Text);
            double acum = double.Parse(dgvListaProdSelecc.CurrentRow.Cells[3].Value.ToString());
            dgvListaProdSelecc.Rows.Remove(dgvListaProdSelecc.CurrentRow);
            lblMostrarTotal.Text = string.Format("{0:f2}", (acumDos - acum));

            for (int i = 0; i < dgvListaProductos.RowCount; i++)
            {
                if (idAux == Convert.ToInt32(dgvListaProductos.Rows[i].Cells[0].Value.ToString()))
                {
                    stock = Convert.ToInt32(dgvListaProductos.Rows[i].Cells[3].Value.ToString());
                    stock += 1;
                    dgvListaProductos.Rows[i].Cells[3].Value = stock.ToString();
                    break;
                }
            }

            if (double.Parse(lblMostrarTotal.Text) <= 0)
            {
                btnSacar.Enabled = false;
            }
        }

        private void btnAceptaCompra_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(lblCuit.Text.ToString(), lblNombre.Text.ToString(), lblApellido.Text.ToString(), 0);
            List<Producto> listaProductoAComprar = new List<Producto>();
            Producto producto;

            for (int i = 0; i < dgvListaProdSelecc.RowCount; i++)
            {
                string marca = dgvListaProdSelecc.Rows[i].Cells[1].Value.ToString();
                string nombre = dgvListaProdSelecc.Rows[i].Cells[2].Value.ToString();
                double precio = double.Parse(dgvListaProdSelecc.Rows[i].Cells[3].Value.ToString());
                producto = new Producto(marca, nombre, precio);
                listaProductoAComprar+=producto;
            }
            Venta venta = new Venta(userForm, cliente, double.Parse(lblMostrarTotal.Text.ToString()), listaProductoAComprar);
            MessageBox.Show(venta.ToString());
        }
    }



}
