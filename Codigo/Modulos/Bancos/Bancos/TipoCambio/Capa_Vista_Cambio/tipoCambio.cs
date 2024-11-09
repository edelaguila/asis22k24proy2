using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Cambio;

namespace Capa_Vista_Cambio
{
    public partial class tipoCambio : Form
    {

        public DataTable tiposDeCambio;
        public Controlador capaControlador = new Controlador();
        private ToolTip toolTip;

        public tipoCambio()
        {
            InitializeComponent();
            llenarCombo();
            toolTip = new ToolTip();
            toolTip.SetToolTip(btnBuscar, "Buscar Moneda");
            toolTip.SetToolTip(btnActualizar, "Actualizar Vista");
        }

        private void llenarCombo()
        {
            List<string> nombresMonedas = capaControlador.ObtenerNombresMonedas();
            cboMonedas.Items.Clear();
            cboMonedas.Items.Add("Seleccionar...");
            foreach (string nombreMoneda in nombresMonedas)
            {
                cboMonedas.Items.Add(nombreMoneda);
            }
            if (cboMonedas.Items.Count > 0)
            {
                cboMonedas.SelectedIndex = 0;
            }
        }

        public void tipoCambio_Load(object sender, EventArgs e)
        {
            tiposDeCambio = capaControlador.ObtenerTipoCambio();
            dgvTipoCambio.DataSource = tiposDeCambio;
            dgvTipoCambio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreMonedaSeleccionada = cboMonedas.SelectedItem.ToString();
            int filaEncontrada = capaControlador.BuscarMoneda(tiposDeCambio, nombreMonedaSeleccionada);

            if (filaEncontrada != -1)
            {
                dgvTipoCambio.ClearSelection();
                dgvTipoCambio.Rows[filaEncontrada].Selected = true;
                dgvTipoCambio.FirstDisplayedScrollingRowIndex = filaEncontrada;
            }
            else
            {
                MessageBox.Show("Moneda no encontrada.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            llenarCombo();
            dgvTipoCambio.ClearSelection();
        }
    }
}
