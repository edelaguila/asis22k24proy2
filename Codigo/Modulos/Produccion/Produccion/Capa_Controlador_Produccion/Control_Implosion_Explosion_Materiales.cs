using Capa_Modelo_Produccion;
using System.Data;

namespace Capa_Controlador_Produccion
{
    public class Control_Implosion_Explosion_Materiales
    {
        private readonly Sentencia_Implosion_Explosion sentencias;

        public Control_Implosion_Explosion_Materiales()
        {
            sentencias = new Sentencia_Implosion_Explosion();
        }

        // Método para obtener productos según la serie (clasificación) como "Materia Prima" o "Producto Terminado"
        public DataTable ObtenerProductosPorSerie(string serie)
        {
            return sentencias.ObtenerProductosPorSerie(serie);
        }

        // Método para obtener materiales necesarios para la explosión de un producto específico, ajustado para recibir idProducto y cantidadDeseada
        public DataTable ObtenerMaterialesParaProducto(int idProducto, int cantidadDeseada)
        {
            // Llamada a Sentencia_Implosion_Explosion con los parámetros necesarios
            return sentencias.ObtenerMaterialesParaProducto(idProducto, cantidadDeseada);
        }

        // Método para obtener recetas que incluyen un material específico para implosión
        public DataTable ObtenerRecetasParaMaterial(int idMaterial)
        {
            return sentencias.ObtenerRecetasParaMaterial(idMaterial);
        }

        // Método adicional para obtener materias primas directamente
        public DataTable ObtenerMateriasPrimas()
        {
            return sentencias.ObtenerMateriasPrimas();
        }

        // Método adicional para obtener productos terminados directamente
        public DataTable ObtenerProductosTerminados()
        {
            return sentencias.ObtenerProductosTerminados();
        }
    }
}
