
namespace CapaVista
{
    partial class Transaccion_proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaccion_proveedores));
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_tipotransacci = new System.Windows.Forms.Label();
            this.Lbl_monto = new System.Windows.Forms.Label();
            this.Lbl_tipo_moneda = new System.Windows.Forms.Label();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Dgv_transacciones_provee = new System.Windows.Forms.DataGridView();
            this.Txt_transaccion = new System.Windows.Forms.TextBox();
            this.Txt_proveedor = new System.Windows.Forms.TextBox();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.tbltransaccionproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cbo_moneda = new System.Windows.Forms.ComboBox();
            this.Cbo_tipotransacci = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Txt_cuenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransaccionproveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(48, 105);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(103, 17);
            this.Lbl_id.TabIndex = 0;
            this.Lbl_id.Text = "ID Transacción";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Location = new System.Drawing.Point(48, 148);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_proveedor.TabIndex = 1;
            this.Lbl_proveedor.Text = "ID Proveedor";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(48, 229);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(144, 17);
            this.Lbl_fecha.TabIndex = 3;
            this.Lbl_fecha.Text = "Fecha de transacción";
            // 
            // Lbl_tipotransacci
            // 
            this.Lbl_tipotransacci.AutoSize = true;
            this.Lbl_tipotransacci.Location = new System.Drawing.Point(613, 148);
            this.Lbl_tipotransacci.Name = "Lbl_tipotransacci";
            this.Lbl_tipotransacci.Size = new System.Drawing.Size(133, 17);
            this.Lbl_tipotransacci.TabIndex = 4;
            this.Lbl_tipotransacci.Text = "Tipo de transacción";
            // 
            // Lbl_monto
            // 
            this.Lbl_monto.AutoSize = true;
            this.Lbl_monto.Location = new System.Drawing.Point(613, 105);
            this.Lbl_monto.Name = "Lbl_monto";
            this.Lbl_monto.Size = new System.Drawing.Size(129, 17);
            this.Lbl_monto.TabIndex = 6;
            this.Lbl_monto.Text = "Transacción monto";
            // 
            // Lbl_tipo_moneda
            // 
            this.Lbl_tipo_moneda.AutoSize = true;
            this.Lbl_tipo_moneda.Location = new System.Drawing.Point(614, 184);
            this.Lbl_tipo_moneda.Name = "Lbl_tipo_moneda";
            this.Lbl_tipo_moneda.Size = new System.Drawing.Size(111, 17);
            this.Lbl_tipo_moneda.TabIndex = 8;
            this.Lbl_tipo_moneda.Text = "Tipo de moneda";
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(625, 225);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(52, 17);
            this.Lbl_estado.TabIndex = 10;
            this.Lbl_estado.Text = "Estado";
            // 
            // Dgv_transacciones_provee
            // 
            this.Dgv_transacciones_provee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_transacciones_provee.Location = new System.Drawing.Point(12, 303);
            this.Dgv_transacciones_provee.MultiSelect = false;
            this.Dgv_transacciones_provee.Name = "Dgv_transacciones_provee";
            this.Dgv_transacciones_provee.RowHeadersWidth = 51;
            this.Dgv_transacciones_provee.RowTemplate.Height = 24;
            this.Dgv_transacciones_provee.Size = new System.Drawing.Size(1041, 295);
            this.Dgv_transacciones_provee.TabIndex = 11;
            // 
            // Txt_transaccion
            // 
            this.Txt_transaccion.Location = new System.Drawing.Point(157, 105);
            this.Txt_transaccion.Name = "Txt_transaccion";
            this.Txt_transaccion.Size = new System.Drawing.Size(156, 22);
            this.Txt_transaccion.TabIndex = 12;
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.Location = new System.Drawing.Point(145, 145);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(156, 22);
            this.Txt_proveedor.TabIndex = 13;
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(748, 105);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(198, 22);
            this.Txt_monto.TabIndex = 18;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_estado.Location = new System.Drawing.Point(683, 222);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 24);
            this.Cbo_estado.TabIndex = 22;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(422, 73);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(62, 62);
            this.Btn_guardar.TabIndex = 23;
            this.toolTip1.SetToolTip(this.Btn_guardar, "Guardar");
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.Location = new System.Drawing.Point(490, 73);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(64, 61);
            this.Btn_editar.TabIndex = 24;
            this.toolTip1.SetToolTip(this.Btn_editar, "Editar");
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(487, 149);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(64, 58);
            this.Btn_eliminar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.Btn_eliminar, "Eliminar");
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar.Image")));
            this.Btn_buscar.Location = new System.Drawing.Point(422, 148);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(62, 60);
            this.Btn_buscar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.Btn_buscar, "Buscar");
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(198, 229);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(200, 22);
            this.Txt_fecha.TabIndex = 28;
            // 
            // tbltransaccionproveedorBindingSource
            // 
            this.tbltransaccionproveedorBindingSource.DataMember = "tbl_transaccion_proveedor";
            // 
            // Cbo_moneda
            // 
            this.Cbo_moneda.FormattingEnabled = true;
            this.Cbo_moneda.Items.AddRange(new object[] {
            "USD",
            "MXN",
            "GTQ",
            "EUR"});
            this.Cbo_moneda.Location = new System.Drawing.Point(731, 181);
            this.Cbo_moneda.Name = "Cbo_moneda";
            this.Cbo_moneda.Size = new System.Drawing.Size(198, 24);
            this.Cbo_moneda.TabIndex = 30;
            // 
            // Cbo_tipotransacci
            // 
            this.Cbo_tipotransacci.FormattingEnabled = true;
            this.Cbo_tipotransacci.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.Cbo_tipotransacci.Location = new System.Drawing.Point(746, 145);
            this.Cbo_tipotransacci.Name = "Cbo_tipotransacci";
            this.Cbo_tipotransacci.Size = new System.Drawing.Size(200, 24);
            this.Cbo_tipotransacci.TabIndex = 31;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reporte.Image")));
            this.Btn_reporte.Location = new System.Drawing.Point(980, 229);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(62, 58);
            this.Btn_reporte.TabIndex = 33;
            this.toolTip1.SetToolTip(this.Btn_reporte, "Ver reporte");
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(980, 21);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(62, 58);
            this.Btn_Salir.TabIndex = 37;
            this.toolTip1.SetToolTip(this.Btn_Salir, "Salir");
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(12, 12);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(62, 62);
            this.Btn_ayuda.TabIndex = 38;
            this.toolTip1.SetToolTip(this.Btn_ayuda, "Ayuda");
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Transacción de proveedores";
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Location = new System.Drawing.Point(48, 190);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(53, 17);
            this.Lbl_cuenta.TabIndex = 35;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // Txt_cuenta
            // 
            this.Txt_cuenta.Location = new System.Drawing.Point(107, 187);
            this.Txt_cuenta.Name = "Txt_cuenta";
            this.Txt_cuenta.Size = new System.Drawing.Size(167, 22);
            this.Txt_cuenta.TabIndex = 36;
            // 
            // Transaccion_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1065, 603);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Txt_cuenta);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Cbo_tipotransacci);
            this.Controls.Add(this.Cbo_moneda);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_monto);
            this.Controls.Add(this.Txt_proveedor);
            this.Controls.Add(this.Txt_transaccion);
            this.Controls.Add(this.Dgv_transacciones_provee);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.Lbl_tipo_moneda);
            this.Controls.Add(this.Lbl_monto);
            this.Controls.Add(this.Lbl_tipotransacci);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_proveedor);
            this.Controls.Add(this.Lbl_id);
            this.Name = "Transaccion_proveedores";
            this.Text = "Transaccion_proveedores";
            this.Load += new System.EventHandler(this.Transaccion_proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransaccionproveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_tipotransacci;
        private System.Windows.Forms.Label Lbl_monto;
        private System.Windows.Forms.Label Lbl_tipo_moneda;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.DataGridView Dgv_transacciones_provee;
        private System.Windows.Forms.TextBox Txt_transaccion;
        private System.Windows.Forms.TextBox Txt_proveedor;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.BindingSource tbltransaccionproveedorBindingSource;
        private System.Windows.Forms.ComboBox Cbo_moneda;
        private System.Windows.Forms.ComboBox Cbo_tipotransacci;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.TextBox Txt_cuenta;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_ayuda;
        // private CapaVista.DataSet1 dataSet1;
        // private CapaVista.DataSet1TableAdapters.tbl_transaccion_proveedorTableAdapter tbl_transaccion_proveedorTableAdapter;
    }
}