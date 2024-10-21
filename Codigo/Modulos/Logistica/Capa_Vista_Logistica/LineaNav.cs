using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Logistica
{
    public partial class LineaNav : Form
    {
        public LineaNav()
        {
            InitializeComponent();
            string idUsuario = "9009";
            string[] alias = { "ID Producto", "CódProducto", "NomProducto", "MedProducto", "PrecUnitario", "Clasificación", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_Productos");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Productos");

            // Configurar el DataGridView para que responda a clics en las celdas
            navegador1.Dgv_Informacion.CellClick += DgvTrasDProductos_CellClick; // Asegúrate de que DgvAlmacenes esté definido

        }
        private void DgvTrasDProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada es válida
            if (e.RowIndex >= 0)
            {
                // Obtener datos de la fila seleccionada, por ejemplo, el ID de la bodega
                DataGridViewRow row = navegador1.Dgv_Informacion.Rows[e.RowIndex];
                string idProductos = row.Cells["Pk_id_Producto"].Value.ToString();  // Asegúrate de que el nombre del campo sea correcto

                // Abrir el formulario TrasladoDProductos y pasarle el ID de la TrasDProductos
                Linea linea = new Linea(idProductos);
                linea.Show();
            }
        }
    }
}
