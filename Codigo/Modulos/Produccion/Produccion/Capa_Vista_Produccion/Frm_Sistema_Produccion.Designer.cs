
namespace Capa_Vista_Produccion
{
    partial class Frm_Sistema_Produccion
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
            this.cbo_orden = new System.Windows.Forms.ComboBox();
            this.cbo_maquinaria = new System.Windows.Forms.ComboBox();
            this.dgv_detalle_orden = new System.Windows.Forms.DataGridView();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_costo_u = new System.Windows.Forms.TextBox();
            this.txt_costo_t = new System.Windows.Forms.TextBox();
            this.nud_duracion_horas = new System.Windows.Forms.NumericUpDown();
            this.txt_mano_obra = new System.Windows.Forms.TextBox();
            this.txt_costo_luz = new System.Windows.Forms.TextBox();
            this.txt_costo_agua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_idProcesoDetalle = new System.Windows.Forms.TextBox();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.txt_idReceta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_idProceso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_horas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_orden
            // 
            this.cbo_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_orden.FormattingEnabled = true;
            this.cbo_orden.Location = new System.Drawing.Point(24, 39);
            this.cbo_orden.Name = "cbo_orden";
            this.cbo_orden.Size = new System.Drawing.Size(123, 21);
            this.cbo_orden.TabIndex = 0;
            // 
            // cbo_maquinaria
            // 
            this.cbo_maquinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maquinaria.FormattingEnabled = true;
            this.cbo_maquinaria.Location = new System.Drawing.Point(24, 78);
            this.cbo_maquinaria.Name = "cbo_maquinaria";
            this.cbo_maquinaria.Size = new System.Drawing.Size(123, 21);
            this.cbo_maquinaria.TabIndex = 1;
            // 
            // dgv_detalle_orden
            // 
            this.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_orden.Location = new System.Drawing.Point(28, 262);
            this.dgv_detalle_orden.Name = "dgv_detalle_orden";
            this.dgv_detalle_orden.Size = new System.Drawing.Size(852, 162);
            this.dgv_detalle_orden.TabIndex = 2;
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(177, 39);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(123, 21);
            this.cbo_empleado.TabIndex = 3;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(177, 78);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(117, 20);
            this.txt_cantidad.TabIndex = 4;
            // 
            // txt_costo_u
            // 
            this.txt_costo_u.Location = new System.Drawing.Point(177, 115);
            this.txt_costo_u.Name = "txt_costo_u";
            this.txt_costo_u.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_u.TabIndex = 5;
            // 
            // txt_costo_t
            // 
            this.txt_costo_t.Location = new System.Drawing.Point(177, 155);
            this.txt_costo_t.Name = "txt_costo_t";
            this.txt_costo_t.ReadOnly = true;
            this.txt_costo_t.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_t.TabIndex = 6;
            // 
            // nud_duracion_horas
            // 
            this.nud_duracion_horas.Location = new System.Drawing.Point(325, 79);
            this.nud_duracion_horas.Name = "nud_duracion_horas";
            this.nud_duracion_horas.Size = new System.Drawing.Size(120, 20);
            this.nud_duracion_horas.TabIndex = 7;
            // 
            // txt_mano_obra
            // 
            this.txt_mano_obra.Location = new System.Drawing.Point(325, 118);
            this.txt_mano_obra.Name = "txt_mano_obra";
            this.txt_mano_obra.Size = new System.Drawing.Size(117, 20);
            this.txt_mano_obra.TabIndex = 8;
            // 
            // txt_costo_luz
            // 
            this.txt_costo_luz.Location = new System.Drawing.Point(177, 195);
            this.txt_costo_luz.Name = "txt_costo_luz";
            this.txt_costo_luz.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_luz.TabIndex = 9;
            // 
            // txt_costo_agua
            // 
            this.txt_costo_agua.Location = new System.Drawing.Point(325, 164);
            this.txt_costo_agua.Name = "txt_costo_agua";
            this.txt_costo_agua.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_agua.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maquinaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Costo Unitrio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Costo Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Duración";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mano de Obra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Costo de Luz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Costo agua";
            // 
            // btn_asignar
            // 
            this.btn_asignar.Location = new System.Drawing.Point(38, 164);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(75, 23);
            this.btn_asignar.TabIndex = 21;
            this.btn_asignar.Text = "asignar";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(806, 22);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(74, 37);
            this.btn_salir.TabIndex = 22;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_idProcesoDetalle
            // 
            this.txt_idProcesoDetalle.Location = new System.Drawing.Point(325, 39);
            this.txt_idProcesoDetalle.Name = "txt_idProcesoDetalle";
            this.txt_idProcesoDetalle.ReadOnly = true;
            this.txt_idProcesoDetalle.Size = new System.Drawing.Size(117, 20);
            this.txt_idProcesoDetalle.TabIndex = 23;
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Location = new System.Drawing.Point(475, 39);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.Size = new System.Drawing.Size(117, 20);
            this.txt_idProducto.TabIndex = 24;
            // 
            // txt_idReceta
            // 
            this.txt_idReceta.Location = new System.Drawing.Point(475, 79);
            this.txt_idReceta.Name = "txt_idReceta";
            this.txt_idReceta.Size = new System.Drawing.Size(117, 20);
            this.txt_idReceta.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Id Proceso detalle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Id Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(472, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Id Receta";
            // 
            // txt_idProceso
            // 
            this.txt_idProceso.Location = new System.Drawing.Point(24, 132);
            this.txt_idProceso.Name = "txt_idProceso";
            this.txt_idProceso.ReadOnly = true;
            this.txt_idProceso.Size = new System.Drawing.Size(117, 20);
            this.txt_idProceso.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Id Proceso";
            // 
            // Frm_Sistema_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 458);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_idProceso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_idReceta);
            this.Controls.Add(this.txt_idProducto);
            this.Controls.Add(this.txt_idProcesoDetalle);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_costo_agua);
            this.Controls.Add(this.txt_costo_luz);
            this.Controls.Add(this.txt_mano_obra);
            this.Controls.Add(this.nud_duracion_horas);
            this.Controls.Add(this.txt_costo_t);
            this.Controls.Add(this.txt_costo_u);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cbo_empleado);
            this.Controls.Add(this.dgv_detalle_orden);
            this.Controls.Add(this.cbo_maquinaria);
            this.Controls.Add(this.cbo_orden);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Sistema_Produccion";
            this.Text = "Frm_Sistema_Produccion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_horas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_orden;
        private System.Windows.Forms.ComboBox cbo_maquinaria;
        private System.Windows.Forms.DataGridView dgv_detalle_orden;
        private System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_costo_u;
        private System.Windows.Forms.TextBox txt_costo_t;
        private System.Windows.Forms.NumericUpDown nud_duracion_horas;
        private System.Windows.Forms.TextBox txt_mano_obra;
        private System.Windows.Forms.TextBox txt_costo_luz;
        private System.Windows.Forms.TextBox txt_costo_agua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_idProcesoDetalle;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.TextBox txt_idReceta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_idProceso;
        private System.Windows.Forms.Label label14;
    }
}