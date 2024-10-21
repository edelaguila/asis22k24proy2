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

        public OdbcDataAdapter queryCliente(string sQuery)
        {
            string sql = "SELECT id_cliente, id_vendedor, nombre_cliente, telefono_cliente, direccion_cliente, saldo_actual_cliente, estadio_cliente FROM " + sTabla_Clientes + " WHERE ruta LIKE '%" + sQuery + "%' OR nombre_archivo LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
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

        public void registrarTransaccion(string Pk_id_transaccion, string Fk_id_clientes, string Fk_id_pais, string fecha_transaccion,
            string cuenta_transaccion, string cuotas_transaccion, string Fk_id_deuda, string monto_deuda, string monto_transaccion,
            string saldo_pendiente, string Fk_id_pago, string tipo_moneda, string serie_transaccion, string estado_transaccion)
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
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //************************************************************************************************************************************************************************************************************

        //CLIENTES 

        string sTabla_Clientes = "Tbl_clientes";

        public OdbcDataAdapter DisplayClientes()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT PK_id_cliente, Fk_id_vendedor, nombre_cliente, Telefono_cliente, direccion_cliente, saldo_cuenta, estado_cliente FROM " + sTabla_Clientes;
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Clientes);
            }
            return dataTable;
        }//end displayclientes

        public void registrarCliente(string Pk_id_cliente, string Fk_id_vendedor, string nombre_cliente, string telefono_cliente,
            string direccion_cliente, string saldo_cuenta, string estado_cliente)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "PK_id_cliente, Fk_id_vendedor, nombre_cliente, telefono_cliente, direccion_cliente, saldo_cuenta, estado_cliente";
                string sSql = "INSERT INTO " + sTabla_Clientes + " (" + sCampos + ") VALUES ('" + Pk_id_cliente + "', '" + Fk_id_vendedor + "', '"
                    + nombre_cliente + "', '" + telefono_cliente + "', '" + direccion_cliente + "', '" + saldo_cuenta + "', '" + estado_cliente + "'"+ "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_transaccion);
            }
        }//end registrar cliente


        //ELIMINAR 

        public void eliminarClientes(string sId_cliente)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + sTabla_Clientes + " where idcliente = " + sId_cliente + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_cliente + " en la tabla " + sTabla_Clientes);
            }
        }//end eliminar 

        //MODIFICAR
        /*public void ModificarClientes(string sRuta, string sNombre_archivo, string sAplicacion, string sEstado, string sId_reporte, string sModulo)
        {
            //aqui estamos haciendo la comprobación de que si tuvo una conexión con la base de datos
            try
            {
                //aqui con los datos recibidos le mandamos la instruccion a la base de datos, para poderlo modificar lo buscamos por id
                string sql = "UPDATE " + sTabla_Clientes + " SET " + "ruta = '" + sRuta + "'," + " nombre_archivo = '" + sNombre_archivo + "'," + " aplicacion = '" + sAplicacion + "'," + " estado = '" + sEstado + "'," + " fk_id_aplicacion = '" + sAplicacion + "'," + " fk_id_modulos = '" + sModulo + "' " + " WHERE (idregistro = '" + sId_reporte + "');";
                OdbcCommand consulta = new OdbcCommand(sql, conexion.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Modificado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en CapaModeloReporteria --> Sentencias" + e);
            }
        }//end modificar 
        */

        //BUSCAR 
       /* public OdbcDataAdapter queryCliente(string sQuery)
        {
            string sql = "SELECT Pk_id_cliente, id_vendedor, nombre_cliente, telefono_cliente, direccione_cliente , estatus_pais FROM " + sTabla_Clientes + " WHERE nombre_pais LIKE '%" + sQuery + "%' OR nombre_pais LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }*/


    }//end sentencia 
          
}


       
