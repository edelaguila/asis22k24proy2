using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Nominas
{
    public class Sentencias
    {
        Conexion cn = new Conexion(); //Conexion con base de datos

        /********0901-21-13093 - Brandon Alejandro Boch Lopez*********************/

        /*************************************************************************/


        /********0901-21-1278 - Gabriela Alejandra Suc Gomez**********************/

        /*************************************************************************/


        /********0901-21-4866 - Kateryn Johana De León Hernández******************/

        /*************************************************************************/


        /********0901-21-843 - Marco Alejandro Monroy Rousselin*******************/

        /*************************************************************************/


        /********0901-21-581 - Fernando José García de León***********************/

        public OdbcDataAdapter funcConsultaDeduPerp()
        {
            try
            {
                string sql = "SELECT pk_dedu_perp as ID, " +
                             "dedu_perp_clase as Clase, " +
                             "dedu_perp_concepto as Concepto, " +
                             "dedu_perp_tipo as Tipo, " +
                             "dedu_perp_aplicacion as Aplicacion, " +
                             "dedu_perp_excepcion as Excepcion, " +
                             "dedu_perp_monto as Monto, " +
                             "estado as Estado " +
                             "FROM tbl_dedu_perp " +
                             "WHERE estado = 1";
                return new OdbcDataAdapter(sql, cn.conexion());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaDeduPerp: " + ex.Message);
                return null;
            }
        }

        public void funcInsertarDeduPerp(string clase, string concepto, string tipo, string aplicacion, int excepcion, float monto)
        {
            OdbcConnection conn = null;
            try
            {
                string sql = "INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto, estado) " +
                             "VALUES (?, ?, ?, ?, ?, ?, 1)";

                conn = cn.conexion();
                // Verificar si la conexión ya está abierta
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    // Agregar parámetros en el orden en que aparecen en la consulta
                    cmd.Parameters.Add("clase", OdbcType.VarChar).Value = clase;
                    cmd.Parameters.Add("concepto", OdbcType.VarChar).Value = concepto;
                    cmd.Parameters.Add("tipo", OdbcType.VarChar).Value = tipo;
                    cmd.Parameters.Add("aplicacion", OdbcType.VarChar).Value = aplicacion;
                    cmd.Parameters.Add("excepcion", OdbcType.TinyInt).Value = excepcion;
                    cmd.Parameters.Add("monto", OdbcType.Real).Value = monto;

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas <= 0)
                    {
                        throw new Exception("No se pudo insertar el registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                string mensaje = "Error en funcInsertarDeduPerp: " + ex.Message;
                Console.WriteLine(mensaje);
                throw new Exception(mensaje);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void funcActualizarDeduPerp(int id, string clase, string concepto, string tipo, string aplicacion, int excepcion, float monto)
        {
            try
            {
                string sql = "UPDATE tbl_dedu_perp SET " +
                             "dedu_perp_clase = ?, " +
                             "dedu_perp_concepto = ?, " +
                             "dedu_perp_tipo = ?, " +
                             "dedu_perp_aplicacion = ?, " +
                             "dedu_perp_excepcion = ?, " +
                             "dedu_perp_monto = ? " +
                             "WHERE pk_dedu_perp = ?";
                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", clase);
                        cmd.Parameters.AddWithValue("?", concepto);
                        cmd.Parameters.AddWithValue("?", tipo);
                        cmd.Parameters.AddWithValue("?", aplicacion);
                        cmd.Parameters.AddWithValue("?", excepcion); // Ya viene como 1 o 0
                        cmd.Parameters.AddWithValue("?", monto);
                        cmd.Parameters.AddWithValue("?", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarDeduPerp: " + ex.Message);
            }
        }

        public void funcEliminarDeduPerp(int id)
        {
            try
            {
                string sql = "UPDATE tbl_dedu_perp SET estado = 0 WHERE pk_dedu_perp = ?";
                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarDeduPerp: " + ex.Message);
            }
        }

        /*************************************************************************/


        ///********0901-21-13093 - Brandon Alejandro Boch Lopez*********************/
        //// Método para llamar al SP calcular_anticipo
        //// Método para llamar al SP calcular_anticipo
        public void CalcularAnticipos(int empleadoId)
        {
            try
            {
                Console.WriteLine($"Ejecutando SP calcular_anticipo para empleado {empleadoId}...");

                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL calcular_anticipo(?)}", cn.conexion()))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_clave_empleado", empleadoId);

                    // Ejecutar el SP
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si el SP afectó alguna fila
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine($"SP calcular_anticipo ejecutado correctamente para empleado {empleadoId}, filas afectadas: " + filasAfectadas);
                    }
                    else
                    {
                        Console.WriteLine($"El SP calcular_anticipo se ejecutó, pero no afectó ninguna fila para empleado {empleadoId}.");
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al ejecutar SP calcular_anticipo para empleado {empleadoId}: {ex.Message}");
            }
        }


        ///*************************************************************************/


        ///********0901-21-1278 - Gabriela Alejandra Suc Gomez**********************/
        public void CalcularLiquidacion()
        {
            try
            {
                // Mostrar un mensaje de inicio de ejecución
                Console.WriteLine("Ejecutando SP Liquidaciones...");

                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL sp_insertar_liquidaciones}", cn.conectar()))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Ejecutar el SP
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si el SP afectó alguna fila
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("SP Liquidaciones. ejecutado correctamente, filas afectadas: " + filasAfectadas);
                    }
                    else
                    {
                        Console.WriteLine("El SP calcular_deduccion_faltas se ejecutó, pero no afectó ninguna fila.");
                    }
                }
            }
            catch (OdbcException ex)
            {
                // Capturar y mostrar el error en caso de que ocurra
                Console.WriteLine("Error al ejecutar el SP calcular_deduccion_faltas: " + ex.Message);
            }
        }

        ///*************************************************************************/


        ///********0901-21-4866 - Kateryn Johana De León Hernández******************/
        //// Método para llamar al SP Calcular_Horas_Extras
        //// Método para llamar al SP Calcular_Horas_Extras
        public void CalcularHorasExtras()
        {
            try
            {
                string mesActualTexto = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                Console.WriteLine(mesActualTexto); // Esto imprimirá el mes actual como texto

                using (OdbcCommand comando = new OdbcCommand("CALL Calcular_Horas_Extras_(?)", cn.conectar()))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@p_mes", OdbcType.VarChar).Value = mesActualTexto/*mesActualTexto.ToLower()*/; // Asegúrate de pasar el mes correcto en minúsculas

                    // Ejecuta el comando y verifica si se afectó alguna fila
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("El SP se ejecutó correctamente y afectó " + filasAfectadas + " filas.");
                    }
                    else
                    {
                        Console.WriteLine("El SP se ejecutó, pero no afectó ninguna fila.");
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al ejecutar el SP: " + ex.Message);
                MessageBox.Show("No se ejecutó el SP.");
            }
        }


        ///*************************************************************************/


        ///********0901-21-843 - Marco Alejandro Monroy Rousselin*******************/
        //// Método para llamar al SP calcular_deduccion_faltas
        public void CalcularDeduccionFaltas()
        {
            try
            {
                // Mostrar un mensaje de inicio de ejecución
                Console.WriteLine("Ejecutando SP calcular_deduccion_faltas...");

                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL calcular_deduccion_faltas}", cn.conectar()))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Ejecutar el SP
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si el SP afectó alguna fila
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("SP calcular_deduccion_faltas ejecutado correctamente, filas afectadas: " + filasAfectadas);
                    }
                    else
                    {
                        Console.WriteLine("El SP calcular_deduccion_faltas se ejecutó, pero no afectó ninguna fila.");
                    }
                }
            }
            catch (OdbcException ex)
            {
                // Capturar y mostrar el error en caso de que ocurra
                Console.WriteLine("Error al ejecutar el SP calcular_deduccion_faltas: " + ex.Message);
            }
        }

        ///*************************************************************************/


        ///********0901-21-581 - Fernando José García de León***********************/
        public void CalcularTotalDeduPer(String Clave, String Empleado, String Encabezado)
        {
            try
            {

                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL sp_calcular_planilla_detalle(?,?,?)}", cn.conectar()))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_pk_registro_planilla_Detalle", Clave);
                    comando.Parameters.AddWithValue("@p_fk_id_registro_planilla_Encabezado", Encabezado);
                    comando.Parameters.AddWithValue("@p_fk_clave_empleado", Empleado);


                    // Ejecutar el SP
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si el SP afectó alguna fila
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine($"SP calcular_anticipo ejecutado correctamente para empleado {Empleado}, filas afectadas: " + filasAfectadas);
                    }
                    else
                    {
                        Console.WriteLine($"El SP calcular_anticipo se ejecutó, pero no afectó ninguna fila para empleado {Empleado}.");
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al ejecutar SP calcular_anticipo para empleado {Empleado}: {ex.Message}");
            }
        }
        ///*************************************************************************/


        ///********0901-21-506 - Ismar Leonel Cortez Sanchez************************/

        public OdbcDataAdapter ObtenerIdsEmpleados()
        {
            string query = "SELECT pk_clave FROM tbl_empleados WHERE estado = 1";

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());
                return adapter; // Devuelve el OdbcDataAdapter con la consulta
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error en la consulta: " + ex.Message);
                return null;
            }

        }


        //// Método para obtener las deducciones calculadas
        public OdbcDataAdapter ObtenerPercepciones()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"
                SELECT 
                    emp.empleados_nombre AS empleados_nombre, 
                    emp.empleados_apellido AS empleados_apellido, 
                    ded.dedu_perp_concepto AS dedu_perp_concepto, 
                    ded.dedu_perp_tipo AS dedu_perp_tipo, 
                    dp.dedu_perp_emp_cantidad AS dedu_perp_emp_cantidad
                FROM 
                    tbl_dedu_perp_emp dp
                INNER JOIN 
                    tbl_empleados emp ON dp.Fk_clave_empleado = emp.pk_clave
                INNER JOIN 
                    tbl_dedu_perp ded ON dp.fk_dedu_perp = ded.pk_dedu_perp
                WHERE 
                    dp.estado = 1
                    AND ded.dedu_perp_clase = 'Percepcion';";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter ObtenerDeducciones()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"
                SELECT 
                    emp.empleados_nombre AS empleados_nombre, 
                    emp.empleados_apellido AS empleados_apellido, 
                    ded.dedu_perp_concepto AS dedu_perp_concepto, 
                    ded.dedu_perp_tipo AS dedu_perp_tipo, 
                    dp.dedu_perp_emp_cantidad AS dedu_perp_emp_cantidad
                FROM 
                    tbl_dedu_perp_emp dp
                INNER JOIN 
                    tbl_empleados emp ON dp.Fk_clave_empleado = emp.pk_clave
                INNER JOIN 
                    tbl_dedu_perp ded ON dp.fk_dedu_perp = ded.pk_dedu_perp
                WHERE 
                    dp.estado = 1
                    AND ded.dedu_perp_clase = 'Deduccion';";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }



        public OdbcDataAdapter ObtenerEncabezado()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"select* from tbl_planilla_Encabezado;";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter ObtenerDetalle()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"select* from tbl_planilla_Detalle;";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }


        public void CalcularTotalMes(String idEncabezado)
        {
            try
            {

                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL sp_sumar_percepciones_a_encabezado(?)}", cn.conectar()))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_fk_id_registro_planilla_Encabezado", idEncabezado);


                    // Ejecutar el SP
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si el SP afectó alguna fila
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine($"SP calcular_anticipo ejecutado correctamente para empleado {idEncabezado}, filas afectadas: " + filasAfectadas);
                    }
                    else
                    {
                        Console.WriteLine($"El SP calcular_anticipo se ejecutó, pero no afectó ninguna fila para empleado {idEncabezado}.");
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al ejecutar SP calcular_anticipo para empleado {idEncabezado}: {ex.Message}");
            }
        }


        ///*************************************************************************/
        /*************************************************************************/




    }





}








