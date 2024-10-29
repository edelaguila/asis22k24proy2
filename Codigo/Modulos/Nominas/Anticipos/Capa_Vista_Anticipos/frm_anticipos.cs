using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Anticipos;

namespace Capa_Vista_Anticipos
{
    public partial class frm_anticipos : Form
    {
        Controlador controlador= new Controlador();
        public frm_anticipos()
        {
            InitializeComponent();
        }

        private void Btn_anticipo_nominas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_meses_anticipos.SelectedItem != null)
                {
                    string mesSeleccionado = cmb_meses_anticipos.SelectedItem.ToString(); // Obtener el mes seleccionado
                    controlador.CalcularAnticipo(mesSeleccionado); // Llamar al método del controlador
                    MessageBox.Show("Cálculo de anticipos realizado con éxito."); // Mensaje de éxito
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un mes."); // Mensaje de advertencia
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Manejo de errores
            }
        }
    }
}
