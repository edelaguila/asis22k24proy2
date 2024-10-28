using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Logica
    {

        private Sentencia sn = new Sentencia();

        public class DetalleComision
        {
            public int IdFactura { get; set; }         // ID de la factura asociada al detalle de comisión
            public decimal Porcentaje { get; set; }     // Porcentaje de comisión
            public decimal MontoVenta { get; set; }     // Monto de la venta
            public decimal MontoComision { get; set; }  // Monto de la comisión calculada
        }


        public DataTable ObtenerVendedores()
        {
            OdbcDataAdapter adapter = sn.ObtenerVendedores();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ObtenerVentasFiltradas(int idVendedor, string filtro, DateTime fechaInicio, DateTime fechaFin)
        {
            OdbcDataAdapter adapter = sn.ObtenerVentasPorVendedor(idVendedor, filtro, fechaInicio, fechaFin);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void GuardarComision(int idVendedor, decimal totalVenta, decimal totalComision, List<DetalleComision> detalles)
        {
            // Insertamos el encabezado de la comisión
            sn.InsertarComisionEncabezado(idVendedor, totalVenta, totalComision);

            // Obtenemos el último ID de encabezado para asociar los detalles
            int idComisionEnc = ObtenerUltimoIdComisionEncabezado();

            // Insertamos cada detalle de comisión
            foreach (var detalle in detalles)
            {
                sn.InsertarComisionDetalle(idComisionEnc, detalle.IdFactura, detalle.Porcentaje, detalle.MontoVenta, detalle.MontoComision);
            }
        }

        private int ObtenerUltimoIdComisionEncabezado()
        {
            // Consulta para obtener el último ID de comisión encabezado
            // Dependiendo de la BD, es posible que necesites implementar esta lógica con una consulta SELECT MAX() o una secuencia específica
            return 0; // Implementación pendiente
        }

    }
}
