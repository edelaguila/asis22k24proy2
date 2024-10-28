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

namespace Capa_Modelo_ListaPrecios
{
    public class sentencia
    {
        private conexion cn;
        //conexion cn = new conexion();
        private string idUsuario;

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
            string sProductos = "SELECT codigoProducto, nombreProducto, clasificacion, pesoProducto, precioUnitario, stock, empaque FROM Tbl_productos WHERE clasificacion = ?";
            OdbcCommand command = new OdbcCommand(sProductos, cn.conectar());
            command.Parameters.AddWithValue("@clasificacion", clasificacion);
            OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);
            //funInsertarBitacora(idUsuario, "Realizo una consulta a modulos", "Tbl_modulos", "1000");
            return dataProductos;
        }

        public DataTable funConsultarproductos(string buscarTexto)
        {
            cn.conectar();

            // Modifica la consulta para buscar por código o nombre y agregar estado activo
            string sProductos = "SELECT codigoProducto, nombreProducto, clasificacion, pesoProducto, precioUnitario, stock, empaque " +
                                "FROM Tbl_productos " +
                                "WHERE estado = 'activo' " + 
                                "(codigoProducto LIKE ? OR nombreProducto LIKE ?)"; // Buscando por código o nombre

            using (OdbcCommand command = new OdbcCommand(sProductos, cn.conectar()))
            {
                // Establece los parámetros para la consulta
                command.Parameters.AddWithValue("@codigo", "%" + buscarTexto + "%"); // Para búsqueda por código
                command.Parameters.AddWithValue("@nombre", "%" + buscarTexto + "%"); // Para búsqueda por nombre

                OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);

               
                // funInsertarBitacora(idUsuario, "Realizó una búsqueda de productos", "Tbl_productos", "1000");


                DataTable tableProducto = new DataTable();
                dataProductos.Fill(tableProducto); // Llena el DataTable con los resultados

                return tableProducto; 
            }
        }

        public OdbcDataAdapter funconsultarClasificaciones()
        {

            /*cn.conectar(); // Conectar a la base de datos

            string sClasificaciones = "SELECT DISTINCT clasificacion FROM Tbl_productos WHERE estado = 1";

            OdbcDataAdapter dataClasificacion = new OdbcDataAdapter(sClasificaciones, cn.conectar());
            return dataClasificacion; */
            cn.conectar(); // Conectar a la base de datos

            // Crear un DataTable para almacenar las clasificaciones
            DataTable dtClasificaciones = new DataTable();

            // Consulta SQL para obtener clasificaciones generales
            string sClasificaciones = @"
        SELECT DISTINCT 'Línea' AS tipo 
        FROM tbl_lineas
        WHERE EXISTS (SELECT 1 FROM tbl_producto_linea WHERE fk_id_linea = pk_id_linea)
        UNION ALL
        SELECT DISTINCT 'Marca' AS tipo 
        FROM tbl_marcas
        WHERE EXISTS (SELECT 1 FROM tbl_producto_marca WHERE fk_id_marca = pk_id_marca)
        UNION ALL
        SELECT DISTINCT 'Inventario' AS tipo 
        FROM tbl_inventario
        WHERE EXISTS (SELECT 1 FROM tbl_producto_inventario WHERE fk_id_inventario = pk_id_inventario);
        ";

            OdbcDataAdapter dataClasificacion = new OdbcDataAdapter(sClasificaciones, cn.conectar());

          
            return dataClasificacion;


        }

        public DataTable ObtenerClasificacionesEspecificas(string tipoClasificacion)
        {
            DataTable dtClasificacionesEspecificas = new DataTable();
            //string sconsultaEspecifica = string.Empty;

            // Consulta SQL para obtener clasificaciones específicas
            string sconsultaEspecifica  = @"
        SELECT 'Línea' AS tipo, nombre_linea AS clasificacion 
        FROM tbl_lineas
        WHERE EXISTS (SELECT 1 FROM tbl_producto_linea WHERE fk_id_linea = pk_id_linea)
        UNION
        SELECT 'Marca' AS tipo, nombre_marca AS clasificacion 
        FROM tbl_marcas
        WHERE EXISTS (SELECT 1 FROM tbl_producto_marca WHERE fk_id_marca = pk_id_marca)
        UNION
        SELECT 'Inventario' AS tipo, descripcion_inventario AS clasificacion 
        FROM tbl_inventario
        WHERE EXISTS (SELECT 1 FROM tbl_producto_inventario WHERE fk_id_inventario = pk_id_inventario);
    ";

            using (OdbcDataAdapter adapter = new OdbcDataAdapter(sconsultaEspecifica, cn.conectar()))
            {
                adapter.Fill(dtClasificacionesEspecificas); // Llena el DataTable con los resultados
            }

            // Filtrar el DataTable para solo incluir la clasificación específica solicitada
            if (!string.IsNullOrEmpty(tipoClasificacion))
            {
                DataView dv = new DataView(dtClasificacionesEspecificas);
                dv.RowFilter = $"tipo = '{tipoClasificacion}'"; // Filtrar por el tipo de clasificación general
                dtClasificacionesEspecificas = dv.ToTable(); // Obtener el DataTable filtrado
            }

            return dtClasificacionesEspecificas;
    }
    


    public OdbcDataAdapter funconsultarProductosPorMarca(string nombreMarca)
        {
            cn.conectar();
            string sProductos = "SELECT p.codigoProducto, p.nombreProducto, p.clasificacion, p.pesoProducto, p.precioUnitario, p.stock, p.empaque " +
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

        public OdbcDataAdapter funconsultarProductosPorLinea(string nombreLinea)
        {
          
            cn.conectar();

            // Consulta SQL que utiliza el nombre de la línea directamente
            string sProductos = "SELECT codigoProducto, nombreProducto, clasificacion, pesoProducto, precioUnitario, stock, empaque " +
                                "FROM Tbl_productos " +
                                "WHERE clasificacion = @nombre_linea";

            using (OdbcCommand command = new OdbcCommand(sProductos, cn.conectar()))
            {
                // Añadir el parámetro con el valor de nombreLinea
                command.Parameters.AddWithValue("@nombreLinea", nombreLinea);

                OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);

                return dataProductos; // Retornar el DataAdapter
            }
        }

        public OdbcDataAdapter funconsultarProductosPorInventario(string nombreInventario)
        {
            // Conectar a la base de datos
            cn.conectar();
            
            string sProductos = "SELECT codigoProducto, nombreProducto, clasificacion, pesoProducto, precioUnitario, stock, empaque FROM Tbl_productos WHERE clasificacion IN (SELECT nombre_inventario FROM Tbl_inventarios WHERE nombre_inventario = ?)";
           
            using (OdbcCommand command = new OdbcCommand(sProductos, cn.conectar()))
            {
                command.Parameters.AddWithValue("@nombreInventario", nombreInventario);
      
                OdbcDataAdapter dataProductos = new OdbcDataAdapter(command);
              

                return dataProductos;
            }
        }

        public OdbcDataAdapter funconsultarLineas()
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
        }

        public OdbcDataAdapter funconsultarInventarios()
        {
            cn.conectar();
            string sInventarios = "SELECT Pk_id_Inventario, nombre_inventario FROM Tbl_inventarios"; 
            OdbcCommand command = new OdbcCommand(sInventarios, cn.conectar());
            OdbcDataAdapter dataInventarios = new OdbcDataAdapter(command);
            return dataInventarios;
        }

        public DataTable funcargarProductosPorClasificacion(string clasificacion)
        {
            DataTable dtResultados = new DataTable();

            string consulta = @"
        SELECT 
        'Linea' AS Clasificacion, 
        l.nombre_linea AS Tipo,
        p.codigoProducto AS Codigo,
        p.nombreProducto AS Producto,
        p.precioUnitario AS Precio_Unitario,
        p.precio_venta AS Precio_Venta,
        p.costo_compra AS Costo_Compra,
        p.pesoProducto AS Peso,
        p.stock AS Stock,
        p.empaque AS Empaque
    FROM 
        tbl_lineas l
    JOIN 
        tbl_producto_linea pl ON l.pk_id_linea = pl.fk_id_linea
    JOIN 
        tbl_productos p ON pl.fk_id_producto = p.Pk_id_Producto
    WHERE 
        p.estado = 1
    AND l.nombre_linea = ?

    UNION ALL

        SELECT      
        'Marca' AS Clasificacion, 
        m.nombre_marca AS Tipo, 
        p.codigoProducto AS Codigo,
        p.nombreProducto AS Producto,
        p.precioUnitario AS Precio_Unitario,
        p.precio_venta AS Precio_Venta,
        p.costo_compra AS Costo_Compra,
        p.pesoProducto AS Peso,
        p.stock AS Stock,
        p.empaque AS Empaque
    FROM 
        tbl_marcas m
    JOIN 
        tbl_producto_marca pm ON m.pk_id_marca = pm.fk_id_marca
    JOIN 
        tbl_productos p ON pm.fk_id_producto = p.Pk_id_Producto
    WHERE 
        p.estado = 1
    AND m.nombre_marca = ?

    UNION ALL   

        SELECT 
        'Inventario' AS Clasificacion, 
        i.descripcion_inventario AS Tipo, 
        p.codigoProducto AS Codigo,
        p.nombreProducto AS Producto,
        p.precioUnitario AS Precio_Unitario,
        p.precio_venta AS Precio_Venta,
        p.costo_compra AS Costo_Compra,
        p.pesoProducto AS Peso,
        p.stock AS Stock,
        p.empaque AS Empaque
    FROM 
        tbl_inventario i
    JOIN 
        tbl_producto_inventario pi ON i.pk_id_inventario = pi.fk_id_inventario
    JOIN 
        tbl_productos p ON pi.fk_id_producto = p.Pk_id_Producto
    WHERE 
        p.estado = 1
    AND i.descripcion_inventario = ?;";

            // Crear el DataAdapter y llenar el DataTable
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(consulta, cn.conectar()))
            {
                // Agregar los parámetros
                adapter.SelectCommand.Parameters.AddWithValue("?", clasificacion); // Para Línea
                adapter.SelectCommand.Parameters.AddWithValue("?", clasificacion); // Para Marca
                adapter.SelectCommand.Parameters.AddWithValue("?", clasificacion); // Para Inventario

                try
                {
                    adapter.Fill(dtResultados); // Llena el DataTable con los resultados
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }

            return dtResultados; // Retorna el DataTable resultante
        }
























    }
}
