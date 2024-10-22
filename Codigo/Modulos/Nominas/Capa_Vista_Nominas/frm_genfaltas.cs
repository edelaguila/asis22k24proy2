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
    public partial class frm_genfaltas : Form
    {
        private static frm_genfaltas instancia = null;
        public static frm_genfaltas ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_genfaltas();
            }
            return instancia;
        }
        public frm_genfaltas()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*Marco Alejandro Monroy**/
            /****Prueba con navegador****/
            string[] alias = { "pk_registro_faltas", "fecha_falta", "mes", "justificacion", "fk_clave_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightGray);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_control_faltas");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Control de Faltas");


            navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "nombre",  1);
            /****************/






        }
    }
}
