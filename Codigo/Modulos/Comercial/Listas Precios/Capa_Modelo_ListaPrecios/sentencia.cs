using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Net;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_ListaPrecios
{
    public class sentencia
    {
        private conexion cn;
        //conexion cn = new conexion();
        private string idUsuario;
        public string sIdUsuario { get; set; }

        public sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
            cn = new conexion();
        }

        public sentencia()
        {

        }

        
        public OdbcDataAdapter funconsultarproductos(string clasificacion) 
        {
            cn.conectar();
            string sProductos = "SELECT codigoProducto, nombreProducto, clasificacion, precioUnitario FROM Tbl_productos WHERE clasificacion = ?";
            OdbcCommand command = new OdbcCommand(sProductos, cn.conectar());
            command.Parameters.AddWithValue("@clasificacion", clasificacion);
            OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);
            //var bitacora = new Capa_Modelo_Seguridad.sentencia();
            //bitacora.funInsertarBitacora(idUsuario, "Realizo una consulta a productos", "Tbl_productos", "3000");
            return dataProductos;
        }

        //Para busqueda por inventario (búsquesa individual por nombre o código)
        /*public DataTable funConsultarproductos(string buscarTexto)
        {
            cn.conectar();

            // Modifica la consulta para buscar por código o nombre y agregar estado activo
            string sProductos = "SELECT codigoProducto, nombreProducto, clasificacion, pesoProducto, precioUnitario, stock, empaque " +
                                "FROM Tbl_productos " +
                                "WHERE estado = 'activo' " + // Asegúrate de tener una columna `estado`
                                "(codigoProducto LIKE ? OR nombreProducto LIKE ?)"; // Buscando por código o nombre

            using (OdbcCommand command = new OdbcCommand(sProductos, cn.conectar()))
            {
                command.Parameters.AddWithValue("@codigo", "%" + buscarTexto + "%"); // Para búsqueda por código
                command.Parameters.AddWithValue("@nombre", "%" + buscarTexto + "%"); // Para búsqueda por nombre

                OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);

                // funInsertarBitacora(idUsuario, "Realizó una búsqueda de productos", "Tbl_productos", "1000");


                DataTable tableProducto = new DataTable();
                dataProductos.Fill(tableProducto); // Llena el DataTable con los resultados

                return tableProducto;
            }
        }*/

        //Para la obtención de clasificaciones generales de los productos (por línea o marca) falta agregar otra clasificación
        public OdbcDataAdapter funconsultarClasificaciones()
        {
            cn.conectar();

            //DataTable dtClasificaciones = new DataTable();

            string sClasificaciones = @"
        SELECT DISTINCT 'Línea' AS tipo 
        FROM Tbl_Linea
        WHERE fk_id_marca IS NOT NULL
        UNION ALL
        SELECT DISTINCT 'Marca' AS tipo 
        FROM Tbl_Marca
        WHERE fk_id_Producto IS NOT NULL";

            OdbcDataAdapter dataClasificacion = new OdbcDataAdapter(sClasificaciones, cn.conectar());
            //var bitacora = new Capa_Modelo_Seguridad.sentencia();
            //bitacora.funInsertarBitacora(idUsuario, "Realizo una consulta a productos", "Tbl_Linea", "3000");

            return dataClasificacion;
        }

        //Obtener las clasificaciones específicas que se encuentra en la tabla de productos
        public DataTable ObtenerClasificacionesEspecificas(string tipoClasificacion)
        {
            DataTable dtClasificacionesEspecificas = new DataTable();

            // Consulta SQL para obtener clasificaciones específicas
            string sconsultaEspecifica = @"
        SELECT 'Línea' AS tipo, nombre_linea AS clasificacion 
        FROM Tbl_Linea
        WHERE fk_id_marca IS NOT NULL
        UNION
        SELECT 'Marca' AS tipo, nombre_marca AS clasificacion 
        FROM Tbl_Marca
        WHERE fk_id_Producto IS NOT NULL";

            using (OdbcDataAdapter adapter = new OdbcDataAdapter(sconsultaEspecifica, cn.conectar()))
            {
                adapter.Fill(dtClasificacionesEspecificas); 
            }

            if (!string.IsNullOrEmpty(tipoClasificacion))
            {
                DataView dv = new DataView(dtClasificacionesEspecificas);
                dv.RowFilter = $"tipo = '{tipoClasificacion}'"; // Filtrar por el tipo de clasificación
                dtClasificacionesEspecificas = dv.ToTable();
                //var bitacora = new Capa_Modelo_Seguridad.sentencia();
                //bitacora.funInsertarBitacora(idUsuario, "Realizo una consulta a productos", "Tbl_Linea", "3000");
            }

            return dtClasificacionesEspecificas;
        }


        //filtrar productos según marca
        /*public OdbcDataAdapter funconsultarProductosPorMarca(string nombreMarca)
        {
            cn.conectar();
            string sProductos = "SELECT p.codigoProducto, p.nombreProducto, p.clasificacion, p.precioUnitario" +
                        "FROM Tbl_productos p " +
                        "JOIN tbl_producto_marca pm ON p.Pk_id_Producto = pm.fk_id_producto " +
                        "JOIN tbl_marcas m ON pm.fk_id_marca = m.pk_id_marca " +
                        "WHERE m.nombre_marca = ?";

            using (OdbcCommand command = new OdbcCommand(sProductos, cn.conectar()))
            {
                command.Parameters.AddWithValue("@nombreMarca", nombreMarca);
                OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);

                return dataProductos;
            }
        }
        */

        //filtrar productos por linea
        /*public OdbcDataAdapter funconsultarProductosPorLinea(string nombreLinea)
        {
            cn.conectar();

            // Consulta SQL que utiliza el nombre de la línea directamente
            string sProductos = "SELECT codigoProducto, nombreProducto, clasificacion, pesoProducto, precioUnitario, stock, empaque " +
                                "FROM Tbl_productos " +
                                "WHERE clasificacion = @nombre_linea";

            using (OdbcCommand command = new OdbcCommand(sProductos, cn.conectar()))
            {
                command.Parameters.AddWithValue("@nombreLinea", nombreLinea);

                OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);

                return dataProductos; 
            }
        }*/

        //filtrar productos por inventario
        public DataTable funconsultarProductosPorInventario()
        {
            try
            {
                string query = "SELECT codigoProducto, nombreProducto FROM Tbl_productos";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                DataTable dtProductos = new DataTable();
                adapter.Fill(dtProductos);
                return dtProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener nombres y códigos de productos: " + ex.Message);
            }
            //var bitacora = new Capa_Modelo_Seguridad.sentencia();
            //bitacora.funInsertarBitacora(idUsuario, "Realizo una consulta a productos", "Tbl_Linea", "3000");
        }

        /* public OdbcDataAdapter funconsultarLineas()
         {
             cn.conectar();
             string sLineas = "SELECT Pk_id_Linea, nombre_linea FROM Tbl_lineas"; 
             OdbcCommand command = new OdbcCommand(sLineas, cn.conectar());
             OdbcDataAdapter dataLineas = new OdbcDataAdapter(command);
             return dataLineas;
         }

         public OdbcDataAdapter funconsultarMarcas()
         {
             cn.conectar();
             string sMarcas = "SELECT Pk_id_Marca, nombre_marca FROM Tbl_marcas"; 
             OdbcCommand command = new OdbcCommand(sMarcas, cn.conectar());
             OdbcDataAdapter dataMarcas = new OdbcDataAdapter(command);
             return dataMarcas;
         }*/

        /*public OdbcDataAdapter funconsultarInventarios()
        {
            cn.conectar();
            string sInventarios = "SELECT Pk_id_Inventario, nombre_inventario FROM Tbl_inventarios"; // Asegúrate de que estos campos existan
            OdbcCommand command = new OdbcCommand(sInventarios, cn.conectar());
            OdbcDataAdapter dataInventarios = new OdbcDataAdapter(command);
            return dataInventarios;
        }*/

        // Muestra los productos filtrados al realizar seleccion general>especifica>productos
        public DataTable funcargarProductosPorClasificacion(string clasificacion)
        {
            DataTable dtResultados = new DataTable();

            string consulta = @"
        SELECT 
            CASE 
                WHEN l.nombre_linea IS NOT NULL THEN 'Linea'
                ELSE 'Marca'
            END AS Clasificacion,
            COALESCE(l.nombre_linea, m.nombre_marca) AS Tipo,
            p.Pk_id_Producto AS Id,
            p.codigoProducto AS Codigo,
            p.nombreProducto AS Producto,
            p.precioUnitario AS Precio_Unitario,
            p.precio_venta AS Precio_Venta,
            p.costo_compra AS Costo_Compra
        FROM 
            tbl_productos p
        LEFT JOIN 
            Tbl_Marca m ON m.fk_id_Producto = p.Pk_id_Producto
        LEFT JOIN 
            Tbl_Linea l ON l.fk_id_marca = m.Pk_id_Marca
        WHERE 
            p.estado = 1
            AND ((l.nombre_linea = ? AND m.nombre_marca IS NOT NULL) -- Búsqueda por línea
                 OR (m.nombre_marca = ? AND l.nombre_linea IS NULL)); -- Búsqueda por marca";

            using (OdbcDataAdapter adapter = new OdbcDataAdapter(consulta, cn.conectar()))
            {
                // Agregar el parámetro clasificacion dos veces, una para cada posible coincidencia
                adapter.SelectCommand.Parameters.AddWithValue("?", clasificacion); // Para Línea
                adapter.SelectCommand.Parameters.AddWithValue("?", clasificacion); // Para Marca

                try
                {
                    adapter.Fill(dtResultados);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }

            return dtResultados;
        }


            public DataTable funcargarProductosPorCodigoONombre(string sbusqueda)
        {
            DataTable dtResultados = new DataTable();

            string consulta = @"
        SELECT 
            'Línea' AS Clasificacion, 
            l.nombre_linea AS Tipo,
            p.Pk_id_Producto AS Id,
            p.codigoProducto AS Codigo,
            p.nombreProducto AS Producto,
            p.precioUnitario AS Precio_Unitario,
            p.precio_venta AS Precio_Venta,
            p.costo_compra AS Costo_Compra
        FROM 
            Tbl_Linea l
        JOIN 
            Tbl_Marca m ON l.fk_id_marca = m.Pk_id_Marca
        JOIN 
            tbl_productos p ON m.fk_id_Producto = p.Pk_id_Producto
        WHERE 
            p.estado = 1
        AND (
            p.codigoProducto = ? OR 
            p.nombreProducto LIKE ?
            )

        UNION ALL

        SELECT      
            'Marca' AS Clasificacion, 
            m.nombre_marca AS Tipo, 
            p.Pk_id_Producto AS Id,
            p.codigoProducto AS Codigo,
            p.nombreProducto AS Producto,
            p.precioUnitario AS Precio_Unitario,
            p.precio_venta AS Precio_Venta,
            p.costo_compra AS Costo_Compra
        FROM 
            Tbl_Marca m
        JOIN 
            tbl_productos p ON m.fk_id_Producto = p.Pk_id_Producto
        WHERE 
            p.estado = 1
        AND (
            p.codigoProducto = ? OR 
            p.nombreProducto LIKE ?
        );";

            using (OdbcDataAdapter adapter = new OdbcDataAdapter(consulta, cn.conectar()))
            {
                string sbusquedaParam = $"{ sbusqueda}%"; // Permitir autocompletar

                // Agregar los parámetros para Línea
                adapter.SelectCommand.Parameters.AddWithValue("?", sbusquedaParam); // Para código
                adapter.SelectCommand.Parameters.AddWithValue("?", sbusquedaParam); // Para nombre

                // Agregar los parámetros para Marca
                adapter.SelectCommand.Parameters.AddWithValue("?", sbusquedaParam); // Para código
                adapter.SelectCommand.Parameters.AddWithValue("?", sbusquedaParam); // Para nombre

                try
                {
                    adapter.Fill(dtResultados); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }

            return dtResultados; 
        }

        //procedimiento de guardado de la creacion de la lista
        /*public void proinsertarlista(int iListaEncabezado, int iProducto, decimal dPrecioLista)
        {
            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    string query = "INSERT INTO Tbl_lista_detalle (" +
                                   "Fk_id_lista_Encabezado, " +
                                   "Fk_id_Producto, " +
                                   "ListDetalle_precio) " +
                                   "VALUES (?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        //cmd.Parameters.AddWithValue("@Pk_id_lista_det", iCodigo);
                        cmd.Parameters.AddWithValue("?", iListaEncabezado);
                        cmd.Parameters.AddWithValue("?", iProducto);
                        cmd.Parameters.AddWithValue("?", dPrecioLista);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        //funInsertarBitacora(idUsuario, "Inserto un nuevo modulo: " + sCodigo + " - " + sNombre, "tbl_modulos", "1000");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar módulo: " + ex.Message);
            }
        }*/

        //llenado de combo para saber que tipo de lista sera (minorista, mayoristas, etc)
        public OdbcDataAdapter funClasificacionLista()
        {
            cn.conectar();
            string sClasificaciones = "SELECT Pk_id_clasificacion, nombre_clasificacion AS Clasificaciones FROM Tbl_clasificacionLista;";
            OdbcDataAdapter dataClasificaciones = new OdbcDataAdapter(sClasificaciones, cn.conectar());
            
            // Insertar registro en la bitácora
            var bitacora = new Capa_Modelo_Seguridad.sentencia();
            bitacora.funInsertarBitacora(idUsuario, "Realizo una consulta a clasificación Lista de Precios", "Tbl_clasificacionLista", "3000");
            return dataClasificaciones;
        }

        //insercion en bd del encabezado de la lista
        public void proinsertarlistaEncabezado(int iCodigoEncabezado, int iClasificacion, DateTime sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    string query = "INSERT INTO Tbl_lista_encabezado (" +
                                   "Pk_id_lista_Encabezado, " +
                                   "Fk_id_clasificacion, " +
                                   "ListEncabezado_fecha, " +
                                   "estado) " +
                                   "VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", iCodigoEncabezado);
                        cmd.Parameters.AddWithValue("?", iClasificacion);
                        cmd.Parameters.AddWithValue("?", sFecha.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?", sEstado == "Activo" ? 1 : 0);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Insertar registro en la bitácora
                        var bitacora = new Capa_Modelo_Seguridad.sentencia();
                        bitacora.funInsertarBitacora(idUsuario, "Inserto un nuevo encabezado de lista: " + iCodigoEncabezado, "Tbl_lista_encabezado", "1000");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar módulo: " + ex.Message);
            }

        }


        //insersion en bd del detalle de la lista
        public void proinsertarlistaDetalle(int iCodigoEncabezado, int iCodigoProducto, decimal dPrecioLista)
        {
            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    string query = "INSERT INTO Tbl_lista_detalle (" +
                                   "Fk_id_lista_Encabezado, " +
                                   "Fk_id_Producto, " +
                                   "ListDetalle_precio) " +
                                   "VALUES (?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", iCodigoEncabezado);
                        cmd.Parameters.AddWithValue("?", iCodigoProducto);
                        cmd.Parameters.AddWithValue("?", dPrecioLista);

                        cmd.ExecuteNonQuery();

                        // Insertar registro en la bitácora
                        var bitacora = new Capa_Modelo_Seguridad.sentencia();
                        bitacora.funInsertarBitacora(idUsuario, "Inserto Detalle de lista: " + iCodigoEncabezado, "Tbl_lista_detalle", "1000");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar detalle: " + ex.Message);
            }
        }


        //obtencion de encabezados de la lista
        public DataTable funmostarEncabezados()
        {
            try
            {
                cn.conectar();
                string sencabezado = "SELECT le.Pk_id_lista_Encabezado AS 'Codigo Lista', " +
                                     "c.nombre_clasificacion AS 'Tipo de Lista', " +
                                     "le.ListEncabezado_fecha AS 'Fecha Creacion', " +
                                     "le.estado AS 'Estado' " +
                                     "FROM Tbl_lista_encabezado le " +
                                     "JOIN tbl_clasificacionlista c ON le.Fk_id_clasificacion = c.pk_id_clasificacion";

                OdbcDataAdapter dataencabezados = new OdbcDataAdapter(sencabezado, cn.conectar());
                DataTable tableEncabezados = new DataTable();
                dataencabezados.Fill(tableEncabezados);

                // Insertar registro en la bitácora
                var bitacora = new Capa_Modelo_Seguridad.sentencia();
                bitacora.funInsertarBitacora(idUsuario, "Consultó los encabezados de lista: ", "Tbl_lista_encabezado", "1000");

                return tableEncabezados; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //filtros de busqueda
        public OdbcDataAdapter funmostarEncabezadosPorEstado(string sestado)
        {
            string sencabezado = "SELECT le.Pk_id_lista_Encabezado AS 'Codigo de Lista', " +
                                 "c.nombre_clasificacion AS 'Para', " +
                                 "le.ListEncabezado_fecha AS 'Fecha de Creacion', " +
                                 "le.estado AS 'Estado' " +
                                 "FROM Tbl_lista_encabezado le " +
                                 "JOIN tbl_clasificacionlista c ON le.Fk_id_clasificacion = c.pk_id_clasificacion " +
                                 "WHERE le.estado = ?";

            OdbcDataAdapter dataencabezados = new OdbcDataAdapter(sencabezado, cn.conectar());
            // Usa el valor 1 para 'Activo' y 0 para cualquier otro estado.
            dataencabezados.SelectCommand.Parameters.AddWithValue("estado", sestado == "Activo" ? 1 : 0);

            // Insertar registro en la bitácora
            var bitacora = new Capa_Modelo_Seguridad.sentencia();
            bitacora.funInsertarBitacora(idUsuario, "Consultó los encabezados de lista por estado: ", "Tbl_lista_encabezado", "1000");

            return dataencabezados;
        }

        public OdbcDataAdapter funmostarEncabezadosPorTipo(string stipoLista)
        {
            string sencabezado = "SELECT le.Pk_id_lista_Encabezado AS 'Codigo de Lista', " +
                                 "c.nombre_clasificacion AS 'Para', " +
                                 "le.ListEncabezado_fecha AS 'Fecha de Creacion', " +
                                 "le.estado AS 'Estado' " +
                                 "FROM Tbl_lista_encabezado le " +
                                 "JOIN tbl_clasificacionlista c ON le.Fk_id_clasificacion = c.pk_id_clasificacion " +
                                 "WHERE c.nombre_clasificacion = ?";

            OdbcDataAdapter dataencabezados = new OdbcDataAdapter(sencabezado, cn.conectar());

            dataencabezados.SelectCommand.Parameters.AddWithValue("nombre_clasificacion", stipoLista);

            // Insertar registro en la bitácora
            var bitacora = new Capa_Modelo_Seguridad.sentencia();
            bitacora.funInsertarBitacora(idUsuario, "Consultó los encabezados de lista por tipo: ", "Tbl_lista_encabezado", "1000");

            return dataencabezados;
        }

        public OdbcDataAdapter funObtenerTiposDeLista()
        {
            cn.conectar();
            string sClasificaciones = "SELECT Pk_id_clasificacion, nombre_clasificacion AS Clasificaciones FROM Tbl_clasificacionLista;";
            OdbcDataAdapter dataClasificaciones = new OdbcDataAdapter(sClasificaciones, cn.conectar());

            // Insertar registro en la bitácora
            var bitacora = new Capa_Modelo_Seguridad.sentencia();
            bitacora.funInsertarBitacora(idUsuario, "Consultó tipos de lista: ", "Tbl_clasificacionLista", "1000");

            return dataClasificaciones;
        }

        //eliminar lista ya creada
        public void proeliminarlista(int idEncabezado)
        {
            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                   
                    // Eliminar detalles primero
                    string queryDetalles = "DELETE FROM Tbl_lista_detalle WHERE Fk_id_lista_Encabezado = ?";
                    using (OdbcCommand commandDetalles = new OdbcCommand(queryDetalles, connection))
                    {
                        commandDetalles.Parameters.AddWithValue("?", idEncabezado);
                        commandDetalles.ExecuteNonQuery();
                    }

                    // Luego eliminar el encabezado
                    string queryEncabezado = "DELETE FROM Tbl_lista_encabezado WHERE Pk_id_lista_Encabezado = ?";
                    using (OdbcCommand commandEncabezado = new OdbcCommand(queryEncabezado, connection))
                    {
                        commandEncabezado.Parameters.AddWithValue("?", idEncabezado);
                        commandEncabezado.ExecuteNonQuery();
                    }
                    // Insertar registro en la bitácora
                    var bitacora = new Capa_Modelo_Seguridad.sentencia();
                    bitacora.funInsertarBitacora(idUsuario, "Eliminó lista de precios: ", "Tbl_lista_detalle", "1000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar encabezado y detalles: " + ex.Message);
            }
        }

        //obtener el detalle para la edicion
        public DataTable funobtenerdetalleEncabezado(int idEncabezado)
        {
            DataTable tableDetalle = new DataTable();

            try
            {
                cn.conectar();
                string sdetalle = @"
        SELECT 
            'Linea' AS 'Clasificacion Producto', 
            l.nombre_linea AS Subclasificacion,
            p.Pk_id_Producto AS Id,
            p.precio_venta AS Precio_Venta,
            p.nombreProducto AS Producto,
            p.codigoProducto AS 'Codigo Producto',
            d.ListDetalle_precio AS 'Precio Lista'
        FROM 
            Tbl_lista_encabezado e
        JOIN 
            Tbl_lista_detalle d ON e.Pk_id_lista_Encabezado = d.Fk_id_lista_Encabezado
        JOIN 
            tbl_productos p ON d.Fk_id_Producto = p.Pk_id_Producto
        JOIN 
            Tbl_Marca m ON m.fk_id_Producto = p.Pk_id_Producto
        JOIN 
            Tbl_Linea l ON l.fk_id_marca = m.Pk_id_Marca
        WHERE 
            e.Pk_id_lista_Encabezado = ? 
            AND p.estado = 1

        UNION ALL

        SELECT
            'Marca' AS 'Clasificacion Producto', 
            m.nombre_marca AS Subclasificacion,
            p.Pk_id_Producto AS Id,
            p.precio_venta AS Precio_Venta,
            p.nombreProducto AS Producto,
            p.codigoProducto AS 'Codigo Producto',
            d.ListDetalle_precio AS 'Precio Lista' 
        FROM 
            Tbl_lista_encabezado e
        JOIN 
            Tbl_lista_detalle d ON e.Pk_id_lista_Encabezado = d.Fk_id_lista_Encabezado
        JOIN 
            tbl_productos p ON d.Fk_id_Producto = p.Pk_id_Producto
        JOIN 
            Tbl_Marca m ON m.fk_id_Producto = p.Pk_id_Producto
        WHERE 
            e.Pk_id_lista_Encabezado = ? 
            AND p.estado = 1;";

                OdbcDataAdapter datadetalle = new OdbcDataAdapter(sdetalle, cn.conectar());
                datadetalle.SelectCommand.Parameters.AddWithValue("@CodigoEncabezado", idEncabezado);
                datadetalle.SelectCommand.Parameters.AddWithValue("@CodigoEncabezado", idEncabezado);

                datadetalle.Fill(tableDetalle);

                // Insertar registro en la bitácora
                var bitacora = new Capa_Modelo_Seguridad.sentencia();
                bitacora.funInsertarBitacora(idUsuario, "Consultó detalle de Lista: ", "Tbl_lista_encabezado", "1000");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

            return tableDetalle; 
        }

        //actualizacion

        public OdbcDataAdapter proactualizarListaEncabezado(int iCodigoEncabezado, int iClasificacion, DateTime sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    // Consulta SQL para actualizar los datos del encabezado
                    string query = "UPDATE Tbl_lista_encabezado SET " +
                                   "Fk_id_clasificacion = ?, " +
                                   "ListEncabezado_fecha = ?, " +
                                   "estado = ? " +
                                   "WHERE Pk_id_lista_Encabezado = ?";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", iClasificacion);
                        cmd.Parameters.AddWithValue("?", sFecha.ToString("yyyy-MM-dd"));  // Convertir la fecha 
                        cmd.Parameters.AddWithValue("?", sEstado == "Activo" ? 1 : 0);    // Convertir "Activo" a 1, otros a 0
                        cmd.Parameters.AddWithValue("?", iCodigoEncabezado);  // Código del encabezado a actualizar

                        cmd.ExecuteNonQuery();
                    }
                    // Insertar registro en la bitácora
                    var bitacora = new Capa_Modelo_Seguridad.sentencia();
                    bitacora.funInsertarBitacora(idUsuario, "Actualizó encabezado de Lista: ", "Tbl_lista_encabezado", "1000");
                }
                // Si la actualización fue exitosa, retornar
                return new OdbcDataAdapter("SELECT * FROM Tbl_lista_encabezado WHERE Pk_id_lista_Encabezado = ?", cn.conectar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar encabezado: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter funactualizarDetalle(int fkIdListaEncabezado, int fkIdProducto, decimal precio)
        {
            try
            {
                string sqlActualizarDetalle = "UPDATE tbl_lista_detalle SET ListDetalle_precio = '" + precio + "' WHERE Fk_id_lista_Encabezado = '" + fkIdListaEncabezado + "' AND Fk_id_Producto = '" + fkIdProducto + "'";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlActualizarDetalle, cn.conectar());

                // Insertar registro en la bitácora
                var bitacora = new Capa_Modelo_Seguridad.sentencia();
                bitacora.funInsertarBitacora(idUsuario, "Actualizó detalle de Lista: ", "tbl_lista_detalle", "1000");

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar detalle: " + ex.Message);
                return null; // Si hay un error, retorna null
            }
        }
    }
}
