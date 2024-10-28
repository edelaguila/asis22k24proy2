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


        ///********0901-21-1278 - Gabriela Alejandra Suc Gomez**********************/
        public void CalcularLiquidacion()
        {
            try
            {
                // Mostrar un mensaje de inicio de ejecución
                Console.WriteLine("Ejecutando SP Liquidaciones...");

                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL sp_insertar_liquidaciones}", conn.conexion()))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Ejecutar el SP
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si el SP afectó alguna fila
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("SP Liquidaciones. ejecutado correctamente, filas afectadas: " + filasAfectadas);
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

        ///*************************************************************************/



    }





}








