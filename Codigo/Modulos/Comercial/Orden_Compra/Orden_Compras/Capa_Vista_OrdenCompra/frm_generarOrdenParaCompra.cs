using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Controlador_OrdenCompra;
using System.Windows.Forms;

namespace Capa_Vista_OrdenCompra
{
    public partial class frm_generarOrdenParaCompra : Form
    {
        logica logic;

        string valorSeleccionadoproducto;
        string valorSeleccionadoEncabezado;
        public frm_generarOrdenParaCompra()
        {
            InitializeComponent();

            logic = new logica();
            string stablav = "Tbl_Productos";
            string scampo1v = "Pk_id_Producto";
            string scampo2v = "nombreProducto";

            string stablae = "Tbl_ordenes_compra";
            string scampo1e = "Pk_encOrCom_id";
            string scampo2e = "EncOrCom_numero";

            prollenarseProductos(stablav, scampo1v, scampo2v);
            prollenarseEncabezado(stablae, scampo1e, scampo2e);

            Cbo_ProDetOrCom.SelectedIndexChanged += new EventHandler(Cbo_ProDetOrCom_SelectedIndexChanged);
            Cmb_id_EncOrCom.SelectedIndexChanged += new EventHandler(Cmb_id_EncOrCom_SelectedIndexChanged_1);
        }

        public void prollenarseProductos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_ProDetOrCom.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_ProDetOrCom.Items.Add(new ComboBoxItem
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

            Cbo_ProDetOrCom.AutoCompleteCustomSource = coleccion;
            Cbo_ProDetOrCom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_ProDetOrCom.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }



        public void prollenarseEncabezado(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cmb_id_EncOrCom.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cmb_id_EncOrCom.Items.Add(new ComboBoxItem1
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

            Cmb_id_EncOrCom.AutoCompleteCustomSource = coleccion;
            Cmb_id_EncOrCom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cmb_id_EncOrCom.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem1
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }





        /*
        private void CargarProductos()
        {
            try
            {
                DataTable dtProducto = logic.funConsultaLogicaProductos();
                Cbo_ProDetOrCom.Items.Clear();
                foreach (DataRow row in dtProducto.Rows)
                {
                    Cbo_ProDetOrCom.Items.Add(row[0].ToString());
                }
                Cbo_ProDetOrCom.SelectedIndexChanged += new EventHandler(Cbo_ProDetOrCom_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        
        }*/


        private void Cbo_ProDetOrCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_generarOrdenParaCompra_Load_1(object sender, EventArgs e)
        {
            /*MessageBox.Show("Formulario cargando...");
             CargarProductos();
                 Cbo_ProDetOrCom.DropDownStyle = ComboBoxStyle.DropDownList;*/

            if (Cbo_ProDetOrCom.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItem)Cbo_ProDetOrCom.SelectedItem;
                valorSeleccionadoproducto = selectedItem.Value;

                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");
            }
            if (Cbo_ProDetOrCom.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItem)Cmb_id_EncOrCom.SelectedItem;
                valorSeleccionadoEncabezado = selectedItem.Value;
            }

            }

        private void Cmb_id_EncOrCom_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            


            }
        }
}

