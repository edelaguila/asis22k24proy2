using Capa_Modelo_Cuentas_Corrientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Cuentas_Corrientes
{
    public class Controlador
    {
        Capa_Modelo_Cuentas_Corrientes.Sentencias sentencias = new Capa_Modelo_Cuentas_Corrientes.Sentencias();

        public DataTable MostrarTransacciones()
        {
            OdbcDataAdapter data = sentencias.DisplayTransacciones();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextId()
        {
            int nextId = sentencias.getMaxIdTransaccion();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public List<string> listadoDeuda()
        {
            List<string> deudasCodes = sentencias.getDeudas();
            return deudasCodes;
        }

        public List<string> listadoPagos()
        {
            List<string> pagosCodes = sentencias.getPagos();
            return pagosCodes;
        }

        public List<string> listadoClientes()
        {
            List<string> clientesCodes = sentencias.getClientes();
            return clientesCodes;
        }

        public List<string> listadoPais()
        {
            List<string> paisCodes = sentencias.getPais();
            return paisCodes;
        }
        public int guardarTransaccion(TextBox PK_id_transaccion, string sFk_id_clientes, string sFk_id_pais, string sfecha_transaccion,
            string scuenta_transaccion, string scuotas_transaccion, string sFk_id_deuda, string smonto_deuda, string smonto_transaccion,
            string ssaldo_pendiente, string sFk_id_pago, string stipo_moneda, string sserie_transaccion, string sestado_transaccion)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(PK_id_transaccion.Text) || string.IsNullOrEmpty(sFk_id_clientes) || string.IsNullOrEmpty(sFk_id_pais) ||
                string.IsNullOrEmpty(sfecha_transaccion) || string.IsNullOrEmpty(scuenta_transaccion) || string.IsNullOrEmpty(scuotas_transaccion)||
                string.IsNullOrEmpty(sFk_id_deuda) || string.IsNullOrEmpty(smonto_deuda) || string.IsNullOrEmpty(smonto_transaccion)||
                string.IsNullOrEmpty(ssaldo_pendiente) || string.IsNullOrEmpty(sFk_id_pago) || string.IsNullOrEmpty(stipo_moneda)||
                string.IsNullOrEmpty(sserie_transaccion) || string.IsNullOrEmpty(sestado_transaccion))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarTransaccion(PK_id_transaccion.Text, sFk_id_clientes, sFk_id_pais, sfecha_transaccion,
            scuenta_transaccion, scuotas_transaccion, sFk_id_deuda, smonto_deuda, smonto_transaccion,
            ssaldo_pendiente, sFk_id_pago, stipo_moneda, sserie_transaccion, sestado_transaccion);
                return 1;
            }
        }
        public void GuardarProveedor(string idProveedor, string fechaRegistro, string nombre, string direccion,
                             string telefono, string email, decimal saldoCuenta, string estadoProveedor)
        {
            try
            {
                sentencias.InsertarProveedor(idProveedor, fechaRegistro, nombre, direccion, telefono, email, saldoCuenta, estadoProveedor);
                MessageBox.Show("Proveedor guardado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
            }
        }

        public void EliminarProveedor(string idProveedor)
        {
            Sentencias sentencias = new Sentencias();
            sentencias.EliminarProveedor(idProveedor);
        }

    }
}
