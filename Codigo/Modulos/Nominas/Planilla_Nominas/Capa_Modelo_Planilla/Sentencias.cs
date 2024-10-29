using Capa_Modelo_Nominas;
using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Planilla
{
    public class Sentencias
    {
        private readonly Conexion cn = new Conexion();

        public OdbcDataAdapter ObtenerEncabezado()
        {
            // Consulta SQL solo con los campos de tbl_planilla_Encabezado
            string query = @"
        SELECT 
            pk_registro_planilla_Encabezado AS EncabezadoID,
            encabezado_correlativo_planilla AS CorrelativoPlanilla,
            encabezado_fecha_inicio AS FechaInicio,
            encabezado_fecha_final AS FechaFinal,
            encabezado_total_mes AS TotalMes
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

        public OdbcDataAdapter ObtenerDetalle()
        {
            // Consulta detallada para obtener los detalles de planilla y otras tablas relacionadas
            string query = @"
        SELECT 
            pd.pk_registro_planilla_Detalle AS DetalleID,
            pd.detalle_total_Percepciones AS TotalPercepciones,
            pd.detalle_total_Deducciones AS TotalDeducciones,
            pd.detalle_total_liquido AS TotalLiquido,
            e.empleados_nombre AS NombreEmpleado,
            e.empleados_apellido AS ApellidoEmpleado,
            pt.puestos_nombre_puesto AS PuestoEmpleado,
            d.departamentos_nombre_departamento AS DepartamentoEmpleado
        FROM 
            tbl_planilla_Detalle AS pd
        INNER JOIN 
            tbl_empleados AS e ON pd.fk_clave_empleado = e.pk_clave
        INNER JOIN 
            tbl_puestos_trabajo AS pt ON e.fk_id_puestos = pt.pk_id_puestos
        INNER JOIN 
            tbl_departamentos AS d ON e.fk_id_departamento = d.pk_id_departamento
        WHERE 
            pd.estado = 1;";

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



        public bool CalcularPlanillaDetalle(int pkRegistroPlanillaDetalle, int fkIdRegistroPlanillaEncabezado, int fkClaveEmpleado)
        {
            using (var connection = cn.conexion())
            {
                try
                {
                    decimal salarioBase = ObtenerSalarioBase(connection, fkClaveEmpleado, out int contratoId);

                    if (contratoId != 0)
                    {
                        decimal totalPercepciones = ObtenerTotalPercepciones(connection, fkClaveEmpleado);
                        decimal totalDeducciones = ObtenerTotalDeducciones(connection, fkClaveEmpleado);

                        decimal totalLiquido = salarioBase + totalPercepciones - totalDeducciones;

                        InsertarDetallePlanilla(connection, pkRegistroPlanillaDetalle, totalPercepciones, totalDeducciones, totalLiquido, fkClaveEmpleado, contratoId, fkIdRegistroPlanillaEncabezado);

                        return true;
                    }
                    else
                    {
                        throw new Exception("No se encontró contrato para este empleado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    cn.desconexion(connection);
                }
            }
        }

        private decimal ObtenerSalarioBase(OdbcConnection connection, int fkClaveEmpleado, out int contratoId)
        {
            contratoId = 0;
            decimal salarioBase = 0;

            string query = @"
                SELECT pk_id_contrato, contratos_salario 
                FROM tbl_contratos 
                WHERE fk_clave_empleado = ? 
                ORDER BY contratos_fecha_creacion DESC 
                LIMIT 1";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fk_clave_empleado", fkClaveEmpleado);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contratoId = reader.GetInt32(0);
                        salarioBase = reader.GetDecimal(1);
                    }
                }
            }
            return salarioBase;
        }

        private decimal ObtenerTotalPercepciones(OdbcConnection connection, int fkClaveEmpleado)
        {
            decimal totalPercepciones = 0;

            string query = @"
                SELECT SUM(dpe.dedu_perp_emp_cantidad)
                FROM tbl_dedu_perp_emp dpe
                INNER JOIN tbl_dedu_perp dp ON dpe.Fk_dedu_perp = dp.pk_dedu_perp
                WHERE dpe.Fk_clave_empleado = ? AND dp.dedu_perp_clase = 'Percepcion' AND dpe.estado = 1";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fk_clave_empleado", fkClaveEmpleado);

                totalPercepciones = Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
            }
            return totalPercepciones;
        }

        private decimal ObtenerTotalDeducciones(OdbcConnection connection, int fkClaveEmpleado)
        {
            decimal totalDeducciones = 0;

            string query = @"
                SELECT SUM(dpe.dedu_perp_emp_cantidad)
                FROM tbl_dedu_perp_emp dpe
                INNER JOIN tbl_dedu_perp dp ON dpe.Fk_dedu_perp = dp.pk_dedu_perp
                WHERE dpe.Fk_clave_empleado = ? AND dp.dedu_perp_clase = 'Deduccion' AND dpe.estado = 1";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fk_clave_empleado", fkClaveEmpleado);

                totalDeducciones = Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
            }
            return totalDeducciones;
        }

        private void InsertarDetallePlanilla(OdbcConnection connection, int pkRegistroPlanillaDetalle, decimal totalPercepciones, decimal totalDeducciones, decimal totalLiquido, int fkClaveEmpleado, int contratoId, int fkIdRegistroPlanillaEncabezado)
        {
            string query = @"
                INSERT INTO tbl_planilla_Detalle 
                (pk_registro_planilla_Detalle, detalle_total_Percepciones, detalle_total_Deducciones, detalle_total_liquido, fk_clave_empleado, fk_id_contrato, fk_id_registro_planilla_Encabezado, estado)
                VALUES (?, ?, ?, ?, ?, ?, ?, 1)";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@pk_registro_planilla_Detalle", pkRegistroPlanillaDetalle);
                cmd.Parameters.AddWithValue("@detalle_total_Percepciones", totalPercepciones);
                cmd.Parameters.AddWithValue("@detalle_total_Deducciones", totalDeducciones);
                cmd.Parameters.AddWithValue("@detalle_total_liquido", totalLiquido);
                cmd.Parameters.AddWithValue("@fk_clave_empleado", fkClaveEmpleado);
                cmd.Parameters.AddWithValue("@fk_id_contrato", contratoId);
                cmd.Parameters.AddWithValue("@fk_id_registro_planilla_Encabezado", fkIdRegistroPlanillaEncabezado);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable obtener2(string sTabla, string sCampo1, string sCampo2)
        {
            Conexion cn = new Conexion();
            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }


        public bool InsertarPlanillaEncabezado(int correlativoPlanilla, DateTime fechaInicio, DateTime fechaFinal, decimal totalMes)
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
                        command.Parameters.AddWithValue("@correlativoPlanilla", correlativoPlanilla);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                        command.Parameters.AddWithValue("@totalMes", totalMes);

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






    }
}
