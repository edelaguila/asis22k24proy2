using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_ListaPrecios;
using System.Data.Odbc;

using System.IO; // Necesario para Directory, File, Path y SearchOption


namespace Capa_Vista_ListaPrecios
{
    public partial class frm_ListadoDetalle : Form
    {
        private logica logic;

        public frm_ListadoDetalle(string idUsuario)
        {
            InitializeComponent();
            logic = new logica(idUsuario);
            Txt_clasificacionSeleccionada.Enabled = false;
            Txt_clasificacionEspecificaSeleccionada.Enabled = false;
            //Txt_porcentaje.Enabled = false;
            Dgv_detalleProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Rdb_costocompra.CheckedChanged += Rdb_costocompra_CheckedChanged;
            Rdb_precioventa.CheckedChanged += Rdb_precioventa_CheckedChanged;
            Rdb_forzar.CheckedChanged += Rdb_forzar_CheckedChanged;

        }

        /*public frm_ListadoDetalle()
        {

        }*/

        private void frm_ListadoDetalle_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarClasificaciones();


            Cbo_producto.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_clasificacionGeneral.DropDownStyle = ComboBoxStyle.DropDownList;

            // Suscribirse al evento SelectedIndexChanged para el ComboBox de clasificaciones
            Cbo_clasificacionGeneral.SelectedIndexChanged += new EventHandler(Cbo_clasificacion_SelectedIndexChanged);
            Cbo_clasificacionEspecifica.SelectedIndexChanged += Cbo_clasificacionEspecifica_SelectedIndexChanged;

            // Suscribir al evento TextChanged
            Txt_productobuscado.TextChanged += new EventHandler(Txt_productobuscado_TextChanged);
            Txt_clasificacionSeleccionada.Text = "";

            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
        }





        private void CargarProductos()
        {
            /*if (Cbo_clasificacion.SelectedItem != null)
                try
                {
                // Obtener la clasificación seleccionada del ComboBox 
                string clasificacion = Cbo_clasificacion.SelectedItem?.ToString(); 

                if (string.IsNullOrEmpty(clasificacion))
                {
                    Console.WriteLine("Error: Debes seleccionar una clasificación.");
                    return;
                }

                // Llamar los productos que concuerden con la clasificación seleccionada
                DataTable dtProducto = logic.funconsultalogicaproductos(clasificacion);

                // Limpiar los items actuales en el ComboBox
                Cbo_producto.Items.Clear();

                // Agregar productos al ComboBox
                foreach (DataRow row in dtProducto.Rows)
                {
                    // Concatenar el código y el nombre del producto
                    string displayText = $"{row["codigoProducto"]} - {row["nombreProducto"]}";
                    Cbo_producto.Items.Add(displayText);
                }

                // Suscribirse al evento SelectedIndexChanged
                Cbo_producto.SelectedIndexChanged += new EventHandler(Cbo_producto_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar productos: " + ex.Message);
            }*/
        }

        private void CargarClasificaciones()
        {
            DataTable dtClasificaciones = logic.funconsultarlogicaClasificaciones();

            if (dtClasificaciones != null && dtClasificaciones.Rows.Count > 0)
            {
                Cbo_clasificacionGeneral.DataSource = dtClasificaciones;
                Cbo_clasificacionGeneral.DisplayMember = "tipo"; // clasificaciones generales
                Cbo_clasificacionGeneral.ValueMember = "tipo";
            }
            else
            {
                MessageBox.Show("No se encontraron clasificaciones.");
            }
        }




        private void Cbo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado
            if (Cbo_producto.SelectedItem != null)
            {
                string selectedProduct = Cbo_producto.SelectedItem.ToString();
                string codigoProducto = selectedProduct.Split('-')[0].Trim(); // Obtiene el código del producto

                // Cargar los detalles del producto en un DataGridView
                //Dgv_detalleProductos_CellContentClick(codigoProducto);
            }
        }

        private void Cbo_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (Cbo_clasificacionGeneral.SelectedValue != null)
            {
                string clasificacionSeleccionada = Cbo_clasificacionGeneral.SelectedValue.ToString();
                CargarProductosPorClasificacion(clasificacionSeleccionada);
            }*/

            if (Cbo_clasificacionGeneral.SelectedValue != null)
            {
                string seleccion = Cbo_clasificacionGeneral.SelectedValue.ToString();
                Txt_clasificacionSeleccionada.Text = seleccion;
                CargarClasificacionesEspecificas(seleccion);
            }
            else
            {
                Txt_clasificacionSeleccionada.Clear();
                Cbo_clasificacionEspecifica.DataSource = null;
                Cbo_clasificacionEspecifica.Enabled = false;
            }
        }

        private void CargarClasificacionesEspecificas(string tipoClasificacion)
        {
            DataTable dtClasificacionesEspecificas = logic.CargarClasificacionesEspecificas(tipoClasificacion);

            // Asigna el DataTable al ComboBox de clasificaciones específicas
            if (dtClasificacionesEspecificas.Rows.Count > 0)
            {
                Cbo_clasificacionEspecifica.DataSource = dtClasificacionesEspecificas;
                Cbo_clasificacionEspecifica.DisplayMember = "clasificacion"; //subclasificaciones de las clasificaciones generales
                Cbo_clasificacionEspecifica.ValueMember = "clasificacion";
                Cbo_clasificacionEspecifica.Enabled = true;
            }
            else
            {
                Cbo_clasificacionEspecifica.DataSource = null;
                Cbo_clasificacionEspecifica.Enabled = false;
                //MessageBox.Show("No se encontraron clasificaciones específicas.");
            }
        }


        // Cargar productos según la clasificación específica
        private void Cbo_clasificacionEspecifica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_clasificacionEspecifica.SelectedItem != null)
            {
                string clasificacionSeleccionada = Cbo_clasificacionEspecifica.SelectedValue.ToString();

                // Llama al método para cargar productos
                DataTable dtProductos = logic.CargarProductos(clasificacionSeleccionada);

                if (dtProductos != null && dtProductos.Rows.Count > 0)
                {
                    Dgv_detalleProductos.DataSource = dtProductos; // Muestra los productos en el DataGridView
                }
                else
                {
                    //MessageBox.Show("No se encontraron productos para la clasificación seleccionada.");
                    Dgv_detalleProductos.DataSource = null; // Limpia el DataGridView si no hay productos
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una clasificación específica.");
            }
        }



        private void CargarProductosPorClasificacion(string nombreClasificacion, string tipo)
        {
            /*try
            {
                // Llamar al método que consulta los productos según la clasificación
                DataTable dtProductos = logic.funlogicaConsultaProductosPorClasificacion(nombreClasificacion, tipo);

                if (dtProductos != null && dtProductos.Rows.Count > 0)
                {
                    Dgv_detalleProductos.DataSource = dtProductos; // Asignar el DataTable al DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para la clasificación seleccionada.");
                    Dgv_detalleProductos.DataSource = null; // Limpiar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }*/


        }


        // Método para cargar productos según la clasificación seleccionada
        private void CargarProductosPorClasificacion(string clasificacion)
        {
            try
            {
                // Llama a tu lógica para obtener productos según la clasificación seleccionada
                DataTable dtProductos = logic.funconsultalogicaproductos(clasificacion);

                // Verifica si se encontraron productos
                if (dtProductos != null && dtProductos.Rows.Count > 0)
                {
                    Dgv_detalleProductos.DataSource = dtProductos;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para la clasificación seleccionada.");
                    Dgv_detalleProductos.DataSource = null; // Limpiar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }



        private void Dgv_detalleProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                // Llamar a la lógica para obtener detalles del producto basado en el código
                DataTable dtDetalles = logic.funconsultalogicaproductos(clasificacion); // Asegúrate de tener este método en tu lógica

                // Limpiar el DataGridView antes de llenarlo
                Dgv_detalleProductos.Rows.Clear();

                // Llenar el DataGridView con los detalles del producto
                foreach (DataRow row in dtDetalles.Rows)
                {
                    // Aquí asumiendo que tienes columnas específicas en tu DataGridView
                    Dgv_detalleProductos.Rows.Add(row["nombre"], row["precio"], row["stock"]); // Ajusta según los nombres de tus columnas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles del producto: " + ex.Message);
            }*/
        }

        private void Txt_productobuscado_TextChanged(object sender, EventArgs e)
        {
            string textoBuscado = Txt_productobuscado.Text;

            if (!string.IsNullOrWhiteSpace(textoBuscado))
            {
                // Llama al método que retorna un DataTable
                DataTable productosEncontrados = logic.funconsultalogicaproductos(textoBuscado);

                // Limpia los resultados anteriores en el ListBox
                listBox_resultados.Items.Clear();

                // Verifica si se encontraron productos
                if (productosEncontrados != null && productosEncontrados.Rows.Count > 0)
                {
                    foreach (DataRow row in productosEncontrados.Rows)
                    {
                        // Combina el nombre y el código para mostrar en el ListBox
                        listBox_resultados.Items.Add(row["codigoProducto"].ToString() + " - " + row["nombreProducto"].ToString());
                    }
                }
                else
                {
                    // Mensaje opcional si no se encuentran resultados
                    MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.");
                }
            }
            else
            {
                // Si el TextBox está vacío, limpiar el ListBox
                listBox_resultados.Items.Clear();
            }
        }

        private void listBox_resultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asegúrate de que hay un elemento seleccionado
            if (listBox_resultados.SelectedItem != null)
            {
                // Obtener el texto seleccionado (ej. "codigo - nombre")
                string productoSeleccionado = listBox_resultados.SelectedItem.ToString();

                // Separa el código y el nombre usando el guion como delimitador
                var partes = productoSeleccionado.Split(new[] { " - " }, StringSplitOptions.None);
                string codigoSeleccionado = partes[0]; // El código

                // Llama a tu lógica para obtener el producto completo basado en la selección
                DataTable detallesProducto = logic.funconsultalogicaproductos(codigoSeleccionado); // Llama el método adecuado

                // Verifica que el DataTable no sea nulo y contenga filas
                if (detallesProducto != null && detallesProducto.Rows.Count > 0)
                {
                    // Muestra los detalles en el DataGridView
                    Dgv_detalleProductos.DataSource = detallesProducto; // Asigna el DataTable al DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles para el producto seleccionado.");
                }

                // Oculta el panel de resultados una vez que se selecciona un producto
                panel_resultado.Visible = false;
            }
        }

        private void Cbo_clasificacionEspecifica_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_clasificacionSeleccionada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gpb_modo_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (Dgv_detalleProductos.DataSource != null)
            {
                // Crea un nuevo DataTable para el segundo DataGridView
                DataTable dtModificacion = new DataTable();

                // Clona la estructura de columnas del primer DataGridView
                dtModificacion = ((DataTable)Dgv_detalleProductos.DataSource).Clone();

                // Copia todas las filas del primer DataGridView al segundo
                foreach (DataGridViewRow row in Dgv_detalleProductos.Rows)
                {
                    if (!row.IsNewRow) // Ignora la fila nueva si existe
                    {
                        DataRow newRow = dtModificacion.NewRow();

                        // Copia los datos de la fila
                        foreach (DataColumn column in dtModificacion.Columns)
                        {
                            newRow[column.ColumnName] = row.Cells[column.ColumnName].Value;
                        }

                        dtModificacion.Rows.Add(newRow);
                    }
                }

                // Asigna el DataTable al segundo DataGridView
                Dgv_seleccionados.DataSource = dtModificacion;
            }
            else
            {
                MessageBox.Show("No hay productos para mover.");
            }
        }

        private void Rdb_precioventa_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_precioventa.Checked)
            {
                Txt_porcentaje.Visible = true; // Habilitar el TextBox
                Txt_porcentaje.Focus(); // Focalizar en el TextBox si lo deseas
            }
            else
            {
                Txt_porcentaje.Visible = false; // Ocultar el TextBox
                Txt_porcentaje.Clear();
            }
        }

        private void Rdb_costocompra_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_costocompra.Checked)
            {
                Txt_porcentaje.Visible = true; // Habilitar el TextBox
                Txt_porcentaje.Focus(); // Focalizar en el TextBox si lo deseas
            }
            else
            {
                Txt_porcentaje.Visible = false; // Ocultar el TextBox
                Txt_porcentaje.Clear();
            }
        }

        private void Rdb_forzar_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_costocompra.Checked)
            {
                Txt_forzado.Visible = true; // Habilitar el TextBox
                Txt_forzado.Focus(); // Focalizar en el TextBox si lo deseas
            }
            else
            {
                Txt_forzado.Visible = false; // Ocultar el TextBox
                Txt_forzado.Clear();
            }
        }


        private decimal[] preciosOriginales;

        private void Txt_porcentaje_TextChanged(object sender, EventArgs e)
        {

            // Asegúrate de que las columnas estén en el DataGridView
            if (!Dgv_seleccionados.Columns.Contains("Ganancia_Inicial"))
            {
                Dgv_seleccionados.Columns.Add("Ganancia_Inicial", "Ganancia Inicial");
            }

            if (!Dgv_seleccionados.Columns.Contains("Ganancia_Nueva"))
            {
                Dgv_seleccionados.Columns.Add("Ganancia_Nueva", "Ganancia Nueva");
            }

            // Verificar si se ha seleccionado un radio button
            if (Rdb_precioventa.Checked || Rdb_costocompra.Checked)
            {
                decimal porcentaje;

                // Validar el valor ingresado en el TextBox
                if (!decimal.TryParse(Txt_porcentaje.Text, out porcentaje) || porcentaje < 0)
                {
                    MessageBox.Show("Por favor, ingrese un porcentaje válido (no negativo).");
                    return; // Salir si el porcentaje no es válido
                }

                // Inicializar el array de precios originales si es necesario
                if (preciosOriginales == null || preciosOriginales.Length != Dgv_seleccionados.Rows.Count)
                {
                    preciosOriginales = new decimal[Dgv_seleccionados.Rows.Count];
                }

                foreach (DataGridViewRow row in Dgv_seleccionados.Rows)
                {
                    if (row.IsNewRow) continue; // Ignorar la fila de nueva entrada

                    // Restaurar valores originales y almacenar si es la primera vez
                    if (preciosOriginales[row.Index] == 0)
                    {
                        preciosOriginales[row.Index] = Convert.ToDecimal(row.Cells["Precio_Venta"].Value);
                    }

                    // Si se ha cambiado de radio button, restaurar los precios originales
                    if (Rdb_precioventa.Checked)
                    {
                        row.Cells["Costo_Compra"].Value = Convert.ToDecimal(row.Cells["Costo_Compra"].Value); // Mantener el valor
                        row.Cells["Precio_Venta"].Value = preciosOriginales[row.Index]; // Restaurar valor original
                    }
                    else if (Rdb_costocompra.Checked)
                    {
                        row.Cells["Precio_Venta"].Value = preciosOriginales[row.Index]; // Mantener el valor
                        row.Cells["Costo_Compra"].Value = Convert.ToDecimal(row.Cells["Costo_Compra"].Value); // Restaurar valor original
                    }

                    // Calcular precios y ganancias
                    decimal precioVenta = Convert.ToDecimal(row.Cells["Precio_Venta"].Value);
                    decimal costoCompra = Convert.ToDecimal(row.Cells["Costo_Compra"].Value);
                    decimal gananciaInicial = Math.Round(precioVenta - costoCompra, 2);

                    // Reestablecer ganancia inicial y nueva a cero
                    row.Cells["Ganancia_Inicial"].Value = gananciaInicial; // Guardar ganancia inicial
                    row.Cells["Ganancia_Nueva"].Value = 0; // Reiniciar ganancia nueva

                    // Realizar cálculos dependiendo del radio button seleccionado
                    if (Rdb_precioventa.Checked)
                    {
                        // Calcular el nuevo precio de venta (reducción)
                        decimal nuevoPrecio = Math.Round(precioVenta - (precioVenta * (porcentaje / 100)), 2);
                        row.Cells["Precio_Venta"].Value = nuevoPrecio; // Actualizar celda

                        // Calcular la nueva ganancia
                        decimal gananciaNueva = Math.Round(nuevoPrecio - costoCompra, 2);
                        row.Cells["Ganancia_Nueva"].Value = gananciaNueva; // Guardar nueva ganancia
                    }
                    else if (Rdb_costocompra.Checked)
                    {
                        // Calcular el nuevo costo de compra (puede ser incremento u otro cálculo)
                        decimal nuevoCosto = Math.Round(costoCompra + (costoCompra * (porcentaje / 100)), 2);
                        row.Cells["Costo_Compra"].Value = nuevoCosto; // Actualizar celda

                        // Calcular la nueva ganancia
                        decimal gananciaNueva = Math.Round(precioVenta - nuevoCosto, 2);
                        row.Cells["Ganancia_Nueva"].Value = gananciaNueva; // Guardar nueva ganancia
                    }
                }
            }

        }

        private void Txt_forzado_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            // Limpiar el primer DataGridView
            Dgv_detalleProductos.DataSource = null; // Desasigna cualquier DataSource existente
            Dgv_detalleProductos.Rows.Clear(); // Limpia las filas del DataGridView

            // Limpiar el segundo DataGridView
            Dgv_seleccionados.DataSource = null; // Desasigna cualquier DataSource existente
            Dgv_seleccionados.Rows.Clear(); // Limpia las filas del DataGridView

            // Limpiar combos
            Cbo_clasificacionGeneral.SelectedIndex = -1;
            Cbo_clasificacionEspecifica.SelectedIndex = -1;

            // Opcionalmente, puedes mostrar un mensaje de confirmación
            MessageBox.Show("La seleccion ha sido limpiada.");
        }
    }
}
