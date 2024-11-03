using System;
using System.Data;

namespace Capa_Controlador_Lotes
{
    public class Control_Lotes
    {
        private readonly Capa_Modelo_Lotes.Sentencia_Lotes sentencias;

        // Constructor que inicializa la instancia de Sentencia_Lotes para interactuar con la base de datos
        public Control_Lotes()
        {
            sentencias = new Capa_Modelo_Lotes.Sentencia_Lotes();
        }

        // Método para agregar un nuevo lote
        public void AgregarLotes(
            int idLote,
            string codigoLote,
            DateTime fechaProduccionLote,
            int cantidadLote,
            int estado,
            int idProducto)
        {
            if (cantidadLote <= 0)
            {
                Console.WriteLine("La cantidad del lote debe ser mayor que cero.");
                return;
            }

            try
            {
                // Llama al método para insertar un nuevo lote en la base de datos
                sentencias.InsertarLote(idLote, codigoLote, fechaProduccionLote, cantidadLote, estado, idProducto);
                Console.WriteLine("Lote agregado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar un lote: " + ex.Message);
            }
        }

        // Método para actualizar un lote existente
        public void ActualizarLotes(
            int idLote,
            string codigoLote,
            DateTime fechaProduccionLote,
            int cantidadLote,
            int estado,
            int idProducto)
        {
            if (idLote <= 0)
            {
                Console.WriteLine("El ID del lote debe ser mayor que cero.");
                return;
            }

            if (cantidadLote < 0)
            {
                Console.WriteLine("La cantidad del lote no puede ser negativa.");
                return;
            }

            try
            {
                // Llama al método para actualizar el lote en la base de datos
                sentencias.ActualizarLote(idLote, codigoLote, fechaProduccionLote, cantidadLote, estado, idProducto);
                Console.WriteLine("Lote actualizado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el lote: " + ex.Message);
            }
        }

        // Método para desactivar un lote
        public void DesactivarLotes(int idLote)
        {
            try
            {
                // Llama al método para desactivar el lote en la base de datos
                sentencias.DesactivarLote(idLote);
                Console.WriteLine("Lote desactivado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desactivar el lote: " + ex.Message);
            }
        }

        // Método para cargar los lotes
        public DataTable CargarLotes()
        {
            try
            {
                // Obtiene los datos de los lotes mediante un INNER JOIN en la base de datos
                DataTable lotes = sentencias.ObtenerLotes();
                Console.WriteLine("Datos de los lotes cargados correctamente. Total de registros: " + lotes.Rows.Count);
                return lotes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los lotes: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener el último ID de lote
        public int ObtenerUltimoIdLotes()
        {
            try
            {
                // Obtiene el último ID de la tabla de lotes
                int ultimoId = sentencias.ObtenerUltimoIdLote();
                Console.WriteLine("Último ID del lote obtenido: " + ultimoId);
                return ultimoId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último ID del lote: " + ex.Message);
                return 0;
            }
        }

        // Método para cargar los productos en un DataTable
        public DataTable CargarProductos()
        {
            try
            {
                // Obtiene los productos activos de la base de datos
                DataTable productos = sentencias.ObtenerProductos();
                Console.WriteLine("Productos cargados correctamente. Total de registros: " + productos.Rows.Count);
                return productos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los productos: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para cargar los procesos en un DataTable
        public DataTable CargarProcesos()
        {
            try
            {
                // Obtiene los procesos de la base de datos
                DataTable procesos = sentencias.ObtenerProcesos();
                Console.WriteLine("Procesos cargados correctamente. Total de registros: " + procesos.Rows.Count);
                return procesos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los procesos: " + ex.Message);
                return new DataTable();
            }
        }
    }
}
