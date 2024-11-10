using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_Factura;
namespace Testfactura
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_insert_encabezado()
        { // Arrange
            // Arrange
            var idFactura = "F12345";
            var idVendedor = "1";  // Asegúrate de que sea un ID válido en tu base de datos
            var idClientes = "10";  // Asegúrate de que sea un ID válido en tu base de datos
            var idPedido = "P100";  // Asegúrate de que sea un ID válido en tu base de datos o permite nulo según tu configuración
            DateTime fechaCreacion = DateTime.Now;
            DateTime fechaVencimiento = DateTime.Now.AddDays(30);
            var formaPago = "al crédito";  // O "al contado", según lo definido en tu aplicación
            var subtotal = "2000.00";
            var iva = "0.12";
            var total = "2240.00";

            var claseFactura = new Sentencia();  // Reemplaza con el nombre de tu clase real

            try
            {
                // Act
                claseFactura.funInsertarFacturaE(idFactura, idVendedor, idClientes, idPedido, fechaCreacion, fechaVencimiento, formaPago, subtotal, iva, total);
            }
            catch (Exception ex)
            {
                // Si hay una excepción, falla la prueba y muestra el mensaje de error
                Assert.Fail($"La inserción del encabezado de factura falló con la excepción: {ex.Message}");
            }
        

    }

        [TestMethod]
        public void test_insert_detalle_cotizacion()
        {
            // Arrange
            var idCotizacion = 12345;  // Asegúrate de que este ID existe en Tbl_cotizacion_encabezado si tienes la restricción de llave foránea
            var idProducto = 1;  // Ajusta según un ID de producto válido en tu base de datos
            var cantidad = 10;
            var precio = 150.75m;
            var subtotal = cantidad * precio;
            var claseCotizacion = new Sentencia(); // Reemplaza con el nombre de tu clase real

            try
            {
                // Act
                claseCotizacion.funInsertarFacturaD(idCotizacion, idProducto, cantidad, precio, subtotal);
            }
            catch (Exception ex)
            {
                // Si hay una excepción, falla la prueba y muestra el mensaje de error
                Assert.Fail($"La inserción del detalle falló con la excepción: {ex.Message}");
            }
        }
    }
}
