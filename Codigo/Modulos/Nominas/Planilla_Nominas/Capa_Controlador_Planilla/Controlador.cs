using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Planilla;

namespace Capa_Controlador_Planilla
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public bool EjecutarCalculoPlanilla(int pkRegistroPlanillaDetalle, int fkIdRegistroPlanillaEncabezado, int fkClaveEmpleado)
        {
            return sn.CalcularPlanillaDetalle(pkRegistroPlanillaDetalle, fkIdRegistroPlanillaEncabezado, fkClaveEmpleado);
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

        public DataTable enviar(string tabla, string campo1, string campo2)
        {

            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }

        public DataTable enviar2(string tabla, string campo1, string campo2)
        {


            /**/
            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }

        public bool AgregarPlanillaEncabezado(int correlativo, DateTime fechaInicio, DateTime fechaFinal, decimal totalMes)
        {
            Sentencias sentencias = new Sentencias();
            return sentencias.InsertarPlanillaEncabezado(correlativo, fechaInicio, fechaFinal, totalMes);
        }




    }

}
