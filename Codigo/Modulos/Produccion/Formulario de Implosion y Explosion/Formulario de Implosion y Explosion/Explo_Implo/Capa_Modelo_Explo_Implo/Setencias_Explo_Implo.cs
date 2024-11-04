using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Explo_Implo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Sentencias_Explo_Implo
    {
        private Conexion_Explo_Implo conexion = new Conexion_Explo_Implo();

        public int ObtenerUltimo()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT MAX(Pk_id_explosion) FROM tbl_explosion";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;
                }
            } // La conexión se cierra automáticamente aquí
        }

        public void GuardarExplosion(int fkIdOrden, int fkIdProducto, int cantidad, int costoTotal, int duracionHoras, int fkIdProceso, DateTime fechaExplosion)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "INSERT INTO tbl_explosion (fk_id_orden, fk_id_Producto, cantidad, costo_total, duracion_horas, fk_id_proceso, fecha_explosion) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    command.Parameters.AddWithValue("?", fkIdOrden);
                    command.Parameters.AddWithValue("?", fkIdProducto);
                    command.Parameters.AddWithValue("?", cantidad);
                    command.Parameters.AddWithValue("?", costoTotal);
                    command.Parameters.AddWithValue("?", duracionHoras);
                    command.Parameters.AddWithValue("?", fkIdProceso);
                    command.Parameters.AddWithValue("?", fechaExplosion);

                    command.ExecuteNonQuery();
                }
            } // La conexión se cierra automáticamente aquí
        }

        public List<int> ObtenerIdsOrdenes()
        {
            List<int> ordenes = new List<int>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_orden FROM tbl_ordenes_produccion";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ordenes.Add(reader.GetInt32(0));
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return ordenes;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT pk_id_producto, nombreProducto FROM Tbl_Productos";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            });
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return productos;
        }

        public List<int> ObtenerIdsProcesos()
        {
            List<int> procesos = new List<int>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_proceso FROM tbl_proceso_produccion_encabezado";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            procesos.Add(reader.GetInt32(0));
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return procesos;
        }

        public DataTable ObtenerTodosExplosion()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_explosion";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            } // La conexión se cierra automáticamente aquí
        }
    }
}
