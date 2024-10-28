
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
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Lbl_pais = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Lbl_cuota = new System.Windows.Forms.Label();
            this.Lbl_monto = new System.Windows.Forms.Label();
            this.Lbl_pago = new System.Windows.Forms.Label();
            this.Lbl_tipo_moneda = new System.Windows.Forms.Label();
            this.Lbl_serie = new System.Windows.Forms.Label();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Dgv_transacciones_provee = new System.Windows.Forms.DataGridView();
            this.Txt_transaccion = new System.Windows.Forms.TextBox();
            this.Txt_proveedor = new System.Windows.Forms.TextBox();
            this.Txt_pais = new System.Windows.Forms.TextBox();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.Txt_pago = new System.Windows.Forms.TextBox();
            this.Txt_serie = new System.Windows.Forms.TextBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.dataSet1 = new CapaVista.DataSet1();
            this.tbltransaccionproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_transaccion_proveedorTableAdapter = new CapaVista.DataSet1TableAdapters.tbl_transaccion_proveedorTableAdapter();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Cbo_moneda = new System.Windows.Forms.ComboBox();
            this.Cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.Cbo_cuota = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransaccionproveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(48, 39);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(103, 17);
            this.Lbl_id.TabIndex = 0;
            this.Lbl_id.Text = "ID Transacción";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Location = new System.Drawing.Point(48, 83);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_proveedor.TabIndex = 1;
            this.Lbl_proveedor.Text = "ID Proveedor";
            // 
            // Lbl_pais
            // 
            this.Lbl_pais.AutoSize = true;
            this.Lbl_pais.Location = new System.Drawing.Point(48, 124);
            this.Lbl_pais.Name = "Lbl_pais";
            this.Lbl_pais.Size = new System.Drawing.Size(52, 17);
            this.Lbl_pais.TabIndex = 2;
            this.Lbl_pais.Text = "ID Pais";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(48, 161);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(144, 17);
            this.Lbl_fecha.TabIndex = 3;
            this.Lbl_fecha.Text = "Fecha de transacción";
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Location = new System.Drawing.Point(48, 192);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(53, 17);
            this.Lbl_cuenta.TabIndex = 4;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // Lbl_cuota
            // 
            this.Lbl_cuota.AutoSize = true;
            this.Lbl_cuota.Location = new System.Drawing.Point(48, 229);
            this.Lbl_cuota.Name = "Lbl_cuota";
            this.Lbl_cuota.Size = new System.Drawing.Size(45, 17);
            this.Lbl_cuota.TabIndex = 5;
            this.Lbl_cuota.Text = "Cuota";
            // 
            // Lbl_monto
            // 
            this.Lbl_monto.AutoSize = true;
            this.Lbl_monto.Location = new System.Drawing.Point(591, 39);
            this.Lbl_monto.Name = "Lbl_monto";
            this.Lbl_monto.Size = new System.Drawing.Size(129, 17);
            this.Lbl_monto.TabIndex = 6;
            this.Lbl_monto.Text = "Transacción monto";
            // 
            // Lbl_pago
            // 
            this.Lbl_pago.AutoSize = true;
            this.Lbl_pago.Location = new System.Drawing.Point(591, 83);
            this.Lbl_pago.Name = "Lbl_pago";
            this.Lbl_pago.Size = new System.Drawing.Size(58, 17);
            this.Lbl_pago.TabIndex = 7;
            this.Lbl_pago.Text = "ID Pago";
            // 
            // Lbl_tipo_moneda
            // 
            this.Lbl_tipo_moneda.AutoSize = true;
            this.Lbl_tipo_moneda.Location = new System.Drawing.Point(591, 118);
            this.Lbl_tipo_moneda.Name = "Lbl_tipo_moneda";
            this.Lbl_tipo_moneda.Size = new System.Drawing.Size(111, 17);
            this.Lbl_tipo_moneda.TabIndex = 8;
            this.Lbl_tipo_moneda.Text = "Tipo de moneda";
            // 
            // Lbl_serie
            // 
            this.Lbl_serie.AutoSize = true;
            this.Lbl_serie.Location = new System.Drawing.Point(591, 155);
            this.Lbl_serie.Name = "Lbl_serie";
            this.Lbl_serie.Size = new System.Drawing.Size(41, 17);
            this.Lbl_serie.TabIndex = 9;
            this.Lbl_serie.Text = "Serie";
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(591, 192);
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
            this.Txt_transaccion.Location = new System.Drawing.Point(157, 39);
            this.Txt_transaccion.Name = "Txt_transaccion";
            this.Txt_transaccion.Size = new System.Drawing.Size(156, 22);
            this.Txt_transaccion.TabIndex = 12;
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.Location = new System.Drawing.Point(157, 83);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(156, 22);
            this.Txt_proveedor.TabIndex = 13;
            // 
            // Txt_pais
            // 
            this.Txt_pais.Location = new System.Drawing.Point(157, 118);
            this.Txt_pais.Name = "Txt_pais";
            this.Txt_pais.Size = new System.Drawing.Size(156, 22);
            this.Txt_pais.TabIndex = 14;
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(727, 38);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(198, 22);
            this.Txt_monto.TabIndex = 18;
            // 
            // Txt_pago
            // 
            this.Txt_pago.Location = new System.Drawing.Point(727, 82);
            this.Txt_pago.Name = "Txt_pago";
            this.Txt_pago.Size = new System.Drawing.Size(198, 22);
            this.Txt_pago.TabIndex = 19;
            // 
            // Txt_serie
            // 
            this.Txt_serie.Location = new System.Drawing.Point(727, 155);
            this.Txt_serie.Name = "Txt_serie";
            this.Txt_serie.Size = new System.Drawing.Size(198, 22);
            this.Txt_serie.TabIndex = 21;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_estado.Location = new System.Drawing.Point(727, 188);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 24);
            this.Cbo_estado.TabIndex = 22;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(446, 21);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(102, 39);
            this.Btn_guardar.TabIndex = 23;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(446, 73);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(102, 36);
            this.Btn_editar.TabIndex = 24;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(446, 118);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(102, 38);
            this.Btn_actualizar.TabIndex = 25;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(446, 161);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(102, 37);
            this.Btn_eliminar.TabIndex = 26;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(446, 204);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(102, 34);
            this.Btn_buscar.TabIndex = 27;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(199, 156);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(200, 22);
            this.Txt_fecha.TabIndex = 28;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltransaccionproveedorBindingSource
            // 
            this.tbltransaccionproveedorBindingSource.DataMember = "tbl_transaccion_proveedor";
            this.tbltransaccionproveedorBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_transaccion_proveedorTableAdapter
            // 
            this.tbl_transaccion_proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(446, 245);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(102, 33);
            this.Btn_limpiar.TabIndex = 29;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Cbo_moneda
            // 
            this.Cbo_moneda.FormattingEnabled = true;
            this.Cbo_moneda.Items.AddRange(new object[] {
            "USD",
            "MXN",
            "GTQ",
            "EUR"});
            this.Cbo_moneda.Location = new System.Drawing.Point(727, 121);
            this.Cbo_moneda.Name = "Cbo_moneda";
            this.Cbo_moneda.Size = new System.Drawing.Size(198, 24);
            this.Cbo_moneda.TabIndex = 30;
            // 
            // Cbo_cuenta
            // 
            this.Cbo_cuenta.FormattingEnabled = true;
            this.Cbo_cuenta.Items.AddRange(new object[] {
            "Activo",
            "Pasivo"});
            this.Cbo_cuenta.Location = new System.Drawing.Point(157, 192);
            this.Cbo_cuenta.Name = "Cbo_cuenta";
            this.Cbo_cuenta.Size = new System.Drawing.Size(200, 24);
            this.Cbo_cuenta.TabIndex = 31;
            // 
            // Cbo_cuota
            // 
            this.Cbo_cuota.FormattingEnabled = true;
            this.Cbo_cuota.Items.AddRange(new object[] {
            "S",
            "M",
            "A"});
            this.Cbo_cuota.Location = new System.Drawing.Point(157, 229);
            this.Cbo_cuota.Name = "Cbo_cuota";
            this.Cbo_cuota.Size = new System.Drawing.Size(200, 24);
            this.Cbo_cuota.TabIndex = 32;
            // 
            // Transaccion_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1065, 603);
            this.Controls.Add(this.Cbo_cuota);
            this.Controls.Add(this.Cbo_cuenta);
            this.Controls.Add(this.Cbo_moneda);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_serie);
            this.Controls.Add(this.Txt_pago);
            this.Controls.Add(this.Txt_monto);
            this.Controls.Add(this.Txt_pais);
            this.Controls.Add(this.Txt_proveedor);
            this.Controls.Add(this.Txt_transaccion);
            this.Controls.Add(this.Dgv_transacciones_provee);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.Lbl_serie);
            this.Controls.Add(this.Lbl_tipo_moneda);
            this.Controls.Add(this.Lbl_pago);
            this.Controls.Add(this.Lbl_monto);
            this.Controls.Add(this.Lbl_cuota);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_pais);
            this.Controls.Add(this.Lbl_proveedor);
            this.Controls.Add(this.Lbl_id);
            this.Name = "Transaccion_proveedores";
            this.Text = "Transaccion_proveedores";
            this.Load += new System.EventHandler(this.Transaccion_proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransaccionproveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.Label Lbl_pais;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.Label Lbl_cuota;
        private System.Windows.Forms.Label Lbl_monto;
        private System.Windows.Forms.Label Lbl_pago;
        private System.Windows.Forms.Label Lbl_tipo_moneda;
        private System.Windows.Forms.Label Lbl_serie;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.DataGridView Dgv_transacciones_provee;
        private System.Windows.Forms.TextBox Txt_transaccion;
        private System.Windows.Forms.TextBox Txt_proveedor;
        private System.Windows.Forms.TextBox Txt_pais;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.TextBox Txt_pago;
        private System.Windows.Forms.TextBox Txt_serie;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_fecha;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbltransaccionproveedorBindingSource;
        private DataSet1TableAdapters.tbl_transaccion_proveedorTableAdapter tbl_transaccion_proveedorTableAdapter;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.ComboBox Cbo_moneda;
        private System.Windows.Forms.ComboBox Cbo_cuenta;
        private System.Windows.Forms.ComboBox Cbo_cuota;
    }
}