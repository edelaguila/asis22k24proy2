
namespace MVC_JavierChamo
{
    partial class Mantenimiento_de_Vehiculos
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NombreSolicitante = new System.Windows.Forms.TextBox();
            this.Fecha_mantenimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_ComponenteAfectado = new System.Windows.Forms.ComboBox();
            this.cmb_TipoMantenimiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID_mantenimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fk_id_vehiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TiempoEstimado = new System.Windows.Forms.TextBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CodigoError = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_responsableAsignado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgbMantenimiento = new System.Windows.Forms.DataGridView();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.btn_NuevoRegistro = new System.Windows.Forms.Button();
            this.btn_generarPDF = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Componente Afectado";
            // 
            // txt_NombreSolicitante
            // 
            this.txt_NombreSolicitante.Location = new System.Drawing.Point(573, 67);
            this.txt_NombreSolicitante.Name = "txt_NombreSolicitante";
            this.txt_NombreSolicitante.Size = new System.Drawing.Size(219, 20);
            this.txt_NombreSolicitante.TabIndex = 38;
            // 
            // Fecha_mantenimiento
            // 
            this.Fecha_mantenimiento.CustomFormat = "2024-10-21";
            this.Fecha_mantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_mantenimiento.Location = new System.Drawing.Point(175, 146);
            this.Fecha_mantenimiento.Name = "Fecha_mantenimiento";
            this.Fecha_mantenimiento.Size = new System.Drawing.Size(226, 20);
            this.Fecha_mantenimiento.TabIndex = 37;
            this.Fecha_mantenimiento.Value = new System.DateTime(2024, 10, 21, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fecha";
            // 
            // cmb_ComponenteAfectado
            // 
            this.cmb_ComponenteAfectado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ComponenteAfectado.FormattingEnabled = true;
            this.cmb_ComponenteAfectado.Items.AddRange(new object[] {
            "Motor",
            "Llantas",
            "Frenos",
            "Aceite/Agua"});
            this.cmb_ComponenteAfectado.Location = new System.Drawing.Point(573, 103);
            this.cmb_ComponenteAfectado.Name = "cmb_ComponenteAfectado";
            this.cmb_ComponenteAfectado.Size = new System.Drawing.Size(208, 21);
            this.cmb_ComponenteAfectado.TabIndex = 35;
            // 
            // cmb_TipoMantenimiento
            // 
            this.cmb_TipoMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoMantenimiento.FormattingEnabled = true;
            this.cmb_TipoMantenimiento.Items.AddRange(new object[] {
            "Preventivo",
            "Correctivo"});
            this.cmb_TipoMantenimiento.Location = new System.Drawing.Point(175, 106);
            this.cmb_TipoMantenimiento.Name = "cmb_TipoMantenimiento";
            this.cmb_TipoMantenimiento.Size = new System.Drawing.Size(226, 21);
            this.cmb_TipoMantenimiento.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo de mantenimiento";
            // 
            // txtID_mantenimiento
            // 
            this.txtID_mantenimiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtID_mantenimiento.Location = new System.Drawing.Point(175, 69);
            this.txtID_mantenimiento.Name = "txtID_mantenimiento";
            this.txtID_mantenimiento.Size = new System.Drawing.Size(226, 20);
            this.txtID_mantenimiento.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID_mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Formulario de solicitud de mantenimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre de Solicitante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(461, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 54;
            this.label11.Text = "Id del vehiculo";
            // 
            // txt_fk_id_vehiculo
            // 
            this.txt_fk_id_vehiculo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_fk_id_vehiculo.Location = new System.Drawing.Point(573, 263);
            this.txt_fk_id_vehiculo.Name = "txt_fk_id_vehiculo";
            this.txt_fk_id_vehiculo.Size = new System.Drawing.Size(168, 20);
            this.txt_fk_id_vehiculo.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Tiempo estimado";
            // 
            // txt_TiempoEstimado
            // 
            this.txt_TiempoEstimado.Location = new System.Drawing.Point(151, 267);
            this.txt_TiempoEstimado.Name = "txt_TiempoEstimado";
            this.txt_TiempoEstimado.Size = new System.Drawing.Size(250, 20);
            this.txt_TiempoEstimado.TabIndex = 46;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "No Activo"});
            this.cmb_Estado.Location = new System.Drawing.Point(573, 202);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(219, 21);
            this.cmb_Estado.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(382, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Estado del mantenimiento";
            // 
            // txt_CodigoError
            // 
            this.txt_CodigoError.Location = new System.Drawing.Point(117, 200);
            this.txt_CodigoError.Name = "txt_CodigoError";
            this.txt_CodigoError.Size = new System.Drawing.Size(258, 20);
            this.txt_CodigoError.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Problema";
            // 
            // txt_responsableAsignado
            // 
            this.txt_responsableAsignado.Location = new System.Drawing.Point(573, 146);
            this.txt_responsableAsignado.Name = "txt_responsableAsignado";
            this.txt_responsableAsignado.Size = new System.Drawing.Size(215, 20);
            this.txt_responsableAsignado.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Responsable asignado";
            // 
            // dgbMantenimiento
            // 
            this.dgbMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMantenimiento.Location = new System.Drawing.Point(38, 404);
            this.dgbMantenimiento.Name = "dgbMantenimiento";
            this.dgbMantenimiento.Size = new System.Drawing.Size(743, 231);
            this.dgbMantenimiento.TabIndex = 55;
            this.dgbMantenimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbMantenimiento_CellClick);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Image = global::MVC_JavierChamo.Properties.Resources.reporte;
            this.btn_Reporte.Location = new System.Drawing.Point(599, 307);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(78, 91);
            this.btn_Reporte.TabIndex = 57;
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_NuevoRegistro
            // 
            this.btn_NuevoRegistro.Image = global::MVC_JavierChamo.Properties.Resources.image__2_;
            this.btn_NuevoRegistro.Location = new System.Drawing.Point(38, 307);
            this.btn_NuevoRegistro.Name = "btn_NuevoRegistro";
            this.btn_NuevoRegistro.Size = new System.Drawing.Size(91, 91);
            this.btn_NuevoRegistro.TabIndex = 56;
            this.btn_NuevoRegistro.UseVisualStyleBackColor = true;
            this.btn_NuevoRegistro.Click += new System.EventHandler(this.btn_NuevoRegistro_Click);
            // 
            // btn_generarPDF
            // 
            this.btn_generarPDF.Image = global::MVC_JavierChamo.Properties.Resources.PDF;
            this.btn_generarPDF.Location = new System.Drawing.Point(692, 307);
            this.btn_generarPDF.Name = "btn_generarPDF";
            this.btn_generarPDF.Size = new System.Drawing.Size(89, 91);
            this.btn_generarPDF.TabIndex = 52;
            this.btn_generarPDF.UseVisualStyleBackColor = true;
            this.btn_generarPDF.Click += new System.EventHandler(this.btn_generarPDF_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::MVC_JavierChamo.Properties.Resources.trash;
            this.btn_Eliminar.Location = new System.Drawing.Point(386, 307);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(89, 91);
            this.btn_Eliminar.TabIndex = 51;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Image = global::MVC_JavierChamo.Properties.Resources.actualizarR;
            this.btn_Actualizar.Location = new System.Drawing.Point(504, 307);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 91);
            this.btn_Actualizar.TabIndex = 50;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Image = global::MVC_JavierChamo.Properties.Resources.lapiz;
            this.btn_Editar.Location = new System.Drawing.Point(275, 307);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(87, 91);
            this.btn_Editar.TabIndex = 49;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Image = global::MVC_JavierChamo.Properties.Resources.Guardar;
            this.btn_Enviar.Location = new System.Drawing.Point(151, 307);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(92, 91);
            this.btn_Enviar.TabIndex = 48;
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Image = global::MVC_JavierChamo.Properties.Resources.ayuda;
            this.btn_Ayuda.Location = new System.Drawing.Point(666, 12);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(126, 49);
            this.btn_Ayuda.TabIndex = 58;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // Mantenimiento_de_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.btn_NuevoRegistro);
            this.Controls.Add(this.dgbMantenimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_fk_id_vehiculo);
            this.Controls.Add(this.btn_generarPDF);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_TiempoEstimado);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_CodigoError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_responsableAsignado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NombreSolicitante);
            this.Controls.Add(this.Fecha_mantenimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_ComponenteAfectado);
            this.Controls.Add(this.cmb_TipoMantenimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID_mantenimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Mantenimiento_de_Vehiculos";
            this.Text = "Mantenimiento_de_Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgbMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_generarPDF;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_NuevoRegistro;
        private System.Windows.Forms.Button btn_Reporte;
        public System.Windows.Forms.DataGridView dgbMantenimiento;
        public System.Windows.Forms.TextBox txt_NombreSolicitante;
        public System.Windows.Forms.TextBox txtID_mantenimiento;
        public System.Windows.Forms.TextBox txt_fk_id_vehiculo;
        public System.Windows.Forms.TextBox txt_TiempoEstimado;
        public System.Windows.Forms.TextBox txt_CodigoError;
        public System.Windows.Forms.TextBox txt_responsableAsignado;
        public System.Windows.Forms.DateTimePicker Fecha_mantenimiento;
        public System.Windows.Forms.ComboBox cmb_ComponenteAfectado;
        public System.Windows.Forms.ComboBox cmb_TipoMantenimiento;
        public System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}