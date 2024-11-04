using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorActivofijo;

namespace CapaVistaActivofijo
{
    public partial class Frm_Depreciacion : Form
    {
        private bool isUpdatingFields = false;
        Controlador cn = new Controlador();
        public Frm_Depreciacion()
        {
            InitializeComponent();
            LlenarComboActivoFijo();
            CargarDescripcionActivos();
            // Asignar eventos a los TextBox
            Txt_CostoAdqui.TextChanged += new EventHandler(TextBox_TextChanged);
            Txt_VidaUtil.TextChanged += new EventHandler(TextBox_TextChanged);
            Txt_ValorResidual.TextChanged += new EventHandler(TextBox_TextChanged);

            // Asignar eventos a los CheckBox
            Chk_LineaRecta.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            Chk_DobleSaldoDeclinable.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            Chk_SumaAnosDigitos.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingFields) return;

            // Validación de campos
            if (!decimal.TryParse(Txt_CostoAdqui.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el costo de adquisición.");
            }
            if (!decimal.TryParse(Txt_VidaUtil.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en la vida útil.");
            }
            if (!decimal.TryParse(Txt_ValorResidual.Text, out _))
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
            Cbo_descripcion.Items.Clear();
            Cbo_descripcion.Items.AddRange(descripciones.ToArray());
        }

        public void BuscarDetalleActivoFijo()
        {
            string tabla = "tbl_activofijo";
            string columna = "Descripcion"; // Usar Descripcion para búsqueda
            string dato = (Cbo_descripcion.SelectedItem != null) ? Cbo_descripcion.SelectedItem.ToString() : string.Empty;

            // Modificar la búsqueda para incluir solo registros con Estado = '1'
            DataTable dt = cn.BuscarConEstado(tabla, columna, dato, "1");

            if (dt.Rows.Count > 0)
            {
                // Deshabilitar eventos de TextChanged
                isUpdatingFields = true;

                // Mostrar detalles en TextBox
                Txt_IDActivoFijo.Text = dt.Rows[0]["Pk_id_idactivofijo"].ToString();
                Txt_CodigoActivo.Text = dt.Rows[0]["Codigo_Activo"].ToString();
                Txt_IDTipoActivo.Text = dt.Rows[0]["Pk_id_tipoactivofijo"].ToString();
                Txt_Marca.Text = dt.Rows[0]["Pk_id_marca"].ToString();
                Txt_Modelo.Text = dt.Rows[0]["Modelo"].ToString();

                dtp_FechaAdquisicion.Value = Convert.ToDateTime(dt.Rows[0]["Fecha_Adquisicion"]);
                dtp_FechaAdquisicion.Enabled = false;

                Txt_CostoAdqui.Text = dt.Rows[0]["Costo_Adquisicion"].ToString();
                Txt_VidaUtil.Text = dt.Rows[0]["Vida_Util"].ToString();
                Txt_ValorResidual.Text = dt.Rows[0]["Valor_Residual"].ToString();
                Txt_Estado.Text = dt.Rows[0]["Estado"].ToString();
                Txt_Cuenta.Text = dt.Rows[0]["Pk_id_cuenta"].ToString();

                // Validar y calcular depreciación si es posible
                if (decimal.TryParse(Txt_CostoAdqui.Text, out _) &&
                    decimal.TryParse(Txt_VidaUtil.Text, out _) &&
                    decimal.TryParse(Txt_ValorResidual.Text, out _))
                {
                    CalcularDepreciacion();
                }

                // Configurar los campos de solo lectura, excepto para txtEstado
                Txt_IDActivoFijo.ReadOnly = true;
                Txt_CodigoActivo.ReadOnly = true;
                Txt_IDTipoActivo.ReadOnly = true;
                Txt_Marca.ReadOnly = true;
                Txt_Modelo.ReadOnly = true;
                Txt_CostoAdqui.ReadOnly = true;
                Txt_VidaUtil.ReadOnly = true;
                Txt_ValorResidual.ReadOnly = true;
                Txt_Cuenta.ReadOnly = true;
                Txt_Estado.ReadOnly = false;

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

                Cbo_descripcion.Items.Clear(); // Limpiar elementos anteriores

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Cbo_descripcion.Items.Add(row[columna].ToString());
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
            if (decimal.TryParse(Txt_CostoAdqui.Text, out decimal costoAdquisicion) &&
                decimal.TryParse(Txt_VidaUtil.Text, out decimal vidaUtil) &&
                decimal.TryParse(Txt_ValorResidual.Text, out decimal valorResidual))
            {
                decimal depreciacionAnual = 0;

                // Verificar qué método de depreciación se ha seleccionado
                if (Chk_LineaRecta.Checked)
                {
                    // Calcular depreciación en línea recta
                    depreciacionAnual = (costoAdquisicion - valorResidual) / vidaUtil;
                }
                else if (Chk_DobleSaldoDeclinable.Checked)
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
                else if (Chk_SumaAnosDigitos.Checked)
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
                Txt_DepreAnual.Text = depreciacionAnual.ToString("F2");

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
            Txt_DepreFiscal.Text = depreciacionFiscal.ToString("F2");
        }


        private void cb_descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleActivoFijo();
        }

        private void chkLineaRecta_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_LineaRecta.Checked)
            {
                Chk_DobleSaldoDeclinable.Checked = false;
                Chk_SumaAnosDigitos.Checked = false;
            }
        }

        private void chkDobleSaldoDeclinable_CheckedChanged(object sender, EventArgs e)
        {

            if (Chk_DobleSaldoDeclinable.Checked)
            {
                Chk_LineaRecta.Checked = false;
                Chk_SumaAnosDigitos.Checked = false;
            }
        }

        private void chkSumaAnosDigitos_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_SumaAnosDigitos.Checked)
            {
                Chk_LineaRecta.Checked = false;
                Chk_DobleSaldoDeclinable.Checked = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarControles(this);
        }
        private void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // Limpia el texto del TextBox
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Restablece la selección del ComboBox
                }
                // Si hay otros tipos de controles, puedes agregar más condiciones aquí

                // Si el control tiene hijos, llama recursivamente a LimpiarControles
                if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }

        public void GuardarDatos()
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Capturar los valores de los controles de la interfaz de usuario
            int idActivoFijo = Convert.ToInt32(Txt_IDActivoFijo.Text);
            string nombreActivo = Txt_NombreTIPOActivo.Text;
            string tipoActivo = Txt_IDTipoActivo.Text;
            string encargado = Txt_Encargado.Text;
            string departamento = Txt_Departamento.Text;
            DateTime fechaDepreciacion = dtp_FechaDepreciacion.Value;
            double depreciacion = double.Parse(Txt_DepreAnual.Text);
            double depreciacionFiscal = double.Parse(Txt_DepreFiscal.Text);
            string descripcion = Txt_Descripcion.Text;
            string estado = Txt_Estado1.Text;
            int idCuenta = Convert.ToInt32(Txt_Cuenta.Text);
            string estado1 = Txt_Estado.Text;
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

        private void Gpb_Activo_Enter(object sender, EventArgs e)
        {

        }
    }
}

