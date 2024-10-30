using Capa_Modelo_Nominas;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo_Planilla
{
    public class Sentencias
    {
        private readonly Conexion cn = new Conexion();

        public OdbcDataAdapter funObtenerEncabezado()
        {
            // Consulta SQL solo con los campos de tbl_planilla_Encabezado
            string query = @"
        SELECT 
            pk_registro_planilla_Encabezado AS ClaveEncabezado,
            encabezado_correlativo_planilla AS Correlativo,
            encabezado_fecha_inicio AS FechaInicio,
            encabezado_fecha_final AS FechaFinal,
            encabezado_total_mes AS TotalMes,
            estado AS Estado
        FROM 
            tbl_planilla_Encabezado
        WHERE 
            estado = 1;";

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener el encabezado: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter funObtenerDetalle()
        {
            // Consulta detallada para obtener los detalles de planilla y otras tablas relacionadas
            string query = @"
                SELECT 
                    pd.pk_registro_planilla_Detalle AS DetalleID,
                    pd.detalle_total_Percepciones AS TotalPercepciones,
                    pd.detalle_total_Deducciones AS TotalDeducciones,
                    pd.detalle_total_liquido AS TotalLiquido,
                    pd.fk_id_registro_planilla_Encabezado AS EncabezadoID, -- Aquí se agrega el ID del encabezado
                    e.empleados_nombre AS NombreEmpleado,
                    e.empleados_apellido AS ApellidoEmpleado,
                    pt.puestos_nombre_puesto AS PuestoEmpleado,
                    d.departamentos_nombre_departamento AS DepartamentoEmpleado,
                    pd.estado AS Estado
                FROM 
                    tbl_planilla_Detalle AS pd
                INNER JOIN 
                    tbl_empleados AS e ON pd.fk_clave_empleado = e.pk_clave
                INNER JOIN 
                    tbl_puestos_trabajo AS pt ON e.fk_id_puestos = pt.pk_id_puestos
                INNER JOIN 
                    tbl_departamentos AS d ON e.fk_id_departamento = d.pk_id_departamento
                WHERE 
                    pd.estado = 1;
                ";

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener el detalle: " + ex.Message);
                return null;
            }
        }


        public bool funCalcularPlanillaDetalle(int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            using (var connection = cn.conexion())
            {
                try
                {
                    decimal desalarioBase = funObtenerSalarioBase(connection, ifkClaveEmpleado, out int icontratoId);
                    decimal detotalPercepciones = funObtenerTotalPercepciones(connection, ifkClaveEmpleado);
                    decimal detotalDeducciones = funObtenerTotalDeducciones(connection, ifkClaveEmpleado);

                    decimal detotalLiquido = desalarioBase + detotalPercepciones - detotalDeducciones;

                    funInsertarDetallePlanilla(connection,detotalPercepciones, detotalDeducciones, detotalLiquido, ifkClaveEmpleado, icontratoId, ifkIdRegistroPlanillaEncabezado);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error en el cálculo de la planilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    cn.desconexion(connection);
                }
            }
        }

        private decimal funObtenerSalarioBase(OdbcConnection connection, int ifkClaveEmpleado, out int icontratoId)
        {
            icontratoId = 0;
            decimal desalarioBase = 0;

            string query = @"
        SELECT pk_id_contrato, contratos_salario 
        FROM tbl_contratos 
        WHERE fk_clave_empleado = ? 
        ORDER BY contratos_fecha_creacion DESC 
        LIMIT 1";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        icontratoId = reader.GetInt32(0);
                        desalarioBase = reader.GetDecimal(1);
                    }
                    else
                    {
                        throw new Exception("No se encontró un contrato para este empleado.");
                    }
                }
            }

            return desalarioBase;
        }

        private decimal funObtenerTotalPercepciones(OdbcConnection connection, int ifkClaveEmpleado)
        {
            string query = @"
        SELECT SUM(dpe.dedu_perp_emp_cantidad)
        FROM tbl_dedu_perp_emp dpe
        INNER JOIN tbl_dedu_perp dp ON dpe.Fk_dedu_perp = dp.pk_dedu_perp
        WHERE dpe.Fk_clave_empleado = ? AND dp.dedu_perp_clase = 'Percepcion' AND dpe.estado = 1";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);

                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    throw new Exception("El empleado no tiene percepciones registradas.");
                }

                return Convert.ToDecimal(result);
            }
        }

        private decimal funObtenerTotalDeducciones(OdbcConnection connection, int ifkClaveEmpleado)
        {
            string query = @"
        SELECT SUM(dpe.dedu_perp_emp_cantidad)
        FROM tbl_dedu_perp_emp dpe
        INNER JOIN tbl_dedu_perp dp ON dpe.Fk_dedu_perp = dp.pk_dedu_perp
        WHERE dpe.Fk_clave_empleado = ? AND dp.dedu_perp_clase = 'Deduccion' AND dpe.estado = 1";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);

                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    throw new Exception("El empleado no tiene deducciones registradas.");
                }

                return Convert.ToDecimal(result);
            }
        }

        private void funInsertarDetallePlanilla(OdbcConnection connection,decimal detotalPercepciones, decimal detotalDeducciones, decimal detotalLiquido, int ifkClaveEmpleado, int icontratoId, int ifkIdRegistroPlanillaEncabezado)
        {
            string query = @"
                INSERT INTO tbl_planilla_Detalle 
                (detalle_total_Percepciones, detalle_total_Deducciones, detalle_total_liquido, fk_clave_empleado, fk_id_contrato, fk_id_registro_planilla_Encabezado, estado)
                VALUES (?, ?, ?, ?, ?, ?, 1)";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                //cmd.Parameters.AddWithValue("@pk_registro_planilla_Detalle", ipkRegistroPlanillaDetalle);
                cmd.Parameters.AddWithValue("@detalle_total_Percepciones", detotalPercepciones);
                cmd.Parameters.AddWithValue("@detalle_total_Deducciones", detotalDeducciones);
                cmd.Parameters.AddWithValue("@detalle_total_liquido", detotalLiquido);
                cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);
                cmd.Parameters.AddWithValue("@fk_id_contrato", icontratoId);
                cmd.Parameters.AddWithValue("@fk_id_registro_planilla_Encabezado", ifkIdRegistroPlanillaEncabezado);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable funobtener2(string sTabla, string sCampo1, string sCampo2)
        {
            Conexion cn = new Conexion();
            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }


        public bool funInsertarPlanillaEncabezado(int icorrelativoPlanilla, DateTime dfechaInicio, DateTime dfechaFinal, decimal detotalMes)
        {
            string query = "INSERT INTO tbl_planilla_Encabezado (encabezado_correlativo_planilla, encabezado_fecha_inicio, encabezado_fecha_final, encabezado_total_mes, estado) " +
                           "VALUES (?, ?, ?, ?, 1)";
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    // Si la conexión ya está abierta, la cerramos primero
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Open(); // Abrimos la conexión después de asegurarnos de que esté cerrada

                    using (OdbcCommand command = new OdbcCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@correlativoPlanilla", icorrelativoPlanilla);
                        command.Parameters.AddWithValue("@fechaInicio", dfechaInicio);
                        command.Parameters.AddWithValue("@fechaFinal", dfechaFinal);
                        command.Parameters.AddWithValue("@totalMes", detotalMes);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al insertar planilla encabezado: " + ex.Message);
                return false;
            }
        }


        public void funcActualizarEncabezado(int iidSeleccionado, int icorrelativo, DateTime dfechaInicio, DateTime dfechaFinal)
        {
            try
            {
                string sql = "UPDATE tbl_planilla_Encabezado SET " +
                             "encabezado_correlativo_planilla = ?, " +
                             "encabezado_fecha_inicio = ?, " +
                             "encabezado_fecha_final = ? " + // Elimina la coma aquí
                             "WHERE pk_registro_planilla_Encabezado = ?";

                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", icorrelativo);
                        cmd.Parameters.AddWithValue("?", dfechaInicio);
                        cmd.Parameters.AddWithValue("?", dfechaFinal);
                        cmd.Parameters.AddWithValue("?", iidSeleccionado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error enfuncActualizarEncabezado: " + ex.Message);
            }
        }

        public void funcEliminarEncabezado(int iidSeleccionado)
        {
            try
            {
                string sql = "UPDATE tbl_planilla_Encabezado SET estado = 0 WHERE pk_registro_planilla_Encabezado = ?";
                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iidSeleccionado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarDeduPerp: " + ex.Message);
            }
        }

        public void funcActualizarDetalle(int iidSeleccionado2, int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            try
            {
                string sql = "UPDATE tbl_planilla_Detalle SET " +
                             "fk_clave_empleado = ?, " +
                             "fk_id_registro_planilla_Encabezado = ? " + 
                             "WHERE pk_registro_planilla_Detalle = ?";

                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ifkClaveEmpleado);
                        cmd.Parameters.AddWithValue("?", ifkIdRegistroPlanillaEncabezado);
                        cmd.Parameters.AddWithValue("?", iidSeleccionado2);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarDetalle: " + ex.Message);
            }
        }

        public void funcEliminarDetalle(int iidSeleccionado2)
        {
            try
            {
                string sql = "UPDATE tbl_planilla_Detalle SET estado = 0 WHERE pk_registro_planilla_Detalle = ?";
                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iidSeleccionado2);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarDetall: " + ex.Message);
            }
        }



        public bool funCalcularPlanillaDetalleSimulado(int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            try
            {
                // Simulación de obtener valores de salario base, percepciones y deducciones
                decimal desalarioBase = funObtenerSalarioBaseSimulado(ifkClaveEmpleado, out int icontratoId);
                decimal detotalPercepciones = funObtenerTotalPercepcionesSimulado(ifkClaveEmpleado);
                decimal detotalDeducciones = funObtenerTotalDeduccionesSimulado(ifkClaveEmpleado);

                // Calculo del total líquido
                decimal detotalLiquido = desalarioBase + detotalPercepciones - detotalDeducciones;

                // Simulación de la inserción del detalle de la planilla
                funInsertarDetallePlanillaSimulado(detotalPercepciones, detotalDeducciones, detotalLiquido, ifkClaveEmpleado, icontratoId, ifkIdRegistroPlanillaEncabezado);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        private decimal funObtenerSalarioBaseSimulado(int ifkClaveEmpleado, out int icontratoId)
        {
            // Valores simulados para el salario base y el ID del contrato
            icontratoId = 1; // Simulamos que el contrato ID es 1
            decimal desalarioBase = 1000.00m; // Salario base simulado
            Console.WriteLine($"Salario base simulado: {desalarioBase} para empleado {ifkClaveEmpleado} con contrato ID {icontratoId}");
            return desalarioBase;
        }

        private decimal funObtenerTotalPercepcionesSimulado(int ifkClaveEmpleado)
        {
            // Valor simulado para el total de percepciones
            decimal detotalPercepciones = 500.00m; // Percepciones simuladas
            Console.WriteLine($"Total percepciones simulado: {detotalPercepciones} para empleado {ifkClaveEmpleado}");
            return detotalPercepciones;
        }

        private decimal funObtenerTotalDeduccionesSimulado(int ifkClaveEmpleado)
        {
            // Valor simulado para el total de deducciones
            decimal detotalDeducciones = 200.00m; // Deducciones simuladas
            Console.WriteLine($"Total deducciones simulado: {detotalDeducciones} para empleado {ifkClaveEmpleado}");
            return detotalDeducciones;
        }

        private void funInsertarDetallePlanillaSimulado(decimal detotalPercepciones, decimal detotalDeducciones, decimal detotalLiquido,
                                                        int ifkClaveEmpleado, int icontratoId, int ifkIdRegistroPlanillaEncabezado)
        {
            // Simulación de la inserción del detalle de la planilla
            Console.WriteLine("Insertando detalle de planilla simulado:");
            Console.WriteLine($"Percepciones: {detotalPercepciones}, Deducciones: {detotalDeducciones}, Total Líquido: {detotalLiquido}");
            Console.WriteLine($"Empleado ID: {ifkClaveEmpleado}, Contrato ID: {icontratoId}, Encabezado ID: {ifkIdRegistroPlanillaEncabezado}");
        }





    }
}
