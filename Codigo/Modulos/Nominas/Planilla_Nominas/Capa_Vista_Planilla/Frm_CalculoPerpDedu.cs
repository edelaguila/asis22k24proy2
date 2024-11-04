﻿using Capa_Controlador_Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista_Planilla
{
    public partial class Frm_CalculoPerpDedu : Form
    {
        Controlador cn = new Controlador();
        String svalorSeleccionado;
        String svalorSeleccionado2;
        private int iidSeleccionado = 0;
        private int iidSeleccionado2 = 0;
        public Frm_CalculoPerpDedu()
        {
            InitializeComponent();
            proCargarEncabezado();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(Btn_insertar, "Insertar un nuevo registro");
            toolTip.SetToolTip(Btn_guardar, "Guardar el registro actual");
            toolTip.SetToolTip(Btn_editar, "Editar el registro seleccionado");
            toolTip.SetToolTip(Btn_cancelar, "Cancelar el ingreso");
            toolTip.SetToolTip(Btn_eliminar, "Eliminar un registro");

            Cbo_Empleado.TabIndex = 0;
            Cbo_DeduccionPerpcepcion.TabIndex = 2;
            proConfigurarControles1(false);
            string stabla = "tbl_empleados";
            string scampo1 = "pk_clave";
            string scampo2 = "empleados_nombre";

            string stablaEnca = "tbl_dedu_perp";
            string scampo1Enca = "pk_dedu_perp";
            string scampo2Enca = "dedu_perp_concepto";


            // Llama al método para llenar el ComboBox
            prollenarseEmpleados(stabla, scampo1, scampo2);
            prollenarseEncabezado(stablaEnca, scampo1Enca, scampo2Enca);

            List<string> items = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            List<string> items2 = new List<string> { "Todos"};

            // Asignar los datos al ComboBox
            cbo_mes.DataSource = items;


        }

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        public void prollenarseEmpleados(string stabla, string scampo1, string scampo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = cn.funenviar(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_Empleado.Items.Clear();

            //Agregar un valor fijo al ComboBox
             Cbo_Empleado.Items.Add(new ComboBoxItem
             {
                 Value = "0",
                 //Puedes ajustar el valor según lo que necesites
             Display = "Todos"
             });

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_Empleado.Items.Add(new ComboBoxItem
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_Empleado.AutoCompleteCustomSource = coleccion;
            Cbo_Empleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_Empleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Empleado.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)Cbo_Empleado.SelectedItem;
                svalorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                Console.Write($"Valor seleccionado: {svalorSeleccionado}", "Valor Seleccionado");
            }
        }

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 2*****************************************************/

        public void prollenarseEncabezado(string stabla, string scampo1, string scampo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = cn.funenviar2(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_DeduccionPerpcepcion.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_DeduccionPerpcepcion.Items.Add(new ComboBoxItem
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion2.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion2.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_DeduccionPerpcepcion.AutoCompleteCustomSource = coleccion2;
            Cbo_DeduccionPerpcepcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_DeduccionPerpcepcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem2
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_DeduccionPerpcepcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_DeduccionPerpcepcion.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)Cbo_DeduccionPerpcepcion.SelectedItem;
                svalorSeleccionado2 = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                Console.Write($"Valor seleccionado: {svalorSeleccionado2}", "Valor Seleccionado");
            }
        }


        /*******************************************************************************************/

        private void proCargarEncabezado()
        {


            //// Cargar deducciones en la DataGridView
            DataTable dedu = cn.funObtenerDedu();
            dgv_deduPerp.DataSource = dedu;
        }


        private void proConfigurarControles1(bool bhabilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            Txt_ClaveVin.Enabled = bhabilitar;

            Cbo_Empleado.Enabled = bhabilitar;
            Cbo_DeduccionPerpcepcion.Enabled = bhabilitar;

            Btn_guardar.Enabled = bhabilitar;
            Btn_editar.Enabled = bhabilitar;
            Btn_eliminar.Enabled = bhabilitar;

        }


        private void proLimpiarFormulario()
        {
            iidSeleccionado = 0;
            // Buscar el último ID en el DataGridView y sumarle 1
            if (dgv_deduPerp.Rows.Count > 0)
            {
                int imaxId = 0;
                foreach (DataGridViewRow row in dgv_deduPerp.Rows)
                {
                    if (row.Cells["ID_Deduccion"].Value != null)
                    {
                        int icurrentId = Convert.ToInt32(row.Cells["ID_Deduccion"].Value);
                        if (icurrentId > imaxId)
                            imaxId = icurrentId;
                    }
                }
                Txt_ClaveVin.Text = (imaxId + 1).ToString();
            }
            else
            {
                Txt_ClaveVin.Text = "1";
            }

            Txt_ClaveVin.Text = "";
            Cbo_Empleado.SelectedIndex=-1;
            Cbo_DeduccionPerpcepcion.SelectedIndex = -1;

        }

        private void proConfigurarControles(bool bhabilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            Txt_ClaveVin.Enabled = bhabilitar;
            Cbo_Empleado.Enabled = bhabilitar;
            Cbo_DeduccionPerpcepcion.Enabled = bhabilitar;

            Btn_guardar.Enabled = bhabilitar;
            Btn_editar.Enabled = bhabilitar;
            Btn_eliminar.Enabled = bhabilitar;

        }



        //***********************************************************************************************/




        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            // Habilitar controles cuando se presiona "Insertar"

            proConfigurarControles1(true);
            proLimpiarFormulario();
            Cbo_Empleado.Focus();

            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;


        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

            if (iidSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para editar");
                return;
            }
            Txt_ClaveVin.Focus();
            Cbo_Empleado.Enabled = true;
            Cbo_DeduccionPerpcepcion.Enabled = true;
            Btn_guardar.Enabled = true;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (Cbo_Empleado.SelectedIndex == -1 || Cbo_DeduccionPerpcepcion.SelectedIndex == -1 )
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }

                // Obtener valores de los campos
                int iempleado = int.Parse(svalorSeleccionado.ToString());
                int idedu = int.Parse(svalorSeleccionado2.ToString());
                //String mes = cbo_mes.SelectedItem.ToString();

                //string iempleado = svalorSeleccionado.ToString();
                //String idedu = svalorSeleccionado2.ToString();
                String mes = cbo_mes.SelectedItem.ToString();


                // Si idSeleccionado es 0, es un nuevo registro
                if (iidSeleccionado == 0)
                {
                    // Insertar nuevo registro
                    cn.funIngresarDedu(iempleado,idedu, mes);
                    MessageBox.Show("Registro insertado exitosamente");
                    // Inicializar los botones de excepción y estado como activos

                }
                else
                {
                    // Actualizar registro existente
                    //cn.funcActualizarLogicaDeduPerp(idSeleccionado, clase, concepto, tipo, aplicacion, excepcionActiva, monto);
                    MessageBox.Show("Registro actualizado exitosamente");
                    // Inicializar los botones de excepción y estado como activos

                }

                proLimpiarFormulario();
                proConfigurarControles(false); // Deshabilitar controles después de guardar
                proCargarEncabezado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            proLimpiarFormulario(); // Limpia el formulario
            proConfigurarControles(false); // Deshabilita controles de edición

            // Reiniciar estados para excepcion y estado
            //excepcionActiva = 1;
            //estadoActivo = 1;
            //ActualizarBotonExcepcion();
            //ActualizarBotonEstado();

            //// Opcionalmente, puedes volver a cargar los datos si es necesario
            //CargarDatos();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (iidSeleccionado != 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                       // cn.funcEliminarLogicaDeduPerp(idSeleccionado);
                        proLimpiarFormulario();
                        proCargarEncabezado();
                        MessageBox.Show("Registro eliminado exitosamente");
                        Btn_editar.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar");
            }
        }

        private void dgv_deduPerp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    iidSeleccionado = Convert.ToInt32(dgv_deduPerp.Rows[e.RowIndex].Cells["ID_Deduccion"].Value);
                    Txt_ClaveVin.Text = iidSeleccionado.ToString(); // Añadir esta línea


                   //Cbo_Empleado.SelectedItem = dgv_deduPerp.Rows[e.RowIndex].Cells["FechaInicio"].Value;
                   // Cbo_DeduccionPerpcepcion.SelectedItem = dgv_deduPerp.Rows[e.RowIndex].Cells["FechaFinal"].Value;


                    Btn_editar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar registro: " + ex.Message);
                }
            }
        }
    }
}
