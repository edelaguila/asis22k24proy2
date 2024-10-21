using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Logistica
{
    public partial class TrasladoDProductos : Form
    {
        private string idProductos; // Campo para almacenar el ID del traslado de productos

        public TrasladoDProductos()
        {
        }

        // Constructor que recibe el ID del traslado de productos
        public TrasladoDProductos(string idProductos)
        {
            InitializeComponent();
            this.idProductos = idProductos;

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Aquí puedes implementar la lógica para cargar información relacionada con el Traslado De Productos usando el ID
            CargarInformacionTrasDProductos(idProductos);
        }

        private void CargarInformacionTrasDProductos(string idTrasladoProductos)
        {
            // Lógica para cargar información del traslado de productos según el ID
            // Por ejemplo, puedes mostrarlo en un Label o en un TextBox
            MessageBox.Show("ID de Traslado de Productos seleccionado: " + idProductos);
            // O puedes realizar una consulta a la base de datos para obtener más información
        }

        
    }
}

