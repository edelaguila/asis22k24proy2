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
    public partial class MantenimientoNav : Form
    {
        public MantenimientoNav()
        {
            InitializeComponent();
            string idUsuario = "9007";
            string[] alias = { "id_vehiculo", "numeroPlaca", "marca", "color", "descripcion", "horaLlegada", "horaSalida", "totalBultos", "pesoTotal", "id_chofer", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_vehiculos");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimiento");
            navegador1.Dgv_Informacion.CellClick += DgvMantenimiento_CellClick;

        }
        private void DgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada es válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = navegador1.Dgv_Informacion.Rows[e.RowIndex];
                string Pk_id_Mantenimiento = row.Cells["Pk_id_vehiculo"].Value.ToString();  // Asegúrate de que el nombre del campo sea correcto

                MantenimientoVehiculos movInventario = new MantenimientoVehiculos(Pk_id_Mantenimiento);
                movInventario.Show();
            }
        }
    }
}
