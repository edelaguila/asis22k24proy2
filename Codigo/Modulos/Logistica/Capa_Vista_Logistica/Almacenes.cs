using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Logistica;


namespace Capa_Vista_Logistica
{
    public partial class Almacenes : Form
    {
        public Almacenes()
        {
            InitializeComponent();
            string idUsuario = "9003";
            string[] alias = { "ID Bodega", "Nombre Bodega", "Ubicación", "Capacidad", "Fecha Registro", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("TBL_BODEGAS");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("ALMACEN");

            // Configurar el DataGridView para que responda a clics en las celdas
            navegador1.Dgv_Informacion.CellClick += DgvAlmacenes_CellClick; // Asegúrate de que DgvAlmacenes esté definido
        }

        // Evento que se dispara al hacer clic en una celda del DataGridView
        private void DgvAlmacenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada es válida
            if (e.RowIndex >= 0)
            {
                // Obtener datos de la fila seleccionada, por ejemplo, el ID de la bodega
                DataGridViewRow row = navegador1.Dgv_Informacion.Rows[e.RowIndex];
                string idBodega = row.Cells["Pk_ID_BODEGA"].Value.ToString();  // Asegúrate de que el nombre del campo sea correcto

                // Abrir el formulario MonitoreoAlmacen y pasarle el ID de la bodega
                MonitoreoAlmacen monitoreoForm = new MonitoreoAlmacen(idBodega);
                monitoreoForm.Show();
            }
        }
    }
}
