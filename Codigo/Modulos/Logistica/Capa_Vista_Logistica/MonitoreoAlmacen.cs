using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Controlador_Logistica; // Para Controlador

namespace Capa_Vista_Logistica
{
    public partial class MonitoreoAlmacen : Form
    {
        private string idBodega; // Campo para almacenar el ID de la bodega
        Controlador controlador = new Controlador(); // Instancia del controlador

        // Constructor que recibe el ID de la bodega
        public MonitoreoAlmacen(string idBodega)
        {
            InitializeComponent();
            this.idBodega = idBodega;
            controlador = new Controlador(); // Inicializa el controlador

            // Cargar información de la bodega
            CargarInformacionBodega(idBodega);
        }

        private void CargarInformacionBodega(string idBodega)
        {
            MessageBox.Show("ID de Bodega seleccionado: " + idBodega);

            OdbcDataReader dr = controlador.ObtenerExistenciasBodega(idBodega);

            // Verificar si dr es null
            if (dr == null)
            {
                MessageBox.Show("No se pudieron obtener existencias para la bodega seleccionada.");
                return; // Salir del método si no hay datos
            }

            try
            {
                DataTable dtExistencias = new DataTable();
                dtExistencias.Load(dr);
                dgvExistencias.DataSource = dtExistencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las existencias: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar el DataReader
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
            }
        }

        private void CargarProductosPorBodega(string idBodega)
        {
            try
            {
                OdbcDataReader drProductos = controlador.ObtenerProductosPorBodega(idBodega);
                DataTable dtProductos = new DataTable();
                dtProductos.Load(drProductos);
                cmbProducto.DataSource = dtProductos;
                cmbProducto.DisplayMember = "nombreProducto"; // Cambia esto si tu columna tiene otro nombre
                cmbProducto.ValueMember = "Pk_id_Producto"; // Cambia esto si tu columna tiene otro nombre
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarExistencias_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado
            if (cmbBodega.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una bodega antes de cargar las existencias.");
                return; // Salir del método si no hay selección
            }

            // Obtener el ID de la bodega seleccionada
            string idBodega = cmbBodega.SelectedItem.ToString(); // Asegúrate de obtener el ID correcto
            controlador.CargarExistencias(idBodega);
        }

        private void btnRealizarAuditoria_Click(object sender, EventArgs e)
        {
            // Verificar si hay un producto seleccionado
            if (cmbProductoAuditoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un producto antes de realizar la auditoría.");
                return; // Salir del método si no hay selección
            }

            // Obtener valores de los controles de la interfaz
            string idProducto = cmbProductoAuditoria.SelectedValue.ToString();

            // Verificar que los campos de cantidad no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCantidadFisica.Text) || string.IsNullOrWhiteSpace(txtCantidadRegistrada.Text))
            {
                MessageBox.Show("Por favor, completa las cantidades físicas y registradas.");
                return; // Salir del método si faltan cantidades
            }

            int cantidadFisica;
            int cantidadRegistrada;

            // Intentar convertir las cantidades a enteros, manejando excepciones si es necesario
            if (!int.TryParse(txtCantidadFisica.Text, out cantidadFisica) || !int.TryParse(txtCantidadRegistrada.Text, out cantidadRegistrada))
            {
                MessageBox.Show("Las cantidades deben ser números enteros válidos.");
                return; // Salir del método si hay un error en la conversión
            }

            bool discrepancia = chkDiscrepanciaDetectada.Checked;

            // Realiza la auditoría a través del controlador
            controlador.RealizarAuditoria(idBodega, idProducto, cantidadFisica, cantidadRegistrada, discrepancia);
            MessageBox.Show("Auditoría realizada con éxito");
        }

        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbBodegaAuditoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbProductoAuditoria_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
