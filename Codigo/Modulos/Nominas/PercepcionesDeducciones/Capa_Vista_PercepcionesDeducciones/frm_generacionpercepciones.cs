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
    public partial class frm_generacionpercepciones : Form
    {
        private Controlador cn = new Controlador();
        public frm_generacionpercepciones()
        {
            InitializeComponent();
            CargarPercepciones();
            Dgv_genpercepciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarPercepciones()
        {
            // Llama al método del controlador y asigna los datos al DataGridView
            DataTable percepciones = cn.ObtenerPercepciones();
            Dgv_genpercepciones.DataSource = percepciones;
        }
    }
}
