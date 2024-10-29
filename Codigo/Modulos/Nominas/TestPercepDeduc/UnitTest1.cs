using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_Nominas;

namespace TestDeduPerp
{
    [TestClass]
    public class TestPerpDed
    {
        [TestMethod]
        public void TestPerp_Ded()
        {
            // Arrange
            var obj = new Sentencias();
            string clavePrueba = "123";
            string empleadoPrueba = "456";
            string encabezadoPrueba = "789";

            // Act
            try
            {
                obj.CalcularTotalDeduPer(clavePrueba, empleadoPrueba, encabezadoPrueba);

                // Assert
                Assert.IsTrue(true); // Si el método se ejecuta sin errores, la prueba es exitosa
            }
            catch (Exception ex)
            {
                Assert.Fail("El método lanzó una excepción: " + ex.Message); // Si hay error, falla la prueba
            }
        }
    }
}
