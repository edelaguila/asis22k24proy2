using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_ListaPrecios;

namespace Capa_Vista_ListaPrecios
{
    public partial class frm_ListadoInicio : Form
    {
        string idUsuario;
        logica logic;

        public frm_ListadoInicio(string idUsuario)
        {
            InitializeComponent();

            //tooltips
            ToolTip tcrearLista = new ToolTip();
            tcrearLista.SetToolTip(Btn_crearLista, "Crear Lista");
            ToolTip teliminarLista = new ToolTip();
            teliminarLista.SetToolTip(Btn_eliminarLista, "Eliminar Lista");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir");
            ToolTip treporte = new ToolTip();
            treporte.SetToolTip(Btn_repote, "Reporte Lista");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
            logic = new logica(idUsuario);
            mostrarencabezados();
            Dgv_listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Agregar opciones al ComboBox de estado
            Cbo_estado.Items.Add("Activo");
            Cbo_estado.Items.Add("Inactivo");

            // Manejar el evento de estado encabezado
            Cbo_estado.SelectedIndexChanged += Cbo_estado_SelectedIndexChanged;
        }

        public frm_ListadoInicio()
        {
        }

        private void frm_ListadoDetalle_Load(object sender, EventArgs e)
        {
            CargarClasificacionesListas();
           // CargarClasificacionesEditar();
        }

        private DataTable originalDataTable;
        //muestra los encabezados en el form del inicio
        void mostrarencabezados()
        {
            try
            {
                DataTable dtencabezado;

                dtencabezado = logic.funcargarEncabezados();

                if (dtencabezado == null || dtencabezado.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    originalDataTable = dtencabezado; // Guarda los datos originales
                    Dgv_listado.DataSource = originalDataTable; 

                    // Crear un mensaje que muestre el nombre y el tipo de cada columna
                    //StringBuilder mensaje = new StringBuilder("Formato de las columnas:\n\n");

                    /*foreach (DataColumn columna in dtencabezado.Columns)
                    {
                        mensaje.AppendLine($"Columna: {columna.ColumnName} - Tipo: {columna.DataType}");
                    }

                    MessageBox.Show(mensaje.ToString(), "Información de las Columnas", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }
        /*************************************************/

        //redirige a el formulario donde se crean las listas
        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            frm_ListadoPrecios nuevoForm = new frm_ListadoPrecios(idUsuario); 
            nuevoForm.Show(); // Muestra el formulario
        }

        /*private void button6_Click(object sender, EventArgs e)
        {
            frm_MantenimientoListas nuevoForm = new frm_MantenimientoListas(idUsuario); // Instancia del nuevo formulario
            nuevoForm.Show(); // Muestra el formulario
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Cbo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        //busqueda por tipo de lista (a quien va diriga) o por estado (activo-inactivo)
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rdb_estado.Checked)
                {
                    string estadoSeleccionado = Cbo_estado.SelectedItem?.ToString();
                    Console.WriteLine("Estado seleccionado: " + estadoSeleccionado); 
                    BuscarPorEstado(estadoSeleccionado);
                }
                else if (Rdb_tipo.Checked)
                {
                    string tipoSeleccionado = Cbo_tipo.Text;
                    Console.WriteLine("Tipo seleccionado: " + tipoSeleccionado); 
                    BuscarPorTipo(tipoSeleccionado);
                }
                else
                {
                    MessageBox.Show("Seleccione una opción de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //busqueda por estado de encabezado
        private void BuscarPorEstado(string estadoSeleccionado)
        {
            if (string.IsNullOrEmpty(estadoSeleccionado))
            {
                MessageBox.Show("Seleccione un estado válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // cargar los encabezados por estado
            DataTable dtEncabezadosEstado = logic.funcargarEncabezadosPorTipoE(estadoSeleccionado);

            if (dtEncabezadosEstado == null || dtEncabezadosEstado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros para el estado seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dgv_listado.DataSource = null; 
            }
            else
            {
                Dgv_listado.DataSource = dtEncabezadosEstado; 
            }
        }

        //busqueda por tipo de lista
        private void BuscarPorTipo(string tipoSeleccionado)
        {
            // Muestra el tipo seleccionado en un cuadro de mensaje
            //MessageBox.Show("Tipo seleccionado: " + tipoSeleccionado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (string.IsNullOrEmpty(tipoSeleccionado))
            {
                MessageBox.Show("Seleccione un tipo válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Carga los datos filtrados por el tipo seleccionado
            DataTable dtEncabezadosTipo = logic.funcargarEncabezadosPorTipoL(tipoSeleccionado);

            if (dtEncabezadosTipo == null || dtEncabezadosTipo.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros para el tipo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Dgv_listado.DataSource = null;
            }
            else
            {
                Dgv_listado.DataSource = dtEncabezadosTipo; 
            }
        }
        
        //carga los tipos de clasificaciones que se crean/manejan por un mantenimiento llamado mantenimiento clasificaciones
        private void CargarClasificacionesListas()
        {
            try
            {
                DataTable tableListas = logic.funcargarEncabezadosPorTipo();

                if (tableListas != null && tableListas.Rows.Count > 0)
                {
                    Cbo_tipo.DataSource = tableListas;
                    Cbo_tipo.DisplayMember = "Clasificaciones"; // El nombre de la columna mostrada
                    Cbo_tipo.ValueMember = "Pk_id_clasificacion"; // O el ID correspondiente
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de listas: {ex.Message}");
            }
        }

        private void Cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //eliminacion de encabezados y detalles DEFINITIVOS 
        private void Btn_eliminarLista_Click(object sender, EventArgs e)
        {
            if (Dgv_listado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del encabezado de la lista seleccionado
            int idEncabezado = Convert.ToInt32(Dgv_listado.SelectedRows[0].Cells["Codigo Lista"].Value);

            // Confirmar eliminación
            DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta lista, será permanente?",
                                                          "Confirmación de eliminación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Llamar a la función que elimina el encabezado y sus detalles
                    logic.funeliminarlista(idEncabezado);
                    MessageBox.Show("El encabezado y sus detalles han sido eliminados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Volver a cargar el DataGridView
                    mostrarencabezados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            /*    if (Dgv_listado.SelectedRows.Count > 0)
            {
            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = Dgv_listado.SelectedRows[0];

            // Obtener los datos de la fila
            int iCodigoEncabezado = (int)filaSeleccionada.Cells["Codigo Lista"].Value;
            string nombreClasificacion = filaSeleccionada.Cells["Tipo de Lista"].Value.ToString();
            DateTime sFecha = (DateTime)filaSeleccionada.Cells["Fecha Creacion"].Value;

            // Convertir el estado numérico a texto
            int estadoValor = Convert.ToInt32(filaSeleccionada.Cells["Estado"].Value);
            string sEstado = estadoValor == 1 ? "Activo" : "Inactivo";

            // Mostrar los datos de la fila en un MessageBox
            string mensaje = $"Código Lista: {iCodigoEncabezado}\n" +
                             $"Clasificación: {nombreClasificacion}\n" +
                             $"Fecha de Creación: {sFecha.ToString("dd/MM/yyyy")}\n" +
                             $"Estado: {sEstado}";
            MessageBox.Show(mensaje, "Datos de la Fila Seleccionada");

            // Obtener el ID de la clasificación a partir del nombre
            if (clasificacionesDict.TryGetValue(nombreClasificacion, out int iClasificacion))
            {
                // Abrir el formulario donde mostrarás los datos
                frm_ListadoPrecios mostrarDatosForm = new frm_ListadoPrecios(idUsuario);
                mostrarDatosForm.CargarDatos(iCodigoEncabezado, sFecha, sEstado, nombreClasificacion);
                mostrarDatosForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: No se encontró la clasificación para el nombre seleccionado.");
            }
        }
        else
        {
            MessageBox.Show("Por favor, seleccione una fila para mostrar los datos.");
        }*/
            frm_ListadoPrecios mostrarDatosForm = new frm_ListadoPrecios(idUsuario);
            mostrarDatosForm.ShowDialog();
        }

        /*public void HabilitarBotones(bool habilitar)
        {
            Btn_editar.Enabled = habilitar; // Cambia 'Btn_Boton1' por el nombre real de tu botón
            Btn_actualizar.Enabled = habilitar; // Cambia 'Btn_Boton2' por el nombre real de tu botón
        }*/

        private Dictionary<string, int> clasificacionesDict;

        private void CargarClasificacionesEditar()
        {
            /*try
            {
                DataTable tableListas = logic.funcargarEncabezadosPorTipo();

                clasificacionesDict = new Dictionary<string, int>(); // Inicializa el diccionario

                if (tableListas != null && tableListas.Rows.Count > 0)
                {
                    Cbo_tipo.DataSource = tableListas;
                    Cbo_tipo.DisplayMember = "Clasificaciones"; // Nombre de la columna mostrada
                    Cbo_tipo.ValueMember = "Pk_id_clasificacion"; // ID correspondiente

                    // Llena el diccionario
                    foreach (DataRow row in tableListas.Rows)
                    {
                        int id = Convert.ToInt32(row["Pk_id_clasificacion"]);
                        string nombre = row["Clasificaciones"].ToString();
                        clasificacionesDict[nombre] = id; // Agrega al diccionario
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de listas: {ex.Message}");
            }*/
        }

        private void Dgv_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_repote_Click(object sender, EventArgs e)
        {
            //ReporteLista frm = new ReporteLista();
            //frm.Show();
        

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Ruta completa al archivo de ayuda
                string ayudaFilePath = @"C:\Users\User\Desktop\TRABAJO_INDIVIDUAL\asis22k24proy2\Codigo\Modulos\Comercial\Listas Precios\AyudaListas\Ayuda.chm";


                // Verificar si el archivo existe
                if (File.Exists(ayudaFilePath))
                {
                    // Abrir el archivo de ayuda .chm en la sección específica
                    Help.ShowHelp(this, ayudaFilePath, "Manual-Listas-de-Precios.html");
                }
                else
                {
                    // Si el archivo no se encuentra, mostrar un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje si ocurre un error
                MessageBox.Show("Error al abrir la ayuda: " + ex.Message);
            }
        }

        /*private string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }*/
    }
}
