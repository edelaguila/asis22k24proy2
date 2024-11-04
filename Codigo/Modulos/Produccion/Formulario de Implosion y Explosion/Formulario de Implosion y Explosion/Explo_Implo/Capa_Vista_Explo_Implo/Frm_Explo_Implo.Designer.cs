
namespace Capa_Vista_Explo_Implo
{
    partial class Frm_Explo_Implo
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
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.dgv_explosion = new System.Windows.Forms.DataGridView();
            this.txt_id_explosion = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_costo_total = new System.Windows.Forms.TextBox();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbo_orden = new System.Windows.Forms.ComboBox();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.cbo_proceso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_explosion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(148, 140);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(100, 28);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(295, 140);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(435, 140);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 28);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(575, 140);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(100, 28);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Explosion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Orden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Producto ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Duracion Horas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Proceso";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(477, 417);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(187, 22);
            this.dtp_fecha.TabIndex = 12;
            // 
            // dgv_explosion
            // 
            this.dgv_explosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_explosion.Location = new System.Drawing.Point(60, 489);
            this.dgv_explosion.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_explosion.Name = "dgv_explosion";
            this.dgv_explosion.RowHeadersWidth = 51;
            this.dgv_explosion.Size = new System.Drawing.Size(717, 185);
            this.dgv_explosion.TabIndex = 13;
            // 
            // txt_id_explosion
            // 
            this.txt_id_explosion.Location = new System.Drawing.Point(244, 242);
            this.txt_id_explosion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_explosion.Name = "txt_id_explosion";
            this.txt_id_explosion.Size = new System.Drawing.Size(149, 22);
            this.txt_id_explosion.TabIndex = 14;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(244, 417);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(149, 22);
            this.txt_cantidad.TabIndex = 17;
            // 
            // txt_costo_total
            // 
            this.txt_costo_total.Location = new System.Drawing.Point(601, 239);
            this.txt_costo_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_costo_total.Name = "txt_costo_total";
            this.txt_costo_total.Size = new System.Drawing.Size(156, 22);
            this.txt_costo_total.TabIndex = 18;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(601, 293);
            this.txt_duracion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(160, 22);
            this.txt_duracion.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Explosion";
            // 
            // cbo_orden
            // 
            this.cbo_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_orden.FormattingEnabled = true;
            this.cbo_orden.Location = new System.Drawing.Point(247, 293);
            this.cbo_orden.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_orden.Name = "cbo_orden";
            this.cbo_orden.Size = new System.Drawing.Size(147, 24);
            this.cbo_orden.TabIndex = 22;
            // 
            // cbo_producto
            // 
            this.cbo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(247, 358);
            this.cbo_producto.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(147, 24);
            this.cbo_producto.TabIndex = 23;
            // 
            // cbo_proceso
            // 
            this.cbo_proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_proceso.FormattingEnabled = true;
            this.cbo_proceso.Location = new System.Drawing.Point(601, 358);
            this.cbo_proceso.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_proceso.Name = "cbo_proceso";
            this.cbo_proceso.Size = new System.Drawing.Size(160, 24);
            this.cbo_proceso.TabIndex = 24;
            // 
            // Frm_Explo_Implo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 727);
            this.Controls.Add(this.cbo_proceso);
            this.Controls.Add(this.cbo_producto);
            this.Controls.Add(this.cbo_orden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_duracion);
            this.Controls.Add(this.txt_costo_total);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_id_explosion);
            this.Controls.Add(this.dgv_explosion);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_ingresar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Explo_Implo";
            this.Text = "Frm_Explo_Implo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_explosion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DataGridView dgv_explosion;
        private System.Windows.Forms.TextBox txt_id_explosion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_costo_total;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbo_orden;
        private System.Windows.Forms.ComboBox cbo_producto;
        private System.Windows.Forms.ComboBox cbo_proceso;
    }
}