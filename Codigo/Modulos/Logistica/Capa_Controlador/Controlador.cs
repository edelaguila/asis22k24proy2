using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using System.Data.Odbc;
using System.Data;


namespace Capa_Controlador
{
    public class Controlador
    {
        private Sentencias sentencias;
        public Controlador()
        {
            sentencias = new Sentencias();
        }
        //Aca inicia la logica del modulo de mantenimiento de vehiculo
        public void RealizarSolicitudMantenimiento(string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            sentencias.InsertarSolicitudMantenimiento(nombreSolicitante, tipoMantenimiento, componenteAfectado, fecha, responsableAsignado, codigo_error_Problema, estadoMantenimiento, tiempoEstimado, id_Movimiento);
        }
        public DataTable MostrarSolicitudesMantenimiento()
        {
            OdbcDataAdapter data = sentencias.DisplaySolicitudesMantenimiento(); // Obtén el DataAdapter
            DataTable tabla = new DataTable(); // Crea una instancia de DataTable
            data.Fill(tabla); // Llena el DataTable con los datos obtenidos
            return tabla; // Retorna el DataTable con los datos
        }
        public void ModificarSolicitudMantenimiento(int id_Mantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            sentencias.ModificarSolicitudMantenimiento(id_Mantenimiento, nombreSolicitante, tipoMantenimiento, componenteAfectado, fecha, responsableAsignado, codigo_error_Problema, estadoMantenimiento, tiempoEstimado, id_Movimiento);
        }
        public void EliminarSolicitudMantenimient(int idMantenimiento)
        {
            sentencias.eliminarSolicitudMantenimiento(idMantenimiento);
        }
        public void CrearPDFMantenimiento(int idMantenimiento)
        {
            sentencias.GenerarPDFMantenmiento(idMantenimiento);
        }
        //Aca finaliza la logica del modulo de mantenimiento de vehiculo

        //Aca empieza la logica del modulo de movimiento de inventario
        public void RealizarMovimientoInventario(int estado, int fk_id_producto, int fk_id_stock, int fk_id_locales)
        {
            sentencias.InsertarMovimientoInventario(estado, fk_id_producto, fk_id_stock, fk_id_locales);
        }
        public DataTable ObtenerProductos()
        {
            return sentencias.llenarcmb("Tbl_Productos", "Pk_id_Producto");
        }

        public DataTable ObtenerStocks()
        {
            return sentencias.llenarcmb("Tbl_TrasladoProductos", "Pk_id_TrasladoProductos");
        }

        public DataTable ObtenerLocales()
        {
            return sentencias.llenarcmb("TBL_LOCALES", "Pk_ID_LOCAL");
        }
        public DataTable MostrarMovimientosInventario()
        {
            OdbcDataAdapter data = sentencias.DisplayMovimientos(); 
            DataTable tabla = new DataTable(); 
            data.Fill(tabla); 
            return tabla; 
        }
        public void ModificarMovimientoInventario(int idMovimiento, int estado, int Fk_id_producto, int Fk_id_stock, int Fk_ID_LOCALES)
        {
            sentencias.ModificarMovimientoInventario(idMovimiento, estado, Fk_id_producto, Fk_id_stock, Fk_ID_LOCALES);
        }
        public void EliminarMovimiento(int idMovimiento)
        {
            sentencias.eliminarMovimientoInventario(idMovimiento);
        }
        public void GenerarPDFMovimientoInventario(int idMovimiento)
        {
            sentencias.GenerarPDFMovimiento(idMovimiento);
        }
    }
}
