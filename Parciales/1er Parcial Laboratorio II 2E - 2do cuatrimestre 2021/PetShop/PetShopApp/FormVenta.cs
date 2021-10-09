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
    public partial class FormVenta : Form
    {
        Usuario userForm;


        public FormVenta()
        {
            InitializeComponent();
        }


        public FormVenta(Usuario usuario) : this()
        {
            this.userForm = usuario;
            btnSalirDeVenta.Visible = false;
            btnCompraNueva.Visible = false;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            btnCancelaCompra.Enabled = false;
            btnAceptaCompra.Enabled = false;
            dgvListaProdSelecc.AllowUserToAddRows = false;
            ActivDesactivPnlCompra(false);
            ActivDesactivPnlVenta(false);
            VisibilidadPnlVenta(false);
            RestartearListas();
            btnSacar.Enabled = false;
            btnLimpiarSelectProd.Enabled = false;
            FocusPnlBuscarCliente(true);
            VisibilidadPnlConfirmarCompra(false);
        }


        public void CargarDataGridProducto()
        {
            int i = 0;
            dgvListaProductos.Refresh();
            dgvListaProductos.DataSource = null;
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


        public List<Producto> ActualizarInventario()
        {
            List<Producto> listaAux = new List<Producto>();
            string nombre;
            string marca;
            int cantidad;
            double precio;
            for (int i = 0; i < dgvListaProductos.RowCount; i++)
            {
                nombre = dgvListaProductos.Rows[i].Cells[1].Value.ToString();
                marca = dgvListaProductos.Rows[i].Cells[2].Value.ToString();
                cantidad = Convert.ToInt32(dgvListaProductos.Rows[i].Cells[3].Value.ToString());
                precio = double.Parse(dgvListaProductos.Rows[i].Cells[4].Value.ToString());
                PetShop.listaProductos += new Producto(nombre, marca, cantidad, precio);
            }
            return PetShop.ObtenerPorductos();
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
                lblMensajeCliente.Text = "Cuit Incorrecto";
                lblMensajeCliente.Visible = true;
                lblCuit.Visible = false;
                lblNombre.Visible = false;
                lblApellido.Visible = false;
                ActivDesactivPnlCompra(false);
            }
            else
            {
                btnLimpiarSelectProd.Enabled = true;
                foreach (var item in lista)
                {
                    if (item.Cuit.ToString() == txtCuit.Text)
                    {
                        if (PetShop.BuscarClientePorString(item, txtCuit.Text.ToLower()))
                        {
                            if (dgvListaProdSelecc.RowCount > 0)
                            {
                                btnSacar.Enabled = true;
                                btnAceptaCompra.Enabled = true;
                                btnCancelaCompra.Enabled = true;
                            }
                            else
                            {
                                btnLimpiarSelectProd.Enabled = false;
                            }

                            if (double.Parse(lblMostrarTotal.Text) <= 0)
                            {
                                btnLimpiarSelectProd.Enabled = false;
                            }

                            ActivDesactivPnlBuscarCliente(false);
                            btnCancelaCompra.Enabled = true;
                            ActivDesactivPnlCompra(true);
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

        public void RestartearListas()
        {
            dgvListaProductos.Rows.Clear();
            dgvListaProdSelecc.Rows.Clear();
            CargarDataGridProducto();
            lblMostrarTotal.Text = "0.00";
        }

        public void RestartearVta()
        {
            pnlVenta.Visible = false;
            lblMontoVta.Text = "0.00";
            cmbFromaPago.Text = "";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
        }

        public void FocusPnlBuscarCliente(bool estado)
        {
            if (estado)
            {
                pnlBuscarCliente.BackColor = Color.LightYellow;
                this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                this.pnlBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
                this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        public void FocusPnlCompra(bool estado)
        {
            if (estado)
            {
                pnlCompra.BackColor = Color.LightYellow;
                this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                this.pnlCompra.BackColor = System.Drawing.SystemColors.Control;
                this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        public void FocusPnlVenta(bool estado)
        {
            if (estado)
            {
                pnlVenta.BackColor = Color.LightYellow;
                this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                this.pnlVenta.BackColor = System.Drawing.SystemColors.Control;
                this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        public void FocusPnlConfirm(bool estado)
        {
            if (estado)
            {
                pnlConfirmarCompra.BackColor = Color.LightYellow;
                this.pnlConfirmarCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                this.pnlConfirmarCompra.BackColor = System.Drawing.SystemColors.Control;
                this.pnlConfirmarCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        public void ActivDesactivPnlBuscarCliente(bool estado)
        {
            if (estado)
            {
                pnlBuscarCliente.Enabled = true;
                FocusPnlBuscarCliente(true);
            }
            else
            {
                pnlBuscarCliente.Enabled = false;
                FocusPnlBuscarCliente(false);
            }
        }

        public void ActivDesactivPnlCompra(bool estado)
        {
            if (estado)
            {
                FocusPnlCompra(true);
                pnlCompra.Enabled = true;
            }
            else
            {
                FocusPnlCompra(false);
                pnlCompra.Enabled = false;
                btnLimpiarSelectProd.Enabled = false;
            }
        }

        public void ActivDesactivPnlVenta(bool estado)
        {
            if (estado)
            {
                pnlVenta.Enabled = true;
                FocusPnlVenta(true);
            }
            else
            {
                pnlVenta.Enabled = false;
                FocusPnlVenta(false);
            }
        }

        public void ActiveDesactivePnlConfirm(bool estado)
        {
            if (estado)
            {
                pnlConfirmarCompra.Enabled = true;
                FocusPnlConfirm(true);
            }
            else
            {
                pnlConfirmarCompra.Enabled = false;
                FocusPnlConfirm(false);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnLimpiarSelectProd.Enabled = true;
            lblMontoVta.Text = "0.00";
            cmbFromaPago.Text = "";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
            btnAceptaCompra.Enabled = true;
            btnCancelaCompra.Enabled = true;
            btnSacar.Enabled = true;
            double acum = 0;
            int stock = 0;
            Producto productoAux = new Producto();
            int aux = Convert.ToInt32(dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[0].Value);
            productoAux = PetShop.ObtenerProductoByID(aux);

            if (!(Convert.ToInt32(dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[3].Value) < 1))
            {
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
            else
            {
                MessageBox.Show("Producto sin stock!!!");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnLimpiarSelectProd.Enabled = true;
            lblMontoVta.Text = "0.00";
            cmbFromaPago.Text = "";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
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
                btnAceptaCompra.Enabled = false;
                //  btnCancelaCompra.Enabled = false;
                btnSacar.Enabled = false;
                btnLimpiarSelectProd.Enabled = false;
            }
        }

        private void btnAceptaCompra_Click(object sender, EventArgs e)
        {
            ActivDesactivPnlCompra(false);
            // btnLimpiarSelectProd.Enabled = false;
            ActivDesactivPnlVenta(true);
            pnlVenta.Visible = true;
            cmbFromaPago.Enabled = true;
            txtMontoAPagar.Enabled = true;
            btnAceptarVta.Enabled = true;
            btnCancelarVta.Enabled = true;
            cmbFromaPago.Text = "Efectivo";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
            Cliente cliente = new Cliente(lblCuit.Text.ToString(), lblNombre.Text.ToString(), lblApellido.Text.ToString(), 0);
            List<Producto> listaProductoAComprar = new List<Producto>();
            Producto producto;

            for (int i = 0; i < dgvListaProdSelecc.RowCount; i++)
            {
                int codigo = Convert.ToInt32(dgvListaProdSelecc.Rows[i].Cells[0].Value.ToString());
                string marca = dgvListaProdSelecc.Rows[i].Cells[1].Value.ToString();
                string nombre = dgvListaProdSelecc.Rows[i].Cells[2].Value.ToString();
                double precio = double.Parse(dgvListaProdSelecc.Rows[i].Cells[3].Value.ToString());
                producto = new Producto(codigo, marca, nombre, precio);
                listaProductoAComprar += producto;
            }
            Venta venta = new Venta(userForm, cliente, double.Parse(lblMostrarTotal.Text.ToString()), listaProductoAComprar);
            //MessageBox.Show(venta.ToString());
            lblMontoVta.Text = lblMostrarTotal.Text;
        }

        private void btnCancelaCompra_Click(object sender, EventArgs e)
        {
            btnSacar.Enabled = false;
            btnAceptaCompra.Enabled = false;
            btnCancelaCompra.Enabled = false;
            ActivDesactivPnlCompra(false);
            ActivDesactivPnlBuscarCliente(true);
        }

        private void btnLimpiarSelectProd_Click(object sender, EventArgs e)
        {
            btnLimpiarSelectProd.Enabled = false;
            btnCancelaCompra.Enabled = true;
            btnAceptaCompra.Enabled = false;
            btnSacar.Enabled = false;
            lblMostrarTotal.Text = "0.00";
            dgvListaProdSelecc.Rows.Clear();
            CargarDataGridProducto();
        }

        public void VisibilidadPnlVenta(bool estado)
        {
            if (estado)
            {
                pnlVenta.Visible = true;
            }
            else
            {
                pnlVenta.Visible = false;
            }
        }

        public void VisibilidadPnlConfirmarCompra(bool estado)
        {
            if (estado)
            {
                pnlConfirmarCompra.Visible = true;
            }
            else
            {
                pnlConfirmarCompra.Visible = false;
            }

        }

        private void btnCancelarVta_Click(object sender, EventArgs e)
        {
            btnAceptaCompra.Enabled = true;
            btnCancelaCompra.Enabled = true;
            RestartearVta();
            ActivDesactivPnlCompra(true);
            btnLimpiarSelectProd.Enabled = true;
        }

        private void btnAceptarVta_Click(object sender, EventArgs e)
        {
            double montoTotal;
            double montoPago;
            //var direction = ListSortDirection.Ascending;
            //dgvListaProdSelecc.Sort(CodProducto, direction);
            if (!(txtMontoAPagar.Text == ""))
            {
                lblMontoPagar.Text = txtMontoAPagar.Text.ToString();
                montoTotal = double.Parse(lblMontoVta.Text.ToString());
                montoPago = double.Parse(lblMontoPagar.Text.ToString());
                lblVto.Text = string.Format("{0:f2}", (montoPago - montoTotal));
                VisibilidadPnlConfirmarCompra(true);
                pnlVenta.Enabled = false;
                FocusPnlVenta(false);
                FocusPnlConfirm(true);
            }
            else
            {
                MessageBox.Show("Por favor ingresar el monto a pagar");
            }
        }

        private void btnCancelarConfirmCompra_Click(object sender, EventArgs e)
        {
            VisibilidadPnlConfirmarCompra(false);
            ActivDesactivPnlVenta(true);
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            int id;
            string marca;
            string nombre;
            double precio;
            List<Producto> listaProducto = new List<Producto>();

            for (int i = 0; i < dgvListaProdSelecc.RowCount; i++)
            {
                id = Convert.ToInt32(dgvListaProdSelecc.Rows[i].Cells[0].Value.ToString());
                marca = dgvListaProdSelecc.Rows[i].Cells[1].Value.ToString();
                nombre = dgvListaProdSelecc.Rows[i].Cells[2].Value.ToString();
                precio = double.Parse(dgvListaProdSelecc.Rows[i].Cells[3].Value.ToString());
                Producto producto = new Producto(id, marca, nombre, precio);
                listaProducto += (producto);
            }
            Cliente cliente = new Cliente(lblCuit.Text.ToString(), lblNombre.Text.ToString(), lblApellido.Text.ToString(), double.Parse(lblMontoPagar.Text.ToString()));
            Venta venta = new Venta(userForm, cliente, double.Parse(lblMontoVta.Text.ToString()), listaProducto);
            FormFactura factura = new FormFactura(venta);
            PetShop.listaVentas += venta;
            PetShop.LimpiarListaProductos();
            ActualizarInventario();

            PasoFinal();
            factura.ShowDialog();
        }

        public void PasoFinal()
        {
            btnSalirDeVenta.Visible = true;
            btnCompraNueva.Visible = true;
            btnConfirmarCompra.Visible = false;
            btnCancelarConfirmCompra.Visible = false;

        }

        private void btnSalirDeVenta_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Dese Salir de la pantalla venta hacia el menu principal?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                frmAdministracion administracion = new frmAdministracion(this.userForm);
                this.Hide();
                administracion.ShowDialog();
                this.Close();
            }
        }

        private void btnCompraNueva_Click(object sender, EventArgs e)
        {
            FormVenta fm = new FormVenta(this.userForm);
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }



}
