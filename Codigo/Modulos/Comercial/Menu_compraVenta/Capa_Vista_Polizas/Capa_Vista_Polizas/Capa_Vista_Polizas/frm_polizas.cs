using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Capa_Controlador_Polizas;

namespace Capa_Vista_Polizas
{
    public partial class frmPolizas : Form
    {
        private string idcuenta;
        private string idoperacion;
        private string idtp;
        List<object[]> detalles = new List<object[]>();

        public frmPolizas()
        {
            InitializeComponent();
            llenarseCuentas("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta");
            llenarseTP("tbl_tipopoliza", "Pk_id_tipopoliza", "tipo");
            llenarseOP("tbl_tipooperacion", "Pk_id_tipooperacion", "nombre");

            //Botones y demas 
            Cbo_Cuenta.Enabled = false;
            Cbo_operacion.Enabled = false;
            Cbo_tipopoliza.Enabled = false;
            Txt_concepto.Enabled = false;
            Txt_valor.Enabled = false;
            Dpt_fecha.Enabled = false;
            Btn_quitar.Enabled = false;
            Btn_aceptar.Enabled = false;
            Btn_registar_poliza.Enabled = false;
            Btn_Cancelar.Enabled = false;
        }

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------

        public void llenarseCuentas(string tabla, string campo1, string campo2)
        {
            controladorPolizas ctr = new controladorPolizas(); // Instancia controlador

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;

            Cbo_Cuenta.ValueMember = cmp1;
            Cbo_Cuenta.DisplayMember = cmp2;

            string[] items = ctr.itemsCuenta(tabla, campo1, campo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Cbo_Cuenta.Items.Add(items[i]);
                    }
                } 
            }

            var dt2 = ctr.enviarCuentas(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo2]));
            }

            Cbo_Cuenta.DataSource = dt2;
            Cbo_Cuenta.ValueMember = campo1;
            Cbo_Cuenta.DisplayMember = campo2;

            Cbo_Cuenta.AutoCompleteCustomSource = coleccion;
            Cbo_Cuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_Cuenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // ---------------------------------- COMBO BOX TIPO CUENTA ----------------------------------

        public void llenarseTP(string tabla, string campo1, string campo2)
        {
            controladorPolizas ctr = new controladorPolizas(); // Instancia controlador

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;

            Cbo_tipopoliza.ValueMember = campo1;
            Cbo_tipopoliza.DisplayMember = campo2;

            string[] items = ctr.itemsTP(tabla, campo1, campo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Cbo_tipopoliza.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarTP(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cbo_tipopoliza.DataSource = dt2;
            Cbo_tipopoliza.ValueMember = campo1;
            Cbo_tipopoliza.DisplayMember = campo2;

            Cbo_tipopoliza.AutoCompleteCustomSource = coleccion;
            Cbo_tipopoliza.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_tipopoliza.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public void llenarseOP(string tabla, string campo1, string campo2)
        {
            controladorPolizas ctr = new controladorPolizas(); // Instancia controlador

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;

            Cbo_operacion.ValueMember = campo1;
            Cbo_operacion.DisplayMember = campo2;

            string[] items = ctr.itemsOP(tabla, campo1, campo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Cbo_operacion.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarOP(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo2]));
            }

            Cbo_operacion.DataSource = dt2;
            Cbo_operacion.ValueMember = campo1;
            Cbo_operacion.DisplayMember = campo2;

            Cbo_operacion.AutoCompleteCustomSource = coleccion;
            Cbo_operacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_operacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cbtipopoliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtp = Cbo_tipopoliza.SelectedValue.ToString();
        }

        private void cboperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            idoperacion = Cbo_operacion.SelectedValue.ToString();
        }

        private void cbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcuenta = Cbo_Cuenta.SelectedValue.ToString();
        }
        private void btn_nueva_poliza_Click(object sender, EventArgs e)
        {
            Cbo_Cuenta.Enabled = true;
            Cbo_operacion.Enabled = true;
            Cbo_tipopoliza.Enabled = true;
            Txt_concepto.Enabled = true;
            Txt_valor.Enabled = true;
            Dpt_fecha.Enabled = true;
            Btn_aceptar.Enabled = true;
            Btn_quitar.Enabled = true;
            Btn_registar_poliza.Enabled = true;
            Btn_Cancelar.Enabled = true;

            //Bandera de prueba
            MessageBox.Show("Empieza el ingreso de una poliza");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Restablecer los ComboBox a su estado inicial (sin selección)
            Cbo_Cuenta.SelectedIndex = 0;
            Cbo_operacion.SelectedIndex = 0;
            Cbo_tipopoliza.SelectedIndex = 0;

            // Limpiar los TextBox
            Txt_concepto.Clear();
            Txt_valor.Clear();

            // Restablecer la fecha en el DateTimePicker a la fecha actual (o a cualquier valor que desees)
            Dpt_fecha.Value = DateTime.Now;

            // Opcional: Desactivar los controles si es parte del proceso
            Cbo_Cuenta.Enabled = false;
            Cbo_operacion.Enabled = false;
            Cbo_tipopoliza.Enabled = false;
            Txt_concepto.Enabled = false;
            Txt_valor.Enabled = false;
            Dpt_fecha.Enabled = false;
            Btn_aceptar.Enabled = false;
            Btn_quitar.Enabled = false;
            Btn_registar_poliza.Enabled = false;
            Btn_Cancelar.Enabled = false;

            //Vaciar labels
            Lbl_AbonoTot.Text = "00.00";
            Lbl_CargoTot.Text = "00.00";

            //Vaciar el DataGridView
            Dgv_Polizas.Rows.Clear();

            // Mostrar un mensaje de confirmación (opcional)
            MessageBox.Show("Se ha cancelado la creación de la póliza");

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Se obtiene los valores de los txtbox
            string concepto = Txt_concepto.Text;
            string valor = Txt_valor.Text;

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Por favor, ingrese un valor.");
                return;
            }

            // Obtener el valor del DateTimePicker
            DateTime fechaSeleccionada = Dpt_fecha.Value;

            // Obtener el ID y nombre de la cuenta seleccionada
            string cuentaSeleccionada = Cbo_Cuenta.Text;
            string idcuenta = Cbo_Cuenta.SelectedValue?.ToString();

            // Verificar si la cuenta es válida
            if (string.IsNullOrEmpty(idcuenta))
            {
                MessageBox.Show("Por favor, seleccione una cuenta válida.");
                return;
            }

            // Obtener el ID y nombre de la operación seleccionada
            string operacionSeleccionada = Cbo_operacion.Text;
            string idoperacion = Cbo_operacion.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(idoperacion))
            {
                MessageBox.Show("Por favor, seleccione una operación válida.");
                return;
            }

            // Verificar si es Cargo o Abono
            string cargo = "";
            string abono = "";

            //Ver si es cargo o abono
            if (operacionSeleccionada.Equals("Cargo", StringComparison.OrdinalIgnoreCase))
            {
                cargo = valor;
                abono = "";
            }
            else if (operacionSeleccionada.Equals("Abono", StringComparison.OrdinalIgnoreCase))
            {
                abono = valor;
                cargo = "";
            }
            else
            {
                MessageBox.Show("Seleccione una operación válida (Cargo o Abono).");
                return;
            }

            // Agregar una nueva fila al DataGridView con los valores correctos
            Dgv_Polizas.Rows.Add(idcuenta, cuentaSeleccionada, cargo, abono);

            //Probando el jalar valores
            //MessageBox.Show($"Concepto: {concepto}\nFecha: {fechaSeleccionada.ToShortDateString()}\nValor: {valor}\nCuenta: {cuentaSeleccionada} (ID: {idcuenta})\nOperación: {operacionSeleccionada} (ID: {idoperacion})\nCargo: {cargo}\nAbono: {abono} \n Tipo: {idtp}");

            // Limpiar los campos después de agregar (opcional)
            SumarColumnas();
            LimpiarCamposDetelle();
        }

        private void LimpiarCamposDetelle()
        {
            Txt_valor.Clear();
            Cbo_Cuenta.SelectedIndex = 0;
            Cbo_operacion.SelectedIndex = 0;
        }

        private void LimpiarCamposEnc()
        {
            Cbo_tipopoliza.SelectedIndex = 0;
            Txt_concepto.Text = "";
            Lbl_AbonoTot.Text = "00.00";
            Lbl_CargoTot.Text = "00.00";
        }

        private void dgvPolizas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_Polizas.Rows[e.RowIndex];

                // Aquí puedes acceder a los valores de la fila seleccionada
                string cuenta = row.Cells["Cuenta"].Value.ToString();
                string cargo = row.Cells["Cargo"].Value.ToString();

                // Mostrar información o hacer algo con los valores seleccionados
                MessageBox.Show($"Cuenta: {cuenta}, Cargo: {cargo}");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Verifica que haya al menos una fila seleccionada
            if (Dgv_Polizas.SelectedRows.Count > 0)
            {
                // Confirmar eliminación si quieres (opcional)
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas quitar esta fila?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada
                    foreach (DataGridViewRow row in Dgv_Polizas.SelectedRows)
                    {
                        Dgv_Polizas.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Se quitó la cuenta", "Aviso");
                    }
                }
            }
            else
            {
                // Si no hay fila seleccionada, mostrar un mensaje
                MessageBox.Show("Por favor selecciona una fila para quitar.", "Aviso");
            }

            SumarColumnas();
        }

        private void SumarColumnas()
        {
            // Variables para almacenar las sumas
            decimal sumaCargo = 0;
            decimal sumaAbono = 0;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in Dgv_Polizas.Rows)
            {
                // Asegurarse de que la fila no esté vacía
                if (row.Cells["Cargo"].Value != null && row.Cells["Abono"].Value != null)
                {
                    // Sumar la columna Cargo
                    decimal cargo;
                    if (decimal.TryParse(row.Cells["Cargo"].Value.ToString(), out cargo))
                    {
                        sumaCargo += cargo;
                    }

                    // Sumar la columna Abono
                    decimal abono;
                    if (decimal.TryParse(row.Cells["Abono"].Value.ToString(), out abono))
                    {
                        sumaAbono += abono;
                    }
                }
            }

            // Mostrar las sumas en los TextBox correspondientes
            Lbl_CargoTot.Text = sumaCargo.ToString("N2"); // Formato numérico con 2 decimales
            Lbl_AbonoTot.Text = sumaAbono.ToString("N2"); // Formato numérico con 2 decimales
        }

        private void btn_registar_poliza_Click(object sender, EventArgs e)
        {
            if (Dgv_Polizas.Rows.Count == 0 || Dgv_Polizas.Rows.Cast<DataGridViewRow>().All(row => row.IsNewRow))
            {
                MessageBox.Show("El detalle de la póliza está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                controladorPolizas ctr = new controladorPolizas();

                string fechaSeleccionada = Dpt_fecha.Text;
                string concepto = Txt_concepto.Text;

                errorProvider1.SetError(Txt_concepto, "");

                // Verificar si el TextBox está vacío
                if (string.IsNullOrWhiteSpace(Txt_concepto.Text))
                {
                    errorProvider1.SetError(Txt_concepto, "Este campo es obligatorio."); // Mostrar mensaje de error
                    Txt_concepto.Focus(); // Enfocar el TextBox
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea crear la póliza?", "Confirmación", MessageBoxButtons.YesNo);

                    // No hacer nada en caso de que el usuario seleccione "Sí" o "No"
                    if (result == DialogResult.Yes)
                    {
                        if (result == DialogResult.Yes)
                        {
                            // Verificar que los ComboBox tengan valores seleccionados
                            if (Cbo_tipopoliza.SelectedValue == null || Cbo_operacion.SelectedValue == null || Cbo_Cuenta.SelectedValue == null)
                            {
                                MessageBox.Show("Por favor, seleccione todos los campos requeridos.");
                                return; // Salir si no se selecciona algo
                            }


                            // Obtener el ID de la cuenta seleccionada directamente como número

                            int idTipoPoliza = int.Parse(idtp);
                            //MessageBox.Show($"ID Tipo Póliza: {idTipoPoliza}", "Detalles de Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpiar la lista antes de agregar detalles
                            detalles.Clear();

                            // Recorrer filas del DGV
                            foreach (DataGridViewRow row in Dgv_Polizas.Rows)
                            {
                                int idop = 0;

                                if (row.IsNewRow) continue; // Ignorar la última fila (nueva)

                                // ID de la cuenta (columna 'Codigo')
                                int idCuenta = Convert.ToInt32(row.Cells["Codigo"].Value);

                                // Determinar si es Cargo o Abono
                                string tipoOperacion = "";
                                decimal valor = 0;

                                if (row.Cells[2].Value != DBNull.Value && row.Cells[2].Value.ToString() != "")
                                {
                                    tipoOperacion = "Cargo";
                                    idop = 1;
                                    valor = Convert.ToDecimal(row.Cells[2].Value);
                                }
                                else if (row.Cells[3].Value != DBNull.Value && row.Cells[3].Value.ToString() != "")
                                {
                                    tipoOperacion = "Abono";
                                    idop = 2;
                                    valor = Convert.ToDecimal(row.Cells[3].Value);
                                }

                                // Crea un arreglo con los valores de la fila
                                object[] detalle = new object[3];
                                detalle[0] = idCuenta; // ID de cuenta seleccionada
                                detalle[1] = idop; // ID de operación
                                detalle[2] = valor; // Valor correspondiente a Cargo o Abono

                                // Agrega el arreglo a la lista
                                detalles.Add(detalle);

                                // Función que cambia la tabla cuentas
                                ctr.ActualizarTblCuentas(idCuenta, tipoOperacion, valor);

                                /*MessageBox.Show($"ID Tipo Póliza: {idTipoPoliza}\nID Operación: {idop}\nID Cuenta Seleccionada: {idCuenta}\nID Valor: {valor}",
                                "Detalles de Selección",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);*/
                            }

                            // Funciones para insertar en las tablas de encabezado póliza y detalle póliza
                            ctr.LlenarEncabezado(fechaSeleccionada, concepto, idTipoPoliza);
                            ctr.LlenarDetalle(fechaSeleccionada, concepto, detalles);

                            // Mensaje de confirmación
                            LimpiarCamposDetelle();
                            LimpiarCamposEnc();
                            Dgv_Polizas.Rows.Clear();
                            MessageBox.Show("Se registró correctamente");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Se canceló el proceso", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
        private void Polizas_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(243, 242, 137);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            if (Dpt_fecha.Value.Date != DateTime.Today)
            {
                Dpt_fecha.Value = DateTime.Today;
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton ayuda
           // toolTipAyuda.SetToolTip(Btn_ayuda, " Documento de ayuda ");

            // Obtener la ruta del directorio del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string sProjectPath = Path.GetFullPath(Path.Combine(sExecutablePath, @"D:\Carpeta de Prueba\Capa_Vista_Polizas\Capa_Vista_Polizas\AyudasPoliza"));
            MessageBox.Show("1" + sProjectPath);


            string sAyudaFolderPath = Path.Combine(sProjectPath, "AyudasPoliza");

            string sPathAyuda = funFindFileInDirectory(sAyudaFolderPath, "AyudaPolizas.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
                MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, sPathAyuda, "ayudaPolizas.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }

        }

        private string funFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sDirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in sFiles)
                    {
                        if (Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {   //Mensaje de No se encontro la carpeta
                    MessageBox.Show("No se encontró la carpeta: " + sDirectory);
                }
            }
            catch (Exception ex)
            {       //Mensaje de error al buscar el archivo
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        private void Btn_ayuda_Click_1(object sender, EventArgs e)
        {

        }
    }
}



