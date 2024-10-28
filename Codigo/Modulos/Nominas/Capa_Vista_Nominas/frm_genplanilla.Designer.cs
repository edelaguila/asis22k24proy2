
namespace Capa_Vista_Nominas
{
    partial class frm_genplanilla
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
            this.dgv_encabezado = new System.Windows.Forms.DataGridView();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.lbl_encabezado = new System.Windows.Forms.Label();
            this.lbl_detalle = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_EncabPlanilla = new System.Windows.Forms.Label();
            this.Lbl_Correlativo = new System.Windows.Forms.Label();
            this.Lbl_fechaInicio = new System.Windows.Forms.Label();
            this.Lbl_FechaFinal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_ClaveDetalle = new System.Windows.Forms.Label();
            this.Cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.Lbl_empleado = new System.Windows.Forms.Label();
            this.Lbl_EncabezadoPlanilla = new System.Windows.Forms.Label();
            this.Cmb_Encabezado = new System.Windows.Forms.ComboBox();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Btn_NuevoDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_encabezado
            // 
            this.dgv_encabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_encabezado.Location = new System.Drawing.Point(12, 311);
            this.dgv_encabezado.Name = "dgv_encabezado";
            this.dgv_encabezado.RowHeadersWidth = 51;
            this.dgv_encabezado.RowTemplate.Height = 24;
            this.dgv_encabezado.Size = new System.Drawing.Size(556, 258);
            this.dgv_encabezado.TabIndex = 0;
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Location = new System.Drawing.Point(629, 311);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.RowHeadersWidth = 51;
            this.dgv_detalle.RowTemplate.Height = 24;
            this.dgv_detalle.Size = new System.Drawing.Size(540, 258);
            this.dgv_detalle.TabIndex = 1;
            // 
            // lbl_encabezado
            // 
            this.lbl_encabezado.AutoSize = true;
            this.lbl_encabezado.Location = new System.Drawing.Point(181, 9);
            this.lbl_encabezado.Name = "lbl_encabezado";
            this.lbl_encabezado.Size = new System.Drawing.Size(131, 16);
            this.lbl_encabezado.TabIndex = 2;
            this.lbl_encabezado.Text = "Encabezado Planilla";
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Location = new System.Drawing.Point(882, 9);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(97, 16);
            this.lbl_detalle.TabIndex = 3;
            this.lbl_detalle.Text = "Detalle Planilla";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Image = global::Capa_Vista_Nominas.Properties.Resources.Nuevo_V2;
            this.Btn_Guardar.Location = new System.Drawing.Point(12, 43);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(76, 65);
            this.Btn_Guardar.TabIndex = 4;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Lbl_EncabPlanilla
            // 
            this.Lbl_EncabPlanilla.AutoSize = true;
            this.Lbl_EncabPlanilla.Location = new System.Drawing.Point(9, 130);
            this.Lbl_EncabPlanilla.Name = "Lbl_EncabPlanilla";
            this.Lbl_EncabPlanilla.Size = new System.Drawing.Size(122, 16);
            this.Lbl_EncabPlanilla.TabIndex = 5;
            this.Lbl_EncabPlanilla.Text = "Clave Encabezado";
            // 
            // Lbl_Correlativo
            // 
            this.Lbl_Correlativo.AutoSize = true;
            this.Lbl_Correlativo.Location = new System.Drawing.Point(9, 162);
            this.Lbl_Correlativo.Name = "Lbl_Correlativo";
            this.Lbl_Correlativo.Size = new System.Drawing.Size(84, 16);
            this.Lbl_Correlativo.TabIndex = 6;
            this.Lbl_Correlativo.Text = "Encabezado";
            // 
            // Lbl_fechaInicio
            // 
            this.Lbl_fechaInicio.AutoSize = true;
            this.Lbl_fechaInicio.Location = new System.Drawing.Point(9, 197);
            this.Lbl_fechaInicio.Name = "Lbl_fechaInicio";
            this.Lbl_fechaInicio.Size = new System.Drawing.Size(79, 16);
            this.Lbl_fechaInicio.TabIndex = 7;
            this.Lbl_fechaInicio.Text = "Fecha inicio";
            // 
            // Lbl_FechaFinal
            // 
            this.Lbl_FechaFinal.AutoSize = true;
            this.Lbl_FechaFinal.Location = new System.Drawing.Point(9, 236);
            this.Lbl_FechaFinal.Name = "Lbl_FechaFinal";
            this.Lbl_FechaFinal.Size = new System.Drawing.Size(77, 16);
            this.Lbl_FechaFinal.TabIndex = 8;
            this.Lbl_FechaFinal.Text = "Fecha Final";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(166, 236);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // Lbl_ClaveDetalle
            // 
            this.Lbl_ClaveDetalle.AutoSize = true;
            this.Lbl_ClaveDetalle.Location = new System.Drawing.Point(629, 135);
            this.Lbl_ClaveDetalle.Name = "Lbl_ClaveDetalle";
            this.Lbl_ClaveDetalle.Size = new System.Drawing.Size(88, 16);
            this.Lbl_ClaveDetalle.TabIndex = 13;
            this.Lbl_ClaveDetalle.Text = "Clave Detalle";
            // 
            // Cmb_Empleado
            // 
            this.Cmb_Empleado.FormattingEnabled = true;
            this.Cmb_Empleado.Location = new System.Drawing.Point(781, 175);
            this.Cmb_Empleado.Name = "Cmb_Empleado";
            this.Cmb_Empleado.Size = new System.Drawing.Size(121, 24);
            this.Cmb_Empleado.TabIndex = 14;
            // 
            // Lbl_empleado
            // 
            this.Lbl_empleado.AutoSize = true;
            this.Lbl_empleado.Location = new System.Drawing.Point(632, 183);
            this.Lbl_empleado.Name = "Lbl_empleado";
            this.Lbl_empleado.Size = new System.Drawing.Size(70, 16);
            this.Lbl_empleado.TabIndex = 15;
            this.Lbl_empleado.Text = "Empleado";
            this.Lbl_empleado.Click += new System.EventHandler(this.Lbl_empleado_Click);
            // 
            // Lbl_EncabezadoPlanilla
            // 
            this.Lbl_EncabezadoPlanilla.AutoSize = true;
            this.Lbl_EncabezadoPlanilla.Location = new System.Drawing.Point(632, 241);
            this.Lbl_EncabezadoPlanilla.Name = "Lbl_EncabezadoPlanilla";
            this.Lbl_EncabezadoPlanilla.Size = new System.Drawing.Size(84, 16);
            this.Lbl_EncabezadoPlanilla.TabIndex = 16;
            this.Lbl_EncabezadoPlanilla.Text = "Encabezado";
            // 
            // Cmb_Encabezado
            // 
            this.Cmb_Encabezado.FormattingEnabled = true;
            this.Cmb_Encabezado.Location = new System.Drawing.Point(781, 234);
            this.Cmb_Encabezado.Name = "Cmb_Encabezado";
            this.Cmb_Encabezado.Size = new System.Drawing.Size(121, 24);
            this.Cmb_Encabezado.TabIndex = 17;
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Location = new System.Drawing.Point(781, 129);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.Size = new System.Drawing.Size(121, 22);
            this.Txt_Clave.TabIndex = 18;
            // 
            // Btn_NuevoDetalle
            // 
            this.Btn_NuevoDetalle.Image = global::Capa_Vista_Nominas.Properties.Resources.Nuevo_V2;
            this.Btn_NuevoDetalle.Location = new System.Drawing.Point(629, 43);
            this.Btn_NuevoDetalle.Name = "Btn_NuevoDetalle";
            this.Btn_NuevoDetalle.Size = new System.Drawing.Size(76, 65);
            this.Btn_NuevoDetalle.TabIndex = 19;
            this.Btn_NuevoDetalle.UseVisualStyleBackColor = true;
            this.Btn_NuevoDetalle.Click += new System.EventHandler(this.Btn_NuevoDetalle_Click);
            // 
            // frm_genplanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 598);
            this.Controls.Add(this.Btn_NuevoDetalle);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Cmb_Encabezado);
            this.Controls.Add(this.Lbl_EncabezadoPlanilla);
            this.Controls.Add(this.Lbl_empleado);
            this.Controls.Add(this.Cmb_Empleado);
            this.Controls.Add(this.Lbl_ClaveDetalle);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_FechaFinal);
            this.Controls.Add(this.Lbl_fechaInicio);
            this.Controls.Add(this.Lbl_Correlativo);
            this.Controls.Add(this.Lbl_EncabPlanilla);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.lbl_detalle);
            this.Controls.Add(this.lbl_encabezado);
            this.Controls.Add(this.dgv_detalle);
            this.Controls.Add(this.dgv_encabezado);
            this.Name = "frm_genplanilla";
            this.Text = "Generación Planilla";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_encabezado;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Label lbl_encabezado;
        private System.Windows.Forms.Label lbl_detalle;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_EncabPlanilla;
        private System.Windows.Forms.Label Lbl_Correlativo;
        private System.Windows.Forms.Label Lbl_fechaInicio;
        private System.Windows.Forms.Label Lbl_FechaFinal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Lbl_ClaveDetalle;
        private System.Windows.Forms.ComboBox Cmb_Empleado;
        private System.Windows.Forms.Label Lbl_empleado;
        private System.Windows.Forms.Label Lbl_EncabezadoPlanilla;
        private System.Windows.Forms.ComboBox Cmb_Encabezado;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.Button Btn_NuevoDetalle;
    }
}