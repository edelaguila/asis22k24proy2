using Capa_Controlador_Cuentas_Corrientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class ProveedorNuevo : Form
    {
        public ProveedorNuevo()
        {
            InitializeComponent();
        }

        private void ProveedorNuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tbl_proveedores' Puede moverla o quitarla según sea necesario.
            this.tbl_proveedoresTableAdapter.Fill(this.dataSet1.tbl_proveedores);

        }

        private void Txt_id_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string idProveedor = Txt_id_cliente.Text;
                string fechaRegistro = Txt_fecha.Text;  // Asegúrate de validar el formato
                string nombre = Txt_nombre.Text;
                string direccion = Txt_direccion.Text;
                string telefono = Txt_telefono.Text;
                string email = Txt_email.Text;
                decimal saldoCuenta = decimal.Parse(Txt_saldo.Text);
                string estadoProveedor = Cbo_estado.SelectedItem.ToString();

                // Llamar al controlador para guardar el proveedor
                Controlador controlador = new Controlador();
                controlador.GuardarProveedor(idProveedor, fechaRegistro, nombre, direccion, telefono, email, saldoCuenta, estadoProveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarDataGrid()
        {
            Controlador controlador = new Controlador();
            Dgv_proveedor_nuevo.DataSource = controlador.MostrarTransacciones(); // O el método que carga los proveedores
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_proveedor_nuevo.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
                {
                    // Obtiene el valor de la primera columna, asumiendo que es el ID del proveedor
                    string idProveedor = Dgv_proveedor_nuevo.SelectedRows[0].Cells["Pk_id_proveedor"].Value.ToString();

                    // Llamamos al controlador para eliminar el registro
                    Controlador controlador = new Controlador();
                    controlador.EliminarProveedor(idProveedor);

                    // Actualizamos el DataGridView para reflejar los cambios
                    MessageBox.Show("Registro eliminado correctamente.");
                    ActualizarDataGrid();  // Método para recargar los datos del DataGridView
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
