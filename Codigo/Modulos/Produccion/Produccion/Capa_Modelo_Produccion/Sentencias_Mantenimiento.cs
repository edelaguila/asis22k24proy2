using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion
{
    public class Sentencias_Mantenimiento
    {
        private Conexion_Produccion conexion;

        public Sentencias_Mantenimiento()
        {
            conexion = new Conexion_Produccion();
        }

        // Método para insertar un nuevo registro de mantenimiento
        public void InsertarMantenimiento(
    string nombreMaquinaria,
    string tipoMaquina,
    decimal horaOperacion,
    string mantenimientoPeriodico,
    DateTime ultimaMantenimiento,
    DateTime proximoMantenimiento,
    string area,
    decimal desgastePorcentaje,
    int estado)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return;
                }

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"INSERT INTO tbl_mantenimientos 
                                (nombre_maquinaria, tipo_maquina, hora_operacion, mantenimiento_periodico, 
                                ultima_mantenimiento, proximo_mantenimiento, area, desgaste_porcentaje, estado) 
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("?", nombreMaquinaria);
                            cmd.Parameters.AddWithValue("?", tipoMaquina);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(horaOperacion)); // Convertir decimal a double
                            cmd.Parameters.AddWithValue("?", mantenimientoPeriodico);
                            cmd.Parameters.AddWithValue("?", ultimaMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", proximoMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", area);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(desgastePorcentaje));
                            cmd.Parameters.AddWithValue("?", estado);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine("Filas insertadas: " + rowsAffected);

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al guardar el mantenimiento: " + ex.Message);
                        Console.WriteLine("Stack Trace: " + ex.StackTrace);
                        throw;  // Relanzar la excepción para más depuración
                    }
                }
            }
        }




        // Método para actualizar un registro de mantenimiento existente
        public void ActualizarMantenimiento(
    int idMaquinaria,
    string nombreMaquinaria,
    string tipoMaquina,
    decimal horaOperacion,
    string mantenimientoPeriodico,
    DateTime ultimaMantenimiento,
    DateTime proximoMantenimiento,
    string area,
    decimal desgastePorcentaje,
    int estado)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return;
                }

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"UPDATE tbl_mantenimientos SET 
                                nombre_maquinaria = ?, 
                                tipo_maquina = ?, 
                                hora_operacion = ?, 
                                mantenimiento_periodico = ?, 
                                ultima_mantenimiento = ?, 
                                proximo_mantenimiento = ?, 
                                area = ?, 
                                desgaste_porcentaje = ?, 
                                estado = ? 
                                WHERE Pk_id_maquinaria = ?";

                        using (OdbcCommand cmd = new OdbcCommand(query, conn, transaction))
                        {
                            // Agrega los parámetros en el orden exacto en que aparecen en la consulta
                            cmd.Parameters.AddWithValue("?", nombreMaquinaria);
                            cmd.Parameters.AddWithValue("?", tipoMaquina);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(horaOperacion)); // Asegura que decimal sea compatible
                            cmd.Parameters.AddWithValue("?", mantenimientoPeriodico);
                            cmd.Parameters.AddWithValue("?", ultimaMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", proximoMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", area);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(desgastePorcentaje)); // Asegura que decimal sea compatible
                            cmd.Parameters.AddWithValue("?", estado);
                            cmd.Parameters.AddWithValue("?", idMaquinaria); // ID para la cláusula WHERE

                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine("Filas actualizadas: " + rowsAffected);
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al actualizar el mantenimiento: " + ex.Message);
                        Console.WriteLine("Stack Trace: " + ex.StackTrace);
                    }
                }
            }
        }


        // Método para eliminar un registro de mantenimiento por ID
        public void DesactivarMantenimiento(int idMaquinaria)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return;
                }

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"UPDATE tbl_mantenimientos SET estado = 0 WHERE Pk_id_maquinaria = ?";

                        using (OdbcCommand cmd = new OdbcCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("?", idMaquinaria); // Parámetro posicional

                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine("Filas actualizadas (desactivadas): " + rowsAffected); // Confirmación en consola

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al desactivar el mantenimiento: " + ex.Message);
                        Console.WriteLine("Stack Trace: " + ex.StackTrace);
                        throw; // Relanzamos para más análisis si se necesita
                    }
                }
            }
        }




        // Método para obtener todos los registros de mantenimiento
        public DataTable ObtenerMantenimientos()
        {
            DataTable tablaMantenimientos = new DataTable();

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return tablaMantenimientos;
                }

                try
                {
                    string query = "SELECT * FROM tbl_mantenimientos";

                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
                    {
                        adapter.Fill(tablaMantenimientos);
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener los mantenimientos: " + ex.Message);
                }
            }

            return tablaMantenimientos;
        }

        // Método para obtener el último ID de maquinaria
        public int ObtenerUltimoIdMaquinaria()
        {
            int ultimoId = 0;

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return ultimoId;
                }

                try
                {
                    string query = "SELECT MAX(Pk_id_maquinaria) FROM tbl_mantenimientos";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            ultimoId = Convert.ToInt32(resultado);
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener el último ID de maquinaria: " + ex.Message);
                }
            }

            return ultimoId;
        }
    }
}
