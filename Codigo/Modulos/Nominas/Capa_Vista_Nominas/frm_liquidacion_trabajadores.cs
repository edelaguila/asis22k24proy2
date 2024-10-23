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
    public partial class frm_liquidacion_trabajadores : Form
    {
        private static frm_liquidacion_trabajadores instancia = null;
        public static frm_liquidacion_trabajadores ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_liquidacion_trabajadores();
            }
            return instancia;
        }

        public frm_liquidacion_trabajadores()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Gabriela Suc ----------------------------------
            //Utilizando navegador
            string[] alias = { "pk_registro_liquidacion", "aguinaldo", "bono_14", "vacaciones", "tipo_operacion", "fk_clave_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightGray);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_liquidacion_trabajadores");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Liquidación de empleados");


            navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "nombre", 1);


        }
    }
}
