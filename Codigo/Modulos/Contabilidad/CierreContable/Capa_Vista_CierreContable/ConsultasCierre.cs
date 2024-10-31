using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_CierreContable;

namespace Capa_Vista_CierreContable
{
    public partial class ConsultasCierre : Form
    {
        Controlador cn = new Controlador();

        public ConsultasCierre()
        {
            InitializeComponent();
        }

        private void btn_mensual_Click_1(object sender, EventArgs e)
        {
            string mes = cbo_mes.Text;
            int periodo = 0; // Variable para el periodo
            string cuenta = cbo_cuenta.Text;

            if (string.IsNullOrEmpty(mes))
            {
                string mensaje = "Error, debe seleccionar un mes para poder realizar la consulta. Intente de nuevo";
                MessageBox.Show(mensaje);
            }
            else
            {
                // Mapear el mes a su correspondiente periodo
                periodo = cn.ObtenerPeriodoPorMes(mes);

                // Verifica si se seleccionó "Todas las cuentas" y ajusta la consulta
                if (cuenta == "Todas las cuentas")
                {
                    // Llama a la consulta sin aplicar filtro de cuenta
                    ConsultarCierreG(periodo, null, dgv_cargos, dgv_abonos);
                }
                else
                {
                    // Llama a la consulta con el filtro de cuenta
                    ConsultarCierreG(periodo, cuenta, dgv_cargos, dgv_abonos);
                }

                // Calcular totales
                Totales(dgv_cargos, dgv_abonos, txt_saldoD, txt_saldoH);
            }

            // Actualizar los saldos
            cn.ActualizarSumasSaldos(txt_saldoant, txt_saldofinal, periodo, cuenta == "Todas las cuentas" ? null : cuenta);
        }


        private void Totales(DataGridView dgv_DebeCG, DataGridView dgv_HaberCG, TextBox txt_boxtotD, TextBox txt_boxtotH)
        {
            float suma1 = 0;
            float suma2 = 0;
            //float saldofinal = 0;
            //float saldoanterior = 0; // Cambiar de saldoanterior a saldoanterior acumulado

            // Para el total de debe
            foreach (DataGridViewRow row in dgv_DebeCG.Rows)
            {
                if (row.Cells[4].Value != null)
                    suma1 += Convert.ToSingle(row.Cells[4].Value);
            }
            txt_boxtotD.Text = suma1.ToString("F2");

            // Para el total de haber
            foreach (DataGridViewRow row in dgv_HaberCG.Rows)
            {
                if (row.Cells[4].Value != null)
                    suma2 += Convert.ToSingle(row.Cells[4].Value);
            }
            txt_boxtotH.Text = suma2.ToString("F2");

            //saldofinal = suma2 - suma1;
            //txt_saldofinal.Text = saldofinal.ToString("F2");
            //txt_saldoant.Text = saldoanterior.ToString("F2");
        }


        private void ConsultarCierreG(int periodo, string cuenta, DataGridView dgv_DebeCG, DataGridView dgv_HaberCG)
        {
            try
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();

                // Verificar si se seleccionó "Todas las cuentas"
                if (cuenta == "Todas las cuentas")
                {
                    cuenta = null; // Pasar null para no aplicar filtro por cuenta
                }

                // Realizar la consulta a la base de datos
                cn.ConsultaCG(periodo, cuenta, dt1, dt2);

                // Comprobar si ambas tablas están vacías
                if (dt1.Rows.Count == 0 && dt2.Rows.Count == 0)
                {
                    // Limpiar el DataGridView
                    dgv_cargos.DataSource = null; // O puedes usar dgv_cierre.Rows.Clear(); para eliminar filas
                    dgv_cargos.Columns.Clear(); // Opcional: si deseas eliminar también las columnas
                                                // Limpiar el DataGridView
                    dgv_abonos.DataSource = null; // O puedes usar dgv_cierre.Rows.Clear(); para eliminar filas
                    dgv_abonos.Columns.Clear(); // Opcional: si deseas eliminar también las columnas
                    MessageBox.Show("Este mes aun no ha sido cerrado");
                }
                else
                {
                    // Asignar los datos a los DataGridView si hay resultados
                    dgv_DebeCG.DataSource = dt1;
                    dgv_HaberCG.DataSource = dt2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar cierre: {ex.Message}");
            }
        }



        private void LlenarCuentas()
        {
            DataTable cuentas = cn.ObtenerCuentas();

            // Limpiar y agregar "Todas las cuentas" al ComboBox
            cbo_cuenta.Items.Clear();
            cbo_cuenta.Items.Add("Todas las cuentas");

            foreach (DataRow row in cuentas.Rows)
            {
                cbo_cuenta.Items.Add(row["nombre_cuenta"]); // Ajustar según el nombre de la columna en tu DataTable
            }

            cbo_cuenta.SelectedIndex = 0; // Seleccionar "Todas las cuentas" como predeterminada
        }

        private void PartidaCierre_Load(object sender, EventArgs e)
        {
            LlenarCuentas();

            // Configuración del ToolTip
            ToolTip toolTip = new ToolTip
            {
                IsBalloon = true // Hacer que el tooltip tenga forma de globo
            };

            // Asignar texto a los botones
            toolTip.SetToolTip(btn_consultar, "Muestra los cargos, abonos y el saldo de cada consulta.");

        }

        private void cbo_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

