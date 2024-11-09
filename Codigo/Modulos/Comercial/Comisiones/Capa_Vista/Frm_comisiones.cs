using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using System.Globalization;
using System.IO;

namespace Capa_Vista
{
    public partial class Frm_comisiones : Form
    {
        Logica logica = new Logica();
       

        // Variable para almacenar el porcentaje de comisión
        private decimal dePorcentajeComision;

        public Frm_comisiones()
        {
            InitializeComponent();
            funCargarVendedores();
            Cbo_filtro.Enabled = false;
            Cbo_vendedor.SelectedIndex = -1;
            Lbl_filtro.Text = "";
        }

        // Método para cargar vendedores en el ComboBox al iniciar el formulario
        private void funCargarVendedores()
        {
            try
            {
                DataTable dtVendedores = logica.funObtenerVendedores();
                Cbo_vendedor.DataSource = dtVendedores;
                Cbo_vendedor.DisplayMember = "NombreCompleto";
                Cbo_vendedor.ValueMember = "Pk_id_vendedor";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar vendedores: " + ex.Message);
            }
        }

        // Evento para buscar ventas de acuerdo al vendedor y al filtro
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
           
        }

        // Método para calcular el total de ventas mostrado en el DataGridView
        private void funCalcularTotalVentas()
        {
            decimal deTotalVentas = 0;
            foreach (DataGridViewRow row in Dgv_ventas.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    deTotalVentas += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            Txt_venta.Text = deTotalVentas.ToString("C", new CultureInfo("es-GT")); // Muestra el total en formato de moneda Q
        }

        
        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            
        }

        private void Cbo_vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
        
        // Evento para calcular la comisión al hacer clic en "Calcular"
        private void Btn_calcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya un total válido en Txt_venta
                if (decimal.TryParse(Txt_venta.Text, NumberStyles.Currency, new CultureInfo("es-GT"), out decimal deTotalVentas))
                {
                    // Leer el porcentaje de comisión desde Txt_porcentaje
                    if (decimal.TryParse(Txt_porcentaje.Text.Replace("%", ""), out decimal dePorcentajeComision))
                    {
                        // Convertir el porcentaje a decimal (por ejemplo, 20% -> 0.20)
                        dePorcentajeComision /= 100;

                        // Calcular la comisión total multiplicando el total de ventas por el porcentaje de comisión
                        decimal deTotalComision = deTotalVentas * dePorcentajeComision;
                        Txt_comision.Text = deTotalComision.ToString("C", new CultureInfo("es-GT"));

                        // Obtener el ID del vendedor
                        int iIdVendedor = (int)Cbo_vendedor.SelectedValue;

                        // Llamar a la lógica para guardar la comisión en la base de datos
                        bool bGuardado = logica.funGuardarComision(iIdVendedor, DateTime.Now, deTotalVentas, deTotalComision, dePorcentajeComision, funObtenerVentasSeleccionadas());

                        if (bGuardado)
                        {
                            MessageBox.Show("Comisión guardada exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al guardar la comisión.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, introduce un porcentaje de comisión válido en el formato correcto.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, asegurese de haber seleccionado un vendedor y los filtros de ventas necesarios.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular la comisión: " + ex.Message);
            }
        }

        // Método para obtener los IDs de las ventas seleccionadas en el DataGridView
        private List<string> funObtenerVentasSeleccionadas()
        {
            List<string> sVentasSeleccionadas = new List<string>();
            foreach (DataGridViewRow row in Dgv_ventas.Rows)
            {
                if (row.Cells["IdVenta"].Value != null) // "IdVenta" es el nombre de la columna que contiene el ID de la venta
                {
                    sVentasSeleccionadas.Add(row.Cells["IdVenta"].Value.ToString());
                }
            }
            return sVentasSeleccionadas;
        }

    private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            Txt_porcentaje.Clear();
            Txt_venta.Clear();
            Txt_comision.Clear();
            Txt_nombre.Clear();
            Lbl_filtro.Text = "";

            // Desmarcar los RadioButton
            Rdb_inventario.Checked = false;
            Rdb_marcas.Checked = false;
            Rdb_lineas.Checked = false;
            Rdb_costo.Checked = false;

            //Habilitar los radioButton
            Rdb_inventario.Enabled = true;
            Rdb_marcas.Enabled = true;
            Rdb_lineas.Enabled = true;
            Rdb_costo.Enabled = true;

            // Restablecer el ComboBox al valor predeterminado
            Cbo_vendedor.SelectedIndex = -1;
            Cbo_filtro.SelectedIndex = -1;
            
            //Habilitar combobox
            Cbo_vendedor.Enabled = true;

            // Limpiar el DataGridView
            Dgv_ventas.DataSource = null;

            // Restablecer los DateTimePicker a sus valores predeterminados
            Dtp_fecha_inicio.Value = DateTime.Now;
            Dtp_fecha_fin.Value = DateTime.Now;
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Frm_reporte rpt = new Frm_reporte();
            rpt.Show();
        }
        //funciones para el test unitario y no exponer directamente las propiedades
        public decimal deVenta
        {
            get { return decimal.Parse(Txt_venta.Text); }
            set { Txt_venta.Text = value.ToString(); }
        }

        public void funEstablecerPorcentajeComision(decimal dePorcentaje)
        {
            dePorcentajeComision = dePorcentaje;
        }

        private decimal _deComisionCalculada;

        public decimal deComisionCalculada
        {
            get { return _deComisionCalculada; }
            private set { _deComisionCalculada = value; }
        }

        public void funCalcularComision()
        {
            deComisionCalculada = deVenta * dePorcentajeComision; // Calcula y asigna la comisión
            Txt_comision.Text = deComisionCalculada.ToString("C", new CultureInfo("es-GT")); // Actualiza el TextBox con formato
        }


        public string funObtenerTextoComision()
        {
            return Txt_comision.Text;
        }
        //fin test
        private void Frm_comisiones_Load(object sender, EventArgs e)
        {

        }

        private void Gpb_ventas_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_vendedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un vendedor.");
                    return;
                }

                int iIdVendedor = (int)Cbo_vendedor.SelectedValue;
                string sFiltro = ""; // Inicializamos el filtro como una cadena vacía
                DateTime dFechaInicio = Dtp_fecha_inicio.Value;
                DateTime dFechaFin = Dtp_fecha_fin.Value;
                string sValorFiltro = Cbo_filtro.SelectedValue?.ToString(); // Valor de marca o línea

                // Asignar el filtro según el RadioButton seleccionado
                if (Rdb_inventario.Checked)
                {
                    sFiltro = "Inventario";
                }
                else if (Rdb_marcas.Checked && !string.IsNullOrEmpty(sValorFiltro))
                {
                    sFiltro = "Marcas";
                }
                else if (Rdb_lineas.Checked && !string.IsNullOrEmpty(sValorFiltro))
                {
                    sFiltro = "Lineas";
                }
                else if (Rdb_costo.Checked)
                {
                    sFiltro = "Costo";
                }
                else
                {
                    MessageBox.Show("Seleccione un filtro(Inventario, Marcas, etc.) y periodo de fechas a buscar.");
                    return;
                }

                // Llamar al método de lógica para obtener las ventas filtradas
                DataTable dtVentas = logica.funObtenerVentasFiltradas(iIdVendedor, sFiltro, dFechaInicio, dFechaFin, sValorFiltro);
                Dgv_ventas.DataSource = dtVentas;

                // Mostrar la comisión
                if (dtVentas.Rows.Count > 0)
                {
                    // Obtiene el valor de la comisión de la primera fila
                    decimal comision = Convert.ToDecimal(dtVentas.Rows[0]["Comision"]);
                    Txt_porcentaje.Text = $"{comision * 100}%"; // Convierte a porcentaje
                }

                Rdb_inventario.Enabled = false;
                Rdb_marcas.Enabled = false;
                Rdb_lineas.Enabled = false;
                Rdb_costo.Enabled = false;

                Cbo_vendedor.Enabled = false;

                // Calcular el total de ventas
                funCalcularTotalVentas();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al buscar ventas: " + ex.Message);
            }
        }

        private void TtReporte_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void Rdb_marcas_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_marcas.Checked)
            {
                Lbl_filtro.Text = "Elegir marca";
                funCargarFiltro("Marca");
                Cbo_filtro.Enabled = true;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }

        private void Rdb_lineas_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_lineas.Checked)
            {
                Lbl_filtro.Text = "Elegir línea";
                funCargarFiltro("Línea");
                Cbo_filtro.Enabled = true;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }

        private void funCargarFiltro(string tipoFiltro)
        {
            try
            {
                DataTable dtFiltro;
                if (tipoFiltro == "Marca")
                {
                    // Limpiar DataSource anterior
                    Cbo_filtro.DataSource = null;

                    dtFiltro = logica.funObtenerMarcas();
                    Cbo_filtro.DisplayMember = "nombre_Marca";
                    Cbo_filtro.ValueMember = "Pk_id_Marca";
                }
                else // Línea
                {
                    // Limpiar DataSource anterior
                    Cbo_filtro.DataSource = null;

                    dtFiltro = logica.funObtenerLineas();
                    Cbo_filtro.DisplayMember = "nombre_linea";
                    Cbo_filtro.ValueMember = "Pk_id_linea";
                }

                Cbo_filtro.DataSource = dtFiltro;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el filtro: " + ex.Message);
            }
        }

        private void Rdb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_inventario.Checked)
            {
                Lbl_filtro.Text = "";
                Cbo_filtro.SelectedIndex = -1;
                Cbo_filtro.Enabled = false;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }
        private void Rdb_costo_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_costo.Checked)
            {
                Lbl_filtro.Text = "";
                Cbo_filtro.SelectedIndex = -1;
                Cbo_filtro.Enabled = false;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }

        private void Cbo_vendedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Verificamos que haya un valor seleccionado en el ComboBox
            if (Cbo_vendedor.SelectedItem != null)
            {
                // Convierte el elemento seleccionado en un DataRowView para acceder a sus campos
                var selectedItem = (DataRowView)Cbo_vendedor.SelectedItem;

                // Obtenemos el nombre o cualquier otro campo que desees mostrar en el TextBox
                Txt_nombre.Text = selectedItem["NombreCompleto"].ToString();
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string sProjectPath = Path.GetFullPath(Path.Combine(sExecutablePath, @"..\..\..\..\..\..\Ayuda\Modulos\Comercial\"));
            MessageBox.Show("1" + sProjectPath);


            string sAyudaFolderPath = Path.Combine(sProjectPath, "AyudaComisiones");

            string sPathAyuda = funFindFileInDirectory(sAyudaFolderPath, "Comisiones.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
                MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, sPathAyuda, "Comisiones.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }
        }

        private string funFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sDirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in sFiles)
                    {
                        if (Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {   //Mensaje de No se encontro la carpeta
                    MessageBox.Show("No se encontró la carpeta: " + sDirectory);
                }
            }
            catch (Exception ex)
            {       //Mensaje de error al buscar el archivo
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

    }
}
