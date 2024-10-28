using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Capa_Controlador_OrdenCompra;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Necesario para Directory, File, Path y SearchOption


namespace Capa_Vista_OrdenCompra
{
    public partial class frm_OrdenCompra : Form
    {
        logica logic;

        public frm_OrdenCompra()
        {
            InitializeComponent();

            Dgv_aplicaciones_asignados.Enabled = true;
        }

        public void actualizardatagriew()
        {


            try
            {
                // Obtener los datos desde la base de datos
                DataTable dt = logic.funConsultaLogicaOrdenes("Tbl_detalle_ordenes_compra");

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    Dgv_aplicaciones_asignados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar los datos: {ex.Message}");
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            frm_generarOrdenParaCompra generarOrdenForm = new frm_generarOrdenParaCompra();
            generarOrdenForm.ShowDialog(); // Abre el formulario como modal

        }

        private void frm_OrdenCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
