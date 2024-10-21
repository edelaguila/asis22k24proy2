using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace Capa_Modelo_Logistica
{
    public class Sentencias
    {
        private Conexion cn = new Conexion(); // Instancia de la clase de conexión

        // Método para cargar las existencias de una bodega en particular (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            OdbcDataReader dr = null;
            OdbcConnection conn = null; // Declarar la conexión aquí

            try
            {
                conn = cn.conexion();
                string query = $"SELECT * FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = '{idBodega}'";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener existencias: " + ex.Message);
                // Asegurarse de que dr sea null en caso de error
                dr = null;
            }
            finally
            {
                // Si se produce un error, cerramos la conexión
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Cerrar la conexión si está abierta
                }
            }

            return dr;
        }

        // Método para insertar una auditoría de inventario (Realizado por Daniel Sierra 0901-21-12740)
        public void InsertarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "INSERT INTO Auditorias (BodegaID, ProductoID, CantidadFisica, CantidadRegistrada, Discrepancia) VALUES (?, ?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@BodegaID", idBodega);
                cmd.Parameters.AddWithValue("@ProductoID", idProducto);
                cmd.Parameters.AddWithValue("@CantidadFisica", cantidadFisica);
                cmd.Parameters.AddWithValue("@CantidadRegistrada", cantidadRegistrada);
                cmd.Parameters.AddWithValue("@Discrepancia", discrepancia);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar auditoría: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Asegurarse de cerrar la conexión
                }
            }
        }
        public void InsertarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "INSERT INTO tbl_mantenimiento VALUES (Pk_id_Mantenimiento, nombre_Solicitante, tipo_de_Mantenimiento, componente_Afectado, fecha, responsable_Asignado, codigo_Error_Problema, Estado, tiempo_Estimado, Fk_id_movimiento)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pk_id_Mantenimiento", idMantenimiento);
                cmd.Parameters.AddWithValue("@nombre_Solicitante", nombreSolicitante);
                cmd.Parameters.AddWithValue("@tipo_de_mantenimiento", tipoMantenimiento);
                cmd.Parameters.AddWithValue("@componente_Afectado", componenteAfectado);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@responsable_Asignado", responsableAsignado);
                cmd.Parameters.AddWithValue("@codigo_Error_Problema", codigo_error_Problema);
                cmd.Parameters.AddWithValue("@Estado", estadoMantenimiento);
                cmd.Parameters.AddWithValue("@tiempo_Estimado", tiempoEstimado);
                cmd.Parameters.AddWithValue("@Fk_id_movimiento", id_Movimiento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar solicitud de mantenimiento: " + ex.Message);

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Asegurarse de cerrar la conexión
                }
            }
        }

        public OdbcDataReader ObtenerProductosPorBodega(string idBodega) //realizado por José Daniel Sierra
        {
            OdbcDataReader dr = null;
            OdbcConnection conn = null;

            try
            {
                conn = cn.conexion(); // Establecer la conexión
                string query = "SELECT * FROM Tbl_Productos WHERE Fk_id_bodega = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fk_id_bodega", idBodega);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos: " + ex.Message);
                dr = null;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return dr;
        }
    }
}