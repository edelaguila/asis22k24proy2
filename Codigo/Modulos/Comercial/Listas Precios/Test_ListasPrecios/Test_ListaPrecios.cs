using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_ListaPrecios;

namespace Test_ListasPrecios
{
    [TestClass]
    public class Test_ListaPrecios
    {
        [TestMethod]
        public void test_insert_lista_encabezado()
        {
            // Arrange
            int iCodigoEncabezado = 10; // Cambiar según el ID(codigo de la lista a probarse) asegurarse de que hayan listas creadas o dara error
            int iClasificacion = 1;       // Id de clasificación existente (esto es en base al mantenimiento de clasificaciones)
            DateTime sFecha = DateTime.Now;
            string sEstado = "Activo";  // puede ser Activo o Inactivo
            var claseLista = new sentencia(); // clase donde está proinsertarlistaEncabezado

            try
            {
                // Act
                claseLista.proinsertarlistaEncabezado(iCodigoEncabezado, iClasificacion, sFecha, sEstado);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Fail($"La inserción del encabezado falló con la excepción: {ex.Message}");
            }
        }

        [TestMethod]
        public void test_insert_lista_detalle()
        {
            // Arrange
            int iCodigoEncabezado = 1001; // ID del encabezado creado previamente (debe ser el mismo que el del encabezado)
            int iCodigoProducto = 7;      // ID del producto existente en el detalle creado(tomar en cuenta que existan productos)
            decimal dPrecioLista = 125.99m;
            var claseLista = new sentencia(); //clase donde está proinsertarlistaDetalle

            try
            {
                // Act
                claseLista.proinsertarlistaDetalle(iCodigoEncabezado, iCodigoProducto, dPrecioLista);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Fail($"La inserción del detalle falló con la excepción: {ex.Message}");
            }
        }

    }
}