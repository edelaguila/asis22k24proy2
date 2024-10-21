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
    public partial class Frm_Ordenes_De_Produccion : Form
    {
        public Frm_Ordenes_De_Produccion()
        {
            InitializeComponent();
            string[] alias = { "ID", "Fecha inicio", "Fecha Fin", "Cantidad", "Costo Total", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_ordenes_produccion");
            navegador1.AsignarNombreForm("Órdenes de Producción");
            //List<string> tablas = new List<string> { "detallefactura", "pagos" };
            //navegador1.AsignarTablas(tablas);
        }
    }
}
