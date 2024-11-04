using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Vista_Polizas;


namespace TestPolizas
{
   /* TEST_CLASS(TestPolizas)
    {
    public:
        // Miembros para los objetos de prueba
        Mock<controladorPolizas>* mockControlador;
    Poliza* formulario; // Cambia esto al nombre real de tu formulario si es distinto

    // Configuración inicial
    [TestInitialize]
    void Setup()
    {
        mockControlador = new Mock<controladorPolizas>();
        formulario = new Poliza();
    }

    // Liberar recursos después de cada prueba
    [TestCleanup]
    void Cleanup()
    {
        delete mockControlador;
        delete formulario;
    }

    [TestMethod]
    void TestLlenarseCuentas()
    {
        // Arrange
        std::string tabla = "tbl_cuentas";
        std::string campo1 = "Pk_id_cuenta";
        std::string campo2 = "nombre_cuenta";

        // Simular el comportamiento del controlador
        std::vector < std::string> mockItems = { "Activo", "Corriente", "Caja" };
        DataTable mockDataTable;
        mockDataTable.Columns.Add(campo1);
        mockDataTable.Columns.Add(campo2);
        mockDataTable.Rows.Add(1, "Activo");
        mockDataTable.Rows.Add(2, "Corriente");

        mockControlador->Setup([=](auto) { return mockItems; });
        mockControlador->Setup([=](auto) { return mockDataTable; });

        formulario->SetControlador(mockControlador->Object); // Método para establecer el controlador en el formulario

        // Act
        formulario->llenarseCuentas(tabla, campo1, campo2);

        // Assert
        Assert::AreEqual(2, static_cast<int>(formulario->cbCuenta.Items.Count)); // Verificar que hay dos elementos
        Assert::AreEqual("Activo", formulario->cbCuenta.Items[0].ToString());
        Assert::AreEqual("Corriente", formulario->cbCuenta.Items[1].ToString());
    }

    [TestMethod]
    void TestCalcularPrima()
    {
        // Arrange
        Poliza poliza;
        double basePrima = 100.0;
        double factorRiesgo = 1.2;

        // Act
        double resultado = poliza.calcularPrima(basePrima, factorRiesgo);

        // Assert
        Assert::AreEqual(120.0, resultado, 0.001);
    }

    [TestMethod]
    void TestCalcularMonto()
    {
        // Arrange
        Poliza poliza;
        double prima = 120.0;
        double tasa = 0.2;

        // Act
        double resultado = poliza.calcularMonto(prima, tasa);

        // Assert
        Assert::AreEqual(144.0, resultado, 0.001);
    }*/
};
