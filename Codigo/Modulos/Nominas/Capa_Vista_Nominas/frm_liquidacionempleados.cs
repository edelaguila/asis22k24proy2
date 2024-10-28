﻿using System;
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
    public partial class frm_liquidacionempleados : Form
    {

        private static frm_liquidacionempleados instancia = null;
        public static frm_liquidacionempleados ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_liquidacionempleados();
            }
            return instancia;
        }


        public frm_liquidacionempleados()
        {
            InitializeComponent();


            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Gabriela Suc ----------------------------------
            // Utilizando navegador
            string[] alias = { "pk_registro_liquidacion", "liquidacion_aguinaldo", "liquidacion_bono_14", "liquidacion_vacaciones", "liquidacion_tipo_operacion", "fk_clave_empleado", "estado" };
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
