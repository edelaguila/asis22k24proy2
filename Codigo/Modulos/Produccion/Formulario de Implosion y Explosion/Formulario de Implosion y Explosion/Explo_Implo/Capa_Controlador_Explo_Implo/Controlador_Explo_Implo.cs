using System;
using System.Collections.Generic;
using System.Data;
using Capa_Modelo_Explo_Implo;

namespace Capa_Controlador_Explo_Implo
{
    public class Controlador_Explo_Implo
    {
        private Sentencias_Explo_Implo modelo = new Sentencias_Explo_Implo();

        public List<int> ObtenerOrdenesProduccion()
        {
            try
            {
                return modelo.ObtenerIdsOrdenes(); // Obtiene los IDs de las órdenes de producción
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener órdenes de producción: " + ex.Message);
                return new List<int>(); // Retorna una lista vacía en caso de error
            }
        }

        public void GuardarExplosion(int fkIdOrden, int fkIdProducto, int cantidad, int costoTotal, int duracionHoras, int fkIdProceso, DateTime fechaExplosion)
        {
            try
            {
                modelo.GuardarExplosion(fkIdOrden, fkIdProducto, cantidad, costoTotal, duracionHoras, fkIdProceso, fechaExplosion); // Guarda la explosión en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la explosión: " + ex.Message);
            }
        }

        public int ObtenerUltimoID()
        {
            try
            {
                return modelo.ObtenerUltimo(); // Obtiene el último ID de explosión
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último ID: " + ex.Message);
                return -1; // Retorna -1 como valor de error
            }
        }

        public Dictionary<int, string> ObtenerProductos()
        {
            try
            {
                var productos = modelo.ObtenerProductos(); // Obtiene la lista de objetos Producto desde el modelo
                                                           // Convierte la lista de Producto a un Dictionary<int, string> para evitar la referencia directa de la clase Producto en la vista
                var productosDict = new Dictionary<int, string>();
                foreach (var producto in productos)
                {
                    productosDict.Add(producto.Id, producto.Nombre);
                }
                return productosDict;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos: " + ex.Message);
                return new Dictionary<int, string>(); // Retorna un diccionario vacío en caso de error
            }
        }



        public List<int> ObtenerProcesosProduccion()
        {
            try
            {
                return modelo.ObtenerIdsProcesos(); // Obtiene los IDs de los procesos de producción
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener procesos de producción: " + ex.Message);
                return new List<int>(); // Retorna una lista vacía en caso de error
            }
        }

        public DataTable ObtenerTodosLosRegistros()
        {
            try
            {
                return modelo.ObtenerTodosExplosion(); // Obtiene todos los registros de explosión
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener todos los registros de explosión: " + ex.Message);
                return new DataTable(); // Retorna un DataTable vacío en caso de error
            }
        }
    }
}
