using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Modelo_Cuentas_Corrientes
{
    public class Sentencias
    {
       string sTabla_transaccion = "Tbl_Transaccion_cliente";
        Conexion conexion = new Conexion();
        public OdbcDataAdapter DisplayTransacciones()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT PK_id_transaccion, Fk_id_clientes, Fk_id_pais, fecha_transaccion, cuenta_transaccion, cuotas_transaccion, Fk_id_deuda" +
                "monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion FROM " 
                + sTabla_transaccion + " WHERE Pk_id_transaccion IS NOT NULL AND Pk_id_transaccion != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }
            return dataTable;
        }

        public int getMaxIdTransaccion()
        {
            int iPk_id_transaccion = 0;
            string sSql = "SELECT max(Pk_id_transaccion) FROM " + sTabla_transaccion + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_transaccion = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_transaccion);
            }
            return iPk_id_transaccion;
        }

        public List<string> getDeudas()
        {
            string sQuery = "SELECT Pk_id_deuda, estado_deuda FROM Tbl_Deudas_Clientes;";
            List<string> deudasCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_deuda"].ToString().Equals("1"))
                    {
                        string sCodigoDeuda = row["Pk_id_deuda"].ToString();
                        deudasCodes.Add(sCodigoDeuda);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return deudasCodes;
        }
        public List<string> getPagos()
        {
            string sQuery = "SELECT Pk_id_pago, estado_pago FROM Tbl_tipodepago;";
            List<string> pagosCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_pago"].ToString().Equals("1"))
                    {
                        string sCodigoPago = row["Pk_id_pago"].ToString();
                        pagosCodes.Add(sCodigoPago);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return pagosCodes;
        }

        public List<string> getClientes()
        {
            string sQuery = "SELECT Pk_id_cliente, estado_cliente FROM Tbl_clientes;";
            List<string> clientesCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_cliente"].ToString().Equals("1"))
                    {
                        string sCodigoCliente = row["Pk_id_cliente"].ToString();
                        clientesCodes.Add(sCodigoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return clientesCodes;
        }

        public List<string> getPais()
        {
            string sQuery = "SELECT Pk_id_pais, estatus_pais FROM Tbl_paises;";
            List<string> paisCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estatus_pais"].ToString().Equals("1"))
                    {
                        string sCodigoPais = row["Pk_id_pais"].ToString();
                        paisCodes.Add(sCodigoPais);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return paisCodes;
        }

        public void registrarTransaccion (string Pk_id_transaccion, string Fk_id_clientes, string Fk_id_pais, string fecha_transaccion, 
            string cuenta_transaccion, string cuotas_transaccion, string Fk_id_deuda, string monto_deuda, string monto_transaccion, 
            string saldo_pendiente, string Fk_id_pago, string tipo_moneda, string serie_transaccion, string estado_transaccion )
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "PK_id_transaccion, Fk_id_clientes, Fk_id_pais, fecha_transaccion, cuenta_transaccion, cuotas_transaccion, Fk_id_deuda" +
                "monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion";
                string sSql = "INSERT INTO " + sTabla_transaccion + " (" + sCampos + ") VALUES ('" + Pk_id_transaccion + "', '" + Fk_id_clientes + "', '" 
                    + Fk_id_pais + "', '" + fecha_transaccion + "', '" + cuenta_transaccion + "', '" + cuotas_transaccion + "', '" + Fk_id_deuda + "'" +
                    ", '" + monto_deuda + "', '" + monto_transaccion + "', '" + saldo_pendiente + "', '" + Fk_id_pago + "', '" + tipo_moneda + "', '" + serie_transaccion + "', '" + estado_transaccion + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_transaccion);
            }
        }
        public void InsertarProveedor(string idProveedor, string fechaRegistro, string nombre, string direccion,
                              string telefono, string email, decimal saldoCuenta, string estadoProveedor)
        {
            try
            {
                string sSql = "INSERT INTO tbl_proveedores (Pk_id_proveedor, fecha_registro, nombre_proveedor, direccion, telefono, email, saldo_cuenta, estado_proveedor) " +
                              "VALUES (?, ?, ?, ?, ?, ?, ?, ?);";

                using (OdbcConnection con = conexion.conexion())
                {
                    con.Open();  // Asegúrate de abrir la conexión
                    using (OdbcCommand cmd = new OdbcCommand(sSql, con))
                    {
                        // Asignar valores a los parámetros
                        cmd.Parameters.AddWithValue("@Pk_id_proveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@fecha_registro", fechaRegistro);
                        cmd.Parameters.AddWithValue("@nombre_proveedor", nombre);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@saldo_cuenta", saldoCuenta);
                        cmd.Parameters.AddWithValue("@estado_proveedor", estadoProveedor);

                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();

                        // Forzar commit manual
                        OdbcCommand commitCmd = new OdbcCommand("COMMIT;", con);
                        commitCmd.ExecuteNonQuery();

                        Console.WriteLine("Proveedor registrado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar proveedor: " + ex.Message);
            }
        }

        public void EliminarProveedor(string idProveedor)
        {
            try
            {
                string sSql = "DELETE FROM tbl_proveedores WHERE Pk_id_proveedor = ?;";

                using (OdbcConnection con = conexion.conexion())
                {
                    con.Open();
                    using (OdbcCommand cmd = new OdbcCommand(sSql, con))
                    {
                        cmd.Parameters.AddWithValue("@Pk_id_proveedor", idProveedor);
                        cmd.ExecuteNonQuery();

                        // Confirmación en consola
                        Console.WriteLine("Proveedor con ID " + idProveedor + " eliminado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el proveedor: " + ex.Message);
            }
        }

    }
}
