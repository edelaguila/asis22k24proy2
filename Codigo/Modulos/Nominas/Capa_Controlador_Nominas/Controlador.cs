using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Nominas;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Capa_Controlador_Nominas
{
    public class Controlador
    {
        Sentencias sn = new Sentencias(); //Conexion con capa modelo


        /********0901-21-13093 - Brandon Alejandro Boch Lopez*********************/

        /*************************************************************************/


        /********0901-21-1278 - Gabriela Alejandra Suc Gomez**********************/

        /*************************************************************************/


        /********0901-21-4866 - Kateryn Johana De León Hernández******************/

        /*************************************************************************/


        /********0901-21-843 - Marco Alejandro Monroy Rousselin*******************/

        /*************************************************************************/


        /********0901-21-581 - Fernando José García de León***********************/

        /*************************************************************************/


        /********0901-21-506 - Ismar Leonel Cortez Sanchez************************/
        // Método que obtiene el logo en formato Image
        //public Image ObtenerLogoEmpresa(int empresaId)
        //{
        //    byte[] imageBytes = modelo.ObtenerLogoEmpresa(empresaId); // Este método retorna un arreglo de bytes

        //    if (imageBytes != null)
        //    {
        //        using (MemoryStream ms = new MemoryStream(imageBytes))
        //        {
        //            return Image.FromStream(ms); // Esto convierte los bytes a una imagen usando System.Drawing.Image
        //        }
        //    }
        //    return null;
        //}

        public List<int> ObtenerIdsEmpleados()
        {
            OdbcDataAdapter adapter = sn.ObtenerIdsEmpleados();
            DataTable empleadosTable = new DataTable();
            List<int> empleadosIds = new List<int>();

            if (adapter != null)
            {
                adapter.Fill(empleadosTable); // Llenar el DataTable con el resultado del OdbcDataAdapter

                // Extraer los IDs de empleados desde el DataTable
                foreach (DataRow row in empleadosTable.Rows)
                {
                    empleadosIds.Add(Convert.ToInt32(row["pk_clave"]));
                }
            }

            return empleadosIds;
        }

        public void CalcularDeduccionesPercepcionesPorEmpleado()
        {
            try
            {
                List<int> empleadosIds = ObtenerIdsEmpleados();
                foreach (int empleadoId in empleadosIds)
                {
                    //sn.CalcularAnticipos(empleadoId); //Deduccion

                }
                //sn.CalcularDeduccionFaltas();//Deduccion
               //sn.CalcularHorasExtras();//Percepcion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al calcular las deducciones: " + ex.Message);
                // Aquí puedes agregar código para registrar en un archivo de log
            }
        }

        public DataTable ObtenerPercepciones()
        {
            OdbcDataAdapter adapter = sn.ObtenerPercepciones();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public DataTable ObtenerDeducciones()
        {
            OdbcDataAdapter adapter = sn.ObtenerDeducciones();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }



        public void CalcularTotalDeduPer(String clave, String Empleado, String Encabezado)
        {
            {
                try
                {
                    //sn.CalcularTotalDeduPer(clave, Empleado, Encabezado);//Percepcion
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al calcular las deducciones: " + ex.Message);
                    // Aquí puedes agregar código para registrar en un archivo de log
                }
            }
        }

        public DataTable ObtenerEncabezado()
        {
            OdbcDataAdapter adapter = sn.ObtenerEncabezado();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }


        public DataTable ObtenerDetalle()
        {
            OdbcDataAdapter adapter = sn.ObtenerDetalle();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public void CalcularLiquidacion()
        {
            try
            {


                //sn.CalcularLiquidacion();//Liquidacion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al calcular las deducciones: " + ex.Message);
                // Aquí puedes agregar código para registrar en un archivo de log
            }
        }



        /*************************************************************************/




    }
}
