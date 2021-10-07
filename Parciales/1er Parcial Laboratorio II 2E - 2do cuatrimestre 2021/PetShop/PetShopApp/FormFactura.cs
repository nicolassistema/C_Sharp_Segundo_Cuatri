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
    public partial class FormFactura : Form
    {
        Venta venta;
   
        public FormFactura()
        {
            InitializeComponent();
        }


        public FormFactura(Venta venta) : this()
        {
            this.venta = venta;


            rtxTicket.Text = venta.ToString();
        }



     


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
