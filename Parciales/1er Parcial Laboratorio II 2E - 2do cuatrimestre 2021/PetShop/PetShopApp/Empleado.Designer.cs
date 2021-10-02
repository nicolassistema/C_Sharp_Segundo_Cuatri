
namespace PetShopApp
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.lblCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(38, 15);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "label1";
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(414, 9);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(142, 15);
            this.lblVolver.TabIndex = 1;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver a pantalla Principal";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVolver_LinkClicked);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Location = new System.Drawing.Point(570, 9);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(76, 15);
            this.lblCerrarSesion.TabIndex = 2;
            this.lblCerrarSesion.TabStop = true;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrarSesion_LinkClicked);
            // 
            // dgvListaEmpleados
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuit,
            this.Nombre,
            this.Apellido,
            this.Usuario,
            this.Password,
            this.Perfil});
            this.dgvListaEmpleados.Location = new System.Drawing.Point(92, 93);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.RowHeadersVisible = false;
            this.dgvListaEmpleados.RowTemplate.Height = 25;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(559, 150);
            this.dgvListaEmpleados.TabIndex = 3;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Perfil
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Perfil.DefaultCellStyle = dataGridViewCellStyle2;
            this.Perfil.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Items.AddRange(new object[] {
            "Admin",
            "Empleado"});
            this.Perfil.Name = "Perfil";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(446, 40);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(200, 47);
            this.pnlBuscar.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(3, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 23);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(122, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(11, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 66);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(11, 40);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 66);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(11, 177);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 66);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(92, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 47);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 252);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.dgvListaEmpleados);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.LinkLabel lblVolver;
        private System.Windows.Forms.LinkLabel lblCerrarSesion;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewComboBoxColumn Perfil;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}