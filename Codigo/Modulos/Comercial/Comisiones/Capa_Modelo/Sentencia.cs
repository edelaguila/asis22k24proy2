using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Sentencia
    {
        private Conexion cn = new Conexion();

        // Método para obtener el listado de vendedores
        public OdbcDataAdapter ObtenerVendedores()
        {
            string query = "SELECT Pk_id_vendedor, CONCAT(vendedores_nombre, ' ', vendedores_apellido) AS NombreCompleto FROM Tbl_vendedores";
            OdbcDataAdapter vendedoresAdapter = new OdbcDataAdapter(query, cn.conectar());
            return vendedoresAdapter;
            //bitacora
        }

        // Método para obtener ventas de un vendedor según filtros
        public OdbcDataAdapter ObtenerVentasPorVendedor(int idVendedor, string filtro, DateTime fechaInicio, DateTime fechaFin)
        {
            string query = $"SELECT Fk_id_factura AS IdVenta, factura_fecha AS FechaVenta, nombreProducto AS Producto, nombre_Marca AS Marca, nombre_linea AS Linea, PedidoDet_cantidad AS CantidadVendida, PedidoEnc_total AS Total " +
                           $"FROM Tbl_factura " +
                           $"JOIN Tbl_pedido_detalle ON Tbl_factura.Pk_id_factura = Tbl_pedido_detalle.Fk_id_pedidoEnc " +
                           $"JOIN Tbl_Productos ON Tbl_pedido_detalle.Fk_id_producto = Tbl_Productos.Pk_id_Producto " +
                           $"JOIN Tbl_Marca ON Tbl_Productos.fk_id_Producto = Tbl_Marca.Pk_id_Marca " +
                           $"JOIN Tbl_Linea ON Tbl_Marca.Pk_id_Marca = Tbl_Linea.Pk_id_linea " +
                           $"WHERE Tbl_pedido_encabezado.Fk_id_vendedor = {idVendedor} AND factura_fecha BETWEEN ? AND ?";

            //Filtro para cada opción (Inventario, Marca, Línea)
            switch (filtro)
            {
                case "Marcas":
                    query += " AND nombre_Marca = @Filtro";
                    break;
                case "Lineas":
                    query += " AND nombre_linea = @Filtro";
                    break;
                case "Inventario":
                    query += " AND Tbl_Productos.estado = 1"; // 1 = al estado del producto "activo"
                    break;
            }

            OdbcCommand command = new OdbcCommand(query, cn.conectar());
            command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@FechaFin", fechaFin);
            OdbcDataAdapter ventasAdapter = new OdbcDataAdapter(command);
            return ventasAdapter;
        }

        // Método para insertar un encabezado de comisión
        public void InsertarComisionEncabezado(int idVendedor, decimal totalVenta, decimal totalComision)
        {
            string query = "INSERT INTO Tbl_comisiones_encabezado (Fk_id_vendedor, Comisiones_fecha_, Comisiones_total_venta, Comisiones_total_comision) VALUES (?, ?, ?, ?)";
            using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
            {
                command.Parameters.AddWithValue("@Fk_id_vendedor", idVendedor);
                command.Parameters.AddWithValue("@Comisiones_fecha_", DateTime.Now);
                command.Parameters.AddWithValue("@Comisiones_total_venta", totalVenta);
                command.Parameters.AddWithValue("@Comisiones_total_comision", totalComision);
                command.ExecuteNonQuery();
            }
        }

        // Método para insertar un detalle de comisión
        public void InsertarComisionDetalle(int idComisionEnc, int idFactura, decimal porcentaje, decimal montoVenta, decimal montoComision)
        {
            string query = "INSERT INTO Tbl_detalle_comisiones (Fk_id_comisionEnc, Fk_id_factura, Comisiones_porcentaje, Comisiones_monto_venta, Comisiones_monto_comision) VALUES (?, ?, ?, ?, ?)";
            using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
            {
                command.Parameters.AddWithValue("@Fk_id_comisionEnc", idComisionEnc);
                command.Parameters.AddWithValue("@Fk_id_factura", idFactura);
                command.Parameters.AddWithValue("@Comisiones_porcentaje", porcentaje);
                command.Parameters.AddWithValue("@Comisiones_monto_venta", montoVenta);
                command.Parameters.AddWithValue("@Comisiones_monto_comision", montoComision);
                command.ExecuteNonQuery();
            }
        }

    }
}
