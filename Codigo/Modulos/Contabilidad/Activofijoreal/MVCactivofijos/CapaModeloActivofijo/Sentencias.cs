using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloActivofijo
{
    public class Sentencias
    {
        Conexion conectar = new Conexion();

        public OdbcDataAdapter llenarTablaActivoFijo(string tabla)
        {
            // Construye la consulta SQL para obtener los datos de la tabla tbl_activofijo
            string sql = "SELECT af.Pk_id_idactivofijo AS ID_Activo, " +
              "af.Codigo_Activo AS Codigo_Activo, " +
              "af.Pk_id_tipoactivofijo AS ID_Tipo_Activo, " +
              "af.Descripcion AS Descripcion, " +
              "af.Pk_id_marca AS ID_Marca, " +
              "af.Modelo AS Modelo, " +
              "af.Fecha_Adquisicion AS Fecha_de_Aquisicion, " +
              "af.Costo_Adquisicion AS Costo_de_Aquisicion, " +
              "af.Vida_Util AS Vida_Util, " +
              "af.Valor_Residual AS Valor_Residual, " +
              "af.Estado AS Estado, " +
              "af.Pk_id_cuenta AS ID_Cuenta " +
              "FROM " + tabla + " af";

            // Crea un objeto OdbcDataAdapter y le pasa la consulta SQL y la conexión
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conectar.conectar());

            // Retorna el objeto OdbcDataAdapter con los datos obtenidos
            return dataTable;
        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, conectar.conectar());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }

        public List<string> llenarCombo(string columna1, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna1} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, conectar.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader[columna1].ToString();
                    datos.Add(ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;

        }

        public void InsertarDepreciacionActivo(DateTime fechaDepreciacion, int idActivoFijo, string nombreActivo, string tipoActivo, string encargado, string departamento, double depreciacion, double depreciacionFiscal, string descripcion, string estado, int idCuenta)
        {
            using (OdbcConnection connection = conectar.conectar())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insertar en la tabla tbl_depreciacion_activofijo
                            string insertQuery = "INSERT INTO tbl_depreciacion_activofijo (Pk_id_idactivofijo, Nombre_Activo, Tipo_Activo, " +
                                                 "Encargado, Departamento, Fecha_Depreciacion, Depreciacion, Depreciacion_Fiscal, " +
                                                 "Descripcion, Estado, Pk_id_cuenta) " +
                                                 "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Pk_id_idactivofijo", idActivoFijo);
                                cmd.Parameters.AddWithValue("@Nombre_Activo", nombreActivo);
                                cmd.Parameters.AddWithValue("@Tipo_Activo", tipoActivo);
                                cmd.Parameters.AddWithValue("@Encargado", encargado);
                                cmd.Parameters.AddWithValue("@Departamento", departamento);
                                cmd.Parameters.AddWithValue("@Fecha_Depreciacion", fechaDepreciacion);
                                cmd.Parameters.AddWithValue("@Depreciacion", depreciacion);
                                cmd.Parameters.AddWithValue("@Depreciacion_Fiscal", depreciacionFiscal);
                                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                                cmd.Parameters.AddWithValue("@Estado", estado);
                                cmd.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);

                                cmd.ExecuteNonQuery();
                            }

                            // Confirmar la transacción si la inserción fue exitosa
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Revertir la transacción si ocurre algún error
                            transaction.Rollback();
                            Console.WriteLine($"Error al insertar depreciación de activo fijo: {ex.Message}");
                            MessageBox.Show("Error al guardar datos en la tabla de depreciación.");
                        }
                    }
                }
            }
        }

        public DataTable BuscarConEstado(string tabla, string columna, string dato, string estado)
        {
            // Crear la consulta con parámetros
            string query = $"SELECT * FROM {tabla} WHERE {columna} = ? AND Estado = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
                // Crear el comando y agregar los parámetros
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dato", dato);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    // Usar OdbcDataAdapter para llenar el DataTable
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerRegistrosConEstado(string tabla, string columna, string estado)
        {
            DataTable dt = new DataTable();

            // Crear la consulta con parámetros
            string query = $"SELECT {columna} FROM {tabla} WHERE Estado = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
                // Crear el comando y agregar el parámetro
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);

                    // Usar OdbcDataAdapter para llenar el DataTable
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }


        public void ActualizarEstadoActivoFijo(int idActivoFijo, string estado)
        {
            // Crear la consulta con parámetros
            string query = "UPDATE tbl_activofijo SET Estado = ? WHERE Pk_id_idactivofijo = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
                // Crear el comando y agregar los parámetros
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    // Agregar parámetros en el orden correcto
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@idActivoFijo", idActivoFijo);

                    // Abrir la conexión


                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                } // El using cerrará automáticamente el OdbcCommand
            } // El using cerrará automáticamente la OdbcConnection
        }

        public DataTable ObtenerRegistrosDepreciacion(int idActivoFijo)
        {
            DataTable dt = new DataTable();

            // Crear la consulta con parámetros
            string query = "SELECT * FROM tbl_depreciacion_activofijo WHERE Pk_id_idactivofijo = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
                // Abrir la conexión


                // Crear el comando y agregar el parámetro
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    // Usar el símbolo correcto para el parámetro de ODBC (no es necesario especificar nombre)
                    cmd.Parameters.AddWithValue("?", idActivoFijo);

                    // Usar OdbcDataAdapter para llenar el DataTable
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt; // Devolver solo los registros para el idActivoFijo especificado
        }

        public DataTable CargarReporte(int idActivoFijo)
        {
            // Obtener los registros de depreciación para el activo fijo especificado
            DataTable dtReporte = ObtenerRegistrosDepreciacion(idActivoFijo);

            return dtReporte; 
        }

    }
    }
    

