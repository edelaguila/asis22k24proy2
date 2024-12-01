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
using CapaControladorActivofijo;
using CrystalDecisions.Windows.Forms;
using System.IO;

namespace CapaVistaActivofijo
{
    public partial class Frm_VistadeActivofijo : Form
    {
        private ReportDocument reporte;
        public Frm_VistadeActivofijo()
        {
            InitializeComponent();

            reporte = new ReportDocument();
           
        }

        public void CargarDatosDepreciacion(int idActivoFijo)
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Obtener los registros de depreciación para el ID del activo fijo
            DataTable dtDepreciacion = cn.ObtenerRegistrosDepreciacion(idActivoFijo);

            // Asignar el DataTable al DataGridView que usas para mostrar los datos de depreciación
            Dgv_Depreciacion.DataSource = dtDepreciacion; // Cambiar a dataGridViewDepreciacion

            // Si deseas realizar alguna configuración adicional del DataGridView
            Dgv_Depreciacion.AutoResizeColumns();
        }
       


        public string ReportFilePath { get; set; } = @"C:\Users\DELL\Desktop\labo analisis\Activofijoreal\MVCactivofijos\CapaVistaActivofijo\CrystalReport3.rpt";
        public void Btn_reporte_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de reporte
            FormReporteunitario reporteForm = new FormReporteunitario();

            // Crear una instancia del reporte
            ReportDocument reportDocument = new ReportDocument();

            // Verificar si el archivo .rpt existe
            if (!File.Exists(ReportFilePath))
            {
                ShowMessage("El archivo de reporte no se encontró:");
                return;
            }

            // Cargar el archivo .rpt
            reportDocument.Load(ReportFilePath);

            // Crear un DataTable que contenga los datos que quieres mostrar en el reporte
            DataTable dtReportData = (DataTable)Dgv_Depreciacion.DataSource;

            // Asignar el DataTable al reporte
            reportDocument.SetDataSource(dtReportData);

            // Asignar el reporte al CrystalReportViewer en el formulario
            reporteForm.crystalReportViewer1.ReportSource = reportDocument;

            // Mostrar el formulario de reporte
            reporteForm.Show();

        }

        private void ShowMessage(string v)
        {
            throw new NotImplementedException();
        }
       

        private void Dgv_Depreciacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_depreci_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de reporte
            FormReporteunitario reporteForm = new FormReporteunitario();

            // Crear una instancia del reporte
            ReportDocument reportDocument = new ReportDocument();

            // Verificar si el archivo .rpt existe
            if (!File.Exists(ReportFilePath))
            {
                ShowMessage("El archivo de reporte no se encontró:");
                return;
            }

            // Cargar el archivo .rpt
            reportDocument.Load(ReportFilePath);

            // Crear un DataTable que contenga los datos que quieres mostrar en el reporte
            DataTable dtReportData = (DataTable)Dgv_Depreciacion.DataSource;

            // Asignar el DataTable al reporte
            reportDocument.SetDataSource(dtReportData);

            // Asignar el reporte al CrystalReportViewer en el formulario
            reporteForm.crystalReportViewer1.ReportSource = reportDocument;

            // Mostrar el formulario de reporte
            reporteForm.Show();
        }
    }
      
}
    


