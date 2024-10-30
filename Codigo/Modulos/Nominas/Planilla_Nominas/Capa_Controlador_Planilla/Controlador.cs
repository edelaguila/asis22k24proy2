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

        public bool funEjecutarCalculoPlanilla(int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            return sn.funCalcularPlanillaDetalle(ifkIdRegistroPlanillaEncabezado, ifkClaveEmpleado);
        }

        public DataTable funObtenerEncabezado()
        {
            OdbcDataAdapter adapter = sn.funObtenerEncabezado();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }


        public DataTable funObtenerDetalle()
        {
            OdbcDataAdapter adapter = sn.funObtenerDetalle();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public DataTable funenviar(string stabla, string scampo1, string scampo2)
        {

            var dt1 = sn.funobtener2(stabla, scampo1, scampo2);

            return dt1;
        }

        public DataTable funenviar2(string stabla, string scampo1, string scampo2)
        {


            /**/
            var dt1 = sn.funobtener2(stabla, scampo1, scampo2);

            return dt1;
        }

        public bool funAgregarPlanillaEncabezado(int icorrelativo, DateTime dfechaInicio, DateTime dfechaFinal, decimal detotalMes)
        {
            Sentencias sentencias = new Sentencias();
            return sentencias.funInsertarPlanillaEncabezado(icorrelativo, dfechaInicio, dfechaFinal, detotalMes);
        }

        public void funcActualizarEncabezado(int iidSeleccionado, int icorrelativo, DateTime dfechaInicio, DateTime dfechaFinal)
        {
            try
            {
                sn.funcActualizarEncabezado(iidSeleccionado, icorrelativo, dfechaInicio,dfechaFinal);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarLogicaDeduPerp: " + ex.Message);
            }
        }

        public void funcEliminarEncabezado(int iidSeleccionado)
        {
            try
            {
                sn.funcEliminarEncabezado(iidSeleccionado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarLogicaDeduPerp: " + ex.Message);
            }
        }

        public void funcActualizarDetalle(int iidSeleccionado2, int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            try
            {
                sn.funcActualizarDetalle(iidSeleccionado2, ifkIdRegistroPlanillaEncabezado, ifkClaveEmpleado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarLogicaDeduPerp: " + ex.Message);
            }
        }

        public void funcEliminarDetalle(int iidSeleccionado2)
        {
            try
            {
                sn.funcEliminarDetalle(iidSeleccionado2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarLogicaDeduPerp: " + ex.Message);
            }
        }



    }

}
