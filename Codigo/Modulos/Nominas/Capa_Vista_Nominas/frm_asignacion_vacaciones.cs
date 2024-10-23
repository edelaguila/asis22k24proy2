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
    public partial class frm_asignacion_vacaciones : Form
    {
        private static frm_asignacion_vacaciones instancia = null;
        public static frm_asignacion_vacaciones ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_asignacion_vacaciones();
            }
            return instancia;
        }


        public frm_asignacion_vacaciones()
        {
            InitializeComponent();


            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Gabriela Suc ----------------------------------
            //Utilizando navegador
            string[] alias = { "pk_registro_vacaciones", "descripcion", "fecha_inicio", "fecha_fin", "fk_clave_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightGray);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_asignacion_vacaciones");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Asignación de vacaciones");


            navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "nombre", 1);
        }
    }
}
