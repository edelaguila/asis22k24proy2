using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion
{
    public class Sentencia_Implosion_Explosion
    {
        private Conexion_Produccion conexion = new Conexion_Produccion();

        // Método para obtener productos por serie (clasificación)
        public DataTable ObtenerProductosPorSerie(string serie)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT Pk_id_Producto, nombreProducto FROM tbl_productos WHERE clasificacion = ?";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("", serie);
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }

            return tabla;
        }

        // Método para obtener los materiales necesarios para un producto específico (Explosión)
        public DataTable ObtenerMaterialesParaProducto(int idProducto, int cantidadDeseada)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT p.nombreProducto, (r.cantidad * ?) AS cantidadNecesaria " +
                           "FROM tbl_receta_detalle r " +
                           "JOIN tbl_productos p ON r.Fk_id_producto = p.Pk_id_Producto " +
                           "WHERE r.Fk_id_receta = ?";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("", cantidadDeseada);
                        cmd.Parameters.AddWithValue("", idProducto);

                        Console.WriteLine($"Ejecutando consulta: {query} con cantidadDeseada={cantidadDeseada} y idProducto={idProducto}");

                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }

            return tabla;
        }

        // Método para obtener las recetas en las que se usa un material específico (Implosión)
        public DataTable ObtenerRecetasParaMaterial(int idMaterial)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT p.nombreProducto, r.cantidad FROM tbl_receta_detalle r " +
                           "JOIN tbl_recetas rec ON r.Fk_id_receta = rec.Pk_id_receta " +
                           "JOIN tbl_productos p ON rec.Fk_id_producto = p.Pk_id_Producto " +
                           "WHERE r.Fk_id_producto = ?";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("", idMaterial);
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }

            return tabla;
        }

        // Método para obtener materias primas
        public DataTable ObtenerMateriasPrimas()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT Pk_id_Producto, nombreProducto FROM tbl_productos WHERE clasificacion = 'Materia Prima'";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }

            return tabla;
        }

        // Método para obtener productos terminados
        public DataTable ObtenerProductosTerminados()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT Pk_id_Producto, nombreProducto FROM tbl_productos WHERE clasificacion = 'Producto Terminado'";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }

            return tabla;
        }
    }
}
