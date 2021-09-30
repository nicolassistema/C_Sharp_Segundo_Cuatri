
namespace PetShopApp
{
    partial class frmAdministracion
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(12, 13);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(38, 15);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "label1";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Location = new System.Drawing.Point(717, 13);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(76, 15);
            this.lblCerrarSesion.TabIndex = 1;
            this.lblCerrarSesion.TabStop = true;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrarSesion_LinkClicked);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(47, 86);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(92, 23);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Venta";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(47, 125);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(92, 23);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(47, 165);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(92, 23);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(47, 207);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(92, 23);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // frmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "frmAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.LinkLabel lblCerrarSesion;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnFacturacion;
    }
}