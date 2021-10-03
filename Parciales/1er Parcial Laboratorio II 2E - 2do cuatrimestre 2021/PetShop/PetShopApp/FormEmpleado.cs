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
    public partial class FormEmpleado : Form
    {
        Usuario userForm;

        public FormEmpleado()
        {
            InitializeComponent();
        }


        public FormEmpleado(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            CargarDataGrid();
        }


        public void CargarDataGrid()
        {
            dgvListaEmpleados.Refresh();
            dgvListaEmpleados.DataSource = null;

            int i = 0;
            int j;
            dgvListaEmpleados.RowCount = PetShop.ObtenerListaUsuarios().Count;

            foreach (var item in PetShop.ObtenerListaUsuarios())
            {
                j = 0;
                if (item.Cuit == userForm.Cuit.ToString())
                {
                    dgvListaEmpleados.Rows[i].Cells[0].Value = item.Cuit;
                    dgvListaEmpleados.Rows[i].Cells[0].ReadOnly = true;
                    dgvListaEmpleados.Rows[i].Cells[5].ReadOnly = true;
                }
                else
                {
                    dgvListaEmpleados.Rows[i].Cells[0].Value = item.Cuit;
                }
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[1].Value = item.Nombre;
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[2].Value = item.Apellido;
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[3].Value = item.NameUsuario;
                j += 1;
                dgvListaEmpleados.Rows[i].Cells[4].Value = item.PassUsuario;
                j += 1;
                if (item.PerfilUsuario == Entidades.Usuario.EPerfilUsuario.Admin)
                {
                    dgvListaEmpleados.Rows[i].Cells[5].Value = "Admin";
                }
                else
                {
                    dgvListaEmpleados.Rows[i].Cells[5].Value = "Empleado";
                }
                i++;
            }
        }


        public void RefrescarForm()
        {
            FormEmpleado form = new FormEmpleado();
            form.Refresh();
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
            dgvListaEmpleados.Rows.Clear();//Limpio el datagrid
            List<Usuario> lista = new List<Usuario>();
            lista = PetShop.ObtenerListaUsuarios();
            string aux;
            foreach (var item in lista)
            {
                if (BuscarPorString(item, txtBuscar.Text.ToLower()))
                {
                    if (item.PerfilUsuario == Entidades.Usuario.EPerfilUsuario.Admin)
                    {
                        aux = "Admin";
                    }
                    else
                    {
                        aux = "Empleado";
                    }
                    dgvListaEmpleados.Rows.Add(item.Cuit, item.Nombre, item.Apellido, item.NameUsuario, item.PassUsuario, aux);
                    MakeReadOnly();
                }
            }
        }

        private void MakeReadOnly()
        {
            dgvListaEmpleados.AllowUserToAddRows = false;
            dgvListaEmpleados.AllowUserToDeleteRows = false;
            dgvListaEmpleados.ReadOnly = true;
        }


        public bool BuscarPorString(Usuario usuario, string palabra)
        {
            if (
                usuario.Cuit.ToLower().Contains(palabra) ||
                usuario.Nombre.ToLower().Contains(palabra) ||
                usuario.Apellido.ToLower().Contains(palabra) ||
                usuario.NameUsuario.ToLower().Contains(palabra) ||
                usuario.PassUsuario.ToLower().Contains(palabra) ||
                usuario.PerfilUsuario.ToString().ToLower().Contains(palabra)
                )
            {
                return true;
            }
            return false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            // pnlBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            //  panelAltaUsuario.Visible = true;
            dgvListaEmpleados.Enabled = true;

            frmAltaEmpleado empleado = new frmAltaEmpleado(this.userForm);
            empleado.ShowDialog();
            this.CargarDataGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvListaEmpleados.DataSource = null;
            List<Usuario> lista = new List<Usuario>();
            //  Usuario usuario;
            lista = PetShop.ObtenerListaUsuarios();
            string aux;
            foreach (DataGridViewCell oneCell in dgvListaEmpleados.SelectedCells)//Busca en que row se selecciono la celda
            {
                aux = dgvListaEmpleados.Rows[dgvListaEmpleados.CurrentCell.RowIndex].Cells[0].Value.ToString();//obtengo el id del registro datagrid tal y como esta en la base
                if (userForm.Cuit != aux)
                {
                    if (dgvListaEmpleados.SelectedCells.Count < 2)//Valido que si hay mas de una celda seleccionada, salga y muestre mensaje de validacion
                    {
                        if (oneCell.Selected)
                        {
                            foreach (var item in lista)//recorro la lista de usuarios ubicando el que tiene el id que obtuve el datagrid
                            {
                                if (item.Cuit == aux)//una vez encontrado, cargo el constructor y lo mando a la funcion eliminar de la base de datos
                                {
                                    DialogResult dr = MessageBox.Show($"Esta seguro de eliminar el usuario\n {item.ToString()}?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dr != DialogResult.No)
                                    {
                                        PetShop.EliminarUsuario(item);
                                        dgvListaEmpleados.DataSource = null;
                                        this.CargarDataGrid();

                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede seleccionar mas de una celda");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("No se puede borrar el usuario que esta loguado actualmente");
                    break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            List<Usuario> auxList = new List<Usuario>();
            for (int i = 0; i < dgvListaEmpleados.RowCount; i++)
            {
                string aux = dgvListaEmpleados.Rows[i].Cells[5].Value.ToString();
                string cuitAux = dgvListaEmpleados.Rows[i].Cells[0].Value.ToString();


                if (userForm.Cuit == cuitAux)
                {
                    lblNombreUsuario.Text = dgvListaEmpleados.Rows[i].Cells[1].Value.ToString() + " " + dgvListaEmpleados.Rows[i].Cells[2].Value.ToString();
                    userForm.Nombre = dgvListaEmpleados.Rows[i].Cells[1].Value.ToString();
                    userForm.Apellido = dgvListaEmpleados.Rows[i].Cells[2].Value.ToString();
                    userForm.NameUsuario = dgvListaEmpleados.Rows[i].Cells[3].Value.ToString();
                    userForm.PassUsuario = dgvListaEmpleados.Rows[i].Cells[4].Value.ToString();
                }

                if (Entidades.Usuario.EPerfilUsuario.Admin.ToString() == aux)
                {
                    Usuario usuario = new Usuario(dgvListaEmpleados.Rows[i].Cells[0].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[1].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[2].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[3].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[4].Value.ToString(),
                                                             Entidades.Usuario.EPerfilUsuario.Admin);
                    auxList.Add(usuario);
                }
                else
                {
                    Usuario usuario = new Usuario(dgvListaEmpleados.Rows[i].Cells[0].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[1].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[2].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[3].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[4].Value.ToString(),
                                                            Entidades.Usuario.EPerfilUsuario.Empleado);
                    auxList.Add(usuario);
                }

                PetShop.LimpiarLista();
                PetShop.CargarListaNuevamente(auxList);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }


    }
}






















