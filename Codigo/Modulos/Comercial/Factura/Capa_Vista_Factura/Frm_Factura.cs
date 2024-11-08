using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Factura;

namespace Capa_Vista_Factura
{
    public partial class Frm_Factura : Form
    {
        Logica logic;
        string valorSeleccionadovendedor;
        string valorSeleccionadoclientes;
        string valorSeleccionadoProducto;
        string valorSeleccionadoPedido;
        string valorSeleccionadoMetodopago;

        public Frm_Factura()
        {
            InitializeComponent();
            InicializarTotal();
            Btn_cancelar.Enabled = true;
            Btn_nuevoCE.Enabled = true;
            Txt_ClienteB.Enabled = false;



            ToolTip tagregrarE = new ToolTip();
            tagregrarE.SetToolTip(Btn_agregar, "agregar producto");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_nuevoCE, "Guardar cotización");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Cancelar Cambios");
            ToolTip teliminar = new ToolTip();
            tcancelar.SetToolTip(Btn_borrar, "elimna producto");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "ayuda con cotizacion");
            ToolTip treporte = new ToolTip();
            treporte.SetToolTip(Btn_reporte, "reporte de cotizacion");
            ToolTip tguardarD = new ToolTip();


            logic = new Logica();
            string stablav = "Tbl_vendedores";
            string scampo1v = "Pk_id_vendedor";
            string scampo2v = "vendedores_nombre";


            string stablaC = "Tbl_clientes";
            string scampo1C = "Pk_id_cliente";
            string scampo2C = "Clientes_nombre";

            string stablaP = "tbl_pedido_encabezado";
            string scampo1P = "Pk_id_PedidoEnc";
            string scampo2P = "Fk_id_cliente";


            string stablal = "Tbl_Productos";
            string scampo1l = "Pk_id_Producto";
            string scampo2l = "nombreProducto";


            prollenarseVendedores(stablav, scampo1v, scampo2v);
            prollenarseClientes(stablaC, scampo1C, scampo2C);
            prollenarsePedido(stablaP, scampo1P, scampo2P);
            prollenarselista(stablal, scampo1l, scampo2l);



            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            Cbo_vendedor.SelectedIndexChanged += new EventHandler(Cbo_vendedor_SelectedIndexChanged);
            Cbo_cliente.SelectedIndexChanged += new EventHandler(Cbo_cliente_SelectedIndexChanged);
            Cbo_producto.SelectedIndexChanged += new EventHandler(Cbo_producto_SelectedIndexChanged);
            Cbo_pedidos.SelectedIndexChanged += new EventHandler(Cbo_pedidos_SelectedIndexChanged_1);
            //proactualizardatagriew();
        }


        private void OpcionLlenado()
        {

        }


        private void Cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InicializarTotal()
        {
            Txt_total.Text = "00.00";
            Txt_subtotal.Text = "00.00";
            Txt_IVA.Text = "00.00";// Asignar el valor "00.00" al TextBox
            Txt_PedidoBUS.Text = "0";
        }

        public void prollenarseVendedores(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_vendedor.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_vendedor.Items.Add(new ComboBoxItemv
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cbo_vendedor.AutoCompleteCustomSource = coleccion;
            Cbo_vendedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_vendedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // /////////////////////////////////////////////////////////////////////////////////
        public void prollenarseClientes(string stabla, string scampo1, string scampo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_cliente.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_cliente.Items.Add(new ComboBoxItemc
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_cliente.AutoCompleteCustomSource = coleccion;
            Cbo_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        public void prollenarsePedido(string stabla, string scampo1, string scampo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_pedidos.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_pedidos.Items.Add(new ComboBoxItem
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_pedidos.AutoCompleteCustomSource = coleccion;
            Cbo_pedidos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_pedidos.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }




        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }

        public class ComboBoxItemv
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }
        public class ComboBoxItemc
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }

        /// //////////////////////////////


        public void prollenarselista(string stabla, string scampo1, string scampo2)
        {

            var dt = logic.funenviar(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_producto.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_producto.Items.Add(new ComboBoxItem
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_producto.AutoCompleteCustomSource = coleccion;
            Cbo_producto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_producto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public class ComboBoxItemP
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }



        public class ComboBoxItem1
        {
            public string Value { get; set; } // Este será el ID o valor que representa el item
            public string Display { get; set; } // Este será el texto que se muestra en el ComboBox

            // Sobrescribir el método ToString para mostrar solo el nombre en el ComboBox
            public override string ToString()
            {
                return Display; // Solo muestra el campo Display
            }
        }


        private void Txt_producton_Click(object sender, EventArgs e)
        {

        }

        private void Txt_totaln_Click(object sender, EventArgs e)
        {

        }




        private void ActualizarComboBox()
        {
            // Limpiar los ítems actuales de los ComboBox
            Cbo_vendedor.Items.Clear();
            Cbo_cliente.Items.Clear();

            Cbo_producto.Items.Clear();

            // Definir las tablas y campos para los vendedores y clientes
            string stablav = "Tbl_vendedores";
            string scampo1v = "Pk_id_vendedor";
            string scampo2v = "vendedores_nombre";


            string stablaC = "Tbl_clientes";
            string scampo1C = "Pk_id_cliente";
            string scampo2C = "Clientes_nombre";

            string stablal = "Tbl_Productos";
            string scampo1l = "Pk_id_Producto";
            string scampo2l = "nombreProducto";

            string stablaP = "tbl_pedido_encabezado";
            string scampo1P = "Pk_id_PedidoEnc";
            string scampo2P = "Fk_id_cliente";


            // Llenar los ComboBox con las funciones correspondientes
            prollenarseVendedores(stablav, scampo1v, scampo2v);
            prollenarseClientes(stablaC, scampo1C, scampo2C);
            prollenarselista(stablal, scampo1l, scampo2l);
            prollenarsePedido(stablaP, scampo1P, scampo2P);

            // Asociar los eventos SelectedIndexChanged si aún no se han registrado
            Cbo_vendedor.SelectedIndexChanged += new EventHandler(Cbo_vendedor_SelectedIndexChanged);
            Cbo_cliente.SelectedIndexChanged += new EventHandler(Cbo_cliente_SelectedIndexChanged);
            Cbo_producto.SelectedIndexChanged += new EventHandler(Cbo_producto_SelectedIndexChanged);
            Cbo_pedidos.SelectedIndexChanged += new EventHandler(Cbo_pedidos_SelectedIndexChanged_1);
            //  Cbo_buscadorE.SelectedIndexChanged += new EventHandler(Cbo_buscadorE_SelectedIndexChanged);

        }

        private void LimpiarDataGridView(DataGridView dataGridView)
        {
            // Verifica si el DataGridView tiene filas
            if (dataGridView.Rows.Count > 0)
            {
                // Elimina todas las filas
                dataGridView.Rows.Clear();
            }
        }

        private void limpiarT()
        {
            Txt_idEncezado.Clear();
            Cbo_vendedor.SelectedIndex = -1;
            Cbo_cliente.SelectedIndex = -1;
            Txt_ClienteB.Clear();
            Txt_total.Clear();
            Cbo_producto.SelectedIndex = -1;
            Txt_precio.Clear();
            LimpiarDataGridView(Dgv_Fcatura);


        }

        private void limpiar()
        {
            Cbo_producto.SelectedIndex = -1;
            Txt_precio.Clear();
            Txt_cantidad.Value = 0;


        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {

            limpiar();
            InicializarTotal();
        }


        public static int iContadorFila = 0;

        private void InsertarEncabezado()
        {
            Cbo_vendedor.Enabled = true;
            Cbo_cliente.Enabled = true;

            if (string.IsNullOrEmpty(Txt_idEncezado.Text))
            {
                MessageBox.Show("Falta ID de factura");
                return;
            }
            else if (string.IsNullOrEmpty(Cbo_vendedor.Text))
            {
                MessageBox.Show("Falta Vendedor");
                return;
            }

            else
            {
                string IdFactura = Txt_idEncezado.Text;
                DateTime fechaVence = Dtp_fechaV.Value;
                DateTime FechaCre = Dtp_fechaC.Value;

                logic.insertarEncabezado(Txt_idEncezado.Text.ToString(), Txt_VendedorBus.Text.ToString(), Txt_ClienteBus.Text.ToString(), Txt_PedidoBUS.Text.ToString(), FechaCre, fechaVence, Txt_pagom.Text.ToString(), Txt_subtotal.Text.ToString(), Txt_IVA.Text.ToString(), Txt_total.Text.ToString());

                // Muestra un mensaje solo si la inserción fue exitosa
            }

            MessageBox.Show("Factura guardada correctamente.");

        }

        private void InsertarDetalle()
        {
            if (!int.TryParse(Txt_idEncezado.Text, out int IdFactura))
            {
                MessageBox.Show("El valor del encabezado no es válido.");
                return;
            }

            // Iterar sobre cada fila de Dgv_cotizacion
            foreach (DataGridViewRow row in Dgv_Fcatura.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila de nueva entrada

                // Verificar que todas las celdas tengan valores válidos antes de insertar
                if (row.Cells["Producto"].Value != null &&
                    row.Cells["Cantidad"].Value != null &&
                    row.Cells["Precio"].Value != null &&
                    row.Cells["Subtotal"].Value != null)
                {
                    // Extraer datos de cada celda
                    int Idproducto = Convert.ToInt32(row.Cells["Producto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    // Llamar a la función log.insertarDetalle con Idcotizacion como primer parámetro
                    logic.insertarDetalle(IdFactura, Idproducto, cantidad, precio, subtotal);
                }
            }

            MessageBox.Show("Factura Guardada correctamente.");

        }

        private void Rdb_Pedido_CheckedChanged(object sender, EventArgs e)
        {
            Cbo_pedidos.Enabled = true;
            Cbo_cliente.Enabled = false;
            Txt_ClienteB.Enabled = false;
            Cbo_vendedor.Enabled = false;
            Txt_ClienteBus.Enabled = false;
            Txt_VendedorBus.Enabled = false;
            Cbo_pedidos.Visible = true;
            Cbo_cliente.Visible = false;
            Txt_PedidoBUS.Visible = false;
            Cbo_vendedor.Visible = false;
        }

        private void Rdb_Manual_CheckedChanged(object sender, EventArgs e)
        {
            Cbo_pedidos.Enabled = false;
            Cbo_cliente.Enabled = true;
            Txt_ClienteB.Enabled = true;
            Cbo_vendedor.Enabled = true;
            Cbo_cliente.Visible = true;
            Cbo_vendedor.Visible = true;
            Txt_PedidoBUS.Visible = true;
            Cbo_pedidos.Visible = false;
        }

        private void Cbo_cliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Cbo_cliente.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItemc)Cbo_cliente.SelectedItem;
                valorSeleccionadoclientes = selectedItem.Value;


                string idcliente = valorSeleccionadoclientes;
                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");

                DataTable tableProducto = logic.funllenarCliente(idcliente);

                if (tableProducto != null && tableProducto.Rows.Count > 0)
                {
                    // Suponiendo que el precio está en la columna "ListDetalle_preVenta"
                    Txt_ClienteB.Text = tableProducto.Rows[0]["Cliente_Tipo"].ToString();
                }
                else
                {
                    Txt_ClienteB.Text = "Precio no encontrado"; // Mensaje o acción en caso de que no se encuentre el precio
                }

                Txt_ClienteBus.Text = valorSeleccionadoclientes.ToString(); ;
            }
        }

        private void Cbo_vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_vendedor.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItemv)Cbo_vendedor.SelectedItem;
                valorSeleccionadovendedor = selectedItem.Value;

                Txt_VendedorBus.Text = valorSeleccionadovendedor.ToString(); ;
                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");
            }
           
        }

        private void Cbo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que el cliente esté seleccionado
            if (Cbo_cliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente antes de elegir un producto.", "Validación", MessageBoxButtons.OK);
                limpiar();
                return; // Sale de la función si no hay un cliente seleccionado

            }

            if (Cbo_producto.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItem)Cbo_producto.SelectedItem;
                valorSeleccionadoProducto = selectedItem.Value;

                string idcliente = valorSeleccionadoclientes;  // Asegúrate de que `valorSeleccionadoclientes` contenga el idCliente
                string idProducto = valorSeleccionadoProducto; // Asegúrate de que `valorSeleccionadoProducto` contenga el idProducto

                //opcion uno
                // Llamar a la función que obtiene los datos del producto con el cliente específico
                DataTable tableProducto = logic.funllenarProducto1(idcliente, idProducto);

                if (tableProducto != null && tableProducto.Rows.Count > 0)
                {
                    // Suponiendo que el precio calculado está en la columna "precio"
                    Txt_precio.Text = tableProducto.Rows[0]["precio"].ToString();

                }
                else
                {
                    DataTable tableProducto2 = logic.funllenarProducto2(idProducto);

                    if (tableProducto2 != null && tableProducto2.Rows.Count > 0)
                    {
                        // Suponiendo que el precio está en la columna "ListDetalle_preVenta"
                        Txt_precio.Text = tableProducto2.Rows[0]["precioUnitario"].ToString();

                    }
                    else
                    {
                        Txt_precio.Text = "Precio no encontrado"; // Mensaje o acción en caso de que no se encuentre el precio
                    }
                }

            }
        }



        private void Btn_nuevoCE_Click(object sender, EventArgs e)
        {
            InsertarEncabezado();
            InsertarDetalle();
            limpiarT();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (Cbo_producto.SelectedItem == null || string.IsNullOrEmpty(Txt_precio.Text) || Txt_cantidad.Value <= 0)
            {
                MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            // Variables para los valores a agregar
            string producto = valorSeleccionadoProducto;
            int cantidad = (int)Txt_cantidad.Value;
            decimal precio = Convert.ToDecimal(Txt_precio.Text);
            decimal subtotal = precio * cantidad;

            bool productoExistente = false;


            // Verificar si el producto ya está en la lista
            foreach (DataGridViewRow fila in Dgv_Fcatura.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == producto)
                {
                    productoExistente = true;
                    MessageBox.Show("El producto ya está en la cotización.", "Producto Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }



            }

            if (!productoExistente)
            {
                // Agregar la fila a la  en el orden solicitado
                Dgv_Fcatura.Rows.Add(producto, cantidad, precio, subtotal);
                // iContadorFila++;

                // Sumar el subtotal al total actual en Txt_total
                decimal ivaPorcentaje = 0.12m;

                // Obtener el subtotal del campo correspondiente
                decimal subtotalG = string.IsNullOrEmpty(Txt_subtotal.Text) ? 0 : Convert.ToDecimal(Txt_subtotal.Text);
                decimal NewsubtotalG = subtotalG + subtotal;
                Txt_subtotal.Text = NewsubtotalG.ToString("0.00");
                // Calcular el IVA sobre el subtotal
                decimal iva = NewsubtotalG * ivaPorcentaje;
                Txt_IVA.Text = iva.ToString("0.00");

                // Calcular el total sumando el subtotal y el IVA
                decimal total = NewsubtotalG + iva;
                Txt_total.Text = total.ToString("0.00");

                // Mostrar el nuevo total en un mensaje
                MessageBox.Show($"Nuevo total: {total.ToString("0.00")}");



            }

            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (Dgv_Fcatura.SelectedRows.Count > 0)
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult confirmacion = MessageBox.Show(
                        "¿Está seguro de que desea eliminar esta asignación?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Obtener el subtotal de la fila seleccionada (suponiendo que está en la columna 3)
                        decimal subtotalEliminado = Convert.ToDecimal(Dgv_Fcatura.SelectedRows[0].Cells[3].Value);

                        // Eliminar la fila del DataGridView
                        Dgv_Fcatura.Rows.RemoveAt(Dgv_Fcatura.SelectedRows[0].Index);

                        decimal ivaPorcentaje = 0.12m;

                        // Obtener el subtotal del campo correspondiente
                        decimal subtotalG = string.IsNullOrEmpty(Txt_subtotal.Text) ? 0 : Convert.ToDecimal(Txt_subtotal.Text);
                        decimal NewsubtotalG = subtotalG - subtotalEliminado;
                        Txt_subtotal.Text = NewsubtotalG.ToString("0.00");
                        // Calcular el IVA sobre el subtotal
                        decimal iva = NewsubtotalG * ivaPorcentaje;
                        Txt_IVA.Text = iva.ToString("0.00");

                        // Calcular el total sumando el subtotal y el IVA
                        decimal total = NewsubtotalG + iva;
                        Txt_total.Text = total.ToString("0.00");

                        // Mostrar el nuevo total en un mensaje
                        MessageBox.Show($"Nuevo total: {total.ToString("0.00")}");
                        MessageBox.Show($"Se eliminó el producto. Nuevo total: {NewsubtotalG.ToString("0.00")}");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }


        private void Txt_ClienteBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_VendedorBus_TextChanged(object sender, EventArgs e)
        {

        }


        private void Cbo_metodoP_SelectedIndexChanged(object sender, EventArgs e)
        {

                valorSeleccionadoMetodopago = Cbo_metodoP.SelectedItem.ToString();
                Txt_pagom.Text = valorSeleccionadoMetodopago.ToString();
            
        }

        private void Cbo_pedidos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Cbo_pedidos.SelectedItem != null)
            {
                // Si hay un valor seleccionado, se asigna a valorSeleccionadoPedido
                var selectedItem = (ComboBoxItem)Cbo_pedidos.SelectedItem;
                valorSeleccionadoPedido = selectedItem.Value;

                Txt_PedidoBUS.Text = valorSeleccionadoPedido.ToString();
            }

        }

        private void Txt_pagom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reporte repo = new Reporte();
            repo.Show();
        }
    }
    
}
