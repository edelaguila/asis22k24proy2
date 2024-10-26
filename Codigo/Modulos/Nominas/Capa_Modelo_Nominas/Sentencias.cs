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
        Conexion con = new Conexion(); //Conexion con base de datos

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
                            "concepto as Concepto, " +
                            "tipo as Tipo, " +
                            "aplicacion as Aplicacion, " +
                            "excepcion as Excepcion, " +
                            "monto as Monto, " +
                            "estado as Estado " +
                            "FROM tbl_dedu_perp " +
                            "WHERE estado = 1";
                return new OdbcDataAdapter(sql, con.conexion());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaDeduPerp: " + ex.Message);
                return null;
            }
        }

        public void funcInsertarDeduPerp(string concepto, string tipo, string aplicacion, int excepcion, float monto)
        {
            OdbcConnection conn = null;
            try
            {
                string sql = "INSERT INTO tbl_dedu_perp (concepto, tipo, aplicacion, excepcion, monto, estado) " +
                            "VALUES (?, ?, ?, ?, ?, 1)";

                conn = con.conexion();
                // Verificar si la conexión ya está abierta
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    // Agregar parámetros en el orden en que aparecen en la consulta
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

        public void funcActualizarDeduPerp(int id, string concepto, string tipo, string aplicacion, int excepcion, float monto)
        {
            try
            {
                string sql = "UPDATE tbl_dedu_perp SET " +
                            "concepto = ?, " +
                            "tipo = ?, " +
                            "aplicacion = ?, " +
                            "excepcion = ?, " +
                            "monto = ? " +
                            "WHERE pk_dedu_perp = ?";
                using (OdbcConnection conn = con.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
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
                using (OdbcConnection conn = con.conexion())
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


        /********0901-21-506 - Ismar Leonel Cortez Sanchez************************/
        //public byte[] ObtenerLogoEmpresa(int empresaId)
        //{
        //    byte[] imageBytes = null;

        //    try
        //    {
        //        using (OdbcConnection connection = con.conexion()) // Abre la conexión
        //        {
        //            string query = "SELECT logo FROM tbl_empresas WHERE empresa_id = ?";
        //            using (OdbcCommand cmd = new OdbcCommand(query, connection))
        //            {
        //                cmd.Parameters.AddWithValue("?", empresaId);

        //                OdbcDataReader reader = cmd.ExecuteReader();

        //                if (reader.Read())
        //                {
        //                    imageBytes = (byte[])reader["logo"]; // Obtenemos el logo como array de bytes
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error al obtener el logo: " + ex.Message);
        //    }

        //    return imageBytes;
        //}
        /*************************************************************************/




    }





}








