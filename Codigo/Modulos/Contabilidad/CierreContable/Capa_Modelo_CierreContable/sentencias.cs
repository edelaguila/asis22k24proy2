using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CierreContable
{
    public class sentencias
    {
        private readonly conexion con = new conexion();

        public OdbcConnection ObtenerConexion()
        {
            return con.Conexion(); // Asegúrate de que este método retorne la conexión
        }

        // Método para llenar la tabla genérico
        public OdbcDataAdapter LlenarTbl(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";
            return new OdbcDataAdapter(sql, ObtenerConexion());
        }

        public (decimal sumaSaldoAnt, decimal sumaSaldoAct) ObtenerSumasSaldos(int periodo, string cuenta)
        {
            decimal sumaSaldoAnt = 0;
            decimal sumaSaldoAct = 0;

            string query = "SELECT SUM(hc.saldo_ant) AS SumaSaldoAnt, SUM(hc.saldo_act) AS SumaSaldoAct " +
                           "FROM tbl_historico_cuentas hc " +
                           "JOIN tbl_cuentas c ON hc.Pk_id_cuenta = c.Pk_id_cuenta " +
                           "WHERE hc.mes = ? AND c.nombre_cuenta = ?";

            using (OdbcConnection conn = ObtenerConexion())
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", periodo);
                cmd.Parameters.AddWithValue("?", cuenta);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sumaSaldoAnt = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        sumaSaldoAct = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    }
                }
            }

            return (sumaSaldoAnt, sumaSaldoAct);
        }

        public int VerificarCuentaPorMes(int mes, int idCuenta)
        {
            int cuentaExistente = 0;

            string query = "SELECT COUNT(*) FROM tbl_historico_cuentas WHERE mes = ? AND Pk_id_cuenta = ?";

            using (OdbcConnection conn = ObtenerConexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", mes);
                    cmd.Parameters.AddWithValue("?", idCuenta);
                    cuentaExistente = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return cuentaExistente;
        }

        // Método para ejecutar una consulta específica
        public DataTable EjecutarConsulta(string query)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = ObtenerConexion())
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
