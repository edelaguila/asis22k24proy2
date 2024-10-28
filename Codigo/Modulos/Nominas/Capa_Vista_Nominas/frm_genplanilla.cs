using Capa_Controlador_Nominas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Nominas
{
    public partial class frm_genplanilla : Form
    {
        Controlador cn = new Controlador();
        public frm_genplanilla()
        {
            InitializeComponent();
            CargarEncabezado();
            CargarDetalle();
            dgv_encabezado.Columns[0].HeaderText = "Clave encabezado";
            dgv_encabezado.Columns[1].HeaderText = "Correlativo";
            dgv_encabezado.Columns[2].HeaderText = "Fecha Inicio";
            dgv_encabezado.Columns[3].HeaderText = "Fecha Final";
            dgv_encabezado.Columns[4].HeaderText = "Total Mes";

            dgv_detalle.Columns[0].HeaderText = "Clave Detalle";
            dgv_detalle.Columns[1].HeaderText = "Total Percepciones";
            dgv_detalle.Columns[2].HeaderText = "Total Deducciones";
            dgv_detalle.Columns[3].HeaderText = "Total Liquido";
            dgv_detalle.Columns[4].HeaderText = "Empleado";
            dgv_detalle.Columns[4].HeaderText = "Contrato";
            dgv_detalle.Columns[4].HeaderText = "Detalle Encabezado";

            List<string> items = new List<string> { "1", "2", "3" };
            Cmb_Empleado.DataSource = items;

            List<string> items2 = new List<string> { "1", "2", "3" };
            Cmb_Encabezado.DataSource = items2;

        }
        private void CalcularTotalDeduPer(String clave, String Empleado, String Encabezado)
        {
            //// Calcular deducciones para todos los empleados
           // cn.CalcularTotalDeduPer(clave, Empleado, Encabezado);

        }

        private void CalcularLiquidacion()
        {
            //// Calcular deducciones para todos los empleados
           // cn.CalcularLiquidacion();

        }

        private void CargarEncabezado()
        {


            //// Cargar deducciones en la DataGridView
            DataTable encabezado = cn.ObtenerEncabezado();
            dgv_encabezado.DataSource = encabezado;
        }
        private void CargarDetalle()
        {


            //// Cargar deducciones en la DataGridView
            DataTable detalle = cn.ObtenerDetalle();
            dgv_detalle.DataSource = detalle;
        }



        private void Lbl_empleado_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_NuevoDetalle_Click(object sender, EventArgs e)
        {

           String clave = Txt_Clave.Text;////Clave

           String empleado = Cmb_Empleado.SelectedItem.ToString(); // Asignar la pregunta seleccionada en cmb;  // Nueva línea para la pregunta de seguridad
           String encabezado = Cmb_Encabezado.SelectedItem.ToString(); // Asignar la pregunta seleccionada en cmb;  // Nueva línea para la pregunta de seguridad



           CalcularTotalDeduPer(clave, empleado, encabezado);
           CalcularLiquidacion();
           CargarDetalle();


        }
    }
}
