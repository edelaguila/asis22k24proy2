using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Produccion;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Sistema_Produccion : Form
    {
        private Control_Sistema_Prod control = new Control_Sistema_Prod();

        public Frm_Sistema_Produccion()
        {
            InitializeComponent();
            this.Load += Frm_Sistema_Produccion_Load;
        }

        // Evento para cargar datos al abrir el formulario
        private void Frm_Sistema_Produccion_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar órdenes en el ComboBox de órdenes
                cbo_orden.DataSource = control.ObtenerOrdenesProduccion();
                cbo_orden.DisplayMember = "Pk_id_orden";
                cbo_orden.ValueMember = "Pk_id_orden";

                // Cargar maquinarias en el ComboBox de maquinarias
                cbo_maquinaria.DataSource = control.ObtenerMaquinarias();
                cbo_maquinaria.DisplayMember = "nombre_maquinaria";
                cbo_maquinaria.ValueMember = "Pk_id_maquinaria";

                // Cargar empleados en el ComboBox de empleados
                cbo_empleado.DataSource = control.ObtenerEmpleados();
                cbo_empleado.DisplayMember = "nombre";
                cbo_empleado.ValueMember = "pk_clave";

                // Asignar automáticamente el siguiente ID de proceso y proceso detalle
                txt_idProceso.Text = control.ObtenerSiguienteIdProceso().ToString();
                txt_idProcesoDetalle.Text = control.ObtenerSiguienteIdProcesoDetalle().ToString();

                // Evento para cargar el detalle de la orden seleccionada
                cbo_orden.SelectedIndexChanged += Cbo_orden_SelectedIndexChanged;

                // Eventos para actualizar el costo total en tiempo real
                txt_costo_u.TextChanged += CalcularCostoTotal;
                txt_cantidad.TextChanged += CalcularCostoTotal;
                txt_mano_obra.TextChanged += CalcularCostoTotal;
                txt_costo_luz.TextChanged += CalcularCostoTotal;
                txt_costo_agua.TextChanged += CalcularCostoTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para cargar el detalle de la orden seleccionada en el DataGridView
        private void Cbo_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_orden.SelectedValue != null && int.TryParse(cbo_orden.SelectedValue.ToString(), out int idOrden))
                {
                    dgv_detalle_orden.DataSource = control.ObtenerDetalleOrden(idOrden);

                    // Cargar producto y receta en los TextBox
                    if (dgv_detalle_orden.Rows.Count > 0 && dgv_detalle_orden.Rows[0].Cells["Fk_id_producto"].Value != null)
                    {
                        int idProducto = Convert.ToInt32(dgv_detalle_orden.Rows[0].Cells["Fk_id_producto"].Value);
                        DataTable productoReceta = control.ObtenerProductoYReceta(idProducto);

                        if (productoReceta.Rows.Count > 0)
                        {
                            txt_idProducto.Text = productoReceta.Rows[0]["idProducto"].ToString();
                            txt_idReceta.Text = productoReceta.Rows[0]["idReceta"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle de la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular y actualizar el costo total
        private void CalcularCostoTotal(object sender, EventArgs e)
        {
            try
            {
                decimal costoU = decimal.TryParse(txt_costo_u.Text, out decimal cU) ? cU : 0;
                int cantidad = int.TryParse(txt_cantidad.Text, out int qty) ? qty : 0;
                decimal manoDeObra = decimal.TryParse(txt_mano_obra.Text, out decimal mO) ? mO : 0;
                decimal costoLuz = decimal.TryParse(txt_costo_luz.Text, out decimal cL) ? cL : 0;
                decimal costoAgua = decimal.TryParse(txt_costo_agua.Text, out decimal cA) ? cA : 0;

                decimal totalCost = (costoU * cantidad) + manoDeObra + costoLuz + costoAgua;
                txt_costo_t.Text = totalCost.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el costo total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón btn_asignar
        private void btn_asignar_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables para encabezado
                int idProceso = Convert.ToInt32(txt_idProceso.Text);
                int idOrden = Convert.ToInt32(cbo_orden.SelectedValue);
                int idMaquinaria = Convert.ToInt32(cbo_maquinaria.SelectedValue);

                // Validar campos vacíos
                if (string.IsNullOrEmpty(txt_idProceso.Text) || string.IsNullOrEmpty(cbo_orden.Text) || string.IsNullOrEmpty(cbo_maquinaria.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos de encabezado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar encabezado
                bool resultadoEncabezado = control.InsertarEncabezado(idProceso, idOrden, idMaquinaria);

                if (resultadoEncabezado)
                {
                    // Variables para detalle
                    int idProcesoDetalle = Convert.ToInt32(txt_idProcesoDetalle.Text);
                    int idProducto = Convert.ToInt32(txt_idProducto.Text);
                    int idReceta = Convert.ToInt32(txt_idReceta.Text);
                    int idEmpleado = Convert.ToInt32(cbo_empleado.SelectedValue);
                    int cantidad = Convert.ToInt32(txt_cantidad.Text);
                    decimal costoU = Convert.ToDecimal(txt_costo_u.Text);
                    decimal costoT = Convert.ToDecimal(txt_costo_t.Text);
                    decimal duracionHoras = nud_duracion_horas.Value;
                    decimal manoDeObra = Convert.ToDecimal(txt_mano_obra.Text);
                    decimal costoLuz = Convert.ToDecimal(txt_costo_luz.Text);
                    decimal costoAgua = Convert.ToDecimal(txt_costo_agua.Text);

                    if (costoT <= 0)
                    {
                        MessageBox.Show("El costo total debe ser mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insertar detalle
                    bool resultadoDetalle = control.InsertarDetalle(idProcesoDetalle, idProducto, idReceta, idEmpleado, idProceso, cantidad, costoU, costoT, duracionHoras, manoDeObra, costoLuz, costoAgua);

                    if (resultadoDetalle)
                    {
                        MessageBox.Show("Registro exitoso en el sistema de producción", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el detalle del proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al registrar el encabezado del proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos ingresados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar el proceso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón btn_salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
