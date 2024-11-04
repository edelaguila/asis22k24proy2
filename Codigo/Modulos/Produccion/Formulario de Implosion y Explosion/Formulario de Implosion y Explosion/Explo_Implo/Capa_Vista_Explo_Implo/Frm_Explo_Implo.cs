using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_Explo_Implo;

namespace Capa_Vista_Explo_Implo
{
    public partial class Frm_Explo_Implo : Form
    {
        private Controlador_Explo_Implo controlador = new Controlador_Explo_Implo();

        public Frm_Explo_Implo()
        {
            InitializeComponent();
            CargarComboBoxes();
            //CargarSiguienteIdExplosion();
            CargarExplosiones();
        }

        private void InicializarFormulario()
        {
            txt_id_explosion.Text = controlador.ObtenerUltimoID().ToString();
            txt_id_explosion.Enabled = false;
            //DeshabilitarCampos();
            //CargarEmpleados();
            //CargarDias();
            txt_id_explosion.Text = controlador.ObtenerUltimoID().ToString();
        }

        private void CargarExplosiones()
        {
            dgv_explosion.DataSource = controlador.ObtenerTodosLosRegistros();
        }

        private void CargarComboBoxes()
        {
            // Llenar cbo_orden
            cbo_orden.DataSource = controlador.ObtenerOrdenesProduccion();
            cbo_orden.DisplayMember = "Pk_id_orden";

            // Llenar cbo_producto con el Dictionary<int, string>
            var productosDict = controlador.ObtenerProductos();
            cbo_producto.DataSource = new BindingSource(productosDict, null);
            cbo_producto.DisplayMember = "Value"; // El nombre del producto
            cbo_producto.ValueMember = "Key";     // El ID del producto

            // Llenar cbo_proceso
            cbo_proceso.DataSource = controlador.ObtenerProcesosProduccion();
            cbo_proceso.DisplayMember = "Pk_id_proceso";
        }


        private void LimpiarCampos()
        {
            txt_cantidad.Clear();
            txt_costo_total.Clear();
            txt_duracion.Clear();
            btn_guardar.Enabled = true;
            //btn.Enabled = true;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
            LimpiarCampos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar y convertir los valores de los campos
                if (!int.TryParse(cbo_orden.SelectedValue?.ToString(), out int fkIdOrden))
                {
                    MessageBox.Show("Por favor, selecciona una orden de producción válida.");
                    return;
                }
                if (!int.TryParse(cbo_producto.SelectedValue?.ToString(), out int fkIdProducto))
                {
                    MessageBox.Show("Por favor, selecciona un producto válido.");
                    return;
                }
                if (!int.TryParse(txt_costo_total.Text, out int costoTotal))
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico válido en el campo Costo Total.");
                    return;
                }
                if (!int.TryParse(txt_cantidad.Text, out int cantidad))
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico válido en el campo Cantidad.");
                    return;
                }
                if (!int.TryParse(txt_duracion.Text, out int duracionHoras))
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico válido en el campo Duración en Horas.");
                    return;
                }
                if (!int.TryParse(cbo_proceso.SelectedValue?.ToString(), out int fkIdProceso))
                {
                    MessageBox.Show("Por favor, selecciona un proceso válido.");
                    return;
                }

                DateTime fechaExplosion = dtp_fecha.Value; // Obtener la fecha seleccionada

                // Llamar al método para guardar la receta
                controlador.GuardarExplosion(fkIdOrden, fkIdProducto, cantidad, costoTotal, duracionHoras, fkIdProceso, fechaExplosion);

                // Mensaje de éxito
                MessageBox.Show("La receta se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresca el DataGridView y limpia los campos
                CargarExplosiones();
                LimpiarCampos();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos numéricos estén correctamente ingresados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la receta: " + ex.Message);
            }

            /*
            int fkIdOrden, fkIdProducto, cantidad, costoTotal, duracionHoras, fkIdProceso;
            DateTime fechaExplosion;

            // Validar fkIdOrden
            if (!int.TryParse(txtOrden.Text, out fkIdOrden))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo Orden.");
                return;
            }

            // Validar fkIdProducto
            if (!int.TryParse(txtProducto.Text, out fkIdProducto))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo Producto.");
                return;
            }

            // Validar cantidad
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo Cantidad.");
                return;
            }

            // Validar costoTotal
            if (!int.TryParse(txtCostoTotal.Text, out costoTotal))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo Costo Total.");
                return;
            }

            // Validar duracionHoras
            if (!int.TryParse(txtDuracionHoras.Text, out duracionHoras))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo Duración en Horas.");
                return;
            }

            // Validar fkIdProceso
            if (!int.TryParse(txtProceso.Text, out fkIdProceso))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo Proceso.");
                return;
            }

            // Validar fechaExplosion
            if (!DateTime.TryParse(txtFechaExplosion.Text, out fechaExplosion))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida en el campo Fecha de Explosión.");
                return;
            }

            // Si todas las validaciones pasan, llama al controlador para guardar los datos
            try
            {
                controlador.GuardarExplosion(fkIdOrden, fkIdProducto, cantidad, costoTotal, duracionHoras, fkIdProceso, fechaExplosion);
                MessageBox.Show("Registro guardado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el registro: " + ex.Message);
            }
            */
        }
    }
}
