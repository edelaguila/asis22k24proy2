
namespace Capa_Vista_Produccion
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
            this.Txt_Codigo_Lote = new System.Windows.Forms.TextBox();
            this.Txt_Id_Lotes = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha_Produccion = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Estado_Lotes = new System.Windows.Forms.ComboBox();
            this.Cbo_Producto = new System.Windows.Forms.ComboBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Lbl_Id_Lote = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Lote = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Detalles = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.dgv_Lotes = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Cbo_Proceso = new System.Windows.Forms.ComboBox();
            this.Lbl_Orden_Proceso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lotes)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Codigo_Lote
            // 
            this.Txt_Codigo_Lote.Location = new System.Drawing.Point(205, 98);
            this.Txt_Codigo_Lote.Name = "Txt_Codigo_Lote";
            this.Txt_Codigo_Lote.Size = new System.Drawing.Size(200, 20);
            this.Txt_Codigo_Lote.TabIndex = 0;
            // 
            // Txt_Id_Lotes
            // 
            this.Txt_Id_Lotes.Enabled = false;
            this.Txt_Id_Lotes.Location = new System.Drawing.Point(205, 52);
            this.Txt_Id_Lotes.Name = "Txt_Id_Lotes";
            this.Txt_Id_Lotes.ReadOnly = true;
            this.Txt_Id_Lotes.Size = new System.Drawing.Size(200, 20);
            this.Txt_Id_Lotes.TabIndex = 1;
            // 
            // Dtp_Fecha_Produccion
            // 
            this.Dtp_Fecha_Produccion.Location = new System.Drawing.Point(205, 148);
            this.Dtp_Fecha_Produccion.Name = "Dtp_Fecha_Produccion";
            this.Dtp_Fecha_Produccion.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Produccion.TabIndex = 2;
            // 
            // Cbo_Estado_Lotes
            // 
            this.Cbo_Estado_Lotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Estado_Lotes.FormattingEnabled = true;
            this.Cbo_Estado_Lotes.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_Estado_Lotes.Location = new System.Drawing.Point(572, 146);
            this.Cbo_Estado_Lotes.Name = "Cbo_Estado_Lotes";
            this.Cbo_Estado_Lotes.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Estado_Lotes.TabIndex = 11;
            // 
            // Cbo_Producto
            // 
            this.Cbo_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Producto.FormattingEnabled = true;
            this.Cbo_Producto.Location = new System.Drawing.Point(572, 98);
            this.Cbo_Producto.Name = "Cbo_Producto";
            this.Cbo_Producto.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Producto.TabIndex = 12;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(572, 52);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(200, 20);
            this.Txt_Cantidad.TabIndex = 13;
            // 
            // Lbl_Id_Lote
            // 
            this.Lbl_Id_Lote.AutoSize = true;
            this.Lbl_Id_Lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Id_Lote.Location = new System.Drawing.Point(62, 55);
            this.Lbl_Id_Lote.Name = "Lbl_Id_Lote";
            this.Lbl_Id_Lote.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Id_Lote.TabIndex = 14;
            this.Lbl_Id_Lote.Text = "Id Lote";
            // 
            // Lbl_Codigo_Lote
            // 
            this.Lbl_Codigo_Lote.AutoSize = true;
            this.Lbl_Codigo_Lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Codigo_Lote.Location = new System.Drawing.Point(62, 101);
            this.Lbl_Codigo_Lote.Name = "Lbl_Codigo_Lote";
            this.Lbl_Codigo_Lote.Size = new System.Drawing.Size(73, 15);
            this.Lbl_Codigo_Lote.TabIndex = 15;
            this.Lbl_Codigo_Lote.Text = "Codigo Lote";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Fecha.Location = new System.Drawing.Point(62, 154);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(123, 15);
            this.Lbl_Fecha.TabIndex = 16;
            this.Lbl_Fecha.Text = "Fecha de Producción";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Estado.Location = new System.Drawing.Point(469, 152);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(45, 15);
            this.Lbl_Estado.TabIndex = 17;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Detalles
            // 
            this.Lbl_Detalles.AutoSize = true;
            this.Lbl_Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Detalles.Location = new System.Drawing.Point(469, 104);
            this.Lbl_Detalles.Name = "Lbl_Detalles";
            this.Lbl_Detalles.Size = new System.Drawing.Size(56, 15);
            this.Lbl_Detalles.TabIndex = 18;
            this.Lbl_Detalles.Text = "Producto";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Cantidad.Location = new System.Drawing.Point(469, 55);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(56, 15);
            this.Lbl_Cantidad.TabIndex = 19;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // dgv_Lotes
            // 
            this.dgv_Lotes.AllowUserToOrderColumns = true;
            this.dgv_Lotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lotes.Location = new System.Drawing.Point(65, 289);
            this.dgv_Lotes.Name = "dgv_Lotes";
            this.dgv_Lotes.Size = new System.Drawing.Size(707, 257);
            this.dgv_Lotes.TabIndex = 20;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_Nuevo.BackgroundImage = global::Capa_Vista_Produccion.Properties.Resources.agregar_archivo__1_;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo.Location = new System.Drawing.Point(263, 213);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(63, 55);
            this.btn_Nuevo.TabIndex = 30;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = global::Capa_Vista_Produccion.Properties.Resources.borrar2;
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Location = new System.Drawing.Point(523, 213);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Eliminar.TabIndex = 29;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Actualizar.BackgroundImage = global::Capa_Vista_Produccion.Properties.Resources.verificado3;
            this.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Location = new System.Drawing.Point(435, 213);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Actualizar.TabIndex = 28;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Agregar.BackgroundImage = global::Capa_Vista_Produccion.Properties.Resources.ahorrar;
            this.Btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Agregar.Location = new System.Drawing.Point(347, 213);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Agregar.TabIndex = 27;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Cbo_Proceso
            // 
            this.Cbo_Proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Proceso.FormattingEnabled = true;
            this.Cbo_Proceso.Location = new System.Drawing.Point(572, 186);
            this.Cbo_Proceso.Name = "Cbo_Proceso";
            this.Cbo_Proceso.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Proceso.TabIndex = 31;
            // 
            // Lbl_Orden_Proceso
            // 
            this.Lbl_Orden_Proceso.AutoSize = true;
            this.Lbl_Orden_Proceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_Orden_Proceso.Location = new System.Drawing.Point(460, 187);
            this.Lbl_Orden_Proceso.Name = "Lbl_Orden_Proceso";
            this.Lbl_Orden_Proceso.Size = new System.Drawing.Size(106, 15);
            this.Lbl_Orden_Proceso.TabIndex = 32;
            this.Lbl_Orden_Proceso.Text = "Orden de Proceso";
            // 
            // Frm_Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(838, 581);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Lotes";
            this.Text = "Frm_Lotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Codigo_Lote;
        private System.Windows.Forms.TextBox Txt_Id_Lotes;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Produccion;
        private System.Windows.Forms.ComboBox Cbo_Estado_Lotes;
        private System.Windows.Forms.ComboBox Cbo_Producto;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label Lbl_Id_Lote;
        private System.Windows.Forms.Label Lbl_Codigo_Lote;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Detalles;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.DataGridView dgv_Lotes;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.ComboBox Cbo_Proceso;
        private System.Windows.Forms.Label Lbl_Orden_Proceso;
    }
}