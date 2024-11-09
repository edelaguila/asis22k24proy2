
namespace Capa_Vista_Transaccion_Proveedor
{
    partial class Frm_transaccion_proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_transaccion_proveedores));
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Txt_cuenta = new System.Windows.Forms.TextBox();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Cbo_tipotransacci = new System.Windows.Forms.ComboBox();
            this.Cbo_moneda = new System.Windows.Forms.ComboBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.Txt_proveedor = new System.Windows.Forms.TextBox();
            this.Txt_transaccion = new System.Windows.Forms.TextBox();
            this.Dgv_transacciones_provee = new System.Windows.Forms.DataGridView();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_tipo_moneda = new System.Windows.Forms.Label();
            this.Lbl_monto = new System.Windows.Forms.Label();
            this.Lbl_tipotransacci = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(7, 32);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(62, 62);
            this.Btn_ayuda.TabIndex = 63;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(975, 41);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(62, 58);
            this.Btn_Salir.TabIndex = 62;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Txt_cuenta
            // 
            this.Txt_cuenta.Location = new System.Drawing.Point(102, 207);
            this.Txt_cuenta.Name = "Txt_cuenta";
            this.Txt_cuenta.Size = new System.Drawing.Size(167, 22);
            this.Txt_cuenta.TabIndex = 61;
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Location = new System.Drawing.Point(43, 210);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(53, 17);
            this.Lbl_cuenta.TabIndex = 60;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 33);
            this.label1.TabIndex = 59;
            this.label1.Text = "Transacción de proveedores";
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reporte.Image")));
            this.Btn_reporte.Location = new System.Drawing.Point(975, 249);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(62, 58);
            this.Btn_reporte.TabIndex = 58;
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Cbo_tipotransacci
            // 
            this.Cbo_tipotransacci.FormattingEnabled = true;
            this.Cbo_tipotransacci.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.Cbo_tipotransacci.Location = new System.Drawing.Point(741, 165);
            this.Cbo_tipotransacci.Name = "Cbo_tipotransacci";
            this.Cbo_tipotransacci.Size = new System.Drawing.Size(200, 24);
            this.Cbo_tipotransacci.TabIndex = 57;
            // 
            // Cbo_moneda
            // 
            this.Cbo_moneda.FormattingEnabled = true;
            this.Cbo_moneda.Items.AddRange(new object[] {
            "USD",
            "MXN",
            "GTQ",
            "EUR"});
            this.Cbo_moneda.Location = new System.Drawing.Point(726, 201);
            this.Cbo_moneda.Name = "Cbo_moneda";
            this.Cbo_moneda.Size = new System.Drawing.Size(198, 24);
            this.Cbo_moneda.TabIndex = 56;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(193, 249);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(200, 22);
            this.Txt_fecha.TabIndex = 55;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar.Image")));
            this.Btn_buscar.Location = new System.Drawing.Point(417, 168);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(62, 60);
            this.Btn_buscar.TabIndex = 54;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(482, 169);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(64, 58);
            this.Btn_eliminar.TabIndex = 53;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.Location = new System.Drawing.Point(485, 93);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(64, 61);
            this.Btn_editar.TabIndex = 52;
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(417, 93);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(62, 62);
            this.Btn_guardar.TabIndex = 51;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_estado.Location = new System.Drawing.Point(678, 242);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 24);
            this.Cbo_estado.TabIndex = 50;
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(743, 125);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(198, 22);
            this.Txt_monto.TabIndex = 49;
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.Location = new System.Drawing.Point(140, 165);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(156, 22);
            this.Txt_proveedor.TabIndex = 48;
            // 
            // Txt_transaccion
            // 
            this.Txt_transaccion.Location = new System.Drawing.Point(152, 125);
            this.Txt_transaccion.Name = "Txt_transaccion";
            this.Txt_transaccion.Size = new System.Drawing.Size(156, 22);
            this.Txt_transaccion.TabIndex = 47;
            // 
            // Dgv_transacciones_provee
            // 
            this.Dgv_transacciones_provee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_transacciones_provee.Location = new System.Drawing.Point(7, 323);
            this.Dgv_transacciones_provee.MultiSelect = false;
            this.Dgv_transacciones_provee.Name = "Dgv_transacciones_provee";
            this.Dgv_transacciones_provee.RowHeadersWidth = 51;
            this.Dgv_transacciones_provee.RowTemplate.Height = 24;
            this.Dgv_transacciones_provee.Size = new System.Drawing.Size(1041, 295);
            this.Dgv_transacciones_provee.TabIndex = 46;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(620, 245);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(52, 17);
            this.Lbl_estado.TabIndex = 45;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_tipo_moneda
            // 
            this.Lbl_tipo_moneda.AutoSize = true;
            this.Lbl_tipo_moneda.Location = new System.Drawing.Point(609, 204);
            this.Lbl_tipo_moneda.Name = "Lbl_tipo_moneda";
            this.Lbl_tipo_moneda.Size = new System.Drawing.Size(111, 17);
            this.Lbl_tipo_moneda.TabIndex = 44;
            this.Lbl_tipo_moneda.Text = "Tipo de moneda";
            // 
            // Lbl_monto
            // 
            this.Lbl_monto.AutoSize = true;
            this.Lbl_monto.Location = new System.Drawing.Point(608, 125);
            this.Lbl_monto.Name = "Lbl_monto";
            this.Lbl_monto.Size = new System.Drawing.Size(129, 17);
            this.Lbl_monto.TabIndex = 43;
            this.Lbl_monto.Text = "Transacción monto";
            // 
            // Lbl_tipotransacci
            // 
            this.Lbl_tipotransacci.AutoSize = true;
            this.Lbl_tipotransacci.Location = new System.Drawing.Point(608, 168);
            this.Lbl_tipotransacci.Name = "Lbl_tipotransacci";
            this.Lbl_tipotransacci.Size = new System.Drawing.Size(133, 17);
            this.Lbl_tipotransacci.TabIndex = 42;
            this.Lbl_tipotransacci.Text = "Tipo de transacción";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(43, 249);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(144, 17);
            this.Lbl_fecha.TabIndex = 41;
            this.Lbl_fecha.Text = "Fecha de transacción";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Location = new System.Drawing.Point(43, 168);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_proveedor.TabIndex = 40;
            this.Lbl_proveedor.Text = "ID Proveedor";
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(43, 125);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(103, 17);
            this.Lbl_id.TabIndex = 39;
            this.Lbl_id.Text = "ID Transacción";
            // 
            // Frm_transaccion_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1055, 650);
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
            this.Name = "Frm_transaccion_proveedores";
            this.Text = "Frm_transaccion_proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox Txt_cuenta;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.ComboBox Cbo_tipotransacci;
        private System.Windows.Forms.ComboBox Cbo_moneda;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.TextBox Txt_proveedor;
        private System.Windows.Forms.TextBox Txt_transaccion;
        private System.Windows.Forms.DataGridView Dgv_transacciones_provee;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_tipo_moneda;
        private System.Windows.Forms.Label Lbl_monto;
        private System.Windows.Forms.Label Lbl_tipotransacci;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.Label Lbl_id;
    }
}