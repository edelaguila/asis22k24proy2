using System;
using System.Data;

namespace Capa_Controlador_Produccion
{
    public class Control_Mantenimiento
    {
        private readonly Capa_Modelo_Produccion.Sentencias_Mantenimiento sentencias;

        // Constructor que inicializa la instancia de Sentencias_Mantenimiento para interactuar con la base de datos
        public Control_Mantenimiento()
        {
            sentencias = new Capa_Modelo_Produccion.Sentencias_Mantenimiento();
        }

        // Método para agregar un nuevo mantenimiento
        public void AgregarMantenimiento(
            string nombreMaquinaria,
            string tipoMaquina,
            decimal horaOperacion,
            string mantenimientoPeriodico,
            DateTime ultimaMantenimiento,
            DateTime proximoMantenimiento,
            string area,
            decimal desgastePorcentaje,
            int estado)
        {
            try
            {
                sentencias.InsertarMantenimiento(
                    nombreMaquinaria,
                    tipoMaquina,
                    horaOperacion,
                    mantenimientoPeriodico,
                    ultimaMantenimiento,
                    proximoMantenimiento,
                    area,
                    desgastePorcentaje,
                    estado
                );
                Console.WriteLine("Mantenimiento agregado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar mantenimiento: " + ex.Message);
            }
        }

        // Método para actualizar un mantenimiento existente
        public void ActualizarMantenimiento(
            int idMaquinaria,
            string nombreMaquinaria,
            string tipoMaquina,
            decimal horaOperacion,
            string mantenimientoPeriodico,
            DateTime ultimaMantenimiento,
            DateTime proximoMantenimiento,
            string area,
            decimal desgastePorcentaje,
            int estado)
        {
            try
            {
                sentencias.ActualizarMantenimiento(
                    idMaquinaria,
                    nombreMaquinaria,
                    tipoMaquina,
                    horaOperacion,
                    mantenimientoPeriodico,
                    ultimaMantenimiento,
                    proximoMantenimiento,
                    area,
                    desgastePorcentaje,
                    estado
                );
                Console.WriteLine("Mantenimiento actualizado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar mantenimiento: " + ex.Message);
            }
        }

        // Método para eliminar un mantenimiento por ID
        public void DesactivarMantenimiento(int idMaquinaria)
        {
            try
            {
                sentencias.DesactivarMantenimiento(idMaquinaria);
                Console.WriteLine("Mantenimiento desactivado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desactivar el mantenimiento: " + ex.Message);
            }
        }


        // Método para obtener todos los mantenimientos en la base de datos
        public DataTable CargarMantenimientos()
        {
            try
            {
                DataTable mantenimientos = sentencias.ObtenerMantenimientos();
                Console.WriteLine("Datos de mantenimientos cargados correctamente. Total de registros: " + mantenimientos.Rows.Count);
                return mantenimientos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los mantenimientos: " + ex.Message);
                return new DataTable(); // Retorna una tabla vacía en caso de error
            }
        }

        // Método para obtener el último ID de la tabla de mantenimientos
        public int ObtenerUltimoIdMaquinaria()
        {
            try
            {
                int ultimoId = sentencias.ObtenerUltimoIdMaquinaria();
                Console.WriteLine("Último ID de maquinaria obtenido: " + ultimoId);
                return ultimoId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último ID de maquinaria: " + ex.Message);
                return 0; // Retorna 0 en caso de error
            }
        }
    }
}
