using System;
using System.Data;
using System.Data.Odbc;  // Agregar esta línea para resolver el error de OdbcException
using Capa_Modelo_Produccion;

namespace Capa_Controlador_Produccion
{
    public class Control_Sistema_Prod
    {
        private Sentencia_Sistema_Prod sentencia = new Sentencia_Sistema_Prod();

        // Método para insertar en tbl_proceso_produccion_encabezado
        public bool InsertarEncabezado(int idProceso, int idOrden, int idMaquinaria)
        {
            try
            {
                return sentencia.InsertarEncabezado(idProceso, idOrden, idMaquinaria);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error ODBC al insertar en encabezado: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en encabezado: " + ex.Message);
                return false;
            }
        }

        // Método para insertar en tbl_proceso_produccion_detalle
        public bool InsertarDetalle(int idProcesoDetalle, int idProducto, int idReceta, int idEmpleado, int idProceso, int cantidad, decimal costoU, decimal costoT, decimal duracionHoras, decimal manoDeObra, decimal costoLuz, decimal costoAgua)
        {
            try
            {
                return sentencia.InsertarDetalle(idProcesoDetalle, idProducto, idReceta, idEmpleado, idProceso, cantidad, costoU, costoT, duracionHoras, manoDeObra, costoLuz, costoAgua);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error ODBC al insertar en detalle: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en detalle: " + ex.Message);
                return false;
            }
        }

        // Método para obtener el siguiente ID de proceso
        public int ObtenerSiguienteIdProceso()
        {
            try
            {
                DataTable dt = sentencia.ObtenerUltimoIdProceso();
                if (dt.Rows.Count > 0 && int.TryParse(dt.Rows[0]["Pk_id_proceso"].ToString(), out int lastId))
                {
                    return lastId + 1;
                }
                return 1; // Empieza en 1 si no hay registros
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el siguiente ID de proceso: " + ex.Message);
                return -1; // Retorna -1 en caso de error
            }
        }

        // Método para obtener el siguiente ID de proceso detalle
        public int ObtenerSiguienteIdProcesoDetalle()
        {
            try
            {
                DataTable dt = sentencia.ObtenerUltimoIdProcesoDetalle();
                if (dt.Rows.Count > 0 && int.TryParse(dt.Rows[0]["Pk_id_proceso_detalle"].ToString(), out int lastId))
                {
                    return lastId + 1;
                }
                return 1; // Empieza en 1 si no hay registros
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el siguiente ID de proceso detalle: " + ex.Message);
                return -1;
            }
        }

        // Método para obtener órdenes de producción
        public DataTable ObtenerOrdenesProduccion()
        {
            try
            {
                return sentencia.ObtenerOrdenesProduccion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener órdenes de producción: " + ex.Message);
                return new DataTable(); // Retorna una tabla vacía en caso de error
            }
        }

        // Método para obtener maquinarias
        public DataTable ObtenerMaquinarias()
        {
            try
            {
                return sentencia.ObtenerMaquinarias();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener maquinarias: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener empleados
        public DataTable ObtenerEmpleados()
        {
            try
            {
                return sentencia.ObtenerEmpleados();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener empleados: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener el detalle de una orden específica
        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            try
            {
                return sentencia.ObtenerDetalleOrden(idOrden);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalle de la orden: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener producto y receta asociados a un producto específico
        public DataTable ObtenerProductoYReceta(int idProducto)
        {
            try
            {
                return sentencia.ObtenerProductoYReceta(idProducto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener producto y receta: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener detalles de una receta específica
        public DataTable ObtenerRecetaDetalle(int idReceta)
        {
            try
            {
                return sentencia.ObtenerRecetaDetalle(idReceta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalles de la receta: " + ex.Message);
                return new DataTable();
            }
        }
    }
}
