using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Lotes;

namespace Capa_Vista_Lotes
{
    public partial class Frm_Lotes : Form
    {
        private Control_Lotes controlLotes;

        public Frm_Lotes()
        {
            InitializeComponent();
            controlLotes = new Control_Lotes();
            CargarCombos();
            GenerarNuevoIdLote();
            CargarLotes();
        }

        // Método para cargar los combos de producto y proceso
        private void CargarCombos()
        {
            // Cargar productos en Cbo_Producto
            Cbo_Producto.DataSource = controlLotes.CargarProductos();
            Cbo_Producto.DisplayMember = "nombreProducto";
            Cbo_Producto.ValueMember = "Pk_id_Producto";
            Cbo_Producto.SelectedIndex = -1;

            // Cargar procesos en Cbo_Proceso
            Cbo_Proceso.DataSource = controlLotes.CargarProcesos();
            Cbo_Proceso.DisplayMember = "Fk_id_orden";
            Cbo_Proceso.ValueMember = "Pk_id_proceso";
            Cbo_Proceso.SelectedIndex = -1;
        }

        // Método para cargar los datos en el DataGridView
        private void CargarLotes()
        {
            DataTable lotes = controlLotes.CargarLotes();
            dgv_Lotes.DataSource = lotes;
            Console.WriteLine("Lotes cargados en dgv_Lotes.");
        }

        // Método para generar un nuevo ID de lote automáticamente
        private void GenerarNuevoIdLote()
        {
            int nuevoId = controlLotes.ObtenerUltimoIdLotes() + 1;
            Txt_Id_Lotes.Text = nuevoId.ToString();
        }

        // Evento para limpiar el formulario y preparar para un nuevo lote
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            GenerarNuevoIdLote();
            Txt_Codigo_Lote.Clear();
            Txt_Cantidad.Clear();
            Cbo_Producto.SelectedIndex = -1;
            Cbo_Proceso.SelectedIndex = -1;
            Cbo_Estado_Lotes.SelectedIndex = 0; // Activo por defecto
        }

        // Evento para agregar un nuevo lote
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idLote = int.Parse(Txt_Id_Lotes.Text);
                string codigoLote = Txt_Codigo_Lote.Text;
                DateTime fechaProduccion = Dtp_Fecha_Produccion.Value;
                int cantidad = int.Parse(Txt_Cantidad.Text);
                int estado = Cbo_Estado_Lotes.SelectedIndex == 0 ? 1 : 0;
                int idProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);

                controlLotes.AgregarLotes(idLote, codigoLote, fechaProduccion, cantidad, estado, idProducto);
                MessageBox.Show("Lote agregado correctamente.");
                btn_Nuevo_Click(sender, e);
                CargarLotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el lote: " + ex.Message);
            }
        }

        // Evento para actualizar un lote existente con confirmación
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea actualizar este lote?", "Confirmar actualización", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int idLote = int.Parse(Txt_Id_Lotes.Text);
                    string codigoLote = Txt_Codigo_Lote.Text;
                    DateTime fechaProduccion = Dtp_Fecha_Produccion.Value;
                    int cantidad = int.Parse(Txt_Cantidad.Text);
                    int estado = Cbo_Estado_Lotes.SelectedIndex == 0 ? 1 : 0;
                    int idProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);

                    controlLotes.ActualizarLotes(idLote, codigoLote, fechaProduccion, cantidad, estado, idProducto);
                    MessageBox.Show("Lote actualizado correctamente.");
                    btn_Nuevo_Click(sender, e);
                    CargarLotes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el lote: " + ex.Message);
                }
            }
        }

        // Evento para eliminar (desactivar) un lote con confirmación
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea desactivar este lote?", "Confirmar desactivación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int idLote = int.Parse(Txt_Id_Lotes.Text);
                    controlLotes.DesactivarLotes(idLote);
                    MessageBox.Show("Lote desactivado correctamente.");
                    btn_Nuevo_Click(sender, e);
                    CargarLotes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al desactivar el lote: " + ex.Message);
                }
            }
        }

        // Método para cargar los datos de un lote seleccionado en los campos
        private void dgv_Lotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Lotes.Rows[e.RowIndex];
                Txt_Id_Lotes.Text = row.Cells["Pk_id_lote"].Value.ToString();
                Txt_Codigo_Lote.Text = row.Cells["codigo_lote"].Value.ToString();
                Dtp_Fecha_Produccion.Value = DateTime.Parse(row.Cells["Fecha_Producción"].Value.ToString());
                Txt_Cantidad.Text = row.Cells["cantidad"].Value.ToString();
                Cbo_Producto.SelectedValue = row.Cells["Fk_id_producto"].Value;
                Cbo_Proceso.SelectedValue = row.Cells["Pk_id_proceso"].Value;
                Cbo_Estado_Lotes.SelectedIndex = (int)row.Cells["estado"].Value == 1 ? 0 : 1;
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte lotes = new Frm_Reporte();
            lotes.Show();
        }
    }
}
