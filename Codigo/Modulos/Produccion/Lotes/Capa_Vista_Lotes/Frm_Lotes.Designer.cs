namespace Capa_Vista_Lotes
{
    partial class Frm_Lotes
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
            this.Lbl_Orden_Proceso = new System.Windows.Forms.Label();
            this.Cbo_Proceso = new System.Windows.Forms.ComboBox();
            this.dgv_Lotes = new System.Windows.Forms.DataGridView();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_Detalles = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Lote = new System.Windows.Forms.Label();
            this.Lbl_Id_Lote = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Cbo_Producto = new System.Windows.Forms.ComboBox();
            this.Cbo_Estado_Lotes = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Produccion = new System.Windows.Forms.DateTimePicker();
            this.Txt_Id_Lotes = new System.Windows.Forms.TextBox();
            this.Txt_Codigo_Lote = new System.Windows.Forms.TextBox();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lotes)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Orden_Proceso
            // 
            this.Lbl_Orden_Proceso.AutoSize = true;
            this.Lbl_Orden_Proceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Orden_Proceso.Location = new System.Drawing.Point(497, 149);
            this.Lbl_Orden_Proceso.Name = "Lbl_Orden_Proceso";
            this.Lbl_Orden_Proceso.Size = new System.Drawing.Size(106, 15);
            this.Lbl_Orden_Proceso.TabIndex = 51;
            this.Lbl_Orden_Proceso.Text = "Orden de Proceso";
            // 
            // Cbo_Proceso
            // 
            this.Cbo_Proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Proceso.FormattingEnabled = true;
            this.Cbo_Proceso.Location = new System.Drawing.Point(609, 148);
            this.Cbo_Proceso.Name = "Cbo_Proceso";
            this.Cbo_Proceso.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Proceso.TabIndex = 50;
            // 
            // dgv_Lotes
            // 
            this.dgv_Lotes.AllowUserToOrderColumns = true;
            this.dgv_Lotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lotes.Location = new System.Drawing.Point(64, 322);
            this.dgv_Lotes.Name = "dgv_Lotes";
            this.dgv_Lotes.Size = new System.Drawing.Size(767, 274);
            this.dgv_Lotes.TabIndex = 45;
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Cantidad.Location = new System.Drawing.Point(497, 58);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(56, 15);
            this.Lbl_Cantidad.TabIndex = 44;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // Lbl_Detalles
            // 
            this.Lbl_Detalles.AutoSize = true;
            this.Lbl_Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Detalles.Location = new System.Drawing.Point(497, 104);
            this.Lbl_Detalles.Name = "Lbl_Detalles";
            this.Lbl_Detalles.Size = new System.Drawing.Size(56, 15);
            this.Lbl_Detalles.TabIndex = 43;
            this.Lbl_Detalles.Text = "Producto";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Estado.Location = new System.Drawing.Point(497, 193);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(45, 15);
            this.Lbl_Estado.TabIndex = 42;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Fecha.Location = new System.Drawing.Point(80, 149);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(123, 15);
            this.Lbl_Fecha.TabIndex = 41;
            this.Lbl_Fecha.Text = "Fecha de Producción";
            // 
            // Lbl_Codigo_Lote
            // 
            this.Lbl_Codigo_Lote.AutoSize = true;
            this.Lbl_Codigo_Lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Codigo_Lote.Location = new System.Drawing.Point(80, 101);
            this.Lbl_Codigo_Lote.Name = "Lbl_Codigo_Lote";
            this.Lbl_Codigo_Lote.Size = new System.Drawing.Size(73, 15);
            this.Lbl_Codigo_Lote.TabIndex = 40;
            this.Lbl_Codigo_Lote.Text = "Codigo Lote";
            // 
            // Lbl_Id_Lote
            // 
            this.Lbl_Id_Lote.AutoSize = true;
            this.Lbl_Id_Lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Id_Lote.Location = new System.Drawing.Point(80, 55);
            this.Lbl_Id_Lote.Name = "Lbl_Id_Lote";
            this.Lbl_Id_Lote.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Id_Lote.TabIndex = 39;
            this.Lbl_Id_Lote.Text = "Id Lote";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(609, 54);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(200, 20);
            this.Txt_Cantidad.TabIndex = 38;
            // 
            // Cbo_Producto
            // 
            this.Cbo_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Producto.FormattingEnabled = true;
            this.Cbo_Producto.Location = new System.Drawing.Point(609, 97);
            this.Cbo_Producto.Name = "Cbo_Producto";
            this.Cbo_Producto.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Producto.TabIndex = 37;
            // 
            // Cbo_Estado_Lotes
            // 
            this.Cbo_Estado_Lotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Estado_Lotes.FormattingEnabled = true;
            this.Cbo_Estado_Lotes.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_Estado_Lotes.Location = new System.Drawing.Point(609, 192);
            this.Cbo_Estado_Lotes.Name = "Cbo_Estado_Lotes";
            this.Cbo_Estado_Lotes.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Estado_Lotes.TabIndex = 36;
            // 
            // Dtp_Fecha_Produccion
            // 
            this.Dtp_Fecha_Produccion.Location = new System.Drawing.Point(223, 148);
            this.Dtp_Fecha_Produccion.Name = "Dtp_Fecha_Produccion";
            this.Dtp_Fecha_Produccion.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Produccion.TabIndex = 35;
            // 
            // Txt_Id_Lotes
            // 
            this.Txt_Id_Lotes.Enabled = false;
            this.Txt_Id_Lotes.Location = new System.Drawing.Point(223, 52);
            this.Txt_Id_Lotes.Name = "Txt_Id_Lotes";
            this.Txt_Id_Lotes.ReadOnly = true;
            this.Txt_Id_Lotes.Size = new System.Drawing.Size(200, 20);
            this.Txt_Id_Lotes.TabIndex = 34;
            // 
            // Txt_Codigo_Lote
            // 
            this.Txt_Codigo_Lote.Location = new System.Drawing.Point(223, 98);
            this.Txt_Codigo_Lote.Name = "Txt_Codigo_Lote";
            this.Txt_Codigo_Lote.Size = new System.Drawing.Size(200, 20);
            this.Txt_Codigo_Lote.TabIndex = 33;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_Reporte.BackgroundImage = global::Capa_Vista_Lotes.Properties.Resources.reporte;
            this.btn_Reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.Location = new System.Drawing.Point(592, 249);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(63, 55);
            this.btn_Reporte.TabIndex = 52;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_Nuevo.BackgroundImage = global::Capa_Vista_Lotes.Properties.Resources.agregar_archivo;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo.Location = new System.Drawing.Point(241, 249);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(63, 55);
            this.btn_Nuevo.TabIndex = 49;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Eliminar.BackgroundImage = global::Capa_Vista_Lotes.Properties.Resources.borrar__1_;
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Location = new System.Drawing.Point(500, 249);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Eliminar.TabIndex = 48;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Actualizar.BackgroundImage = global::Capa_Vista_Lotes.Properties.Resources.convenio;
            this.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Location = new System.Drawing.Point(413, 249);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Actualizar.TabIndex = 47;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Agregar.BackgroundImage = global::Capa_Vista_Lotes.Properties.Resources.ahorrar;
            this.Btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Agregar.Location = new System.Drawing.Point(325, 249);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Agregar.TabIndex = 46;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Frm_Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.Lbl_Orden_Proceso);
            this.Controls.Add(this.Cbo_Proceso);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.dgv_Lotes);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.Lbl_Detalles);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Codigo_Lote);
            this.Controls.Add(this.Lbl_Id_Lote);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Cbo_Producto);
            this.Controls.Add(this.Cbo_Estado_Lotes);
            this.Controls.Add(this.Dtp_Fecha_Produccion);
            this.Controls.Add(this.Txt_Id_Lotes);
            this.Controls.Add(this.Txt_Codigo_Lote);
            this.Name = "Frm_Lotes";
            this.Text = "Frm_Lotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Orden_Proceso;
        private System.Windows.Forms.ComboBox Cbo_Proceso;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView dgv_Lotes;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_Detalles;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Codigo_Lote;
        private System.Windows.Forms.Label Lbl_Id_Lote;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Producto;
        private System.Windows.Forms.ComboBox Cbo_Estado_Lotes;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Produccion;
        private System.Windows.Forms.TextBox Txt_Id_Lotes;
        private System.Windows.Forms.TextBox Txt_Codigo_Lote;
        private System.Windows.Forms.Button btn_Reporte;
    }
}