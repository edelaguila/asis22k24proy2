
namespace MVC_JavierChamo
{
    partial class Movimiento_de_Inventario
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
            this.dgbMovimientoInventario = new System.Windows.Forms.DataGridView();
            this.cbm_Id_del_stock = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbm_Id_del_producto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbm_Estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numMovimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbm_Local = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_GenerarPDF = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMovimientoInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbMovimientoInventario
            // 
            this.dgbMovimientoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMovimientoInventario.Location = new System.Drawing.Point(86, 296);
            this.dgbMovimientoInventario.Name = "dgbMovimientoInventario";
            this.dgbMovimientoInventario.Size = new System.Drawing.Size(540, 262);
            this.dgbMovimientoInventario.TabIndex = 42;
            this.dgbMovimientoInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbMovimientoInventario_CellClick);
            // 
            // cbm_Id_del_stock
            // 
            this.cbm_Id_del_stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_Id_del_stock.FormattingEnabled = true;
            this.cbm_Id_del_stock.Location = new System.Drawing.Point(470, 203);
            this.cbm_Id_del_stock.Name = "cbm_Id_del_stock";
            this.cbm_Id_del_stock.Size = new System.Drawing.Size(191, 21);
            this.cbm_Id_del_stock.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Id del stock";
            // 
            // cbm_Id_del_producto
            // 
            this.cbm_Id_del_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_Id_del_producto.FormattingEnabled = true;
            this.cbm_Id_del_producto.Location = new System.Drawing.Point(163, 203);
            this.cbm_Id_del_producto.Name = "cbm_Id_del_producto";
            this.cbm_Id_del_producto.Size = new System.Drawing.Size(184, 21);
            this.cbm_Id_del_producto.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Id del Producto";
            // 
            // cbm_Estado
            // 
            this.cbm_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_Estado.FormattingEnabled = true;
            this.cbm_Estado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbm_Estado.Location = new System.Drawing.Point(470, 152);
            this.cbm_Estado.Name = "cbm_Estado";
            this.cbm_Estado.Size = new System.Drawing.Size(213, 21);
            this.cbm_Estado.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Estado";
            // 
            // txt_numMovimiento
            // 
            this.txt_numMovimiento.Location = new System.Drawing.Point(163, 157);
            this.txt_numMovimiento.Name = "txt_numMovimiento";
            this.txt_numMovimiento.Size = new System.Drawing.Size(184, 20);
            this.txt_numMovimiento.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Núm. de movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Id del Local";
            // 
            // cbm_Local
            // 
            this.cbm_Local.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_Local.FormattingEnabled = true;
            this.cbm_Local.Location = new System.Drawing.Point(163, 251);
            this.cbm_Local.Name = "cbm_Local";
            this.cbm_Local.Size = new System.Drawing.Size(121, 21);
            this.cbm_Local.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(169, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 39);
            this.label3.TabIndex = 48;
            this.label3.Text = "Movimiento de Inventario";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Image = global::MVC_JavierChamo.Properties.Resources.ayuda;
            this.btn_Ayuda.Location = new System.Drawing.Point(640, 296);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(81, 49);
            this.btn_Ayuda.TabIndex = 49;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Image = global::MVC_JavierChamo.Properties.Resources.reporte;
            this.btn_Reporte.Location = new System.Drawing.Point(640, 8);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(95, 96);
            this.btn_Reporte.TabIndex = 47;
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Image = global::MVC_JavierChamo.Properties.Resources.actualizarR;
            this.btn_Actualizar.Location = new System.Drawing.Point(383, 8);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(102, 96);
            this.btn_Actualizar.TabIndex = 44;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_GenerarPDF
            // 
            this.btn_GenerarPDF.Image = global::MVC_JavierChamo.Properties.Resources.PDF;
            this.btn_GenerarPDF.Location = new System.Drawing.Point(512, 8);
            this.btn_GenerarPDF.Name = "btn_GenerarPDF";
            this.btn_GenerarPDF.Size = new System.Drawing.Size(105, 96);
            this.btn_GenerarPDF.TabIndex = 43;
            this.btn_GenerarPDF.UseVisualStyleBackColor = true;
            this.btn_GenerarPDF.Click += new System.EventHandler(this.btn_GenerarPDF_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::MVC_JavierChamo.Properties.Resources.trash;
            this.btn_Eliminar.Location = new System.Drawing.Point(256, 8);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(101, 96);
            this.btn_Eliminar.TabIndex = 29;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Image = global::MVC_JavierChamo.Properties.Resources.lapiz;
            this.btn_Editar.Location = new System.Drawing.Point(143, 10);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(91, 94);
            this.btn_Editar.TabIndex = 27;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::MVC_JavierChamo.Properties.Resources.Guardar;
            this.btn_Guardar.Location = new System.Drawing.Point(16, 13);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(107, 91);
            this.btn_Guardar.TabIndex = 26;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Movimiento_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(747, 570);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.cbm_Local);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_GenerarPDF);
            this.Controls.Add(this.dgbMovimientoInventario);
            this.Controls.Add(this.cbm_Id_del_stock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbm_Id_del_producto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbm_Estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numMovimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "Movimiento_de_Inventario";
            this.Text = "Movimiento_de_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgbMovimientoInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_GenerarPDF;
        private System.Windows.Forms.DataGridView dgbMovimientoInventario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numMovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbm_Id_del_stock;
        public System.Windows.Forms.ComboBox cbm_Id_del_producto;
        public System.Windows.Forms.ComboBox cbm_Estado;
        public System.Windows.Forms.ComboBox cbm_Local;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}