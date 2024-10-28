using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Contabilidad;
namespace Capa_Vista_Contabilidad
{
    public partial class VIstaActivofijo : Form
    {
        public VIstaActivofijo()
        {
            InitializeComponent();
        }
        public void CargarDatosDepreciacion(int idActivoFijo)
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Obtener los registros de depreciación para el ID del activo fijo
            DataTable dtDepreciacion = cn.ObtenerRegistrosDepreciacion(idActivoFijo);

            // Asignar el DataTable al DataGridView que usas para mostrar los datos de depreciación
            dataGridView1.DataSource = dtDepreciacion; // Cambiar a dataGridViewDepreciacion

            // Si deseas realizar alguna configuración adicional del DataGridView
            dataGridView1.AutoResizeColumns();
        }
    }
}
