using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_JavierChamo
{
    public partial class GenerarPDF_MovimientoInventario : Form
    {
        Capa_Controlador.Controlador capa_Controlador_Logistica = new Capa_Controlador.Controlador();

        public GenerarPDF_MovimientoInventario()
        {
            InitializeComponent();
        }

        private void btn_generarPDF_Click(object sender, EventArgs e)
        {
            int idMovimiento;
            if (!int.TryParse(txtMovimientoInventario.Text, out idMovimiento))
            {
                MessageBox.Show("Por favor, ingresa un ID de movimiento válido.");
                return;
            }
            capa_Controlador_Logistica.GenerarPDFMovimientoInventario(idMovimiento);
        }
    }
}
