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

        public void CargarDatosMantenimiento(int idActivoFijo)
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Obtener los registros de mantenimiento para el ID del activo fijo
            DataTable dtMantenimiento = cn.ObtenerRegistrosHistorialServicio(idActivoFijo);

            // Asignar el DataTable al DataGridView que usas para mostrar los datos de mantenimiento
            Dgv_Mantenimiento.DataSource = dtMantenimiento;

            // Configuración adicional del DataGridView si es necesario
            Dgv_Mantenimiento.AutoResizeColumns();
        }



        public void Btn_reporte_Click(object sender, EventArgs e)
        {
           

        }

        private void ShowMessage(string v)
        {
            throw new NotImplementedException();
        }
       

        private void Dgv_Depreciacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string FindFileInDirectoryReporte(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.rpt", SearchOption.TopDirectoryOnly);
                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }
            // Retorna null si no se encontró el archivo
            return null;
        }
        public FormReporteunitario FormReporteunitario;
        public async void Btn_depreci_Click(object sender, EventArgs e)
        {
            try
            {
                // Espera de 500 ms antes de continuar
                await Task.Delay(500);

                // Crear una nueva instancia del formulario
                FormReporteunitario = new FormReporteunitario();

                // Establecer la posición de inicio del formulario
                FormReporteunitario.StartPosition = FormStartPosition.CenterScreen;

                // Mostrar el formulario
                FormReporteunitario.Show();

                // Confirmar que el formulario se abrió
                MessageBox.Show("Formulario abierto");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de excepción
                MessageBox.Show($"Ocurrió un error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        

        private void Dgv_Mantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gpb_datosacti_Enter(object sender, EventArgs e)
        {

        }
    }
      
}
    


