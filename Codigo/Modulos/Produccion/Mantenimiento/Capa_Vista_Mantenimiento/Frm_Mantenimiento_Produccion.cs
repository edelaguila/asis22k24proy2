using System;
using System.Data;
using System.Windows.Forms;
using Capa_Control_Mantenimiento;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Capa_Vista_Mantenimiento
{
    public partial class Frm_Mantenimiento_Produccion : Form
    {
        private Control_Mantenimiento control;
        private int idMaquinaSeleccionada; // Variable para almacenar temporalmente el ID de la máquina
        private ToolTip toolTip;

        public Frm_Mantenimiento_Produccion()
        {
            InitializeComponent();
            control = new Control_Mantenimiento();

            // Configurar ToolTips
            toolTip = new ToolTip();
            ConfigurarToolTips();
            Dgv_Mantenimientos.CellClick += Dgv_Mantenimientos_CellClick;

            // Cargar valores predeterminados en los ComboBox
            CargarValoresPredeterminados();

            // Cargar los datos en el DataGridView al inicializar el formulario
            CargarDatos();

            // Cargar las opciones en el ComboBox de nombre de máquina
            CargarComboNombreMaquina();

            // Asociar el evento de selección de cambio en cbo_nombre_maquina
            cbo_nombre_maquina.SelectedIndexChanged += Cbo_nombre_maquina_SelectedIndexChanged;

            // Cargar el último ID al TextBox
            ObtenerUltimoIdMaquinaria();
        }

        private void CargarComboNombreMaquina()
        {
            cbo_nombre_maquina.Items.Clear();
            DataTable maquinas = control.ObtenerNombresMaquinas();

            foreach (DataRow row in maquinas.Rows)
            {
                cbo_nombre_maquina.Items.Add(row["nombre_maquina"].ToString());
            }
        }

        private void Cbo_nombre_maquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que haya un elemento seleccionado
            if (cbo_nombre_maquina.SelectedItem != null)
            {
                // Obtener el nombre de la máquina seleccionada
                string nombreMaquina = cbo_nombre_maquina.SelectedItem.ToString();

                // Obtener id y tipo de la máquina desde el controlador
                var (idMaquina, tipoMaquina) = control.ObtenerDatosMaquina(nombreMaquina);

                // Almacenar el id en la variable
                idMaquinaSeleccionada = idMaquina;

                // Autocompletar el tipo de máquina en el ComboBox
                Cbo_TipoMaquina.SelectedItem = tipoMaquina;
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ObtenerUltimoIdMaquinaria();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    // Llamar al método de agregar mantenimiento en el controlador con los valores de los controles
                    control.AgregarMantenimiento(
                        idMaquinaSeleccionada, // ID de la máquina seleccionado
                        cbo_nombre_maquina.SelectedItem.ToString(),
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

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Mantenimientos.SelectedRows.Count > 0 && ValidarCampos())
                {
                    int idMaquinaria = Convert.ToInt32(Txt_ID_Maquinaria.Text);

                    control.ActualizarMantenimiento(
                        idMaquinaria,
                        idMaquinaSeleccionada, // ID de la máquina seleccionado
                        cbo_nombre_maquina.SelectedItem.ToString(),
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
                        control.DesactivarMantenimiento(idMaquinaria);
                        MessageBox.Show("Mantenimiento desactivado correctamente.");
                        CargarDatos();
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

        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(Btn_Agregar, "Agregar un nuevo mantenimiento");
            toolTip.SetToolTip(Btn_Actualizar, "Actualizar el mantenimiento seleccionado");
            toolTip.SetToolTip(Btn_Eliminar, "Desactivar el mantenimiento seleccionado");
            toolTip.SetToolTip(btn_Nuevo, "Limpiar los campos para un nuevo ingreso de mantenimiento");
        }

        private void CargarValoresPredeterminados()
        {
            Cbo_TipoMaquina.Items.Clear();
            Cbo_TipoMaquina.Items.AddRange(new object[] { "Cortadora", "Taladradora", "Fresadora", "Torno", "Pulidora" });

            if (Cbo_TipoMaquina.Items.Count > 0)
            {
                Cbo_TipoMaquina.SelectedIndex = 0;
            }

            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.AddRange(new object[] { "Inactivo", "Activo" });
            Cbo_Estado.SelectedIndex = 1;

            Cbo_Area.Items.Clear();
            Cbo_Area.Items.AddRange(new object[] { "Producción", "Mantenimiento", "Calidad", "Almacén", "Logística" });
            Cbo_Area.SelectedIndex = 0;

            Nud_HoraOperacion.Minimum = 0;
            Nud_HoraOperacion.Maximum = 10000;

            Nud_DesgastePorcentaje.Minimum = 0;
            Nud_DesgastePorcentaje.Maximum = 100;
        }

        private void CargarDatos()
        {
            Dgv_Mantenimientos.DataSource = control.CargarMantenimientos();
            Console.WriteLine("Datos cargados en el DataGridView.");
        }

        private void ObtenerUltimoIdMaquinaria()
        {
            int ultimoId = control.ObtenerUltimoIdMaquinaria();
            Txt_ID_Maquinaria.Text = (ultimoId + 1).ToString();
            Txt_ID_Maquinaria.ReadOnly = true;
            Console.WriteLine("Último ID de maquinaria obtenido y mostrado en el TextBox: " + Txt_ID_Maquinaria.Text);
        }

        private void Dgv_Mantenimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Mantenimientos.Rows[e.RowIndex];

                Txt_ID_Maquinaria.Text = fila.Cells["Pk_id_maquinaria"].Value?.ToString() ?? string.Empty;
                cbo_nombre_maquina.SelectedItem = fila.Cells["nombre_maquinaria"].Value?.ToString();

                var tipoMaquina = fila.Cells["tipo_maquina"].Value?.ToString();
                Cbo_TipoMaquina.SelectedItem = Cbo_TipoMaquina.Items.Contains(tipoMaquina) ? tipoMaquina : null;

                Nud_HoraOperacion.Value = fila.Cells["hora_operacion"].Value != null ? Convert.ToDecimal(fila.Cells["hora_operacion"].Value) : 0;
                Txt_MantenimientoPeriodico.Text = fila.Cells["mantenimiento_periodico"].Value?.ToString() ?? string.Empty;

                Dtp_UltimaMantenimiento.Value = fila.Cells["ultima_mantenimiento"].Value != null
                    ? Convert.ToDateTime(fila.Cells["ultima_mantenimiento"].Value)
                    : DateTime.Now;

                Dtp_ProximoMantenimiento.Value = fila.Cells["proximo_mantenimiento"].Value != null
                    ? Convert.ToDateTime(fila.Cells["proximo_mantenimiento"].Value)
                    : DateTime.Now;

                var area = fila.Cells["area"].Value?.ToString();
                Cbo_Area.SelectedItem = Cbo_Area.Items.Contains(area) ? area : null;

                Nud_DesgastePorcentaje.Value = fila.Cells["desgaste_porcentaje"].Value != null ? Convert.ToDecimal(fila.Cells["desgaste_porcentaje"].Value) : 0;
                Cbo_Estado.SelectedIndex = fila.Cells["estado"].Value != null ? Convert.ToInt32(fila.Cells["estado"].Value) : -1;
            }
        }

        private void LimpiarCampos()
        {
            cbo_nombre_maquina.SelectedIndex = -1;
            Cbo_TipoMaquina.SelectedIndex = 0;
            Nud_HoraOperacion.Value = 0;
            Txt_MantenimientoPeriodico.Clear();
            Dtp_UltimaMantenimiento.Value = DateTime.Now;
            Dtp_ProximoMantenimiento.Value = DateTime.Now;
            Cbo_Area.SelectedIndex = 0;
            Nud_DesgastePorcentaje.Value = 0;
            Cbo_Estado.SelectedIndex = 1;
        }

        private bool ValidarCampos()
        {
            try
            {
                if (cbo_nombre_maquina.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione el nombre de la maquinaria.");
                    return false;
                }
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
                    MessageBox.Show("Seleccione un área.");
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

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "Ayudas/ayuda1.chm", "index.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el archivo de ayuda: " + ex.Message);
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte reporte = new Frm_Reporte();
            reporte.Show();
        }
    }
}
