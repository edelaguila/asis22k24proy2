﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CierreContable
{
    public class sentencias
    {
        private conexion con = new conexion();

        public OdbcConnection ObtenerConexion()
        {
            return con.Conexion(); // Asegúrate de que este método retorne la conexión
        }

        // Método para llenar la tabla genérico
        public OdbcDataAdapter llenarTbl(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public (decimal sumaSaldoAnt, decimal sumaSaldoAct) ObtenerSumasSaldos(int periodo, string cuenta)
        {
            decimal sumaSaldoAnt = 0;
            decimal sumaSaldoAct = 0;

            // Actualiza la consulta para incluir el JOIN con tbl_cuentas
            string query = "SELECT SUM(hc.saldo_ant) AS SumaSaldoAnt, SUM(hc.saldo_act) AS SumaSaldoAct " +
                           "FROM tbl_historico_cuentas hc " +
                           "JOIN tbl_cuentas c ON hc.Pk_id_cuenta = c.Pk_id_cuenta " +
                           "WHERE hc.mes = ? AND c.nombre_cuenta = ?";

            using (OdbcConnection conn = con.Conexion())
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", periodo); // Agregar el parámetro del periodo
                cmd.Parameters.AddWithValue("?", cuenta);   // Agregar el parámetro de cuenta

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Manejo de valores nulos y conversión
                    sumaSaldoAnt = reader.IsDBNull(0) ? 0 : Convert.ToDecimal(reader["SumaSaldoAnt"]);
                    sumaSaldoAct = reader.IsDBNull(1) ? 0 : Convert.ToDecimal(reader["SumaSaldoAct"]);
                }

                reader.Close();
            }

            return (sumaSaldoAnt, sumaSaldoAct);
        }

        public int VerificarCuentaPorMes(int mes, int idCuenta)
        {
            int cuentaExistente = 0;

            string query = "SELECT COUNT(*) FROM tbl_historico_cuentas WHERE mes = @mes AND Pk_id_cuenta = @idCuenta";

            using (OdbcConnection conn = con.Conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mes", mes);
                    cmd.Parameters.AddWithValue("@idCuenta", idCuenta);
                    cuentaExistente = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return cuentaExistente;
        }

        // Método para ejecutar una consulta específica
        public DataTable EjecutarConsulta(string query)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = con.Conexion())
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }


    }

}

