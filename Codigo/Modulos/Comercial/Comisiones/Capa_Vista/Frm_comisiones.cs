using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;

namespace Capa_Vista
{
    public partial class Frm_comisiones : Form
    {
        Logica logica = new Logica();

        public Frm_comisiones()
        {
            InitializeComponent();
            CargarVendedores();
        }

        // Método para cargar vendedores en el ComboBox al iniciar el formulario
        private void CargarVendedores()
        {
            DataTable dtVendedores = logica.ObtenerVendedores();
            Cbo_vendedor.DataSource = dtVendedores;
            Cbo_vendedor.DisplayMember = "NombreCompleto";
            Cbo_vendedor.ValueMember = "Pk_id_vendedor";
        }

        // Evento para buscar ventas de acuerdo al vendedor y al filtro
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Cbo_vendedor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un vendedor.");
                return;
            }

            int idVendedor = (int)Cbo_vendedor.SelectedValue;
            string filtro = ""; // Inicializamos el filtro como una cadena vacía
            DateTime fechaInicio = Dtp_fecha_inicio.Value;
            DateTime fechaFin = Dtp_fecha_fin.Value;

            // Asignar el filtro según el RadioButton seleccionado
            if (Rdb_inventario.Checked)
            {
                filtro = "Inventario";
            }
            else if (Rdb_marcas.Checked)
            {
                filtro = "Marcas";
            }
            else if (Rdb_lineas.Checked)
            {
                filtro = "Lineas";
            }
            else if (Rdb_costo.Checked)
            {
                filtro = "Costo";
            }
            else
            {
                MessageBox.Show("Seleccione un filtro.");
                return;
            }

            // Llamar al método de lógica para obtener las ventas filtradas
            DataTable dtVentas = logica.ObtenerVentasFiltradas(idVendedor, filtro, fechaInicio, fechaFin);
            Dgv_ventas.DataSource = dtVentas;

            // Calcular el total de ventas
            CalcularTotalVentas();
        }

        // Método para calcular el total de ventas mostrado en el DataGridView
        private void CalcularTotalVentas()
        {
            decimal totalVentas = 0;
            foreach (DataGridViewRow row in Dgv_ventas.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    totalVentas += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            Txt_venta.Text = totalVentas.ToString("C"); // Muestra el total en formato de moneda
        }

        // Evento para calcular la comisión al hacer clic en "Calcular"
        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            decimal totalVentas = Convert.ToDecimal(Txt_venta.Text, System.Globalization.CultureInfo.CurrentCulture);
            decimal porcentajeComision = 0.1m; // Porcentaje de comisión, por ejemplo 10%
            decimal totalComision = totalVentas * porcentajeComision;

            Txt_comision.Text = totalComision.ToString("C"); // Muestra la comisión en formato de moneda
        }

        private void Cbo_vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya un valor seleccionado en el ComboBox
            if (Cbo_vendedor.SelectedItem != null)
            {
                // Convertimos el elemento seleccionado en un DataRowView para acceder a sus campos
                var selectedItem = (DataRowView)Cbo_vendedor.SelectedItem;

                // Obtenemos el nombre o cualquier otro campo que desees mostrar en el TextBox
                Txt_nombre.Text = selectedItem["NombreCompleto"].ToString();
            }
        }
    }
}
