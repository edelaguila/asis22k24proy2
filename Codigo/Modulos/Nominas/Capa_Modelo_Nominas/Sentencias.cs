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





    }





}








