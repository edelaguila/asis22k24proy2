using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Odbc;
using Capa_Modelo_Nominas;
using Capa_Modelo_Seguridad;
using System.Reflection; // Para usar Reflection

namespace TestTotalMes_IsmarCortez
{
    [TestClass]
    public class TestTotalMes_IsmarCortez
    {
        [TestMethod]
        public void Test_TotalMes_Exito()
        {
            // Arrange
            var mockConexion = new Mock<conexion>(); // Mock de la conexión
            var mockCommand = new Mock<OdbcCommand>(); // Mock del comando OdbcCommand
            var mockConnection = new Mock<OdbcConnection>(); // Mock de la OdbcConnection

            // Simula que la conexión abre correctamente
            mockConexion.Setup(c => c.conectar()).Returns(mockConnection.Object);

            // Simula que el comando es ejecutado exitosamente y afecta filas
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1); // Simula que afecta 1 fila

            // Simula la creación de un OdbcCommand en la conexión
            mockConnection.Setup(conn => conn.CreateCommand()).Returns(mockCommand.Object);

            var sentencias = new Sentencias();

            // Usa Reflection para establecer el campo privado 'cn'
            FieldInfo cnField = typeof(Sentencias).GetField("cn", BindingFlags.NonPublic | BindingFlags.Instance);
            cnField.SetValue(sentencias, mockConexion.Object); // Asigna el mock de conexión a 'cn'

            // Act
            var resultado = sentencias.CalcularTotalMes("1"); // Probar con un id de encabezado válido

            // Assert
            Assert.IsTrue(resultado); // El resultado debe ser true porque afecta filas
        }

        [TestMethod]
        public void Test_TotalMes_Fallo()
        {
            // Arrange
            var mockConexion = new Mock<conexion>();
            var mockCommand = new Mock<OdbcCommand>();
            var mockConnection = new Mock<OdbcConnection>();

            mockConexion.Setup(c => c.conectar()).Returns(mockConnection.Object);

            // Simula que el comando no afecta filas
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(0); // No afecta filas

            mockConnection.Setup(conn => conn.CreateCommand()).Returns(mockCommand.Object);

            var sentencias = new Sentencias();

            // Usa Reflection para establecer el campo privado 'cn'
            FieldInfo cnField = typeof(Sentencias).GetField("cn", BindingFlags.NonPublic | BindingFlags.Instance);
            cnField.SetValue(sentencias, mockConexion.Object); // Asigna el mock de conexión a 'cn'

            // Act
            var resultado = sentencias.CalcularTotalMes("1");

            // Assert
            Assert.IsFalse(resultado); // El resultado debe ser false porque no afecta filas
        }

        [TestMethod]
        public void Test_TotalMes_ErrorConexion()
        {
            // Arrange
            var mockConexion = new Mock<conexion>();

            // Simula que la conexión retorna null (fallo de conexión)
            mockConexion.Setup(c => c.conectar()).Returns((OdbcConnection)null);

            var sentencias = new Sentencias();

            // Usa Reflection para establecer el campo privado 'cn'
            FieldInfo cnField = typeof(Sentencias).GetField("cn", BindingFlags.NonPublic | BindingFlags.Instance);
            cnField.SetValue(sentencias, mockConexion.Object); // Asigna el mock de conexión a 'cn'

            // Act
            var resultado = sentencias.CalcularTotalMes("1");

            // Assert
            Assert.IsFalse(resultado); // Debe retornar false porque no se conecta a la DB
        }
    }
}
