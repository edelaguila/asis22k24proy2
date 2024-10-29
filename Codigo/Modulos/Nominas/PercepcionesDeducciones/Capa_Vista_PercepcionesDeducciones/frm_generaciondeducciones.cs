using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_PercepcionesDeducciones;

namespace Capa_Vista_PercepcionesDeducciones
{
    public partial class frm_generaciondeducciones : Form
    {
        private Controlador cn = new Controlador();
         public frm_generaciondeducciones()
        {
            InitializeComponent();
            CargarDeducciones();
            Dgv_gendeducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarDeducciones()
        {
            // Llama al método del controlador y asigna los datos al DataGridView
            DataTable percepciones = cn.ObtenerDeducciones();
            Dgv_gendeducciones.DataSource = percepciones;
        }
    }
}
