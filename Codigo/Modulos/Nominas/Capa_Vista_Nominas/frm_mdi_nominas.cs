using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Nominas;

namespace Capa_Vista_Nominas
{
    public partial class frm_mdi_nominas : Form
    {
        Controlador cn = new Controlador(); //Conexion capa controlador
        public frm_mdi_nominas()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_empleados frm = frm_empleados.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_departamentos frm = frm_departamentos.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void deduccionesPercepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_deducciones frm = frm_deducciones.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void nominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_nominas frm = frm_nominas.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void deduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_procesos_deducciones frm = frm_procesos_deducciones.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void percepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_procesos_percepciones frm = frm_procesos_percepciones.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_reportes frm = frm_reportes.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_seguridad frm = frm_seguridad.ventana_unica();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.BringToFront(); //Traer el form al frente
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
