namespace Capa_Vista_Planilla
{
    partial class Frm_GenPlanilla
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
            this.Lbl_Correlativo = new System.Windows.Forms.Label();
            this.dgv_encabezado = new System.Windows.Forms.DataGridView();
            this.Cbo_ClaveEmpleado = new System.Windows.Forms.ComboBox();
            this.Txt_ClaveDetalle = new System.Windows.Forms.TextBox();
            this.Txt_Correlativo = new System.Windows.Forms.TextBox();
            this.Lbl_Encabezado = new System.Windows.Forms.Label();
            this.Lbl_ClaveEmpleado = new System.Windows.Forms.Label();
            this.Lbl_ClaveDetalle = new System.Windows.Forms.Label();
            this.Lbl_FechaFin = new System.Windows.Forms.Label();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Lbl_pk_Encabezado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.Cbo_CEncabezado = new System.Windows.Forms.ComboBox();
            this.Btn_cancelarPlanilla = new System.Windows.Forms.Button();
            this.Btn_guardarPlanilla = new System.Windows.Forms.Button();
            this.Btn_editarPlanilla = new System.Windows.Forms.Button();
            this.Btn_insertarPlanilla = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_insertar = new System.Windows.Forms.Button();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.Txt_ClaveEncabezado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Correlativo
            // 
            this.Lbl_Correlativo.AutoSize = true;
            this.Lbl_Correlativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Correlativo.Location = new System.Drawing.Point(122, 179);
            this.Lbl_Correlativo.Name = "Lbl_Correlativo";
            this.Lbl_Correlativo.Size = new System.Drawing.Size(108, 22);
            this.Lbl_Correlativo.TabIndex = 65;
            this.Lbl_Correlativo.Text = "Correlativo";
            // 
            // dgv_encabezado
            // 
            this.dgv_encabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_encabezado.Location = new System.Drawing.Point(23, 299);
            this.dgv_encabezado.Name = "dgv_encabezado";
            this.dgv_encabezado.RowHeadersWidth = 51;
            this.dgv_encabezado.RowTemplate.Height = 24;
            this.dgv_encabezado.Size = new System.Drawing.Size(595, 266);
            this.dgv_encabezado.TabIndex = 52;
            // 
            // Cbo_ClaveEmpleado
            // 
            this.Cbo_ClaveEmpleado.FormattingEnabled = true;
            this.Cbo_ClaveEmpleado.Location = new System.Drawing.Point(907, 181);
            this.Cbo_ClaveEmpleado.Name = "Cbo_ClaveEmpleado";
            this.Cbo_ClaveEmpleado.Size = new System.Drawing.Size(193, 24);
            this.Cbo_ClaveEmpleado.TabIndex = 50;
            this.Cbo_ClaveEmpleado.SelectedIndexChanged += new System.EventHandler(this.Cbo_ClaveEmpleado_SelectedIndexChanged);
            // 
            // Txt_ClaveDetalle
            // 
            this.Txt_ClaveDetalle.Location = new System.Drawing.Point(907, 138);
            this.Txt_ClaveDetalle.Name = "Txt_ClaveDetalle";
            this.Txt_ClaveDetalle.Size = new System.Drawing.Size(191, 22);
            this.Txt_ClaveDetalle.TabIndex = 48;
            // 
            // Txt_Correlativo
            // 
            this.Txt_Correlativo.Location = new System.Drawing.Point(321, 181);
            this.Txt_Correlativo.Name = "Txt_Correlativo";
            this.Txt_Correlativo.Size = new System.Drawing.Size(193, 22);
            this.Txt_Correlativo.TabIndex = 47;
            // 
            // Lbl_Encabezado
            // 
            this.Lbl_Encabezado.AutoSize = true;
            this.Lbl_Encabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Encabezado.Location = new System.Drawing.Point(711, 227);
            this.Lbl_Encabezado.Name = "Lbl_Encabezado";
            this.Lbl_Encabezado.Size = new System.Drawing.Size(176, 22);
            this.Lbl_Encabezado.TabIndex = 45;
            this.Lbl_Encabezado.Text = "Clave Encabezado";
            // 
            // Lbl_ClaveEmpleado
            // 
            this.Lbl_ClaveEmpleado.AutoSize = true;
            this.Lbl_ClaveEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ClaveEmpleado.Location = new System.Drawing.Point(711, 183);
            this.Lbl_ClaveEmpleado.Name = "Lbl_ClaveEmpleado";
            this.Lbl_ClaveEmpleado.Size = new System.Drawing.Size(155, 22);
            this.Lbl_ClaveEmpleado.TabIndex = 44;
            this.Lbl_ClaveEmpleado.Text = "Clave Empleado";
            // 
            // Lbl_ClaveDetalle
            // 
            this.Lbl_ClaveDetalle.AutoSize = true;
            this.Lbl_ClaveDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ClaveDetalle.Location = new System.Drawing.Point(711, 138);
            this.Lbl_ClaveDetalle.Name = "Lbl_ClaveDetalle";
            this.Lbl_ClaveDetalle.Size = new System.Drawing.Size(130, 22);
            this.Lbl_ClaveDetalle.TabIndex = 43;
            this.Lbl_ClaveDetalle.Text = "Clave Detalle";
            // 
            // Lbl_FechaFin
            // 
            this.Lbl_FechaFin.AutoSize = true;
            this.Lbl_FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_FechaFin.Location = new System.Drawing.Point(122, 253);
            this.Lbl_FechaFin.Name = "Lbl_FechaFin";
            this.Lbl_FechaFin.Size = new System.Drawing.Size(99, 22);
            this.Lbl_FechaFin.TabIndex = 42;
            this.Lbl_FechaFin.Text = "Fecha Fin";
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(122, 216);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(118, 22);
            this.Lbl_FechaInicio.TabIndex = 41;
            this.Lbl_FechaInicio.Text = "Fecha Inicio";
            // 
            // Lbl_pk_Encabezado
            // 
            this.Lbl_pk_Encabezado.AutoSize = true;
            this.Lbl_pk_Encabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_pk_Encabezado.Location = new System.Drawing.Point(122, 144);
            this.Lbl_pk_Encabezado.Name = "Lbl_pk_Encabezado";
            this.Lbl_pk_Encabezado.Size = new System.Drawing.Size(176, 22);
            this.Lbl_pk_Encabezado.TabIndex = 40;
            this.Lbl_pk_Encabezado.Text = "Clave Encabezado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(255, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Encabezado Planilla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Location = new System.Drawing.Point(640, 299);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.RowHeadersWidth = 51;
            this.dgv_detalle.RowTemplate.Height = 24;
            this.dgv_detalle.Size = new System.Drawing.Size(585, 266);
            this.dgv_detalle.TabIndex = 67;
            // 
            // Cbo_CEncabezado
            // 
            this.Cbo_CEncabezado.FormattingEnabled = true;
            this.Cbo_CEncabezado.Location = new System.Drawing.Point(907, 229);
            this.Cbo_CEncabezado.Name = "Cbo_CEncabezado";
            this.Cbo_CEncabezado.Size = new System.Drawing.Size(193, 24);
            this.Cbo_CEncabezado.TabIndex = 68;
            this.Cbo_CEncabezado.SelectedIndexChanged += new System.EventHandler(this.Cbo_CEncabezado_SelectedIndexChanged);
            // 
            // Btn_cancelarPlanilla
            // 
            this.Btn_cancelarPlanilla.Image = global::Capa_Vista_Planilla.Properties.Resources.CANCELAR_V4;
            this.Btn_cancelarPlanilla.Location = new System.Drawing.Point(1011, 14);
            this.Btn_cancelarPlanilla.Name = "Btn_cancelarPlanilla";
            this.Btn_cancelarPlanilla.Size = new System.Drawing.Size(75, 71);
            this.Btn_cancelarPlanilla.TabIndex = 73;
            this.Btn_cancelarPlanilla.UseVisualStyleBackColor = true;
            // 
            // Btn_guardarPlanilla
            // 
            this.Btn_guardarPlanilla.Image = global::Capa_Vista_Planilla.Properties.Resources.guardar;
            this.Btn_guardarPlanilla.Location = new System.Drawing.Point(937, 14);
            this.Btn_guardarPlanilla.Name = "Btn_guardarPlanilla";
            this.Btn_guardarPlanilla.Size = new System.Drawing.Size(75, 71);
            this.Btn_guardarPlanilla.TabIndex = 71;
            this.Btn_guardarPlanilla.UseVisualStyleBackColor = true;
            this.Btn_guardarPlanilla.Click += new System.EventHandler(this.Btn_guardarPlanilla_Click);
            // 
            // Btn_editarPlanilla
            // 
            this.Btn_editarPlanilla.Image = global::Capa_Vista_Planilla.Properties.Resources.EDITAR_V4;
            this.Btn_editarPlanilla.Location = new System.Drawing.Point(863, 14);
            this.Btn_editarPlanilla.Name = "Btn_editarPlanilla";
            this.Btn_editarPlanilla.Size = new System.Drawing.Size(75, 71);
            this.Btn_editarPlanilla.TabIndex = 70;
            this.Btn_editarPlanilla.UseVisualStyleBackColor = true;
            this.Btn_editarPlanilla.Click += new System.EventHandler(this.Btn_editarPlanilla_Click);
            // 
            // Btn_insertarPlanilla
            // 
            this.Btn_insertarPlanilla.Image = global::Capa_Vista_Planilla.Properties.Resources.INGRESAR_V4;
            this.Btn_insertarPlanilla.Location = new System.Drawing.Point(793, 14);
            this.Btn_insertarPlanilla.Name = "Btn_insertarPlanilla";
            this.Btn_insertarPlanilla.Size = new System.Drawing.Size(75, 71);
            this.Btn_insertarPlanilla.TabIndex = 69;
            this.Btn_insertarPlanilla.UseVisualStyleBackColor = true;
            this.Btn_insertarPlanilla.Click += new System.EventHandler(this.Btn_insertarPlanilla_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Image = global::Capa_Vista_Planilla.Properties.Resources.CANCELAR_V4;
            this.Btn_cancelar.Location = new System.Drawing.Point(398, 18);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 71);
            this.Btn_cancelar.TabIndex = 55;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::Capa_Vista_Planilla.Properties.Resources.guardar;
            this.Btn_guardar.Location = new System.Drawing.Point(324, 18);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 71);
            this.Btn_guardar.TabIndex = 38;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = global::Capa_Vista_Planilla.Properties.Resources.EDITAR_V4;
            this.Btn_editar.Location = new System.Drawing.Point(250, 18);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 71);
            this.Btn_editar.TabIndex = 37;
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_insertar
            // 
            this.Btn_insertar.Image = global::Capa_Vista_Planilla.Properties.Resources.INGRESAR_V4;
            this.Btn_insertar.Location = new System.Drawing.Point(180, 18);
            this.Btn_insertar.Name = "Btn_insertar";
            this.Btn_insertar.Size = new System.Drawing.Size(75, 71);
            this.Btn_insertar.TabIndex = 36;
            this.Btn_insertar.UseVisualStyleBackColor = true;
            this.Btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(321, 216);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(193, 22);
            this.dtp_inicio.TabIndex = 74;
            // 
            // dtp_final
            // 
            this.dtp_final.Location = new System.Drawing.Point(321, 253);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(193, 22);
            this.dtp_final.TabIndex = 75;
            // 
            // Txt_ClaveEncabezado
            // 
            this.Txt_ClaveEncabezado.Location = new System.Drawing.Point(321, 144);
            this.Txt_ClaveEncabezado.Name = "Txt_ClaveEncabezado";
            this.Txt_ClaveEncabezado.Size = new System.Drawing.Size(193, 22);
            this.Txt_ClaveEncabezado.TabIndex = 76;
            // 
            // Frm_GenPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1237, 592);
            this.Controls.Add(this.Txt_ClaveEncabezado);
            this.Controls.Add(this.dtp_final);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.Btn_cancelarPlanilla);
            this.Controls.Add(this.Btn_guardarPlanilla);
            this.Controls.Add(this.Btn_editarPlanilla);
            this.Controls.Add(this.Btn_insertarPlanilla);
            this.Controls.Add(this.Cbo_CEncabezado);
            this.Controls.Add(this.dgv_detalle);
            this.Controls.Add(this.Lbl_Correlativo);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.dgv_encabezado);
            this.Controls.Add(this.Cbo_ClaveEmpleado);
            this.Controls.Add(this.Txt_ClaveDetalle);
            this.Controls.Add(this.Txt_Correlativo);
            this.Controls.Add(this.Lbl_Encabezado);
            this.Controls.Add(this.Lbl_ClaveEmpleado);
            this.Controls.Add(this.Lbl_ClaveDetalle);
            this.Controls.Add(this.Lbl_FechaFin);
            this.Controls.Add(this.Lbl_FechaInicio);
            this.Controls.Add(this.Lbl_pk_Encabezado);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_insertar);
            this.Controls.Add(this.label1);
            this.Name = "Frm_GenPlanilla";
            this.Text = "Frm_GenPlanilla";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Correlativo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.DataGridView dgv_encabezado;
        private System.Windows.Forms.ComboBox Cbo_ClaveEmpleado;
        private System.Windows.Forms.TextBox Txt_ClaveDetalle;
        private System.Windows.Forms.TextBox Txt_Correlativo;
        private System.Windows.Forms.Label Lbl_Encabezado;
        private System.Windows.Forms.Label Lbl_ClaveEmpleado;
        private System.Windows.Forms.Label Lbl_ClaveDetalle;
        private System.Windows.Forms.Label Lbl_FechaFin;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label Lbl_pk_Encabezado;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_insertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.ComboBox Cbo_CEncabezado;
        private System.Windows.Forms.Button Btn_cancelarPlanilla;
        private System.Windows.Forms.Button Btn_guardarPlanilla;
        private System.Windows.Forms.Button Btn_editarPlanilla;
        private System.Windows.Forms.Button Btn_insertarPlanilla;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.TextBox Txt_ClaveEncabezado;
    }
}