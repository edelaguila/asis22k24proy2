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
    public partial class frm_genpercepciones : Form
    {
        Controlador cn = new Controlador();
        public frm_genpercepciones()
        {
            InitializeComponent();
            CargarPercepciones();
            dgv_percepciones.Columns[0].HeaderText = "Nombre Empleado";
            dgv_percepciones.Columns[1].HeaderText = "Apellido Empleado";
            dgv_percepciones.Columns[2].HeaderText = "Concepto";
            dgv_percepciones.Columns[3].HeaderText = "Tipo";
            dgv_percepciones.Columns[4].HeaderText = "Cantidad";


        }

        private void CargarPercepciones()
        {


            //// Cargar deducciones en la DataGridView
            DataTable deducciones = cn.ObtenerPercepciones();
            dgv_percepciones.DataSource = deducciones;
        }

        private void CalcularDeduccionesYPercepciones()
        {
            //// Calcular deducciones para todos los empleados


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularDeduccionesYPercepciones();
            CargarPercepciones();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarPercepciones();
        }
    }
}
