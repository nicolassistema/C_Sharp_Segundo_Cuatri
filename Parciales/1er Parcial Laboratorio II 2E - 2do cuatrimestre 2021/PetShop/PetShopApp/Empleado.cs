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
    public partial class frmEmpleado : Form
    {
        Usuario userForm;

        public frmEmpleado()
        {
            InitializeComponent();
           // PetShop.HardcodUsuarios();
        }



        public frmEmpleado(Usuario usuario) : this()
        {

            int i = 0;
            int j;
            this.userForm = usuario;
           
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;

            List<Usuario> lista = new List<Usuario>();
            lista = PetShop.ObtenerListaUsuarios();

            dgvListaEmpleados.RowCount = lista.Count;

            foreach (var item in lista)
            {
                j = 0;
                dgvListaEmpleados.Rows[i].Cells[j].Value = item.Cuit;
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[j].Value = item.Nombre;
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[j].Value = item.Apellido;
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[j].Value = item.NameUsuario;
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[j].Value = item.PassUsuario;
                j += 1;
               if (item.PerfilUsuario ==  Entidades.Usuario.EPerfilUsuario.Admin)
                {
                    dgvListaEmpleados.Rows[i].Cells[j].Value = "Admin";
                }
                else
                {
                    dgvListaEmpleados.Rows[i].Cells[j].Value = "Empleado";
                }
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
    }
}
