using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Para OdbcDataReader
using Capa_Modelo_Logistica; // Para Sentencias


namespace Capa_Controlador_Logistica
{
    public class Controlador
    {
        private Sentencias sentencias; // Instancia de la clase Sentencias

        public Controlador()
        {
            sentencias = new Sentencias(); // Inicializar la instancia de Sentencias
        }

        // Método para obtener existencias de una bodega (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            return sentencias.ObtenerExistenciasBodega(idBodega);
        }

        // Método para cargar existencias (puede agregar más lógica si es necesario) (Realizado por Daniel Sierra 0901-21-12740)
        public void CargarExistencias(string idBodega)
        {
            OdbcDataReader dr = ObtenerExistenciasBodega(idBodega);
            // Aquí puedes agregar lógica para manejar los datos obtenidos, como llenarlos en un DataGridView
        }

        // Método para realizar auditoría (Realizado por Daniel Sierra 0901-21-12740)
        public void RealizarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            sentencias.InsertarAuditoria(idBodega, idProducto, cantidadFisica, cantidadRegistrada, discrepancia);
        }
        // Método para obtener productos de bodega (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerProductosPorBodega(string idBodega)
        {
            return sentencias.ObtenerProductosPorBodega(idBodega);
        }
        public void RealizarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            sentencias.InsertarSolicitudMantenimiento(idMantenimiento, nombreSolicitante, tipoMantenimiento, componenteAfectado, fecha, responsableAsignado, codigo_error_Problema, estadoMantenimiento, tiempoEstimado, id_Movimiento);
        }

    }
}
