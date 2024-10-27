using System;
using System.Data;
using System.Data.Odbc;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Capa_Controlador_Produccion;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Mantenimiento_Produccion : Form
    {
        private Control_Mantenimiento control;
        private ToolTip toolTip;

        public Frm_Mantenimiento_Produccion()
        {
            InitializeComponent();
            control = new Control_Mantenimiento();

            // Configurar ToolTips
            toolTip = new ToolTip();
            ConfigurarToolTips();

            // Cargar valores predeterminados en los ComboBox
            CargarValoresPredeterminados();

            // Cargar los datos en el DataGridView al inicializar el formulario
            CargarDatos();

            // Asocia el evento CellClick al DataGridView
            Dgv_Mantenimientos.CellClick += Dgv_Mantenimientos_CellClick;

            // Cargar el último ID al TextBox
            ObtenerUltimoIdMaquinaria();
        }

        // Método para configurar ToolTips en los botones
        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(Btn_Agregar, "Agregar un nuevo mantenimiento");
            toolTip.SetToolTip(Btn_Actualizar, "Actualizar el mantenimiento seleccionado");
            toolTip.SetToolTip(Btn_Eliminar, "Desactivar el mantenimiento seleccionado");
            toolTip.SetToolTip(btn_Nuevo, "Limpiar los campos para un nuevo ingreso de mantenimiento");
        }

        // Método para cargar los valores predeterminados en los ComboBox
        private void CargarValoresPredeterminados()
        {
            Cbo_TipoMaquina.Items.Clear();
            Cbo_TipoMaquina.Items.AddRange(new object[] { "Cortadora", "Taladradora", "Fresadora", "Torno", "Pulidora" });
            Cbo_TipoMaquina.SelectedIndex = 0;

            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.AddRange(new object[] { "Inactivo", "Activo" });
            Cbo_Estado.SelectedIndex = 1;

            Cbo_Area.Items.Clear();
            Cbo_Area.Items.AddRange(new object[] { "Producción", "Mantenimiento", "Calidad", "Almacén", "Logística" });
            Cbo_Area.SelectedIndex = 0;

            // Configura los límites del NumericUpDown
            Nud_HoraOperacion.Minimum = 0;
            Nud_HoraOperacion.Maximum = 10000;

            Nud_DesgastePorcentaje.Minimum = 0;
            Nud_DesgastePorcentaje.Maximum = 100;
        }

        // Método para cargar los datos en el DataGridView
        private void CargarDatos()
        {
            Dgv_Mantenimientos.DataSource = control.CargarMantenimientos();
            Console.WriteLine("Datos cargados en el DataGridView.");
        }

        // Método para obtener el último ID ingresado en la tabla y mostrarlo en el TextBox
        private void ObtenerUltimoIdMaquinaria()
        {
            int ultimoId = control.ObtenerUltimoIdMaquinaria();
            Txt_ID_Maquinaria.Text = (ultimoId + 1).ToString();
            Txt_ID_Maquinaria.ReadOnly = true;
            Console.WriteLine("Último ID de maquinaria obtenido y mostrado en el TextBox: " + Txt_ID_Maquinaria.Text);
        }

        // Evento del botón Agregar
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    control.AgregarMantenimiento(
                        Txt_NombreMaquinaria.Text,
                        Cbo_TipoMaquina.SelectedItem.ToString(),
                        Nud_HoraOperacion.Value,
                        Txt_MantenimientoPeriodico.Text,
                        Dtp_UltimaMantenimiento.Value,
                        Dtp_ProximoMantenimiento.Value,
                        Cbo_Area.SelectedItem?.ToString(),
                        Nud_DesgastePorcentaje.Value,
                        Cbo_Estado.SelectedIndex
                    );

                    MessageBox.Show("Mantenimiento agregado correctamente.");
                    CargarDatos();
                    ObtenerUltimoIdMaquinaria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el mantenimiento: " + ex.Message);
            }
        }

        // Evento del botón Actualizar
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Mantenimientos.SelectedRows.Count > 0 && ValidarCampos())
                {
                    int idMaquinaria = Convert.ToInt32(Txt_ID_Maquinaria.Text);

                    control.ActualizarMantenimiento(
                        idMaquinaria,
                        Txt_NombreMaquinaria.Text,
                        Cbo_TipoMaquina.SelectedItem.ToString(),
                        Nud_HoraOperacion.Value,
                        Txt_MantenimientoPeriodico.Text,
                        Dtp_UltimaMantenimiento.Value,
                        Dtp_ProximoMantenimiento.Value,
                        Cbo_Area.SelectedItem?.ToString(),
                        Nud_DesgastePorcentaje.Value,
                        Cbo_Estado.SelectedIndex
                    );

                    MessageBox.Show("Mantenimiento actualizado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Seleccione un mantenimiento para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el mantenimiento: " + ex.Message);
            }
        }

        // Evento del botón Eliminar
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txt_ID_Maquinaria.Text))
                {
                    int idMaquinaria = Convert.ToInt32(Txt_ID_Maquinaria.Text);
                    DialogResult result = MessageBox.Show("¿Está seguro de desactivar el mantenimiento?", "Confirmación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        control.DesactivarMantenimiento(idMaquinaria); // Cambia el estado a 0
                        MessageBox.Show("Mantenimiento desactivado correctamente.");
                        CargarDatos(); // Refrescar el DataGridView
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un mantenimiento para desactivar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desactivar el mantenimiento: " + ex.Message);
            }
        }

        // Método para manejar el clic en una celda del DataGridView y cargar los datos en los controles
        private void Dgv_Mantenimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que no se hace clic en el encabezado
            {
                DataGridViewRow fila = Dgv_Mantenimientos.Rows[e.RowIndex];

                // Asigna cada valor al control correspondiente, manejando posibles valores nulos y límites
                Txt_ID_Maquinaria.Text = fila.Cells["Pk_id_maquinaria"].Value?.ToString() ?? string.Empty;
                Txt_NombreMaquinaria.Text = fila.Cells["nombre_maquinaria"].Value?.ToString() ?? string.Empty;

                var tipoMaquina = fila.Cells["tipo_maquina"].Value?.ToString();
                Cbo_TipoMaquina.SelectedItem = Cbo_TipoMaquina.Items.Contains(tipoMaquina) ? tipoMaquina : null;

                decimal horaOperacion = fila.Cells["hora_operacion"].Value != null ? Convert.ToDecimal(fila.Cells["hora_operacion"].Value) : 0;
                Nud_HoraOperacion.Value = Math.Min(horaOperacion, Nud_HoraOperacion.Maximum);

                Txt_MantenimientoPeriodico.Text = fila.Cells["mantenimiento_periodico"].Value?.ToString() ?? string.Empty;

                Dtp_UltimaMantenimiento.Value = fila.Cells["ultima_mantenimiento"].Value != null
                    ? Convert.ToDateTime(fila.Cells["ultima_mantenimiento"].Value)
                    : DateTime.Now;

                Dtp_ProximoMantenimiento.Value = fila.Cells["proximo_mantenimiento"].Value != null
                    ? Convert.ToDateTime(fila.Cells["proximo_mantenimiento"].Value)
                    : DateTime.Now;

                var area = fila.Cells["area"].Value?.ToString();
                Cbo_Area.SelectedItem = Cbo_Area.Items.Contains(area) ? area : null;

                decimal desgastePorcentaje = fila.Cells["desgaste_porcentaje"].Value != null ? Convert.ToDecimal(fila.Cells["desgaste_porcentaje"].Value) : 0;
                Nud_DesgastePorcentaje.Value = Math.Min(desgastePorcentaje, Nud_DesgastePorcentaje.Maximum);

                Cbo_Estado.SelectedIndex = fila.Cells["estado"].Value != null ? Convert.ToInt32(fila.Cells["estado"].Value) : -1;
            }
        }

        // Método de validación para campos requeridos con try-catch para cada campo
        private bool ValidarCampos()
        {
            try
            {
                // Validación para Txt_NombreMaquinaria
                if (string.IsNullOrWhiteSpace(Txt_NombreMaquinaria.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la maquinaria.");
                    return false;
                }
                else if (Txt_NombreMaquinaria.Text.Length > 50)
                {
                    MessageBox.Show("El nombre de la maquinaria no debe exceder los 50 caracteres.");
                    return false;
                }
                else if (!Regex.IsMatch(Txt_NombreMaquinaria.Text, @"^(?=.*[a-zA-Z])[a-zA-Z0-9\s]+$"))
                {
                    MessageBox.Show("El nombre de la maquinaria debe contener al menos una letra y solo puede contener letras, números y espacios.");
                    return false;
                }

                // Validación para Txt_MantenimientoPeriodico
                string mantenimientoPeriodico = Txt_MantenimientoPeriodico.Text.Trim();
                if (string.IsNullOrWhiteSpace(mantenimientoPeriodico))
                {
                    MessageBox.Show("Por favor, ingrese una descripción válida para el mantenimiento periódico.");
                    return false;
                }
                else if (mantenimientoPeriodico.Length < 3 || mantenimientoPeriodico.Length > 100)
                {
                    MessageBox.Show("La descripción del mantenimiento periódico debe tener entre 3 y 100 caracteres.");
                    return false;
                }
                else if (!Regex.IsMatch(mantenimientoPeriodico, @"[a-zA-Z]")) // Asegura que contiene al menos una letra
                {
                    MessageBox.Show("La descripción del mantenimiento periódico debe contener al menos una letra.");
                    return false;
                }
                else if (Regex.IsMatch(mantenimientoPeriodico, @"^\d+$")) // Evita que sea solo números
                {
                    MessageBox.Show("La descripción del mantenimiento periódico no puede ser solo números.");
                    return false;
                }

                // Validación adicional para otros campos
                if (Cbo_TipoMaquina.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo de máquina.");
                    return false;
                }

                if (Cbo_Estado.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un estado.");
                    return false;
                }

                if (Nud_HoraOperacion.Value <= 0 || Nud_HoraOperacion.Value > 10000)
                {
                    MessageBox.Show("La hora de operación debe ser un valor positivo y no mayor a 10000.");
                    return false;
                }

                if (Dtp_ProximoMantenimiento.Value <= Dtp_UltimaMantenimiento.Value)
                {
                    MessageBox.Show("La fecha del próximo mantenimiento debe ser posterior a la última fecha de mantenimiento.");
                    return false;
                }

                if (Cbo_Area.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un área.");
                    return false;
                }

                if (Nud_DesgastePorcentaje.Value < 0 || Nud_DesgastePorcentaje.Value > 100)
                {
                    MessageBox.Show("El porcentaje de desgaste debe estar entre 0 y 100.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación de campos: " + ex.Message);
                return false;
            }

            return true;
        }

        private void Frm_Mantenimiento_Load(object sender, EventArgs e)
        {
            ObtenerUltimoIdMaquinaria();
        }

        // Evento del botón Nuevo para limpiar campos y cargar el siguiente ID
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();  // Llama al método para limpiar los campos
            ObtenerUltimoIdMaquinaria();  // Configura Txt_ID_Maquinaria con el siguiente ID
        }

        // Método para limpiar todos los campos en el formulario
        private void LimpiarCampos()
        {
            Txt_NombreMaquinaria.Clear();  // Limpia el nombre de la maquinaria
            Cbo_TipoMaquina.SelectedIndex = 0;  // Restablece el tipo de máquina al primer elemento
            Nud_HoraOperacion.Value = 0;  // Restablece la hora de operación a 0
            Txt_MantenimientoPeriodico.Clear();  // Limpia el campo de mantenimiento periódico
            Dtp_UltimaMantenimiento.Value = DateTime.Now;  // Restablece la fecha de último mantenimiento a hoy
            Dtp_ProximoMantenimiento.Value = DateTime.Now;  // Restablece la fecha de próximo mantenimiento a hoy
            Cbo_Area.SelectedIndex = 0;  // Restablece el área al primer elemento
            Nud_DesgastePorcentaje.Value = 0;  // Restablece el porcentaje de desgaste a 0
            Cbo_Estado.SelectedIndex = 1;  // Establece el estado en 'Activo'
        }
    }
}
