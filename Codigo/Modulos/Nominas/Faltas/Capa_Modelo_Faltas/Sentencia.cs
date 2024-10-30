using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_Faltas
{
    public class Sentencia
    {
        Conexion cn = new Conexion(); //Conexion con base de datos

        // Método para obtener todos los empleados
        public DataTable ObtenerEmpleados()
        {
            DataTable empleados = new DataTable();
            using (var connection = cn.conexion())
            {
                string query = "SELECT pk_clave, empleados_nombre FROM tbl_empleados";
                using (var command = new OdbcCommand(query, connection))
                using (var adapter = new OdbcDataAdapter(command))
                {
                    adapter.Fill(empleados);
                }
            }
            return empleados;
        }

        // Método para obtener todas las faltas registradas
        public DataTable ObtenerTodasLasFaltas()
        {
            DataTable faltas = new DataTable();
            using (var connection = cn.conexion())
            {
                string query = "SELECT * FROM tbl_control_faltas";
                using (var command = new OdbcCommand(query, connection))
                using (var adapter = new OdbcDataAdapter(command))
                {
                    adapter.Fill(faltas);
                }
            }
            return faltas;
        }

        // Método para registrar o actualizar la deducción de faltas en tbl_dedu_perp_emp
        public void GuardarDeduccionPorFaltas(int idEmpleado, int totalFaltas)
        {
            using (var connection = cn.conexion())
            {
                try
                {
                    // Primero verificamos si existe el registro
                    string queryVerificar = @"
                SELECT COUNT(*) 
                FROM tbl_dedu_perp_emp 
                WHERE Fk_clave_empleado = ?";

                    using (var cmdVerificar = new OdbcCommand(queryVerificar, connection))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Fk_clave_empleado", idEmpleado);
                        int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                        // Obtenemos el ID de la deducción por faltas
                        string queryDeduccionId = @"
                    SELECT pk_dedu_perp 
                    FROM tbl_dedu_perp 
                    WHERE dedu_perp_concepto = 'Faltas' 
                    LIMIT 1";

                        using (var cmdDeduccionId = new OdbcCommand(queryDeduccionId, connection))
                        {
                            object deduccionId = cmdDeduccionId.ExecuteScalar();

                            if (deduccionId == null)
                            {
                                throw new Exception("No se encontró el concepto 'Faltas' en tbl_dedu_perp");
                            }

                            string query;
                            if (existe > 0)
                            {
                                // Actualizar
                                query = @"
                            UPDATE tbl_dedu_perp_emp 
                            SET dedu_perp_emp_cantidad = ?, 
                                estado = 1
                            WHERE Fk_clave_empleado = ? 
                            AND Fk_dedu_perp = ?";
                            }
                            else
                            {
                                // Insertar
                                query = @"
                            INSERT INTO tbl_dedu_perp_emp 
                            (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, estado)
                            VALUES (?, ?, ?, 1)";
                            }

                            using (var cmd = new OdbcCommand(query, connection))
                            {
                                if (existe > 0)
                                {
                                    cmd.Parameters.AddWithValue("@cantidad", totalFaltas);
                                    cmd.Parameters.AddWithValue("@empleado", idEmpleado);
                                    cmd.Parameters.AddWithValue("@deduccion", deduccionId);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@empleado", idEmpleado);
                                    cmd.Parameters.AddWithValue("@deduccion", deduccionId);
                                    cmd.Parameters.AddWithValue("@cantidad", totalFaltas);
                                }

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Solo relanzamos la excepción
                    throw new Exception("Error al guardar la deducción por faltas: " + ex.Message, ex);
                }
            }
        }


        // Método para calcular las faltas de un empleado en un mes específico
        public int CalcularFaltasEmpleado(int idEmpleado, string mes)
        {
            int totalFaltas = 0;
            using (var connection = cn.conexion())
            {
                string query = @"
                    SELECT COUNT(*) FROM tbl_control_faltas
                    WHERE fk_clave_empleado = ? AND faltas_mes = ?";

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fk_clave_empleado", idEmpleado);
                    command.Parameters.AddWithValue("@faltas_mes", mes);

                    totalFaltas = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return totalFaltas;
        }
    }
}