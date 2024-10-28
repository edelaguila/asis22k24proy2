using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Controlador_Contabilidad;

namespace Capa_Vista_Contabilidad
{
    public partial class DatoActivo : Form
    {
        Controlador cn = new Controlador();
        public DatoActivo()
        {
            InitializeComponent();
            actualizarDataGridView();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string emp = "tbl_activofijo";

        public void actualizarDataGridView()
        {
            // Llama al método llenarTablaActivoFijo y obtiene el DataTable
            DataTable dt = cn.llenarTablaActivoFijo(emp);

            // Asigna el DataTable como DataSource del DataGridView
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Asegurarse de que se ha seleccionado una fila válida
            if (e.RowIndex < 0) return;

            // Obtener los datos de la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

            // Obtener el ID del activo fijo
            int idActivoFijo = Convert.ToInt32(filaSeleccionada.Cells["ID_Activo"].Value);

            // Crear una instancia de frmActivoFijo (o la forma que uses para los activos fijos)
            VIstaActivofijo formActivoFijo = new VIstaActivofijo();

            // Establecer la pestaña activa en el TabControl
            formActivoFijo.a.SelectedTab = formActivoFijo.tabPage1; // Cambia a tabPage1

            // Pasar los datos a los controles en frmActivoFijo
            formActivoFijo.txtCodigoActivo.Text = filaSeleccionada.Cells["Codigo_Activo"].Value.ToString();
            formActivoFijo.txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            formActivoFijo.txtModelo.Text = filaSeleccionada.Cells["Modelo"].Value.ToString();
            formActivoFijo.dtpFechaAdquisicion.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha_de_Aquisicion"].Value);
            formActivoFijo.txtCostoAdquisicion.Text = filaSeleccionada.Cells["Costo_de_Aquisicion"].Value.ToString();
            formActivoFijo.txtVidaUtil.Text = filaSeleccionada.Cells["Vida_Util"].Value.ToString();
            formActivoFijo.txtValorResidual.Text = filaSeleccionada.Cells["Valor_Residual"].Value.ToString();
            formActivoFijo.txtEstado.Text = filaSeleccionada.Cells["Estado"].Value.ToString();
            formActivoFijo.txtIDActivoFijo.Text = filaSeleccionada.Cells["ID_Activo"].Value.ToString();

            // Nuevos campos a manejar
            formActivoFijo.txtTipoActivo.Text = filaSeleccionada.Cells["ID_Tipo_Activo"].Value.ToString(); // Tipo de Activo
            formActivoFijo.txtMarca.Text = filaSeleccionada.Cells["ID_Marca"].Value.ToString(); // Marca
            formActivoFijo.txtCuenta.Text = filaSeleccionada.Cells["ID_Cuenta"].Value.ToString(); // Cuenta

            // Inhabilitar los controles de frmActivoFijo
            DeshabilitarControles(formActivoFijo);

            // Cargar los datos de depreciación en un DataGridView en formActivoFijo
            formActivoFijo.CargarDatosDepreciacion(idActivoFijo);

            formActivoFijo.StartPosition = FormStartPosition.CenterScreen;

            // Mostrar frmActivoFijo
            formActivoFijo.ShowDialog();
        }

        private void DeshabilitarControles(VIstaActivofijo formActivoFijo)
        {
            formActivoFijo.txtCodigoActivo.Enabled = false;
            formActivoFijo.txtDescripcion.Enabled = false;
            formActivoFijo.txtModelo.Enabled = false;
            formActivoFijo.dtpFechaAdquisicion.Enabled = false;
            formActivoFijo.txtCostoAdquisicion.Enabled = false;
            formActivoFijo.txtVidaUtil.Enabled = false;
            formActivoFijo.txtValorResidual.Enabled = false;
            formActivoFijo.txtEstado.Enabled = false;
            formActivoFijo.txtIDActivoFijo.Enabled = false;
            formActivoFijo.txtTipoActivo.Enabled = false; // Deshabilitar Tipo de Activo
            formActivoFijo.txtMarca.Enabled = false; // Deshabilitar Marca
            formActivoFijo.txtCuenta.Enabled = false; // Deshabilitar Cuenta
        }
        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            await Task.Delay(500); // Espera de 500 ms
            Depreciacionactivofijo form2 = new Depreciacionactivofijo(); // Cambiar a PRUEBA3
            form2.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            form2.Show(); // Mostrar el formulario
        }

        private void btndepreci_Click(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
