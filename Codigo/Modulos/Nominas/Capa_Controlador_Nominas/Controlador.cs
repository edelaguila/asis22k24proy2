using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Nominas;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Reflection;

namespace Capa_Controlador_Nominas
{
    public class Controlador
    {
        Sentencias sn = new Sentencias(); //Conexion con capa modelo

        // Método que obtiene el logo en formato Image
        //public Image ObtenerLogoEmpresa(int empresaId)
        //{
        //    byte[] imageBytes = modelo.ObtenerLogoEmpresa(empresaId); // Este método retorna un arreglo de bytes

        //    if (imageBytes != null)
        //    {
        //        using (MemoryStream ms = new MemoryStream(imageBytes))
        //        {
        //            return Image.FromStream(ms); // Esto convierte los bytes a una imagen usando System.Drawing.Image
        //        }
        //    }
        //    return null;
        //}


    }
}
