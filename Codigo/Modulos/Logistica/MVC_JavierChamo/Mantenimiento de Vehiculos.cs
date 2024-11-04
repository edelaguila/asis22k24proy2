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

namespace MVC_JavierChamo
{
    public partial class Mantenimiento_de_Vehiculos : Form
    {
        Capa_Controlador.Controlador capa_Controlador_Logistica = new Capa_Controlador.Controlador();

        public Mantenimiento_de_Vehiculos()
        {
            InitializeComponent();
            capa_Controlador_Logistica.MostrarSolicitudesMantenimiento();
            CargarSolicitudesenDatagriedView();
        }
        public void btn_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                capa_Controlador_Logistica.RealizarSolicitudMantenimiento(txt_NombreSolicitante.Text, cmb_TipoMantenimiento.Text, cmb_ComponenteAfectado.Text, Fecha_mantenimiento.Text, txt_responsableAsignado.Text, txt_CodigoError.Text, cmb_Estado.Text, txt_TiempoEstimado.Text, Convert.ToInt32(txt_fk_id_vehiculo.Text));
                LimpiarTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex);
            }
        }
        public void CargarSolicitudesenDatagriedView()
        {
            try
            {
                // Obtener los datos de la tabla
                DataTable tablaMantenimiento = capa_Controlador_Logistica.MostrarSolicitudesMantenimiento();

                // Asignar los datos al DataGridView
                dgbMantenimiento.DataSource = tablaMantenimiento;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos en el DataGridView: " + ex.Message);
            }
        }
        public void LimpiarTextbox()
        {
            txtID_mantenimiento.Clear();
            txt_NombreSolicitante.Clear();
            txt_responsableAsignado.Clear();
            txt_CodigoError.Clear();
            txt_TiempoEstimado.Clear();
            txt_fk_id_vehiculo.Clear();
        }

        private void btn_generarPDF_Click(object sender, EventArgs e)
        {
            GenerarPDF generarPDF = new GenerarPDF();
            generarPDF.Show();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                capa_Controlador_Logistica.ModificarSolicitudMantenimiento(Convert.ToInt32(txtID_mantenimiento.Text), txt_NombreSolicitante.Text, cmb_TipoMantenimiento.Text, cmb_ComponenteAfectado.Text, Fecha_mantenimiento.Text, txt_responsableAsignado.Text, txt_CodigoError.Text, cmb_Estado.Text, txt_TiempoEstimado.Text, Convert.ToInt32(txt_fk_id_vehiculo.Text));
                LimpiarTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex);
            }
        }

        private void dgbMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgbMantenimiento.Rows[e.RowIndex];
                txt_NombreSolicitante.Text = row.Cells["nombre_Solicitante"].Value.ToString();
                cmb_TipoMantenimiento.Text = row.Cells["tipo_de_Mantenimiento"].Value.ToString();
                cmb_ComponenteAfectado.Text = row.Cells["componente_Afectado"].Value.ToString();
                Fecha_mantenimiento.Text = row.Cells["fecha"].Value.ToString();
                txt_responsableAsignado.Text = row.Cells["responsable_Asignado"].Value.ToString();
                txt_CodigoError.Text = row.Cells["codigo_Error_Problema"].Value.ToString();
                cmb_Estado.Text = row.Cells["estado_del_Mantenimiento"].Value.ToString();
                txt_TiempoEstimado.Text = row.Cells["tiempo_Estimado"].Value.ToString();
                txt_fk_id_vehiculo.Text = row.Cells["Fk_id_vehiculo"].Value.ToString();

                int idMantenimiento = Convert.ToInt32(row.Cells["Pk_id_mantenimiento"].Value);
                txtID_mantenimiento.Text = idMantenimiento.ToString();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID_mantenimiento.Text))
                {
                    int idMantenimeinto = Convert.ToInt32(txtID_mantenimiento.Text);
                    capa_Controlador_Logistica.EliminarSolicitudMantenimient(idMantenimeinto);
                    LimpiarTextbox();
                    CargarSolicitudesenDatagriedView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el registro: " + ex.Message);
            }
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarSolicitudesenDatagriedView();
        }

        private void btn_NuevoRegistro_Click(object sender, EventArgs e)
        {
            LimpiarTextbox();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Reporte_MantenimientoVehiculos frm = new Reporte_MantenimientoVehiculos();
            frm.Show();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:/Users/franc/Desktop/MVC_JavierChamo/Ayuda/AyudaMantenimientoVehiculo/AyudaMantenimientoVehiculo.chm", "AyudaMantenimientoVehiculo.html");
        }
    }
}
