using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Controlador_Contabilidad;
namespace Capa_Vista_Contabilidad
{
    public partial class Depreciacionactivofijo : Form
    {
        private bool isUpdatingFields = false;
        Controlador cn = new Controlador();
        public Depreciacionactivofijo()
        {
            InitializeComponent();
            LlenarComboActivoFijo();
            CargarDescripcionActivos();
            // Asignar eventos a los TextBox
            txtCostoAdquisicion.TextChanged += new EventHandler(TextBox_TextChanged);
            txtVidaUtil.TextChanged += new EventHandler(TextBox_TextChanged);
            txtValorResidual.TextChanged += new EventHandler(TextBox_TextChanged);

            // Asignar eventos a los CheckBox
            chkLineaRecta.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            chkDobleSaldoDeclinable.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            chkSumaAnosDigitos.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingFields) return;

            // Validación de campos
            if (!decimal.TryParse(txtCostoAdquisicion.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el costo de adquisición.");
            }
            if (!decimal.TryParse(txtVidaUtil.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en la vida útil.");
            }
            if (!decimal.TryParse(txtValorResidual.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el valor residual.");
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalcularDepreciacion(); // Llama a tu método de cálculo
        }
        public void LlenarComboActivoFijo()
        {
            List<string> descripciones = cn.llenarCombo("Descripcion", "tbl_activofijo");
            cb_descripcion.Items.Clear();
            cb_descripcion.Items.AddRange(descripciones.ToArray());
        }

        public void BuscarDetalleActivoFijo()
        {
            string tabla = "tbl_activofijo";
            string columna = "Descripcion"; // Usar Descripcion para búsqueda
            string dato = (cb_descripcion.SelectedItem != null) ? cb_descripcion.SelectedItem.ToString() : string.Empty;

            // Modificar la búsqueda para incluir solo registros con Estado = '1'
            DataTable dt = cn.BuscarConEstado(tabla, columna, dato, "1");

            if (dt.Rows.Count > 0)
            {
                // Deshabilitar eventos de TextChanged
                isUpdatingFields = true;

                // Mostrar detalles en TextBox
                txtIDActivoFijo.Text = dt.Rows[0]["Pk_id_idactivofijo"].ToString();
                txtCodigoActivo.Text = dt.Rows[0]["Codigo_Activo"].ToString();
                txtIDTipoActivo.Text = dt.Rows[0]["Pk_id_tipoactivofijo"].ToString();
                txtMarca.Text = dt.Rows[0]["Pk_id_marca"].ToString();
                txtModelo.Text = dt.Rows[0]["Modelo"].ToString();

                dtpFechaAdquisicion.Value = Convert.ToDateTime(dt.Rows[0]["Fecha_Adquisicion"]);
                dtpFechaAdquisicion.Enabled = false;

                txtCostoAdquisicion.Text = dt.Rows[0]["Costo_Adquisicion"].ToString();
                txtVidaUtil.Text = dt.Rows[0]["Vida_Util"].ToString();
                txtValorResidual.Text = dt.Rows[0]["Valor_Residual"].ToString();
                txtEstado.Text = dt.Rows[0]["Estado"].ToString();
                txtCuenta.Text = dt.Rows[0]["Pk_id_cuenta"].ToString();

                // Validar y calcular depreciación si es posible
                if (decimal.TryParse(txtCostoAdquisicion.Text, out _) &&
                    decimal.TryParse(txtVidaUtil.Text, out _) &&
                    decimal.TryParse(txtValorResidual.Text, out _))
                {
                    CalcularDepreciacion();
                }

                // Configurar los campos de solo lectura, excepto para txtEstado
                txtIDActivoFijo.ReadOnly = true;
                txtCodigoActivo.ReadOnly = true;
                txtIDTipoActivo.ReadOnly = true;
                txtMarca.ReadOnly = true;
                txtModelo.ReadOnly = true;
                txtCostoAdquisicion.ReadOnly = true;
                txtVidaUtil.ReadOnly = true;
                txtValorResidual.ReadOnly = true;
                txtCuenta.ReadOnly = true;
                txtEstado.ReadOnly = false;

                // Rehabilitar el procesamiento de eventos
                isUpdatingFields = false;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }
        private void CargarDescripcionActivos()
        {
            string tabla = "tbl_activofijo";
            string columna = "Descripcion";

            try
            {
                // Obtener solo registros con Estado = '1'
                DataTable dt = cn.ObtenerRegistrosConEstado(tabla, columna, "1");

                cb_descripcion.Items.Clear(); // Limpiar elementos anteriores

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cb_descripcion.Items.Add(row[columna].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron activos disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar descripciones: {ex.Message}");
            }
        }


        private void CalcularDepreciacion()
        {
            // Verificar que todos los campos estén llenos y convertir los valores
            if (decimal.TryParse(txtCostoAdquisicion.Text, out decimal costoAdquisicion) &&
                decimal.TryParse(txtVidaUtil.Text, out decimal vidaUtil) &&
                decimal.TryParse(txtValorResidual.Text, out decimal valorResidual))
            {
                decimal depreciacionAnual = 0;

                // Verificar qué método de depreciación se ha seleccionado
                if (chkLineaRecta.Checked)
                {
                    // Calcular depreciación en línea recta
                    depreciacionAnual = (costoAdquisicion - valorResidual) / vidaUtil;
                }
                else if (chkDobleSaldoDeclinable.Checked)
                {
                    // Calcular depreciación usando el método de doble saldo declinable
                    decimal tasaDepreciacion = 2 / vidaUtil; // Tasa del 200%
                    depreciacionAnual = (costoAdquisicion - valorResidual) * tasaDepreciacion;
                    // Asegúrate de que la depreciación no exceda el valor residual
                    if (depreciacionAnual + valorResidual > costoAdquisicion)
                    {
                        depreciacionAnual = costoAdquisicion - valorResidual; // Limitación al valor residual
                    }
                }
                else if (chkSumaAnosDigitos.Checked)
                {
                    // Calcular depreciación usando el método de suma de años dígitos
                    int vidaUtilInt = (int)vidaUtil;
                    int sumaAnos = (vidaUtilInt * (vidaUtilInt + 1)) / 2; // Suma de años dígitos
                    int añoActual = 1; // Por ejemplo, para el primer año

                    // Depreciación del primer año
                    depreciacionAnual = (costoAdquisicion - valorResidual) * (vidaUtilInt - añoActual + 1) / sumaAnos;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un método de depreciación.");
                    return; // Salir si no se seleccionó ningún método
                }

                // Mostrar el resultado en el TextBox de depreciación anual
                txtDepreciacionAnual.Text = depreciacionAnual.ToString("F2");

                // Calcular y mostrar la depreciación fiscal
                CalcularDepreciacionFiscal(costoAdquisicion);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en todos los campos.");
            }
        }
        private void CalcularDepreciacionFiscal(decimal costoAdquisicion)
        {
            // Define la tasa de depreciación fiscal
            decimal tasaDepreciacionFiscal = 0.20m; // Por ejemplo, el 20%

            // Calcular la depreciación fiscal
            decimal depreciacionFiscal = costoAdquisicion * tasaDepreciacionFiscal;

            // Mostrar el resultado en el TextBox de depreciación fiscal
            txtDepreciacionFiscal.Text = depreciacionFiscal.ToString("F2");
        }

        private void cb_descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleActivoFijo();
        }

        private void chkLineaRecta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLineaRecta.Checked)
            {
                chkDobleSaldoDeclinable.Checked = false;
                chkSumaAnosDigitos.Checked = false;
            }
        }

        private void chkDobleSaldoDeclinable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDobleSaldoDeclinable.Checked)
            {
                chkLineaRecta.Checked = false;
                chkSumaAnosDigitos.Checked = false;
            }
        }

        private void chkSumaAnosDigitos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSumaAnosDigitos.Checked)
            {
                chkLineaRecta.Checked = false;
                chkDobleSaldoDeclinable.Checked = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            // Limpiar todos los TextBox en el formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty; // Limpia el texto del TextBox
                }
            }

            // Si tienes otros controles que deseas limpiar, agrégales aquí
            // Ejemplo: limpiar un ComboBox
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1; // Restablece la selección del ComboBox
                }
            }


        }

        public void GuardarDatos()
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Capturar los valores de los controles de la interfaz de usuario
            int idActivoFijo = Convert.ToInt32(txtIDActivoFijo.Text);
            string nombreActivo = txtNombreTIPOActivo.Text;
            string tipoActivo = txtIDTipoActivo.Text;
            string encargado = txtEncargado.Text;
            string departamento = txtDepartamento.Text;
            DateTime fechaDepreciacion = dtpFechaDepreciacion.Value;
            double depreciacion = double.Parse(txtDepreciacionAnual.Text);
            double depreciacionFiscal = double.Parse(txtDepreciacionFiscal.Text);
            string descripcion = txtDescripcion.Text;
            string estado = txtEstado1.Text;
            int idCuenta = Convert.ToInt32(txtCuenta.Text);
            string estado1 = txtEstado.Text;
            // Llamar al método del controlador para guardar los datos
            cn.InsertarDepreciacionActivo(fechaDepreciacion, idActivoFijo, nombreActivo, tipoActivo, encargado, departamento,
                                           depreciacion, depreciacionFiscal, descripcion, estado, idCuenta);
            cn.ActualizarEstadoActivoFijo(idActivoFijo, estado1);
            // Mostrar mensaje de éxito
            MessageBox.Show("Datos guardados exitosamente en la tabla de depreciación de activo fijo.");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
    }
}
