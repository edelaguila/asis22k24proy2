using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador
{
    public class Controlador
    {
        CapaModelo.Sentencias sentencias = new CapaModelo.Sentencias();

        // Variables para manejar modo edición
        public bool esEdicion = false;
        public string idTransaccionSeleccionada;

        // Método para guardar o actualizar una transacción
        public int GuardarTransaccion(TextBox idTransaccion, TextBox idProveedor, TextBox idPais,
                              string sfecha_transaccion, string stipo_transaccion,
                              string sMonto, string sMoneda,
                              string sEstado, TextBox idCuenta)
        {
            if (string.IsNullOrEmpty(idProveedor.Text) || string.IsNullOrEmpty(idPais.Text) ||
                string.IsNullOrEmpty(sfecha_transaccion) || string.IsNullOrEmpty(stipo_transaccion) ||
                string.IsNullOrEmpty(sMonto) || string.IsNullOrEmpty(sMoneda) ||
                string.IsNullOrEmpty(sEstado) || string.IsNullOrEmpty(idCuenta.Text))
            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                try
                {
                    if (esEdicion)
                    {
                        // Actualizar transacción existente
                        sentencias.ActualizarTransaccion(idTransaccionSeleccionada, idProveedor.Text, idPais.Text,
                                                         sfecha_transaccion, stipo_transaccion, sMonto, sMoneda, sEstado, idCuenta.Text);
                        MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        esEdicion = false; // Resetear modo edición
                    }
                    else
                    {
                        // Guardar nueva transacción
                        sentencias.registrarTransaccion(idTransaccion.Text, idProveedor.Text, idPais.Text,
                                                        sfecha_transaccion, stipo_transaccion, sMonto, sMoneda, sEstado, idCuenta.Text);
                        MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar o actualizar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }


        public void eliminarTransaccion(string idTransaccion)
        {
            if (!string.IsNullOrEmpty(idTransaccion))
            {
                sentencias.eliminarTransaccion(idTransaccion);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro. El ID es nulo o vacío.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public OdbcDataAdapter buscarTransaccionPorCampo(string campo, string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                return sentencias.buscarTransaccion(campo, valor);
            }
            else
            {
                MessageBox.Show("El campo de búsqueda está vacío.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        // Método para mostrar datos en el DataGridView
        public OdbcDataAdapter DisplayTransaccion()
        {
            return sentencias.DisplayTransaccion();
        }
        // -----------------------------------------------------------------------------------------------------------------------------------
    }
}