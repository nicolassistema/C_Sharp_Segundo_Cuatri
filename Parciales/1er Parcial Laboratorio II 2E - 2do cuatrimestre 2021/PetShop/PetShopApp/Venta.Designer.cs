
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(24, 26);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(38, 15);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "label1";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Location = new System.Drawing.Point(692, 26);
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
            this.lblVolver.Location = new System.Drawing.Point(522, 26);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(142, 15);
            this.lblVolver.TabIndex = 2;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver a pantalla Principal";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVolver_LinkClicked);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.LinkLabel lblCerrarSesion;
        private System.Windows.Forms.LinkLabel lblVolver;
    }
}