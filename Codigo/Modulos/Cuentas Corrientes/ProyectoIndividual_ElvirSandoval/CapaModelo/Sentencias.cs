using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class Sentencias
    {
        private string sTabla_transacciones = "tbl_transaccion_proveedor";
        private Conexion conexion = new Conexion();

        public OdbcDataAdapter DisplayTransaccion()
        {
            string sSql = $"SELECT * FROM {sTabla_transacciones};";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public void registrarTransaccion(string id_transaccion, string id_proveedor, string fecha_transaccion,
                                 string transaccion_tipo, string transaccion_monto,
                                 string transaccion_tipo_moneda,
                                 string transaccion_estado, string id_transC)
        {
            string sCampos = "Pk_id_transaccion, Fk_id_proveedor, fecha_transaccion, transaccion_tipo, " +
                             "transaccion_monto, transaccion_tipo_moneda, transaccion_estado, Fk_id_transC";

            string sSql = $"INSERT INTO {sTabla_transacciones} ({sCampos}) VALUES " +
                          $"('{id_transaccion}', '{id_proveedor}', '{fecha_transaccion}', '{transaccion_tipo}', " +
                          $"'{transaccion_monto}', '{transaccion_tipo_moneda}', " +
                          $"'{transaccion_estado}', '{id_transC}')";

            try
            {
                using (OdbcConnection conn = conexion.conexion()) // Usamos 'using' para manejar la conexión de forma automática
                using (OdbcCommand cmd = new OdbcCommand(sSql, conn))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transacción guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarTransaccion(string id_transaccion, string id_proveedor,
                                  string fecha_transaccion, string tipo,
                                  string monto, string moneda,
                                  string estado, string id_transC)
        {
            try
            {
                string sSql = $"UPDATE tbl_transaccion_proveedor SET " +
                              $"Fk_id_proveedor = '{id_proveedor}', " +
                              $"fecha_transaccion = '{fecha_transaccion}', transaccion_tipo = '{tipo}', " +
                              $"transaccion_monto = '{monto}', Fk_id_transC = '{id_transC}', " +
                              $"transaccion_tipo_moneda = '{moneda}', " +
                              $"transaccion_estado = '{estado}' " +
                              $"WHERE Pk_id_transaccion = '{id_transaccion}'";

                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo actualizar el registro.");
            }
        }

        public void eliminarTransaccion(string idTransaccion)
        {
            try
            {
                string sSql = "DELETE FROM tbl_transaccion_proveedor WHERE Pk_id_transaccion = ?;";
                using (OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion()))
                {
                    cmd.Parameters.AddWithValue("@id", idTransaccion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el registro: " + ex.Message);
            }
        }

        public OdbcDataAdapter buscarTransaccion(string campo, string valor)
        {
            string sSql = $"SELECT * FROM tbl_transaccion_proveedor WHERE {campo} = ?;";
            OdbcDataAdapter dataAdapter = null;

            try
            {
                OdbcConnection conn = conexion.conexion(); // Conexión abierta aquí

                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open(); // Aseguramos que esté abierta

                OdbcCommand cmd = new OdbcCommand(sSql, conn);
                cmd.Parameters.AddWithValue("@valor", valor);

                dataAdapter = new OdbcDataAdapter(cmd); // Inicializamos el DataAdapter correctamente
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la búsqueda: " + ex.Message);
            }

            return dataAdapter;
        }

        // -----------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}