using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Faltas;
using System.Data;

namespace Capa_Controlador_Faltas
{
    public class Controlador
    {
        private readonly Sentencia sn = new Sentencia();

        // Método para obtener las faltas de un empleado específico en un mes
        public int CalcularFaltasEmpleado(int idEmpleado, string mes)
        {
            return sn.CalcularFaltasEmpleado(idEmpleado, mes);
        }

        // Método para obtener todos los empleados
        public DataTable ObtenerEmpleados()
        {
            return sn.ObtenerEmpleados();
        }

        // Método para obtener todas las faltas en la tabla deducciones
        public DataTable ObtenerTodasLasFaltas()
        {
            return sn.ObtenerTodasLasFaltas();
        }

        // Método para guardar o actualizar la deducción por faltas
        public void GuardarDeduccionPorFaltas(int idEmpleado, int totalFaltas)
        {
            sn.GuardarDeduccionPorFaltas(idEmpleado, totalFaltas);
        }

    }
}



