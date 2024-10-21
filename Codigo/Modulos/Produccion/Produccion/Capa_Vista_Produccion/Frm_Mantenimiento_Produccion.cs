using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Mantenimiento_Produccion : Form // Nombre del formulario actualizado
    {
        public Frm_Mantenimiento_Produccion()
        {
            InitializeComponent();

            // Alias actualizados para los campos de la tabla Mantenimiento Producción
            string[] alias = { "ID", "Nombre", "Descripción", "Detalles", "Costo", "Precio Venta", "Stock", "Creación", "Estado" };

            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue); // Color de fondo
            navegador1.AsignarColorFuente(Color.BlueViolet); // Color de fuente
            navegador1.ObtenerIdAplicacion("1000"); // ID de aplicación diferente
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("Tbl_Mantenimiento_Produccion");
            navegador1.AsignarNombreForm("Mantenimiento de Producción");
            //List<string> tablas = new List<string> { "detallefactura", "pagos" };
            //navegador1.AsignarTablas(tablas);
        }
    }
}
