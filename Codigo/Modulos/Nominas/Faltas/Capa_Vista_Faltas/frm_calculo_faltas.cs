using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Faltas;

namespace Capa_Vista_Faltas
{
    public partial class frm_calculo_faltas : Form
    {
        private readonly Controlador controlador = new Controlador();

        public frm_calculo_faltas()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarTodasLasFaltas();
            CargarMeses();


        }

        // Cargar la lista de empleados en el ComboBox
        private void CargarEmpleados()
        {
            try
            {
                DataTable empleados = controlador.ObtenerEmpleados();
                Cbo_Empleados.DataSource = empleados;
                Cbo_Empleados.DisplayMember = "empleados_nombre";
                Cbo_Empleados.ValueMember = "pk_clave";
                Cbo_Empleados.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        // Cargar todas las faltas en el DataGridView
        private void CargarTodasLasFaltas()
        {
            try
            {
                DataTable faltas = controlador.ObtenerTodasLasFaltas();
                Dgv_Faltas.DataSource = faltas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar faltas: " + ex.Message);
            }
        }

        private void CargarMeses()
        {
            // Puedes reemplazar estos meses por una lista obtenida de la base de datos, si es necesario
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Cbo_Mes.DataSource = meses;
            Cbo_Mes.SelectedIndex = -1;
        }
        private void Dgv_Faltas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Calculo_Falta_Click_1(object sender, EventArgs e)
        {
            if (Cbo_Empleados.SelectedIndex != -1 && Cbo_Mes.SelectedIndex != -1)
            {
                int idEmpleado = Convert.ToInt32(Cbo_Empleados.SelectedValue);
                string mesSeleccionado = Cbo_Mes.SelectedItem.ToString();
                try
                {
                    int totalFaltas = controlador.CalcularFaltasEmpleado(idEmpleado, mesSeleccionado);
                    MessageBox.Show("Total de faltas en el mes de " + mesSeleccionado + ": " + totalFaltas);

                    // Guardar la deducción de faltas en la base de datos
                    controlador.GuardarDeduccionPorFaltas(idEmpleado, totalFaltas);
                    MessageBox.Show("La deducción por faltas se ha guardado correctamente.");

                    // Actualiza el DataGridView después del cálculo
                    CargarTodasLasFaltas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado y un mes.");
            }
        }


        private void Cbo_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_calculo_faltas_Load(object sender, EventArgs e)
        {

        }
    }
}

