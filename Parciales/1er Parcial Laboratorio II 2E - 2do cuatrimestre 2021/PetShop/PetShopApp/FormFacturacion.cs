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
using System.Globalization;


namespace PetShopApp
{
    public partial class frmFacturacion : Form
    {
        private Timer ti;

        Usuario userForm;
        List<Venta> listaVentas;
        Facturacion facturacion;
        public frmFacturacion()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
            lblTimer.Visible = true;
        }

        public frmFacturacion(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
        }

        public frmFacturacion(Usuario usuario, List<Venta> ventas) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            this.listaVentas = ventas;
            CargarTexto();
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lblTimer.Text = hoy.ToString("F", CultureInfo.CreateSpecificCulture("es-ES"));
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

        public void CargarTexto()
        {
            lblFecha.Visible = true;
            facturacion = new Facturacion(listaVentas);
            lblFecha.Text = facturacion.ToString();
        }




    }
}
