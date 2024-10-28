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

        public void CalcularHorasExtras()
        {
            try
            {
                string mesActualTexto = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                Console.WriteLine(mesActualTexto); // Esto imprimirá el mes actual como texto

                using (OdbcCommand comando = new OdbcCommand("CALL Calcular_Horas_Extras_(?)", con.conexion()))
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
                Console.WriteLine("No se ejecutó el SP.");
            }
        }


        /*************************************************************************/


        /********0901-21-843 - Marco Alejandro Monroy Rousselin*******************/

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








