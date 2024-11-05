using System.Data;
using System.Collections.Generic;

namespace Capa_Controlador_Produccion
{
    public class Control_RRHH
    {
        private Capa_Modelo_Produccion.Sentencia_RRHH sentencia = new Capa_Modelo_Produccion.Sentencia_RRHH();

        public int ObtenerUltimoID()
        {
            return sentencia.ObtenerUltimoIdRRHH();
        }

        public DataTable ObtenerEmpleados()
        {
            return sentencia.ObtenerEmpleadosActivos();
        }

        public List<decimal> ObtenerSalarios()
        {
            return sentencia.ObtenerSalarios();
        }

        public List<decimal> ObtenerHorasExtras()
        {
            return sentencia.ObtenerHorasExtras();
        }

        public void GuardarRegistro(int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
            sentencia.GuardarRegistroRRHH(empleadoID, salario, dias, totalDias, horas, totalHoras, horasExtra, totalHorasExtras, totalManoObra);
        }

        public void ModificarRegistro(int idRRHH, int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
            sentencia.ModificarRegistroRRHH(idRRHH, empleadoID, salario, dias, totalDias, horas, totalHoras, horasExtra, totalHorasExtras, totalManoObra);
        }
        public void EliminarRegistro(int idRRHH)
        {
            sentencia.EliminarRegistroRRHH(idRRHH);
        }

        public DataTable ObtenerTodosLosRegistros()
        {
            return sentencia.ObtenerTodosLosRegistrosRRHH();
        }

    }
}
