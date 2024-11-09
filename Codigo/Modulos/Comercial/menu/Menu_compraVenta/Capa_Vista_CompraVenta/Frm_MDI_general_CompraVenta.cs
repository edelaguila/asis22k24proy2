using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CompraVenta;
//using Capa_Vista_Cotizacion;
using Interfac_V3;
/*using Capa_Vista_ListaPrecios;
using Capa_Vista_Polizas;
using Capa_vista_pedido;
using Capa_Vista_OrdenCompra;
using Capa_Vista_Factura;
using Capa_Vista;*/
namespace Capa_Vista_CompraVenta
{
    public partial class Frm_MDI_general_CompraVenta : Form
    {
        private int childFormNumber = 0;
        string idUsuario;
        public Frm_MDI_general_CompraVenta(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.IsMdiContainer = true;
            Lbl_usuario2.Text = idUsuario;
            DateTime fechaHoraActual = DateTime.Now;
            Lbl_hora.Text = fechaHoraActual.ToString();

            //this.WindowState = FormWindowState.Maximized; // Maximiza el formulario al iniciar

            ocultaSubMenu();

        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuCatalogosOpcion1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenuProcesosOpcion1_Click(object sender, EventArgs e)
        {
            

        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int lx, ly;
        int sw, sh;

        private void button9_Click(object sender, EventArgs e)
        {
            /*Frm_proveedores Prov = new Frm_proveedores(idUsuario);
            Prov.MdiParent = this;
            Prov.Show();
            AbrirFormulario<Frm_proveedores>();
            ocultaSubMenu();*/
            Frm_proveedores formulario = new Frm_proveedores(idUsuario);
            formulario.MdiParent = this;
            formulario.Show(); 
  

        }

        private void button6_Click(object sender, EventArgs e)
        {
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuCatalogos_Click(object sender, EventArgs e)
        {

        }
        private void ocultaSubMenu() 
        {
            if (Pnl_Mantenimiento.Visible == true)
                Pnl_Mantenimiento.Visible = false;
            if (Pnl_Compra.Visible == true)
                Pnl_Compra.Visible = false;
        }
        private void muestraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultaSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            muestraSubMenu(Pnl_Mantenimiento);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            muestraSubMenu(Pnl_Compra);
        }

        private void Btn_compra_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_poliza_Click(object sender, EventArgs e)
        {
            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            
                
   
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            Frm_clientes Clie = new Frm_clientes(idUsuario);
            Clie.MdiParent = this;
            Clie.Show();
        }

        private void Btn_vendedores_Click(object sender, EventArgs e)
        {
            Frm_vendedores Ven = new Frm_vendedores(idUsuario);
            Ven.MdiParent = this;
            Ven.Show();
        }

        private void Pnl_panelGeneral_Paint(object sender, PaintEventArgs e)
        {
           /* Frm_vendedores Ven = new Frm_vendedores(idUsuario);
            Ven.MdiParent = this;
            Ven.Show();
           
            */
        }

        private void Btn_compra_Click_1(object sender, EventArgs e)
        {
            /*frm_compra Ven = new frm_compra();
            Ven.MdiParent = this;
            Ven.Show();*/

        }

        private void Btn_poliza_Click_1(object sender, EventArgs e)
        {
            /*frmPolizas formulario = new frmPolizas();
            formulario.MdiParent = this;
            formulario.Show();*/
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*frm_cotizaciones formulario = new frm_cotizaciones();
            formulario.MdiParent = this;
            formulario.Show();*/
        }

        private void button11_Click(object sender, EventArgs e)
        {/*
            frm_pedidos Ven = new frm_pedidos();
            Ven.MdiParent = this;
            Ven.Show();*/
           
           
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            /*Frm_Factura Ven = new Frm_Factura();
            Ven.MdiParent = this;
            Ven.Show();*/
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
          /*  frm_ListadoInicio Ven = new frm_ListadoInicio();
            Ven.MdiParent = this;
            Ven.Show();*/
           
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           /*  Frm_comisiones Ven = new Frm_comisiones();
            Ven.MdiParent = this;
            Ven.Show();*/
           
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            muestraSubMenu(Pnl_Venta);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           /* frm_MantenimientoListas Ven = new frm_MantenimientoListas(idUsuario);
            Ven.MdiParent = this;
            Ven.Show();*/
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormModulos formulario = new FormModulos(idUsuario);
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

    }
}
