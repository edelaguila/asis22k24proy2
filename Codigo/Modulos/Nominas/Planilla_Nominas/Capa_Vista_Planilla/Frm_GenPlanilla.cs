using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Capa_Controlador_Planilla;

namespace Capa_Vista_Planilla
{
    public partial class Frm_GenPlanilla : Form
    {
        Controlador cn = new Controlador();
        String valorSeleccionado;
        String valorSeleccionado2;
        public Frm_GenPlanilla()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(Btn_insertar, "Insertar un nuevo registro");
            toolTip.SetToolTip(Btn_guardar, "Guardar el registro actual");
            toolTip.SetToolTip(Btn_editar, "Editar el registro seleccionado");

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

            string tabla = "tbl_empleados";
            string campo1 = "pk_clave";
            string campo2 = "empleados_nombre";

            string tablaEnca = " tbl_planilla_Encabezado";
            string campo1Enca = "pk_registro_planilla_Encabezado";
            string campo2Enca = "encabezado_correlativo_planilla";


            // Llama al método para llenar el ComboBox
            llenarseEmpleados(tabla, campo1, campo2);
            llenarseEncabezado(tablaEnca, campo1Enca, campo2Enca);

        }

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        public void llenarseEmpleados(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = cn.enviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_ClaveEmpleado.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_ClaveEmpleado.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cbo_ClaveEmpleado.AutoCompleteCustomSource = coleccion;
            Cbo_ClaveEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_ClaveEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_ClaveEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_ClaveEmpleado.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)Cbo_ClaveEmpleado.SelectedItem;
                 valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                Console.Write($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }

        /******************************************************************************************/

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 2*****************************************************/

        public void llenarseEncabezado(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = cn.enviar2(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_CEncabezado.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_CEncabezado.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion2.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion2.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cbo_CEncabezado.AutoCompleteCustomSource = coleccion2;
            Cbo_CEncabezado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_CEncabezado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem2
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_CEncabezado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_CEncabezado.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)Cbo_CEncabezado.SelectedItem;
                valorSeleccionado2 = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                Console.Write($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }

        /**********************************************************************************************/


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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Método para habilitar o deshabilitar los controles
        private void ConfigurarControles1(bool habilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            Txt_ClaveEncabezado.Enabled = habilitar;
            Txt_Correlativo.Enabled = habilitar;
            dtp_inicio.Enabled = habilitar;
            dtp_final.Enabled = habilitar;


            Btn_guardar.Enabled = habilitar;
            Btn_editar.Enabled = habilitar;

        }

        private void LimpiarFormulario()
        {


            Txt_ClaveEncabezado.Text = "";
            Txt_Correlativo.Text = "";

        }


        private void ConfigurarControles2(bool habilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            Txt_ClaveDetalle.Enabled = habilitar;
            Cbo_ClaveEmpleado.Enabled = habilitar;
            Cbo_CEncabezado.Enabled = habilitar;



            Btn_guardarPlanilla.Enabled = habilitar;
            Btn_editarPlanilla.Enabled = habilitar;

        }

        private void LimpiarFormulari2()
        {


            Txt_ClaveEncabezado.Text = "";
            Txt_Correlativo.Text = "";

        }



        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            ConfigurarControles1(true);
            //LimpiarFormulario();
            //Txt_Correlativo.Focus();
            //Btn_editar.Enabled = false;


        }

        private void Btn_editarPlanilla_Click(object sender, EventArgs e)
        {

        }

        private void Btn_guardarPlanilla_Click(object sender, EventArgs e)
        {
            int pkRegistroPlanillaDetalle = Convert.ToInt32(Txt_ClaveDetalle.Text);
            //var selectedEmpleado = (ComboBoxItem)Cbo_ClaveEmpleado.SelectedItem;
            //var selectedEncabezado = (ComboBoxItem)Cbo_CEncabezado.SelectedItem;

            //// Obtener nombres
            //string nombreEmpleado = selectedEmpleado.Value;
            //string nombreAplicacion = selectedEncabezado.Value;

            //MessageBox.Show(nombreEmpleado);
            //MessageBox.Show(nombreAplicacion);


            int fkIdRegistroPlanillaEncabezado = Convert.ToInt32(valorSeleccionado2); // ID del encabezado de la planilla
            int fkClaveEmpleado = Convert.ToInt32(valorSeleccionado); // ID del empleado


            bool exito = cn.EjecutarCalculoPlanilla(pkRegistroPlanillaDetalle, fkIdRegistroPlanillaEncabezado, fkClaveEmpleado);

            if (exito)
            {
                MessageBox.Show("Cálculo de planilla completado con éxito.");
                CargarDetalle();
                ConfigurarControles1(false);
                LimpiarFormulario();

            }
            else
            {
                MessageBox.Show("Error al calcular la planilla.");
            }

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            int correlativo = Convert.ToInt32(Txt_Correlativo.Text);
            DateTime fechaInicio = dtp_inicio.Value;
            DateTime fechaFinal = dtp_final.Value;
            decimal totalMes = 0; // Puedes calcular o asignar este valor como sea necesario.

            Controlador controlador = new Controlador();
            bool resultado = controlador.AgregarPlanillaEncabezado(correlativo, fechaInicio, fechaFinal, totalMes);

            if (resultado)
            {
                CargarEncabezado();
                MessageBox.Show("Encabezado de planilla agregado correctamente.");

                string tablaEnca = " tbl_planilla_Encabezado";
                string campo1Enca = "pk_registro_planilla_Encabezado";
                string campo2Enca = "encabezado_correlativo_planilla";

                llenarseEncabezado(tablaEnca, campo1Enca, campo2Enca);
                ConfigurarControles1(false);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al agregar el encabezado de planilla.");
            }
        }

        private void Btn_insertarPlanilla_Click(object sender, EventArgs e)
        {
            ConfigurarControles1(true);
        }
    }
}
