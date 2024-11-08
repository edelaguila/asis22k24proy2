using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Para OdbcDataReader
using Capa_Modelo_Logistica; // Para Sentencias
using System.Windows.Forms;
using System.Data;

namespace Capa_Controlador_Logistica
{
    public class Controlador
    {
        //Metodo de controlador realizado por Pedro Citalán 0901-20-16151
        Sentencias sn = new Sentencias();

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------
        public string[] itemsCuenta(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbCuentas(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarCuentas(string tabla, string campo1, string campo2)
        {
            var dt1 = sn.obtenerCuentas(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX TIPO POLIZA ----------------------------------

        public string[] itemsTP(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbTP(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarTP(string tabla, string campo1, string campo2)
        {
            var dt1 = sn.obtenerTP(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public string[] itemsOP(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbTP(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarOP(string tabla, string campo1, string campo2)
        {
            var dt1 = sn.obtenerTP(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- Funcion para actualizar la tabla cuentas ----------------------------------

        public void ActualizarTblCuentas(int idCuenta, string tipoOperacion, decimal valor)
        {
            Sentencias sn = new Sentencias();

            sn.ActulizarCuentas(idCuenta, tipoOperacion, valor);
            return;
        }

        // ---------------------------------- Insertar en polizas ----------------------------------
        public void LlenarEncabezado(string fechaSeleccionada, string concepto, int tipoPoli)
        {
            Sentencias sn = new Sentencias();
            sn.LlenarEncabezado(fechaSeleccionada, concepto, tipoPoli);
            return;
        }

        public void LlenarDetalle(string fechaSeleccionada, string concepto, List<object[]> detalles)
        {
            Sentencias sn = new Sentencias();
            sn.LlenarDetalle(fechaSeleccionada, concepto, detalles);
            return;
        }

    }
}

