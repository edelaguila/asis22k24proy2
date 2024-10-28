using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_OrdenCompra;
using System.Windows.Forms;

namespace Capa_Controlador_OrdenCompra
{
    public class logica
    {
        sentencia sn;

        public logica()
        {
            sn = new sentencia();
        }




        public DataTable funConsultaLogicaProductos()
        {

            try
            {
                OdbcDataAdapter dtProducto = sn.funProductos();
                DataTable tableProducto = new DataTable();
                dtProducto.Fill(tableProducto);
                return tableProducto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public DataTable funConsultaLogicaOrdenes(string sAplicacionUsuario)
        {

            // Llamar al método que retorna un DataTable
            DataTable table = new DataTable();
            OdbcDataAdapter dt = sn.funMostrarOrdenesGeneradas(sAplicacionUsuario); // Cambio en el nombre del método para reflejar permisos
            dt.Fill(table);
            return table;
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



    }

}
