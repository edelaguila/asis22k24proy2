using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Implosion_Explosion; // Importamos el controlador actualizado

namespace Capa_Vista_Implosion_Explosion
{
    public partial class Frm_Implosion_Explosion_Materiales : Form
    {
        private readonly Control_Implosion_Explosion_Materiales control;

        public Frm_Implosion_Explosion_Materiales()
        {
            InitializeComponent();
            control = new Control_Implosion_Explosion_Materiales();
            CargarProductos();
        }

        // Método para cargar materias primas y productos terminados en los ComboBox correspondientes
        private void CargarProductos()
        {
            // Cargar materias primas en ComboBox de implosión
            DataTable materiasPrimas = control.ObtenerMateriasPrimas();
            cmb_implosion.DataSource = materiasPrimas;
            cmb_implosion.DisplayMember = "nombreProducto";
            cmb_implosion.ValueMember = "Pk_id_Producto";

            // Cargar productos terminados en ComboBox de explosión
            DataTable productosTerminados = control.ObtenerProductosTerminados();
            cmb_explosion.DataSource = productosTerminados;
            cmb_explosion.DisplayMember = "nombreProducto";
            cmb_explosion.ValueMember = "Pk_id_Producto";
        }

        // Lógica del botón Explosión
        private void Btn_Explosion_Click(object sender, EventArgs e)
        {
            if (cmb_explosion.SelectedValue == null || !int.TryParse(cmb_explosion.SelectedValue.ToString(), out int idProducto))
            {
                MessageBox.Show("Por favor, seleccione un producto válido para la explosión.");
                return;
            }

            if (!int.TryParse(txt_cantidad_ex.Text, out int cantidadDeseada))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            // Obtener los materiales necesarios para el producto en base a la cantidad deseada
            DataTable materiales = control.ObtenerMaterialesParaProducto(idProducto, cantidadDeseada);

            if (materiales.Rows.Count > 0)
            {
                string mensaje = $"Explosión para {cantidadDeseada} unidad(es) del producto seleccionado:\nIngredientes necesarios:\n";
                foreach (DataRow row in materiales.Rows)
                {
                    string nombreMaterial = row["nombreProducto"].ToString();
                    int cantidadNecesaria = Convert.ToInt32(row["cantidadNecesaria"]);
                    mensaje += $"- {nombreMaterial}: {cantidadNecesaria} unidades\n";
                }

                MessageBox.Show(mensaje, "Resultado de la explosión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron materiales para este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lógica del botón Implosión
        private void Btn_Implosion_Click(object sender, EventArgs e)
        {
            if (cmb_implosion.SelectedValue == null || !int.TryParse(cmb_implosion.SelectedValue.ToString(), out int idMaterial))
            {
                MessageBox.Show("Por favor, seleccione un material válido para la implosión.");
                return;
            }

            if (!int.TryParse(txt_cantidad_implosion.Text, out int cantidadDisponible))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de material disponible.");
                return;
            }

            DataTable recetas = control.ObtenerRecetasParaMaterial(idMaterial);

            if (recetas.Rows.Count > 0)
            {
                string mensaje = $"Implosión para {cantidadDisponible} unidad(es) del material seleccionado:\n";
                foreach (DataRow row in recetas.Rows)
                {
                    string nombreProducto = row["nombreProducto"].ToString();
                    int cantidadPorProducto = Convert.ToInt32(row["cantidad"]);
                    int productosPosibles = cantidadDisponible / cantidadPorProducto;
                    mensaje += $"- Puede producir {productosPosibles} unidad(es) de {nombreProducto}.\n";
                }
                MessageBox.Show(mensaje, "Resultado de la implosión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron productos que utilicen este material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
