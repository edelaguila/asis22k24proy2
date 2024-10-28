using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace Capa_Modelo_OrdenCompra
{
    public class sentencia
    {
        conexion cn = new conexion();


        public sentencia()
        {

        }


        public string[] funllenarCmb(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtener(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }




        public OdbcDataAdapter funProductos()
        {
            cn.conectar();
            string sqlProductos = "SELECT Pk_id_Producto AS Id_Producto, codigoProducto AS Codigo, nombreProducto AS Nombre, pesoProducto AS Peso, precioUnitario AS Precio_Unitario, clasificacion AS Clasificacion, estado AS Estado, stock AS Stock, empaque AS Empaque FROM Tbl_Productos";
            OdbcDataAdapter dataProducto = new OdbcDataAdapter(sqlProductos, cn.conectar());
            return dataProducto;
        }







        public OdbcDataAdapter funMostrarOrdenesGeneradas(string sTablaOrdenesCompra)
        {
            try
            {
                string sql = @"
                            SELECT 
                        doc.Pk_detOrCom_id AS ID_Detalle,
                        oc.Pk_encOrCom_id AS ID_Encabezado,
                        p.Pk_id_Producto AS Producto,
                        p.precioUnitario AS Precio_Unitario,
                        doc.DetOrCom_cantidad AS Cantidad,
                        doc.DetOrCom_total AS Total
                    FROM 
                        Tbl_detalle_ordenes_compra doc
                    JOIN 
                        Tbl_ordenes_compra oc ON doc.Fk_encOrCom_id = oc.Pk_encOrCom_id
                    JOIN 
                        Tbl_Productos p ON doc.Fk_id_producto = p.Pk_id_Producto;
            ";

                // Crear el adaptador de datos con la conexión
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar());
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return null;
            }
        }
        }
}
