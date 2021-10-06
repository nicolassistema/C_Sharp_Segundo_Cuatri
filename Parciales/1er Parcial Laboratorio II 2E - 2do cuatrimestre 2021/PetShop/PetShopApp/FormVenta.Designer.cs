
namespace PetShopApp
{
    partial class frmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.pnlBuscarCliente = new System.Windows.Forms.Panel();
            this.lblMensajeCliente = new System.Windows.Forms.Label();
            this.lblCuitIng = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblMostrarTotal = new System.Windows.Forms.Label();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.dgvListaProdSelecc = new System.Windows.Forms.DataGridView();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.CodPorducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesos = new System.Windows.Forms.Label();
            this.btnCancelaCompra = new System.Windows.Forms.Button();
            this.btnAceptaCompra = new System.Windows.Forms.Button();
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.lblVto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPesosPagar = new System.Windows.Forms.Label();
            this.lblMontoVta = new System.Windows.Forms.Label();
            this.lblPesosVta = new System.Windows.Forms.Label();
            this.lblPVto = new System.Windows.Forms.Label();
            this.lblMontoPagar = new System.Windows.Forms.Label();
            this.btnCancelarVta = new System.Windows.Forms.Button();
            this.btnAceptarVta = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFormaPAgo = new System.Windows.Forms.Label();
            this.txtMontoAPagar = new System.Windows.Forms.TextBox();
            this.cmbFromaPago = new System.Windows.Forms.ComboBox();
            this.pnlConfirmarCompra = new System.Windows.Forms.Panel();
            this.pnlBuscarCliente.SuspendLayout();
            this.pnlCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdSelecc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.pnlVenta.SuspendLayout();
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
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Location = new System.Drawing.Point(1104, 9);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(76, 15);
            this.lblCerrarSesion.TabIndex = 1;
            this.lblCerrarSesion.TabStop = true;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrarSesion_LinkClicked);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(934, 9);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(142, 15);
            this.lblVolver.TabIndex = 2;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver a pantalla Principal";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVolver_LinkClicked);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(55, 44);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 23);
            this.txtCuit.TabIndex = 3;
            // 
            // pnlBuscarCliente
            // 
            this.pnlBuscarCliente.Controls.Add(this.lblMensajeCliente);
            this.pnlBuscarCliente.Controls.Add(this.lblCuitIng);
            this.pnlBuscarCliente.Controls.Add(this.btnBuscarCliente);
            this.pnlBuscarCliente.Controls.Add(this.lblApellido);
            this.pnlBuscarCliente.Controls.Add(this.lblNombre);
            this.pnlBuscarCliente.Controls.Add(this.lblCuit);
            this.pnlBuscarCliente.Controls.Add(this.txtCuit);
            this.pnlBuscarCliente.Location = new System.Drawing.Point(15, 38);
            this.pnlBuscarCliente.Name = "pnlBuscarCliente";
            this.pnlBuscarCliente.Size = new System.Drawing.Size(270, 174);
            this.pnlBuscarCliente.TabIndex = 4;
            // 
            // lblMensajeCliente
            // 
            this.lblMensajeCliente.AutoSize = true;
            this.lblMensajeCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeCliente.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeCliente.Location = new System.Drawing.Point(3, 11);
            this.lblMensajeCliente.Name = "lblMensajeCliente";
            this.lblMensajeCliente.Padding = new System.Windows.Forms.Padding(0, 0, 180, 0);
            this.lblMensajeCliente.Size = new System.Drawing.Size(233, 15);
            this.lblMensajeCliente.TabIndex = 13;
            this.lblMensajeCliente.Text = "mensaje";
            this.lblMensajeCliente.Visible = false;
            // 
            // lblCuitIng
            // 
            this.lblCuitIng.AutoSize = true;
            this.lblCuitIng.Location = new System.Drawing.Point(20, 48);
            this.lblCuitIng.Name = "lblCuitIng";
            this.lblCuitIng.Size = new System.Drawing.Size(29, 15);
            this.lblCuitIng.TabIndex = 12;
            this.lblCuitIng.Text = "Cuit";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(192, 30);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 49);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(18, 152);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(38, 15);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "label3";
            this.lblApellido.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "label2";
            this.lblNombre.Visible = false;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(18, 93);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(38, 15);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "label1";
            this.lblCuit.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(370, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 89);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(370, 102);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 89);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "<<";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblMostrarTotal
            // 
            this.lblMostrarTotal.AutoSize = true;
            this.lblMostrarTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostrarTotal.Location = new System.Drawing.Point(671, 398);
            this.lblMostrarTotal.Name = "lblMostrarTotal";
            this.lblMostrarTotal.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblMostrarTotal.Size = new System.Drawing.Size(83, 37);
            this.lblMostrarTotal.TabIndex = 8;
            this.lblMostrarTotal.Text = "0";
            // 
            // pnlCompra
            // 
            this.pnlCompra.Controls.Add(this.dgvListaProdSelecc);
            this.pnlCompra.Controls.Add(this.dgvListaProductos);
            this.pnlCompra.Controls.Add(this.lblPesos);
            this.pnlCompra.Controls.Add(this.btnCancelaCompra);
            this.pnlCompra.Controls.Add(this.btnAceptaCompra);
            this.pnlCompra.Controls.Add(this.lblMostrarTotal);
            this.pnlCompra.Controls.Add(this.btnSacar);
            this.pnlCompra.Controls.Add(this.btnAgregar);
            this.pnlCompra.Location = new System.Drawing.Point(403, 53);
            this.pnlCompra.Name = "pnlCompra";
            this.pnlCompra.Size = new System.Drawing.Size(777, 466);
            this.pnlCompra.TabIndex = 10;
            // 
            // dgvListaProdSelecc
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProdSelecc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProdSelecc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdSelecc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProdSelecc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProdSelecc.Location = new System.Drawing.Point(451, 7);
            this.dgvListaProdSelecc.Name = "dgvListaProdSelecc";
            this.dgvListaProdSelecc.RowHeadersVisible = false;
            this.dgvListaProdSelecc.RowTemplate.Height = 25;
            this.dgvListaProdSelecc.Size = new System.Drawing.Size(317, 357);
            this.dgvListaProdSelecc.TabIndex = 14;
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "CodProducto";
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dgvListaProductos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPorducto,
            this.Marca,
            this.Nombre,
            this.Stock,
            this.Precio});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaProductos.Location = new System.Drawing.Point(14, 7);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersVisible = false;
            this.dgvListaProductos.RowTemplate.Height = 25;
            this.dgvListaProductos.Size = new System.Drawing.Size(350, 456);
            this.dgvListaProductos.TabIndex = 13;
            // 
            // CodPorducto
            // 
            this.CodPorducto.HeaderText = "CodPorducto";
            this.CodPorducto.Name = "CodPorducto";
            this.CodPorducto.Width = 50;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 50;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 50;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesos.Location = new System.Drawing.Point(632, 398);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(33, 37);
            this.lblPesos.TabIndex = 12;
            this.lblPesos.Text = "$";
            // 
            // btnCancelaCompra
            // 
            this.btnCancelaCompra.Location = new System.Drawing.Point(551, 389);
            this.btnCancelaCompra.Name = "btnCancelaCompra";
            this.btnCancelaCompra.Size = new System.Drawing.Size(75, 53);
            this.btnCancelaCompra.TabIndex = 11;
            this.btnCancelaCompra.Text = "Cancelar";
            this.btnCancelaCompra.UseVisualStyleBackColor = true;
            this.btnCancelaCompra.Click += new System.EventHandler(this.btnCancelaCompra_Click);
            // 
            // btnAceptaCompra
            // 
            this.btnAceptaCompra.Location = new System.Drawing.Point(453, 389);
            this.btnAceptaCompra.Name = "btnAceptaCompra";
            this.btnAceptaCompra.Size = new System.Drawing.Size(75, 53);
            this.btnAceptaCompra.TabIndex = 10;
            this.btnAceptaCompra.Text = "Aceptar";
            this.btnAceptaCompra.UseVisualStyleBackColor = true;
            this.btnAceptaCompra.Click += new System.EventHandler(this.btnAceptaCompra_Click);
            // 
            // pnlVenta
            // 
            this.pnlVenta.Controls.Add(this.lblVto);
            this.pnlVenta.Controls.Add(this.label1);
            this.pnlVenta.Controls.Add(this.lblPesosPagar);
            this.pnlVenta.Controls.Add(this.lblMontoVta);
            this.pnlVenta.Controls.Add(this.lblPesosVta);
            this.pnlVenta.Controls.Add(this.lblPVto);
            this.pnlVenta.Controls.Add(this.lblMontoPagar);
            this.pnlVenta.Controls.Add(this.btnCancelarVta);
            this.pnlVenta.Controls.Add(this.btnAceptarVta);
            this.pnlVenta.Controls.Add(this.lblMonto);
            this.pnlVenta.Controls.Add(this.lblFormaPAgo);
            this.pnlVenta.Controls.Add(this.txtMontoAPagar);
            this.pnlVenta.Controls.Add(this.cmbFromaPago);
            this.pnlVenta.Location = new System.Drawing.Point(15, 345);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(372, 171);
            this.pnlVenta.TabIndex = 11;
            // 
            // lblVto
            // 
            this.lblVto.AutoSize = true;
            this.lblVto.Location = new System.Drawing.Point(300, 113);
            this.lblVto.Name = "lblVto";
            this.lblVto.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblVto.Size = new System.Drawing.Size(63, 15);
            this.lblVto.TabIndex = 19;
            this.lblVto.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(220, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vuelto";
            // 
            // lblPesosPagar
            // 
            this.lblPesosPagar.AutoSize = true;
            this.lblPesosPagar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesosPagar.Location = new System.Drawing.Point(249, 62);
            this.lblPesosPagar.Name = "lblPesosPagar";
            this.lblPesosPagar.Size = new System.Drawing.Size(18, 20);
            this.lblPesosPagar.TabIndex = 17;
            this.lblPesosPagar.Text = "$";
            // 
            // lblMontoVta
            // 
            this.lblMontoVta.AutoSize = true;
            this.lblMontoVta.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoVta.Location = new System.Drawing.Point(281, 11);
            this.lblMontoVta.Name = "lblMontoVta";
            this.lblMontoVta.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblMontoVta.Size = new System.Drawing.Size(83, 37);
            this.lblMontoVta.TabIndex = 13;
            this.lblMontoVta.Text = "0";
            // 
            // lblPesosVta
            // 
            this.lblPesosVta.AutoSize = true;
            this.lblPesosVta.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesosVta.Location = new System.Drawing.Point(242, 11);
            this.lblPesosVta.Name = "lblPesosVta";
            this.lblPesosVta.Size = new System.Drawing.Size(33, 37);
            this.lblPesosVta.TabIndex = 13;
            this.lblPesosVta.Text = "$";
            // 
            // lblPVto
            // 
            this.lblPVto.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblPVto.AutoSize = true;
            this.lblPVto.Location = new System.Drawing.Point(281, 113);
            this.lblPVto.Name = "lblPVto";
            this.lblPVto.Size = new System.Drawing.Size(13, 15);
            this.lblPVto.TabIndex = 16;
            this.lblPVto.Text = "$";
            // 
            // lblMontoPagar
            // 
            this.lblMontoPagar.AutoSize = true;
            this.lblMontoPagar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoPagar.Location = new System.Drawing.Point(288, 62);
            this.lblMontoPagar.Name = "lblMontoPagar";
            this.lblMontoPagar.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblMontoPagar.Size = new System.Drawing.Size(68, 20);
            this.lblMontoPagar.TabIndex = 15;
            this.lblMontoPagar.Text = "0";
            // 
            // btnCancelarVta
            // 
            this.btnCancelarVta.Location = new System.Drawing.Point(120, 113);
            this.btnCancelarVta.Name = "btnCancelarVta";
            this.btnCancelarVta.Size = new System.Drawing.Size(75, 55);
            this.btnCancelarVta.TabIndex = 14;
            this.btnCancelarVta.Text = "Cancelar";
            this.btnCancelarVta.UseVisualStyleBackColor = true;
            this.btnCancelarVta.Click += new System.EventHandler(this.btnCancelarVta_Click);
            // 
            // btnAceptarVta
            // 
            this.btnAceptarVta.Location = new System.Drawing.Point(29, 113);
            this.btnAceptarVta.Name = "btnAceptarVta";
            this.btnAceptarVta.Size = new System.Drawing.Size(75, 55);
            this.btnAceptarVta.TabIndex = 12;
            this.btnAceptarVta.Text = "Aceptar";
            this.btnAceptarVta.UseVisualStyleBackColor = true;
            this.btnAceptarVta.Click += new System.EventHandler(this.btnAceptarVta_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(46, 66);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.Text = "Monto";
            // 
            // lblFormaPAgo
            // 
            this.lblFormaPAgo.AutoSize = true;
            this.lblFormaPAgo.Location = new System.Drawing.Point(7, 29);
            this.lblFormaPAgo.Name = "lblFormaPAgo";
            this.lblFormaPAgo.Size = new System.Drawing.Size(62, 15);
            this.lblFormaPAgo.TabIndex = 8;
            this.lblFormaPAgo.Text = "F. de Pago";
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.Location = new System.Drawing.Point(95, 63);
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.Size = new System.Drawing.Size(100, 23);
            this.txtMontoAPagar.TabIndex = 8;
            // 
            // cmbFromaPago
            // 
            this.cmbFromaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromaPago.FormattingEnabled = true;
            this.cmbFromaPago.Items.AddRange(new object[] {
            "MercadoPago",
            "Efectivo",
            "TarjetaDebito"});
            this.cmbFromaPago.Location = new System.Drawing.Point(75, 23);
            this.cmbFromaPago.Name = "cmbFromaPago";
            this.cmbFromaPago.Size = new System.Drawing.Size(121, 23);
            this.cmbFromaPago.TabIndex = 0;
            // 
            // pnlConfirmarCompra
            // 
            this.pnlConfirmarCompra.Location = new System.Drawing.Point(15, 218);
            this.pnlConfirmarCompra.Name = "pnlConfirmarCompra";
            this.pnlConfirmarCompra.Size = new System.Drawing.Size(372, 121);
            this.pnlConfirmarCompra.TabIndex = 12;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 535);
            this.Controls.Add(this.pnlConfirmarCompra);
            this.Controls.Add(this.pnlVenta);
            this.Controls.Add(this.pnlCompra);
            this.Controls.Add(this.pnlBuscarCliente);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.pnlBuscarCliente.ResumeLayout(false);
            this.pnlBuscarCliente.PerformLayout();
            this.pnlCompra.ResumeLayout(false);
            this.pnlCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdSelecc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.LinkLabel lblCerrarSesion;
        private System.Windows.Forms.LinkLabel lblVolver;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Panel pnlBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblMostrarTotal;
        private System.Windows.Forms.Panel pnlCompra;
        private System.Windows.Forms.Button btnCancelaCompra;
        private System.Windows.Forms.Button btnAceptaCompra;
        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.Label lblPVto;
        private System.Windows.Forms.Label lblMontoPagar;
        private System.Windows.Forms.Button btnCancelarVta;
        private System.Windows.Forms.Button btnAceptarVta;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFormaPAgo;
        private System.Windows.Forms.TextBox txtMontoAPagar;
        private System.Windows.Forms.ComboBox cmbFromaPago;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblMontoVta;
        private System.Windows.Forms.Label lblPesosVta;
        private System.Windows.Forms.Label lblVto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPesosPagar;
        private System.Windows.Forms.Label lblCuitIng;
        private System.Windows.Forms.Label lblMensajeCliente;
        private System.Windows.Forms.DataGridView dgvListaProdSelecc;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPorducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel pnlConfirmarCompra;
    }
}