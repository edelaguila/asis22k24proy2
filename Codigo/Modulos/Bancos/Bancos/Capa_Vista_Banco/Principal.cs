using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Banco
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovimientoBancario form2 = new MovimientoBancario(); // Crea una instancia del segundo formulario
            form2.Show(); // Muestra el segundo formulario
            //this.Hide(); // Oculta el formulario actual (opcional)
        }

        private void tipo_Cambio_Click(object sender, EventArgs e)
        {
            tipoCambio frmTipoCambio = new tipoCambio();
            frmTipoCambio.Show();
        }
    }
}
