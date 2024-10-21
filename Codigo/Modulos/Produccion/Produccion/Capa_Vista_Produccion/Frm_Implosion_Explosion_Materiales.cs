using Capa_Controlador_Produccion;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Implosion_Explosion_Materiales : Form
    {
        private readonly Control_Implosion_Explosion_Materiales control;

        public Frm_Implosion_Explosion_Materiales()
        {
            InitializeComponent();
            control = new Control_Implosion_Explosion_Materiales();
            CargarProductos(); // Llamamos al método que carga los productos en los ComboBox
        }

        // Método para cargar los productos en los ComboBox según la serie
        private void CargarProductos()
        {
            // Llenar ComboBox de implosión con productos que tengan la serie "B"
            DataTable productosImplosion = control.ObtenerProductosPorSerie("B");
            cmb_implosion.DataSource = productosImplosion;
            cmb_implosion.DisplayMember = "Nombre";  // Mostrar el nombre del producto
            cmb_implosion.ValueMember = "id_producto";  // Valor interno del producto (pero no se mostrará)

            // Llenar ComboBox de explosión con productos que tengan la serie "A"
            DataTable productosExplosion = control.ObtenerProductosPorSerie("A");
            cmb_explosion.DataSource = productosExplosion;
            cmb_explosion.DisplayMember = "Nombre";  // Mostrar el nombre del producto
            cmb_explosion.ValueMember = "id_producto";  // Valor interno del producto (pero no se mostrará)
        }

        // Lógica del botón Explosión
        private void Btn_Explosion_Click(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado en el ComboBox de explosión
            string productoSeleccionado = cmb_explosion.Text;

            // Obtener la cantidad ingresada en el TextBox de explosión
            if (!int.TryParse(txt_cantidad_ex.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            // Definir las recetas predefinidas según el producto seleccionado
            string mensaje = "";
            switch (productoSeleccionado)
            {
                case "Cama King":
                    mensaje = $"Explosión para {cantidad} {productoSeleccionado}:\n" +
                              $"Necesita {cantidad * 20} unidades de 50 Esponja.\n" +
                              $"Necesita {cantidad * 10} unidades de Tela para colchón.";
                    break;

                case "Cama Queen":
                    mensaje = $"Explosión para {cantidad} {productoSeleccionado}:\n" +
                              $"Necesita {cantidad * 15} unidades de 50 Esponja.\n" +
                              $"Necesita {cantidad * 12} unidades de Tela para colchón.";
                    break;

                case "Cama Doble":
                    mensaje = $"Explosión para {cantidad} {productoSeleccionado}:\n" +
                              $"Necesita {cantidad * 30} unidades de 50 Esponja.\n" +
                              $"Necesita {cantidad * 20} unidades de Tela para colchón.";
                    break;

                default:
                    mensaje = "No hay una receta definida para este producto.";
                    break;
            }

            // Mostrar el resultado en un cuadro de mensaje
            MessageBox.Show(mensaje, "Resultado de la explosión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Lógica del botón Implosión
        private void Btn_Implosion_Click(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado en el ComboBox de implosión
            string productoSeleccionado = cmb_implosion.Text;

            // Definir las recetas predefinidas (momentáneas) para la implosión
            string mensaje = "";
            switch (productoSeleccionado)
            {
                case "50 Esponja":
                    mensaje = $"Implosión para {productoSeleccionado}:\n" +
                              $"Con 50 unidades de esponja puedes producir:\n" +
                              $"- {50 / 20} camas King\n" +
                              $"- {50 / 15} camas Queen\n" +
                              $"- {50 / 30} camas Doble.";
                    break;

                case "Tela para colchón":
                    mensaje = $"Implosión para {productoSeleccionado}:\n" +
                              $"Con 100 unidades de tela puedes producir:\n" +
                              $"- {100 / 10} camas King\n" +
                              $"- {100 / 12} camas Queen\n" +
                              $"- {100 / 20} camas Doble.";
                    break;

                default:
                    mensaje = "No hay una receta definida para este material.";
                    break;
            }

            // Mostrar el resultado en un cuadro de mensaje
            MessageBox.Show(mensaje, "Resultado de la implosión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
