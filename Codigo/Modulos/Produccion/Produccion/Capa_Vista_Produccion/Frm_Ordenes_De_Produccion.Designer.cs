
namespace Capa_Vista_Produccion
{
    partial class Frm_Ordenes_De_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordenes_De_Produccion));
            this.dgv_ordenes = new System.Windows.Forms.DataGridView();
            this.txt_id_orden = new System.Windows.Forms.TextBox();
            this.cbo_estado_orden = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_id_orden = new System.Windows.Forms.Label();
            this.lbl_estado_orden = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_buscar_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_buscar_fin = new System.Windows.Forms.DateTimePicker();
            this.dgv_detalle_orden = new System.Windows.Forms.DataGridView();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ordenes
            // 
            this.dgv_ordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordenes.Location = new System.Drawing.Point(22, 362);
            this.dgv_ordenes.Name = "dgv_ordenes";
            this.dgv_ordenes.Size = new System.Drawing.Size(546, 263);
            this.dgv_ordenes.TabIndex = 0;
            // 
            // txt_id_orden
            // 
            this.txt_id_orden.Location = new System.Drawing.Point(84, 162);
            this.txt_id_orden.Name = "txt_id_orden";
            this.txt_id_orden.Size = new System.Drawing.Size(100, 20);
            this.txt_id_orden.TabIndex = 1;
            // 
            // cbo_estado_orden
            // 
            this.cbo_estado_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado_orden.FormattingEnabled = true;
            this.cbo_estado_orden.Location = new System.Drawing.Point(84, 244);
            this.cbo_estado_orden.Name = "cbo_estado_orden";
            this.cbo_estado_orden.Size = new System.Drawing.Size(121, 21);
            this.cbo_estado_orden.TabIndex = 3;
            this.cbo_estado_orden.SelectedIndexChanged += new System.EventHandler(this.cbo_estado_orden_SelectedIndexChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar.BackgroundImage")));
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.Location = new System.Drawing.Point(32, 85);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 65);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(113, 85);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 65);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(194, 85);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 65);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(452, 85);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 65);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_id_orden
            // 
            this.lbl_id_orden.AutoSize = true;
            this.lbl_id_orden.Location = new System.Drawing.Point(60, 165);
            this.lbl_id_orden.Name = "lbl_id_orden";
            this.lbl_id_orden.Size = new System.Drawing.Size(18, 13);
            this.lbl_id_orden.TabIndex = 8;
            this.lbl_id_orden.Text = "ID";
            // 
            // lbl_estado_orden
            // 
            this.lbl_estado_orden.AutoSize = true;
            this.lbl_estado_orden.Location = new System.Drawing.Point(29, 247);
            this.lbl_estado_orden.Name = "lbl_estado_orden";
            this.lbl_estado_orden.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado_orden.TabIndex = 10;
            this.lbl_estado_orden.Text = "Estado";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(84, 218);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 11;
            // 
            // cbo_producto
            // 
            this.cbo_producto.DisplayMember = "nombreProducto";
            this.cbo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(84, 188);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(121, 21);
            this.cbo_producto.TabIndex = 12;
            this.cbo_producto.ValueMember = "Pk_id_producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(29, 221);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad.TabIndex = 13;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(29, 191);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(50, 13);
            this.lbl_producto.TabIndex = 14;
            this.lbl_producto.Text = "Producto";
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(84, 280);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(222, 20);
            this.dtp_fecha_inicio.TabIndex = 19;
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Location = new System.Drawing.Point(84, 317);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(222, 20);
            this.dtp_fecha_fin.TabIndex = 20;
            // 
            // dtp_buscar_inicio
            // 
            this.dtp_buscar_inicio.Location = new System.Drawing.Point(533, 117);
            this.dtp_buscar_inicio.Name = "dtp_buscar_inicio";
            this.dtp_buscar_inicio.Size = new System.Drawing.Size(222, 20);
            this.dtp_buscar_inicio.TabIndex = 21;
            // 
            // dtp_buscar_fin
            // 
            this.dtp_buscar_fin.Location = new System.Drawing.Point(781, 117);
            this.dtp_buscar_fin.Name = "dtp_buscar_fin";
            this.dtp_buscar_fin.Size = new System.Drawing.Size(222, 20);
            this.dtp_buscar_fin.TabIndex = 22;
            // 
            // dgv_detalle_orden
            // 
            this.dgv_detalle_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_orden.Location = new System.Drawing.Point(574, 362);
            this.dgv_detalle_orden.Name = "dgv_detalle_orden";
            this.dgv_detalle_orden.Size = new System.Drawing.Size(546, 263);
            this.dgv_detalle_orden.TabIndex = 23;
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Location = new System.Drawing.Point(211, 186);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(150, 23);
            this.btn_agregar_producto.TabIndex = 25;
            this.btn_agregar_producto.Text = "Añadir producto a la orden";
            this.btn_agregar_producto.UseVisualStyleBackColor = true;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(1057, 80);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 65);
            this.btn_Salir.TabIndex = 26;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ordenes de Producción";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_Ordenes_De_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1144, 637);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_agregar_producto);
            this.Controls.Add(this.dgv_detalle_orden);
            this.Controls.Add(this.dtp_buscar_fin);
            this.Controls.Add(this.dtp_buscar_inicio);
            this.Controls.Add(this.dtp_fecha_fin);
            this.Controls.Add(this.dtp_fecha_inicio);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.cbo_producto);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_estado_orden);
            this.Controls.Add(this.lbl_id_orden);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cbo_estado_orden);
            this.Controls.Add(this.txt_id_orden);
            this.Controls.Add(this.dgv_ordenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Ordenes_De_Produccion";
            this.Text = "Frm_Ordenes_De_Produccion";
            this.Load += new System.EventHandler(this.Frm_Ordenes_De_Produccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ordenes;
        private System.Windows.Forms.TextBox txt_id_orden;
        private System.Windows.Forms.ComboBox cbo_estado_orden;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_id_orden;
        private System.Windows.Forms.Label lbl_estado_orden;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox cbo_producto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_buscar_inicio;
        private System.Windows.Forms.DateTimePicker dtp_buscar_fin;
        private System.Windows.Forms.DataGridView dgv_detalle_orden;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}