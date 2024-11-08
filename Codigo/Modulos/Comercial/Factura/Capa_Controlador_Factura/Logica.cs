using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Modelo_Factura;

namespace Capa_Controlador_Factura
{
    public class Logica
    {
        Sentencia sn;

        public Logica()
        {
            sn = new Sentencia();
        }




        public string[] funitems(string stabla, string scampo1, string scampo2)
        {
            string[] Items = sn.funllenarCmb(stabla, scampo1, scampo2);

            return Items;




        }

        public DataTable funenviar(string stabla, string scampo1, string scampo2)
        {

            var dt = sn.funobtener(stabla, scampo1, scampo2);

            return dt;
        }

        /// ////////////////////////////


        public string[] funitems1P(string stabla)
        {
            // Obtener los datos usando la función modificada anteriormente
            DataTable dt = sn.funobtenerP(stabla);

            // Crear un arreglo para los items
            string[] items = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Formato "ID-Nombre"
                items[i] = dt.Rows[i]["Fk_id_Producto"].ToString() + "-" + dt.Rows[i]["Producto_nombre"].ToString();
            }

            return items;
        }

        public DataTable funenviar1P(string stabla)
        {
            // Usar la función modificada para obtener el DataTable con ID y nombre
            var dt1 = sn.funobtenerP(stabla);
            return dt1;
        }

        public DataTable funllenarProducto1(string idcliente, string idProducto)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.prollenadoProducto1(idcliente, idProducto))
                {
                    DataTable tableProducto = new DataTable();
                    cmpsAplicaciones.Fill(tableProducto);
                    return tableProducto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }

        }

        public DataTable funllenarProducto2(string idProducto)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.prollenadoProducto2(idProducto))
                {
                    DataTable tableProducto = new DataTable();
                    cmpsAplicaciones.Fill(tableProducto);
                    return tableProducto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }

        }

        public DataTable funllenarCliente(string idcliente)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.prollenadoCliente(idcliente)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableProducto = new DataTable();
                    cmpsAplicaciones.Fill(tableProducto);
                    return tableProducto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }

        }




        public string[] funitemsP(string stabla, string scampo1, string scampo2)
        {
            // Obtener los datos usando la función modificada
            DataTable dt = funenviarP(stabla, scampo1, scampo2);

            // Crear un arreglo para los items
            string[] items = new string[dt.Rows.Count];

            // Recorrer cada fila y formar el string con el ID del pedido y el nombre del cliente
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Formato "ID_Pedido - Nombre Cliente"
                items[i] = dt.Rows[i]["Pk_id_pedidoEnc"].ToString() + "-" + dt.Rows[i]["Clientes_nombre"].ToString() + " " + dt.Rows[i]["Clientes_apellido"].ToString();
            }

            return items;
        }

        public DataTable funenviarP(string stabla, string scampo1, string scampo2)
        {
            // Usar la función modificada para obtener el DataTable con el ID del pedido y el nombre del cliente
            var dt1 = sn.funobtener1(stabla, scampo1, scampo2);
            return dt1;
        }


        public bool insertarEncabezado(string IdFactura, string IdVendedor, string IdClientes, string IdPedido, DateTime FechaCre, DateTime FechaVen, string FormaP, string subtotale, string Iva, string TotalT)
        {
            try
            {
                sn.funInsertarFacturaE(IdFactura, IdVendedor, IdClientes, IdPedido, FechaCre, FechaVen, FormaP, subtotale, Iva, TotalT);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el Encabezado: " + ex.Message);
                return false;
            }
        }

        public bool insertarDetalle(int IdFactura, int IdProducto, int Cantidad, decimal Precio, decimal Subtotal)
        {
            try
            {
                sn.funInsertarFacturaD(IdFactura, IdProducto, Cantidad, Precio, Subtotal);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el Detalle: " + ex.Message);
                return false;
            }
        }

        public class DetalleCotizacion
        {
            public string IdFactura { get; set; }
            public int IdProducto { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Subtotal { get; set; }
        }

        private int funObtenerUltimoIdComisionEncabezado()
        {
            // Consulta para obtener el último ID de comisión encabezado
            return 0; // Implementación pendiente
        }



    }
}
