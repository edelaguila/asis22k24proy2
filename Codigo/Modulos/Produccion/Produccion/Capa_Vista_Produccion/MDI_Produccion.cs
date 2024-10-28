using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Cierre_Produccion;
using Capa_Vista_Polizas_Prod;

namespace Capa_Vista_Produccion
{
    public partial class MDI_Produccion : Form
    {
        // Variables para capturar la posición y el tamaño del formulario antes de maximizar
        int lx, ly;
        int sw, sh;

        public MDI_Produccion(string idUsuario)
        {
            InitializeComponent();
            ocultaSubMenu(); // Solo oculta los menús al inicio
            lbl_user.Text = idUsuario;

            // Configura el evento Tick de timer1 y comienza a ejecutarlo
            timer1.Tick += ActualizarFechaHora;
            timer1.Interval = 1000; // 1 segundo
            timer1.Start(); // Iniciar el Timer
        }

        string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

        // Ocultar submenús al iniciar (sin cerrar al abrir otro)
        private void ocultaSubMenu()
        {
            panelMenuProcesos.Visible = false;
            panelMenuMantenimiento.Visible = false;
        }

        // Evento Tick del Timer para actualizar la fecha y hora
        private void ActualizarFechaHora(object sender, EventArgs e)
        {
            lbl_fecha_y_hora.Text = DateTime.Now.ToString("G"); // Muestra la fecha y hora actual
        }

        // Mostrar u ocultar submenús (ahora se permite que los dos estén abiertos al mismo tiempo)
        private void muestraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true; // Solo muestra el panel si está oculto
            }
            else
            {
                subMenu.Visible = false; // Oculta el panel si ya está visible
            }
        }

        // Función para cerrar el formulario
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Funcionalidades de botones de procesos
        // Botón de mantenimiento
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Mantenimientos
            */
        }

        // Botón de órdenes de producción
        private void btnOrdenesProduccion_Click(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Órdenes de Producción
            */
        }

        // Botón de maquinaria
        private void btnMaquinaria_Click_1(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Recetas
            */
        }

        // Botón de empleados (enlace a RRHH)
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de RRHH
            */
        }

        // Botón de cierre
        private void btnCierre_Click(object sender, EventArgs e)
        {
            Frm_Cierre Cierre = new Frm_Cierre();
            Cierre.Show();
        }

        // Botón de implosión/explosión de materiales
        private void btnImplosionExplosion_Click(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Implosión y Explosión
            */
        }

        // Botón de sistema de producción
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Producción
            */
        }

        // Botón de enlace a contabilidad (Pólizas)
        private void btnPolizas_Click(object sender, EventArgs e)
        {
            Frm_Polizas_Prod polizas = new Frm_Polizas_Prod();
            polizas.Show();
        }

        // Botón de conversiones
        private void btnConversiones_Click_1(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Conversiones
            */
        }

        // Botón de series
        private void btnSeries_Click_1(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Series
            */
        }

        // Botón de lotes
        private void btnLotes_Click_1(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Lotes
            */
        }
        #endregion

        // Mostrar el submenú de procesos
        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuProcesos);
        }

        // Mostrar el submenú de mantenimiento
        private void btnMenuMantenimiento_Click_1(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuMantenimiento);
        }

        // Minimizar el formulario
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Maximizar el formulario
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            // Capturar la posición y el tamaño antes de maximizar
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void Btn_Recetas_Click_1(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Recetas
            */
        }

        // Restaurar el tamaño original de la ventana
        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        // Función para salir del formulario
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
