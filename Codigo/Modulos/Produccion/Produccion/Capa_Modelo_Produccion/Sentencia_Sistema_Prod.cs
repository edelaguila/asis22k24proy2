using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion
{
    public class Sentencia_Sistema_Prod
    {
        private Conexion_Produccion conexion = new Conexion_Produccion();

        // Método para validar y asegurar que la conexión esté cerrada
        private void CerrarConexionSiAbierta(OdbcConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        // Método para insertar en tbl_proceso_produccion_encabezado
        public bool InsertarEncabezado(int idProceso, int idOrden, int idMaquinaria)
        {
            string query = "INSERT INTO tbl_proceso_produccion_encabezado (Pk_id_proceso, Fk_id_orden, Fk_id_maquinaria) VALUES (?, ?, ?)";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcCommand cmd = new OdbcCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idProceso", idProceso);
                cmd.Parameters.AddWithValue("@idOrden", idOrden);
                cmd.Parameters.AddWithValue("@idMaquinaria", idMaquinaria);

                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error ODBC al insertar encabezado: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar encabezado: " + ex.Message);
                    return false;
                }
                finally
                {
                    CerrarConexionSiAbierta(conn);
                }
            }
        }

        // Método para insertar en tbl_proceso_produccion_detalle
        public bool InsertarDetalle(int idProcesoDetalle, int idProducto, int idReceta, int idEmpleado, int idProceso, int cantidad, decimal costoU, decimal costoT, decimal duracionHoras, decimal manoDeObra, decimal costoLuz, decimal costoAgua)
        {
            string query = "INSERT INTO tbl_proceso_produccion_detalle (Pk_id_proceso_detalle, Fk_id_productos, Fk_id_receta, Fk_id_empleado, Fk_id_proceso, cantidad, costo_u, costo_t, duracion_horas, mano_de_obra, costo_luz, costo_agua) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcCommand cmd = new OdbcCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idProcesoDetalle", idProcesoDetalle);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@idReceta", idReceta);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@idProceso", idProceso);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@costoU", costoU);
                cmd.Parameters.AddWithValue("@costoT", costoT);
                cmd.Parameters.AddWithValue("@duracionHoras", duracionHoras);
                cmd.Parameters.AddWithValue("@manoDeObra", manoDeObra);
                cmd.Parameters.AddWithValue("@costoLuz", costoLuz);
                cmd.Parameters.AddWithValue("@costoAgua", costoAgua);

                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error de operación no válida al insertar detalle: " + ex.Message);
                    return false;
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error ODBC al insertar detalle: " + ex.Message);
                    return false;
                }
                finally
                {
                    CerrarConexionSiAbierta(conn);
                }
            }
        }

        // Método para obtener el último id de proceso en tbl_proceso_produccion_encabezado
        public DataTable ObtenerUltimoIdProceso()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MAX(Pk_id_proceso) AS Pk_id_proceso FROM tbl_proceso_produccion_encabezado";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el último id de proceso: " + ex.Message);
                }
                finally
                {
                    CerrarConexionSiAbierta(conn);
                }
            }
            return dt;
        }

        // Método para obtener el último id de detalle en tbl_proceso_produccion_detalle
        public DataTable ObtenerUltimoIdProcesoDetalle()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MAX(Pk_id_proceso_detalle) AS Pk_id_proceso_detalle FROM tbl_proceso_produccion_detalle";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    adapter.Fill(dt);
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error ODBC al obtener el último id de proceso detalle: " + ex.Message);
                }
                finally
                {
                    CerrarConexionSiAbierta(conn);
                }
            }
            return dt;
        }

        // Método para obtener el detalle de una orden de producción específica
        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Pk_id_detalle, Fk_id_producto, cantidad FROM tbl_ordenes_produccion_detalle WHERE Fk_id_orden = ?";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcCommand cmd = new OdbcCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idOrden", idOrden);
                using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open) conn.Open();
                        adapter.Fill(dt);
                    }
                    catch (OdbcException ex)
                    {
                        Console.WriteLine("Error ODBC al obtener detalle de la orden: " + ex.Message);
                    }
                    finally
                    {
                        CerrarConexionSiAbierta(conn);
                    }
                }
            }
            return dt;
        }

        // Método para obtener el producto y la receta asociados a un producto en tbl_recetas
        public DataTable ObtenerProductoYReceta(int idProducto)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Fk_id_producto AS idProducto, Pk_id_receta AS idReceta FROM tbl_recetas WHERE Fk_id_producto = ?";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcCommand cmd = new OdbcCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open) conn.Open();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener producto y receta: " + ex.Message);
                    }
                    finally
                    {
                        CerrarConexionSiAbierta(conn);
                    }
                }
            }
            return dt;
        }

        // Método para obtener órdenes de producción
        public DataTable ObtenerOrdenesProduccion()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Pk_id_orden, fecha_inicio, fecha_fin, cantidad FROM tbl_ordenes_produccion WHERE estado = 1";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener órdenes: " + ex.Message);
                }
                finally
                {
                    CerrarConexionSiAbierta(conn);
                }
            }
            return dt;
        }

        // Método para obtener maquinarias
        public DataTable ObtenerMaquinarias()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Pk_id_maquinaria, nombre_maquinaria FROM tbl_mantenimientos WHERE estado = 1";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener maquinarias: " + ex.Message);
                }
                finally
                {
                    CerrarConexionSiAbierta(conn);
                }
            }
            return dt;
        }

        // Método para obtener empleados
        public DataTable ObtenerEmpleados()
        {
            DataTable dt = new DataTable();
            string query = "SELECT pk_clave, nombre, apellido FROM tbl_empleados WHERE estado = 1";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener empleados: " + ex.Message);
                }
                finally
                {
                    CerrarConexionSiAbierta(conn);
                }
            }
            return dt;
        }

        // Método para obtener detalles de una receta específica
        public DataTable ObtenerRecetaDetalle(int idReceta)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Pk_id_detalle, Fk_id_producto, cantidad FROM tbl_receta_detalle WHERE Fk_id_receta = ?";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            using (OdbcCommand cmd = new OdbcCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idReceta", idReceta);
                using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open) conn.Open();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener detalle de receta: " + ex.Message);
                    }
                    finally
                    {
                        CerrarConexionSiAbierta(conn);
                    }
                }
            }
            return dt;
        }
    }
}
