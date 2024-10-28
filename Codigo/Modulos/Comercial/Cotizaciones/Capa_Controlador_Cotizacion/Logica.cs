using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo_Cotizacion;

namespace Capa_Controlador_Cotizacion
{
    public class Logica
    {
        Sentencia sn;

        public Logica(string idUsuario)
        {
            sn = new Sentencia(idUsuario);
        }

        public Logica() { }


        // combo usuario y perfil 
        public string[] funitems(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funllenarCmb(tabla, campo1, campo2);

            return Items;




        }

        public DataTable funenviar(string tabla, string campo1, string campo2)
        {

            var dt1 = sn.funobtener(tabla, campo1, campo2);

            return dt1;
        }

/// ////////////////////////////

        public string[] funitemsPerfiles(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funllenarCmbPerfiles(tabla, campo1, campo2);

            return Items;




        }

        public DataTable funenviarPerfiles(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.funobtenerPerfiles(tabla, campo1, campo2);

            return dt1;
        }


        public string[] funitemsAsigUP(string tabla, string campo1)
        {
            string[] Items = sn.funllenarCboAsigUP(tabla, campo1);

            return Items;




        }

        public DataTable funenviarAsigUP(string tabla, string campo1)
        {


            /**/
            var dt1 = sn.funobtenerAsigUP(tabla, campo1);

            return dt1;
        }
    }
}
