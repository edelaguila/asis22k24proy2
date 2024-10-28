using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using CrystalDecisions.Windows.Forms;



namespace Capa_Vista_EstadosFinancieros
{
    public partial class EstadosFinancieros : Form
    {
        public EstadosFinancieros()
        {
            InitializeComponent();
        }

        private void btn_Ver_Balance_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "ReportesEstados", "Balance.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private void btn_VerFlujo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "ReportesEstados", "FlujoDeEfectivo.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private void btn_VerEstadoResultados_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "ReportesEstados", "EstadoDeResultados.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private void btn_Ver_BalanceHistorico_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "ReportesEstados", "BalanceHistorico.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private void btn_Ver_EResultadosHistorico_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "ReportesEstados", "EstadoDeResultadosHistorico.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private void btn_Ver_FEfectivoHistorico_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "ReportesEstados", "FlujoDeEfectivoHistorico.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }
    }
}