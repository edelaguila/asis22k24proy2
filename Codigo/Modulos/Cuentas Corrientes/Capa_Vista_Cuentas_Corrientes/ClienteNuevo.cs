using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class ClienteNuevo : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        //Boolean bConfirmRuta = true;

        public ClienteNuevo()
        {
            InitializeComponent();
            actualizarVistaClientes();
            cargarCategorias();
            getId();
        }
        
        void getId()
        {
            Txt_id_cliente.Text = controlador.getNextId();
        }

 

        private void actualizarVistaClientes()
        {
            DataTable data = controlador.MostrarClientes();
            Dgv_clientenuevo.DataSource = data;
            Dgv_clientenuevo.Columns[0].HeaderText = "Pk_id_cliente";
            Dgv_clientenuevo.Columns[1].HeaderText = "Fk_id_vendedor";
            Dgv_clientenuevo.Columns[2].HeaderText = "nombre";
            Dgv_clientenuevo.Columns[3].HeaderText = "telefono";
            Dgv_clientenuevo.Columns[4].HeaderText = "direccion";
            Dgv_clientenuevo.Columns[5].HeaderText = "saldo";
            Dgv_clientenuevo.Columns[6].HeaderText = "estado";

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //BOTON GUARDAR
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void cargarCategorias()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_estado.DataSource = limpiarTexbox;
            //List<string> applicationCodes = controlador.listadoEstado();///preguntar
            //Cbo_estado.DataSource = applicationCodes;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarClientes(Txt_id_cliente, Txt_id_vendedor.Text, Txt_nombre.Text, Txt_telefono.Text, Txt_direccion.Text,
                Txt_saldo.Text, Cbo_estado.Text);
            actualizarVistaClientes();
            getId();
        }

        private void Dgv_clientenuevo_DoubleClick(object sender, EventArgs e)
        {
            if (Dgv_clientenuevo.CurrentRow.Index != -1)
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_eliminar.Enabled = true;
                Btn_buscar.Enabled = true;
                Btn_actualizar.Enabled = true;

                Txt_id_cliente.Text = Dgv_clientenuevo.CurrentRow.Cells[0].Value.ToString();
                Txt_id_vendedor.Text = Dgv_clientenuevo.CurrentRow.Cells[1].Value.ToString();
                Txt_nombre.Text = Dgv_clientenuevo.CurrentRow.Cells[2].Value.ToString();
                Txt_telefono.Text = Dgv_clientenuevo.CurrentRow.Cells[3].Value.ToString();
                Txt_direccion.Text = Dgv_clientenuevo.CurrentRow.Cells[4].Value.ToString();
                Txt_saldo.Text = Dgv_clientenuevo.CurrentRow.Cells[5].Value.ToString();
                Cbo_estado.Text = Dgv_clientenuevo.CurrentRow.Cells[6].Value.ToString();
              
            }
        }
        //----------------BOTON DE BUSCAR -----------------------
        //-------------------------------------------------------
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            //mostramos todos los reportes que hay en la base de datos según lo introducido en el textbox y la desplegamos
            DataTable data = controlador.queryCliente(Txt_nombre);//preguntar
            Dgv_clientenuevo.DataSource = data;
        }//end buscar 

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrar_cliente(Txt_id_cliente);
            actualizarVistaClientes();
            getId();

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaClientes();
            cargarCategorias();
            getId();

            Btn_guardar.Enabled = true;
            Btn_buscar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;

            Txt_id_cliente.Text = "";
            Txt_id_vendedor.Text = "";
            Txt_nombre.Text = "";
            Txt_telefono.Text = "";
            Txt_direccion.Text = "";
            Txt_saldo.Text = "";
            Cbo_estado.SelectedIndex = 0;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            actualizarVistaClientes();
            cargarCategorias();
            getId();

            Btn_guardar.Enabled = true;
            Btn_buscar.Enabled = false;
            Btn_editar.Enabled = true;
            Btn_eliminar.Enabled = false;

            Txt_id_cliente.Text = "";
            Txt_id_vendedor.Text = "";
            Txt_nombre.Text = "";
            Txt_telefono.Text = "";
            Txt_direccion.Text = "";
            Txt_saldo.Text = "";
            Cbo_estado.SelectedIndex = 0;
        }
    }
}
