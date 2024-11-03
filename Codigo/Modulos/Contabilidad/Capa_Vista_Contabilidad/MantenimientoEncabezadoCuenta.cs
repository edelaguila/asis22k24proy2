﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Contabilidad
{
    public partial class MantenimientoEncabezadoCuenta : Form
    {
        public MantenimientoEncabezadoCuenta()
        {
            InitializeComponent();

            string idusuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // --------------- TABLA MANTENIMIENTO ------------------------
            string[] alias = { "codigo", "nombre", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idusuario);
            navegador1.AsignarTabla("tbl_encabezadoclasecuenta");


            navegador1.AsignarNombreForm("CLASE CUENTA");

        }
    }
}
