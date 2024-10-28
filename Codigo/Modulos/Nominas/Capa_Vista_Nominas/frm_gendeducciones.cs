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
    public partial class frm_gendeducciones : Form
    {
        Controlador cn = new Controlador();
        public frm_gendeducciones()
        {
            InitializeComponent();
            CargarDeducciones();
            dgv_deducciones.Columns[0].HeaderText = "Nombre Empleado";
            dgv_deducciones.Columns[1].HeaderText = "Apellido Empleado";
            dgv_deducciones.Columns[2].HeaderText = "Concepto";
            dgv_deducciones.Columns[3].HeaderText = "Tipo";
            dgv_deducciones.Columns[4].HeaderText = "Cantidad";



        }

        private void CargarDeducciones()
        {


            DataTable deducciones = cn.ObtenerDeducciones();
            dgv_deducciones.DataSource = deducciones;
        }

        private void CalcularDeduccionesYPercepciones()
        {
            //// Calcular deducciones para todos los empleados
  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularDeduccionesYPercepciones();
            CargarDeducciones();

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarDeducciones();
        }
    }
}
