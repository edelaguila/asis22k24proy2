using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;

namespace Capa_Modelo_Produccion
{
    public class Sentencia_RRHH
    {
        private Conexion_Produccion conexion = new Conexion_Produccion();

        public int ObtenerUltimoIdRRHH()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT MAX(Pk_id_RRHH) FROM tbl_rrhh_produccion";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                //conn.Open();
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;

            }
        }

        public DataTable ObtenerEmpleadosActivos()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT pk_clave, empleados_nombre FROM tbl_empleados WHERE estado = 1";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                //conn.Open();
                da.Fill(dt);
                return dt;
            }
        }

        public List<decimal> ObtenerHorasExtras()
        {
            List<decimal> horasExtras = new List<decimal>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT horas_cantidad_horas FROM tbl_horas_extra";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    horasExtras.Add(reader.GetDecimal(0));
                }
            }
            return horasExtras;
        }

        public List<decimal> ObtenerSalarios()
        {
            List<decimal> salarios = new List<decimal>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT contratos_salario FROM tbl_contratos";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    salarios.Add(reader.GetDecimal(0));
                }
            }
            return salarios;
        }

        public void GuardarRegistroRRHH(int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "INSERT INTO tbl_rrhh (id_empleado, salario, dias, total_dias, horas, total_horas, horas_extras, total_horas_extras, total_mano_obra, estado) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, 1)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", empleadoID);
                cmd.Parameters.AddWithValue("?", salario);
                cmd.Parameters.AddWithValue("?", dias);
                cmd.Parameters.AddWithValue("?", totalDias);
                cmd.Parameters.AddWithValue("?", horas);
                cmd.Parameters.AddWithValue("?", totalHoras);
                cmd.Parameters.AddWithValue("?", horasExtra);
                cmd.Parameters.AddWithValue("?", totalHorasExtras);
                cmd.Parameters.AddWithValue("?", totalManoObra);
                //conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarRegistroRRHH(int idRRHH, int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "UPDATE tbl_rrhh SET id_empleado = ?,  salario = ?, dias = ?, total_dias = ?, horas = ?, total_horas = ?, horas_extras = ?, total_horas_extras = ?, total_mano_obra = ? WHERE id_RRHH = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", empleadoID);
                cmd.Parameters.AddWithValue("?", salario);
                cmd.Parameters.AddWithValue("?", dias);
                cmd.Parameters.AddWithValue("?", totalDias);
                cmd.Parameters.AddWithValue("?", horas);
                cmd.Parameters.AddWithValue("?", totalHoras);
                cmd.Parameters.AddWithValue("?", horasExtra);
                cmd.Parameters.AddWithValue("?", totalHorasExtras);
                cmd.Parameters.AddWithValue("?", totalManoObra);
                cmd.Parameters.AddWithValue("?", idRRHH);
                //conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarRegistroRRHH(int idRRHH)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "DELETE FROM tbl_rrhh WHERE id_RRHH = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idRRHH);
                //conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerTodosLosRegistrosRRHH()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_rrhh_produccion";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

    }
}
