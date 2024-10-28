using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using Capa_Modelo_Nominas;
using Capa_Modelo_Seguridad;


using System.Net;
using System.Text.RegularExpressions;


namespace Capa_Modelo_Nominas
{
    public class Sentencias
    {
        Conexion conn = new Conexion(); //Conexion con base de datos

        /********0901-21-13093 - Brandon Alejandro Boch Lopez*********************/

        /*************************************************************************/


        /********0901-21-1278 - Gabriela Alejandra Suc Gomez**********************/

        /*************************************************************************/


        /********0901-21-4866 - Kateryn Johana De León Hernández******************/

        /*************************************************************************/


        /********0901-21-843 - Marco Alejandro Monroy Rousselin*******************/
        //// Método para llamar al SP calcular_deduccion_faltas
        public void CalcularDeduccionFaltas()
        {
            try
            {
                // Mostrar un mensaje de inicio de ejecución
                Console.WriteLine("Ejecutando SP calcular_deduccion_faltas...");

                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL calcular_deduccion_faltas}", conn.conexion()))
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


        /*************************************************************************/


        /********0901-21-581 - Fernando José García de León***********************/

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








