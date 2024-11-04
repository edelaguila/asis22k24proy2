using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_JavierChamo
{
    public partial class Movimiento_de_Inventario : Form
    {
        Capa_Controlador.Controlador capa_Controlador_Logistica = new Capa_Controlador.Controlador();
        
        public Movimiento_de_Inventario()
        {
            InitializeComponent();
            llenarComboBox();
            CargarSolicitudesenDatagriedView();
        }

        public void btn_Guardar_Click(object sender, EventArgs e)
        {

            capa_Controlador_Logistica.RealizarMovimientoInventario(
                Convert.ToInt32(cbm_Estado.Text),
                Convert.ToInt32(cbm_Id_del_producto.SelectedValue),  // Asegúrate de usar SelectedValue
                Convert.ToInt32(cbm_Id_del_stock.SelectedValue),     // Cambia esto
                Convert.ToInt32(cbm_Local.SelectedValue)              // Cambia esto
            );
            CargarSolicitudesenDatagriedView();
        }
        private void llenarComboBox()
        {
            try
            {
                // Llenar ComboBox para Productos
                DataTable productos = capa_Controlador_Logistica.ObtenerProductos();
                if (productos.Columns.Contains("Pk_id_Producto") && productos.Rows.Count > 0)
                {
                    cbm_Id_del_producto.DataSource = productos;
                    cbm_Id_del_producto.DisplayMember = "Pk_id_Producto"; // Mostrar el ID
                    cbm_Id_del_producto.ValueMember = "Pk_id_Producto";
                    cbm_Id_del_producto.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para mostrar.");
                }

                // Llenar ComboBox para Stock
                DataTable stocks = capa_Controlador_Logistica.ObtenerStocks();
                if (stocks.Columns.Contains("Pk_id_TrasladoProductos") && stocks.Rows.Count > 0)
                {
                    cbm_Id_del_stock.DataSource = stocks;
                    cbm_Id_del_stock.DisplayMember = "Pk_id_TrasladoProductos"; // Mostrar el ID
                    cbm_Id_del_stock.ValueMember = "Pk_id_TrasladoProductos";
                    cbm_Id_del_stock.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron stocks para mostrar.");
                }

                // Llenar ComboBox para Locales
                DataTable locales = capa_Controlador_Logistica.ObtenerLocales();
                if (locales.Columns.Contains("Pk_ID_LOCAL") && locales.Rows.Count > 0)
                {
                    cbm_Local.DataSource = locales;
                    cbm_Local.DisplayMember = "Pk_ID_LOCAL"; // Mostrar el ID
                    cbm_Local.ValueMember = "Pk_ID_LOCAL";
                    cbm_Local.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron locales para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al llenar los ComboBox: " + ex.Message);
            }
        }
        public void CargarSolicitudesenDatagriedView()
        {
            try
            {
                DataTable tablaMantenimiento = capa_Controlador_Logistica.MostrarMovimientosInventario();
                dgbMovimientoInventario.DataSource = tablaMantenimiento;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos en el DataGridView: " + ex.Message);
            }
        }
        

        private void dgbMovimientoInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgbMovimientoInventario.Rows[e.RowIndex];
                cbm_Estado.Text = row.Cells["estado"].Value.ToString();
                cbm_Id_del_producto.Text = row.Cells["Fk_id_producto"].Value.ToString();
                cbm_Id_del_stock.Text = row.Cells["Fk_id_stock"].Value.ToString();
                cbm_Local.Text = row.Cells["Fk_ID_LOCALES"].Value.ToString();
                

                int numMovimiento = Convert.ToInt32(row.Cells["Pk_id_movimiento"].Value);
                txt_numMovimiento.Text = numMovimiento.ToString();
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarSolicitudesenDatagriedView();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            capa_Controlador_Logistica.ModificarMovimientoInventario(Convert.ToInt32(txt_numMovimiento.Text), Convert.ToInt32(cbm_Estado.Text), Convert.ToInt32(cbm_Id_del_producto.Text), Convert.ToInt32(cbm_Id_del_stock.Text), Convert.ToInt32(cbm_Local.Text));
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            capa_Controlador_Logistica.EliminarMovimiento(Convert.ToInt32(txt_numMovimiento.Text));
        }

        private void btn_GenerarPDF_Click(object sender, EventArgs e)
        {
            GenerarPDF_MovimientoInventario generarPDF_MovimientoInventario = new GenerarPDF_MovimientoInventario();
            generarPDF_MovimientoInventario.Show();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            ReporteMovimientoInventario frm = new ReporteMovimientoInventario();
            frm.Show();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/franc/Desktop/MVC_JavierChamo/Ayuda/AyudaMovimientoInventario/AyudaMovimientodeInventario.chm", "AyudaMovimientoInventario.html");
        }
    }
}
