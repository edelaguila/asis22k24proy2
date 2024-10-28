using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CierreContable;

namespace Capa_Vista_CierreContable
{
    public partial class CierreMensual : Form
    {
        Controlador cn = new Controlador();
        public CierreMensual()
        {
            InitializeComponent();
        }

        private void ConsultasCierre_Load(object sender, EventArgs e)
        {
            LlenarCuentas();
            
            LlenarCboAnio();
            LlenarCboMes();
            // Configuración del ToolTip
            ToolTip toolTip = new ToolTip
            {
                IsBalloon = true // Hacer que el tooltip tenga forma de globo
            };
            toolTip.SetToolTip(btn_GuardarCierre, "Guarda el cierre contable, no se podrá modificar nada luego de esto.");
            toolTip.SetToolTip(btn_cancelar, "Cancela el guardado del cierre actual");
            toolTip.SetToolTip(btn_nuevocierre, "Genera el cierre del mes actual");
        }

        private void LlenarCboAnio()
        {
            // Obtener el año actual
            int anioActual = DateTime.Now.Year;

            // Limpiar el ComboBox
            cbo_año.Items.Clear();

            // Agregar el año actual al ComboBox
            cbo_año.Items.Add(anioActual.ToString());

            // Seleccionar el año actual como predeterminado
            cbo_año.SelectedIndex = 0;
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




        private void LlenarCboMes()
        {
            // Verificar si hay un año seleccionado
            if (int.TryParse(cbo_año.Text, out int anio))
            {
                // Obtener todas las cuentas
                DataTable cuentas = cn.ObtenerCuentas();
                HashSet<int> idsCuentas = new HashSet<int>();

                // Agregar los IDs de las cuentas a un HashSet para fácil verificación
                foreach (DataRow row in cuentas.Rows)
                {
                    idsCuentas.Add(Convert.ToInt32(row["Pk_id_cuenta"])); // Asegúrate de que el nombre de la columna sea correcto
                }

                // Obtener el último mes con datos
                int ultimoMesConDatos = cn.ObtenerUltimoMesConDatos(anio);

                // Limpiar el ComboBox
                cbo_mes.Items.Clear();

                // Llamar al método del controlador para obtener los meses válidos
                DataTable mesesValidos = cn.ObtenerMesesSinDatos(ultimoMesConDatos, idsCuentas);

                // Llenar el ComboBox con los meses obtenidos
                foreach (DataRow row in mesesValidos.Rows)
                {
                    cbo_mes.Items.Add(row["Mes"]);
                }

                // Si no hay meses disponibles, puedes mostrar un mensaje
                if (cbo_mes.Items.Count == 0)
                {
                    MessageBox.Show("No hay meses disponibles para seleccionar.");
                }
            }
        }




        private void LlenarCierre(string cuentaSeleccionada)
        {
            DataTable datosCierre;

            // Verificar si se seleccionó "Todas las cuentas"
            if (cuentaSeleccionada == "Todas las cuentas")
            {
                datosCierre = cn.ObtenerDatosCierre(null); // Pasar null o un valor que indique que se deben obtener todas las cuentas
            }
            else
            {
                datosCierre = cn.ObtenerDatosCierre(cuentaSeleccionada);
            }

            // Verificar si se obtuvieron datos
            if (datosCierre != null && datosCierre.Rows.Count > 0)
            {
                dgv_cierre.DataSource = datosCierre; // Asignar el DataTable al DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron datos para la cuenta seleccionada.");
                dgv_cierre.DataSource = null; // Limpiar el DataGridView si no hay datos
            }
        }




        private void btn_nuevocierre_Click(object sender, EventArgs e)
        {
            string mes = cbo_mes.Text; // Obtener el mes desde el ComboBox
            string anio = cbo_año.Text; // Año de interés
            string cuentaSeleccionada = cbo_cuenta.Text;
            int periodo = 0;
            int aniov = 0;

            // Intenta convertir el texto a un entero
            if (!int.TryParse(anio, out aniov))
            {
                // La conversión falló, maneja el error aquí
                MessageBox.Show("Error: el año seleccionado no es válido.");
                return; // Salir del método si el año no es válido
            }

            // Verificar si se seleccionó un mes
            if (string.IsNullOrEmpty(mes))
            {
                string mensaje = "Error, debe seleccionar un mes para poder realizar la consulta. Intente de nuevo";
                MessageBox.Show(mensaje);
                return; // Salir del método si el mes no es válido
            }

            // Mapear el mes a su correspondiente periodo
            periodo = cn.ObtenerPeriodoPorMes(mes);

            LlenarCierre(cuentaSeleccionada);

            MessageBox.Show($"Mes: {mes}, Año: {aniov}.");

            cn.ConsultarCierreG(periodo, cuentaSeleccionada, txt_cargomes, txt_abonomes, txt_saldoantmes, txt_saldoactmes);


            // Aquí puedes continuar con cualquier lógica que necesites, 
            // como habilitar otros controles o realizar otras acciones.

            btn_nuevocierre.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_GuardarCierre.Enabled = true;
        }

        // Evento de clic para btn_cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            // Limpiar el DataGridView
            dgv_cierre.DataSource = null; // O puedes usar dgv_cierre.Rows.Clear(); para eliminar filas
            dgv_cierre.Columns.Clear(); // Opcional: si deseas eliminar también las columnas

            // Activa el botón Nuevocierre y desactiva el botón Cancelar
            btn_nuevocierre.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_GuardarCierre.Enabled = false;
        }

        // Método para incrementar el año si el año actual tiene cierres completos
        private void IncrementarAnioSiEsNecesario(int anio)
        {
            // Verificar si el año tiene cierres completos
            if (cn.VerificarCierresCompletos(anio))
            {
                // Incrementar el año y  en el ComboBox
                int nuevoAnio = anio + 1;
                cbo_año.Items.Clear();
                cbo_año.Items.Add(nuevoAnio.ToString());
                cbo_año.SelectedIndex = 0;

                MessageBox.Show("Se ha completado el año. Ahora se procederá al año " + nuevoAnio);

                // Actualizar el año en tbl_historico_cuentas
                cn.ActualizarAnioHistorico(anio, nuevoAnio);
            }
        }

        private void IncrementarAnioSiEsNecesario()
        {
            int anioActual = int.Parse(cbo_año.Text);

            // Verificar si el año actual tiene cierres completos
            if (cn.VerificarCierresCompletos(anioActual))
            {
                // Incrementar el año en el ComboBox y en la base de datos
                int nuevoAnio = anioActual + 1;
                cbo_año.Items.Clear();
                cbo_año.Items.Add(nuevoAnio.ToString());
                cbo_año.SelectedIndex = 0;

                MessageBox.Show("Se ha completado el año. Ahora se procederá al año " + nuevoAnio);

                // Lógica para actualizar el año en `tbl_historico_cuentas`
                cn.ActualizarAnioHistorico(anioActual, nuevoAnio);
            }
        }


        private void btn_GuardarCierre_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Estás seguro de realizar esta operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                string mes = cbo_mes.Text;  // Obtener el mes como texto
                int anio = int.Parse(cbo_año.Text);

                int periodo = cn.ObtenerPeriodoPorMes(mes.ToUpper()); // Convertir a mayúsculas

                if (periodo == 0)
                {
                    MessageBox.Show("Error: el mes seleccionado no es válido.");
                    return; // Salir si el mes no es válido
                }

                cn.GenerarNuevoCierre(periodo, anio); // Usar el periodo obtenido

                // Verifica y actualiza el año completo
                cn.VerificarYActualizarAnoCompleto(anio);

                // Llama a IncrementarAnioSiEsNecesario para incrementar el año si es necesario
                IncrementarAnioSiEsNecesario(anio);

                // Limpiar el DataGridView y restaurar botones a su estado inicial
                dgv_cierre.DataSource = null;  // Desvincular el DataGridView de su fuente de datos
                dgv_cierre.Rows.Clear();       // Limpiar las filas

                btn_nuevocierre.Enabled = true;
                btn_GuardarCierre.Enabled = false;
                LlenarCboMes();

                // Actualizar ComboBox de meses
                cn.ActualizarComboBoxMeses();
            }
            else
            {
                dgv_cierre.Rows.Clear();
                btn_nuevocierre.Enabled = true;
            }
        }




    }
}
