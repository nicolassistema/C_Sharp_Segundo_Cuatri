using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            rtxTicket.Enabled = false;
            this.venta = venta;
            ImprimirPorPantalla();
        }

        public void ImprimirPorPantalla()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------Pet Shop------------------");
            sb.AppendLine("                    'El Pikachu Juan'             ");
            sb.AppendLine("           By Nicolas Ezequiel Letticugna       ");
            sb.AppendLine("       Av. Gral. Chamizo y Donovan - Gerli      ");
            sb.AppendLine("         Tel. 0800-2020-2020 (op. 3)            ");
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine(MostrarFecha());
            sb.Append(venta.ToString());
            rtxTicket.Text = sb.ToString();
        }

        public string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------Pet Shop------------------");
            sb.AppendLine("                    'El Pikachu Juan'             ");
            sb.AppendLine("           By Nicolas Ezequiel Letticugna       ");
            sb.AppendLine("       Av. Gral. Chamizo y Donovan - Gerli      ");
            sb.AppendLine("         Tel. 0800-2020-2020 (op. 3)            ");
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine(MostrarFecha());
            sb.Append(venta.ToString());

            return sb.ToString();
        }

        public string MostrarFecha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Factura N°  {venta.NumeroFactura}    " + DateTime.Today.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss"));
            return sb.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ImprimirEnTxt()
        {
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            // saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.FileName = "Nombre del archivo";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter tesxtoAGuardar = File.CreateText(txt);
                        tesxtoAGuardar.WriteLine(rtxTicket.Text);
                        tesxtoAGuardar.Close();
                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter tesxtoAGuardar = File.CreateText(txt);
                        tesxtoAGuardar.WriteLine(rtxTicket.Text);
                        tesxtoAGuardar.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirEnTxt();
        }
    }
}
