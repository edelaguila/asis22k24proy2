using System;
using System.Data;
using Capa_Modelo_ListaPrecios;
using System.Data.Odbc;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Capa_Controlador_ListaPrecios
{
    public class logica
    {
        sentencia sn;

        public logica(string idUsuario)
        {
            sn = new sentencia(idUsuario);
        }

        public logica() { }

        // Función para obtener productos
        public DataTable funconsultalogicaproductos(string clasificacion)
        {
            try
            {
                OdbcDataAdapter dtProducto = sn.funconsultarproductos(clasificacion);
                DataTable tableProducto = new DataTable();
                dtProducto.Fill(tableProducto);
                return tableProducto;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funconsultalogicaproductos: " + ex.Message);
                return null;
            }
        }

        //Función para obtener clasificaciones
        public DataTable funconsultarlogicaClasificaciones()
        {
            try
            {
                OdbcDataAdapter dtClasificacion = sn.funconsultarClasificaciones(); // Asegúrate de implementar este método
                DataTable tableClasificacion = new DataTable();
                dtClasificacion.Fill(tableClasificacion);
                return tableClasificacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funconsultarClasificaciones: " + ex.Message);
                return null;
            }
        }


        public DataTable CargarClasificacionesEspecificas(string tipoClasificacion)
        {
            try
            {
                // Llama al método de acceso a datos para obtener las clasificaciones específicas
                DataTable dtClasificacionesEspecificas = sn.ObtenerClasificacionesEspecificas(tipoClasificacion);
                return dtClasificacionesEspecificas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CargarClasificacionesEspecificas: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }


        public DataTable CargarProductos(string clasificacion)
        {
            try
            {
                // Llama al método de acceso a datos para obtener las clasificaciones específicas
                DataTable dtClasificacionesEspecificas = sn.funcargarProductosPorClasificacion(clasificacion);
                return dtClasificacionesEspecificas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CargarClasificacionesEspecificas: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }



        public DataTable funconsultalogicaProductosPorMarca(string nombreMarca)
        {
            try
            {
                OdbcDataAdapter adapter = sn.funconsultarProductosPorMarca(nombreMarca); // Llama al método de la capa modelo
                DataTable dtProductos = new DataTable();
                adapter.Fill(dtProductos); // Llena el DataTable con los resultados
                return dtProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar productos por marca: " + ex.Message);
            }
        }

        public DataTable funconsultaLogicaProductosPorLinea(string nombreLinea)
        {
            try
            {
                OdbcDataAdapter adapter = sn.funconsultarProductosPorLinea(nombreLinea);
                DataTable dtProductos = new DataTable();
                adapter.Fill(dtProductos);
                return dtProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar productos por línea: " + ex.Message);
            }
        }

        public DataTable funconsultaProductosPorInventario(string nombreInventario)
        {
            try
            {
                OdbcDataAdapter adapter = sn.funconsultarProductosPorInventario(nombreInventario);
                DataTable dtProductos = new DataTable();
                adapter.Fill(dtProductos);
                return dtProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar productos por inventario: " + ex.Message);
            }
        }

        public DataTable funlogicaConsultarLineas()
        {
            try
            {
                OdbcDataAdapter adapter = sn.funconsultarLineas();
                DataTable dtLineas = new DataTable();
                adapter.Fill(dtLineas);
                return dtLineas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar líneas: " + ex.Message);
            }
        }

        public DataTable funlogicaConsultarMarcas()
        {
            try
            {
                OdbcDataAdapter adapter = sn.funconsultarMarcas();
                DataTable dtMarcas = new DataTable();
                adapter.Fill(dtMarcas);
                return dtMarcas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar marcas: " + ex.Message);
            }
        }

        public DataTable funlogicaConsultarInventarios()
        {
            try
            {
                OdbcDataAdapter adapter = sn.funconsultarInventarios();
                DataTable dtInventarios = new DataTable();
                adapter.Fill(dtInventarios);
                return dtInventarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar inventarios: " + ex.Message);
            }
        }
    }

}

