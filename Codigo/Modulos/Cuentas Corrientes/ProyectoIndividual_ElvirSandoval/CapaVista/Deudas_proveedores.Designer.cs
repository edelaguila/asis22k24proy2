
namespace CapaVista
{
    partial class Deudas_proveedores
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
            this.Lbl_deuda = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Lbl_pago = new System.Windows.Forms.Label();
            this.Lbl_monto = new System.Windows.Forms.Label();
            this.Lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.Lbl_fecha_venci = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Dgv_deudas_provee = new System.Windows.Forms.DataGridView();
            this.Txt_deuda = new System.Windows.Forms.TextBox();
            this.Txt_proveedor = new System.Windows.Forms.TextBox();
            this.Txt_pago = new System.Windows.Forms.TextBox();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Txt_fecha_ini = new System.Windows.Forms.TextBox();
            this.Txt_fecha_venci = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas_provee)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_deuda
            // 
            this.Lbl_deuda.AutoSize = true;
            this.Lbl_deuda.Location = new System.Drawing.Point(48, 41);
            this.Lbl_deuda.Name = "Lbl_deuda";
            this.Lbl_deuda.Size = new System.Drawing.Size(67, 17);
            this.Lbl_deuda.TabIndex = 0;
            this.Lbl_deuda.Text = "ID Deuda";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Location = new System.Drawing.Point(48, 102);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_proveedor.TabIndex = 1;
            this.Lbl_proveedor.Text = "ID Proveedor";
            // 
            // Lbl_pago
            // 
            this.Lbl_pago.AutoSize = true;
            this.Lbl_pago.Location = new System.Drawing.Point(48, 159);
            this.Lbl_pago.Name = "Lbl_pago";
            this.Lbl_pago.Size = new System.Drawing.Size(58, 17);
            this.Lbl_pago.TabIndex = 2;
            this.Lbl_pago.Text = "ID Pago";
            // 
            // Lbl_monto
            // 
            this.Lbl_monto.AutoSize = true;
            this.Lbl_monto.Location = new System.Drawing.Point(48, 219);
            this.Lbl_monto.Name = "Lbl_monto";
            this.Lbl_monto.Size = new System.Drawing.Size(111, 17);
            this.Lbl_monto.TabIndex = 3;
            this.Lbl_monto.Text = "Monto de deuda";
            // 
            // Lbl_fecha_inicio
            // 
            this.Lbl_fecha_inicio.AutoSize = true;
            this.Lbl_fecha_inicio.Location = new System.Drawing.Point(579, 41);
            this.Lbl_fecha_inicio.Name = "Lbl_fecha_inicio";
            this.Lbl_fecha_inicio.Size = new System.Drawing.Size(103, 17);
            this.Lbl_fecha_inicio.TabIndex = 4;
            this.Lbl_fecha_inicio.Text = "Fecha de inicio";
            // 
            // Lbl_fecha_venci
            // 
            this.Lbl_fecha_venci.AutoSize = true;
            this.Lbl_fecha_venci.Location = new System.Drawing.Point(579, 102);
            this.Lbl_fecha_venci.Name = "Lbl_fecha_venci";
            this.Lbl_fecha_venci.Size = new System.Drawing.Size(146, 17);
            this.Lbl_fecha_venci.TabIndex = 5;
            this.Lbl_fecha_venci.Text = "Fecha de vencimiento";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Location = new System.Drawing.Point(579, 150);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(82, 17);
            this.Lbl_descripcion.TabIndex = 6;
            this.Lbl_descripcion.Text = "Descripción";
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(579, 219);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(116, 17);
            this.Lbl_estado.TabIndex = 7;
            this.Lbl_estado.Text = "Estado de deuda";
            // 
            // Dgv_deudas_provee
            // 
            this.Dgv_deudas_provee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_deudas_provee.Location = new System.Drawing.Point(12, 335);
            this.Dgv_deudas_provee.MultiSelect = false;
            this.Dgv_deudas_provee.Name = "Dgv_deudas_provee";
            this.Dgv_deudas_provee.RowHeadersWidth = 51;
            this.Dgv_deudas_provee.RowTemplate.Height = 24;
            this.Dgv_deudas_provee.Size = new System.Drawing.Size(968, 267);
            this.Dgv_deudas_provee.TabIndex = 8;
            // 
            // Txt_deuda
            // 
            this.Txt_deuda.Location = new System.Drawing.Point(121, 41);
            this.Txt_deuda.Name = "Txt_deuda";
            this.Txt_deuda.Size = new System.Drawing.Size(210, 22);
            this.Txt_deuda.TabIndex = 9;
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.Location = new System.Drawing.Point(145, 102);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(186, 22);
            this.Txt_proveedor.TabIndex = 10;
            // 
            // Txt_pago
            // 
            this.Txt_pago.Location = new System.Drawing.Point(121, 159);
            this.Txt_pago.Name = "Txt_pago";
            this.Txt_pago.Size = new System.Drawing.Size(139, 22);
            this.Txt_pago.TabIndex = 11;
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(166, 219);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(165, 22);
            this.Txt_monto.TabIndex = 12;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(668, 150);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(249, 22);
            this.Txt_descripcion.TabIndex = 15;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_estado.Location = new System.Drawing.Point(702, 215);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(215, 24);
            this.Cbo_estado.TabIndex = 16;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(409, 22);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(88, 36);
            this.Btn_guardar.TabIndex = 17;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(409, 64);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(88, 36);
            this.Btn_editar.TabIndex = 18;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(409, 106);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(88, 36);
            this.Btn_actualizar.TabIndex = 19;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(409, 148);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(88, 36);
            this.Btn_eliminar.TabIndex = 20;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(409, 190);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(88, 36);
            this.Btn_buscar.TabIndex = 21;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(409, 232);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(88, 36);
            this.Btn_limpiar.TabIndex = 22;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Txt_fecha_ini
            // 
            this.Txt_fecha_ini.Location = new System.Drawing.Point(689, 40);
            this.Txt_fecha_ini.Name = "Txt_fecha_ini";
            this.Txt_fecha_ini.Size = new System.Drawing.Size(228, 22);
            this.Txt_fecha_ini.TabIndex = 23;
            // 
            // Txt_fecha_venci
            // 
            this.Txt_fecha_venci.Location = new System.Drawing.Point(732, 106);
            this.Txt_fecha_venci.Name = "Txt_fecha_venci";
            this.Txt_fecha_venci.Size = new System.Drawing.Size(185, 22);
            this.Txt_fecha_venci.TabIndex = 24;
            // 
            // Deudas_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(992, 605);
            this.Controls.Add(this.Txt_fecha_venci);
            this.Controls.Add(this.Txt_fecha_ini);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_descripcion);
            this.Controls.Add(this.Txt_monto);
            this.Controls.Add(this.Txt_pago);
            this.Controls.Add(this.Txt_proveedor);
            this.Controls.Add(this.Txt_deuda);
            this.Controls.Add(this.Dgv_deudas_provee);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.Lbl_descripcion);
            this.Controls.Add(this.Lbl_fecha_venci);
            this.Controls.Add(this.Lbl_fecha_inicio);
            this.Controls.Add(this.Lbl_monto);
            this.Controls.Add(this.Lbl_pago);
            this.Controls.Add(this.Lbl_proveedor);
            this.Controls.Add(this.Lbl_deuda);
            this.Name = "Deudas_proveedores";
            this.Text = "Deudas_proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas_provee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_deuda;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.Label Lbl_pago;
        private System.Windows.Forms.Label Lbl_monto;
        private System.Windows.Forms.Label Lbl_fecha_inicio;
        private System.Windows.Forms.Label Lbl_fecha_venci;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.DataGridView Dgv_deudas_provee;
        private System.Windows.Forms.TextBox Txt_deuda;
        private System.Windows.Forms.TextBox Txt_proveedor;
        private System.Windows.Forms.TextBox Txt_pago;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.TextBox Txt_fecha_ini;
        private System.Windows.Forms.TextBox Txt_fecha_venci;
    }
}