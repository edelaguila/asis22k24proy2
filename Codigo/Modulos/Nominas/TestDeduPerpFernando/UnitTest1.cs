using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Data;
using System.Data.Odbc;

namespace TestDeduPerpFernando
{
    [TestClass]
    public class TestDeduPerp
    {
        [TestMethod]
        public void CalcularTotalDeduPer_SuccessfulExecution_AffectsRows()
        {
            // Arrange
            var mockConnection = new Mock<OdbcConnection>();
            var mockCommand = new Mock<OdbcCommand>();
            var mockCn = new Mock<Capa_Modelo_Nominas>(); // Asegúrate de que Capa_Modelo_Nominas tenga la propiedad/método 'conexion()'

            // Configurar el método conexion() para que devuelva una conexión simulada
            mockCn.Setup(cn => cn.conexion()).Returns(mockConnection.Object);

            // Configurar el comando simulado para que devuelva un número de filas afectadas
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1); // Simular que afecta una fila
            mockCommand.SetupProperty(cmd => cmd.CommandType);
            mockCommand.Setup(cmd => cmd.Parameters.AddWithValue(It.IsAny<string>(), It.IsAny<object>()));

            // Actuar como si estuvieras ejecutando el procedimiento almacenado
            using (OdbcCommand comando = new OdbcCommand("{CALL sp_calcular_planilla_detalle(?,?,?)}", mockCn.Object.conexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_pk_registro_planilla_Detalle", "claveEjemplo");
                comando.Parameters.AddWithValue("@p_fk_id_registro_planilla_Encabezado", "encabezadoEjemplo");
                comando.Parameters.AddWithValue("@p_fk_clave_empleado", "empleadoEjemplo");
                int filasAfectadas = comando.ExecuteNonQuery();

                // Assert
                Assert.AreEqual(1, filasAfectadas, "Se esperaba que el SP afectara una fila.");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(OdbcException))]
        public void CalcularTotalDeduPer_ThrowsOdbcException()
        {
            // Arrange
            var mockConnection = new Mock<OdbcConnection>();
            var mockCommand = new Mock<OdbcCommand>();
            var mockCn = new Mock<Capa_Modelo_Nominas>();

            // Configurar el método conexion() para que devuelva una conexión simulada
            mockCn.Setup(cn => cn.conexion()).Returns(mockConnection.Object);

            // Configurar el comando simulado para lanzar una excepción
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Throws(new OdbcException());

            // Actuar como si estuvieras ejecutando el procedimiento almacenado
            using (OdbcCommand comando = new OdbcCommand("{CALL sp_calcular_planilla_detalle(?,?,?)}", mockCn.Object.conexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_pk_registro_planilla_Detalle", "claveEjemplo");
                comando.Parameters.AddWithValue("@p_fk_id_registro_planilla_Encabezado", "encabezadoEjemplo");
                comando.Parameters.AddWithValue("@p_fk_clave_empleado", "empleadoEjemplo");

                // Act - Esto debería lanzar una excepción
                comando.ExecuteNonQuery();
            }
        }
    }
}
