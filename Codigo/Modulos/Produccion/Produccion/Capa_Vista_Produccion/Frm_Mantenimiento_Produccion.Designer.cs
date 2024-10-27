
namespace Capa_Vista_Produccion
{
    partial class Frm_Mantenimiento_Produccion
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
            this.Dgv_Mantenimientos = new System.Windows.Forms.DataGridView();
            this.Txt_ID_Maquinaria = new System.Windows.Forms.TextBox();
            this.Txt_NombreMaquinaria = new System.Windows.Forms.TextBox();
            this.Cbo_TipoMaquina = new System.Windows.Forms.ComboBox();
            this.Nud_HoraOperacion = new System.Windows.Forms.NumericUpDown();
            this.Txt_MantenimientoPeriodico = new System.Windows.Forms.TextBox();
            this.Dtp_UltimaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.Dtp_ProximoMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Area = new System.Windows.Forms.ComboBox();
            this.Nud_DesgastePorcentaje = new System.Windows.Forms.NumericUpDown();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Btn_Cargar = new System.Windows.Forms.Button();
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
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_HoraOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_DesgastePorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Mantenimientos
            // 
            this.Dgv_Mantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mantenimientos.Location = new System.Drawing.Point(34, 340);
            this.Dgv_Mantenimientos.Name = "Dgv_Mantenimientos";
            this.Dgv_Mantenimientos.Size = new System.Drawing.Size(771, 283);
            this.Dgv_Mantenimientos.TabIndex = 0;
            // 
            // Txt_ID_Maquinaria
            // 
            this.Txt_ID_Maquinaria.Enabled = false;
            this.Txt_ID_Maquinaria.Location = new System.Drawing.Point(204, 38);
            this.Txt_ID_Maquinaria.Name = "Txt_ID_Maquinaria";
            this.Txt_ID_Maquinaria.ReadOnly = true;
            this.Txt_ID_Maquinaria.Size = new System.Drawing.Size(148, 20);
            this.Txt_ID_Maquinaria.TabIndex = 1;
            // 
            // Txt_NombreMaquinaria
            // 
            this.Txt_NombreMaquinaria.Location = new System.Drawing.Point(204, 77);
            this.Txt_NombreMaquinaria.Name = "Txt_NombreMaquinaria";
            this.Txt_NombreMaquinaria.Size = new System.Drawing.Size(148, 20);
            this.Txt_NombreMaquinaria.TabIndex = 2;
            // 
            // Cbo_TipoMaquina
            // 
            this.Cbo_TipoMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoMaquina.FormattingEnabled = true;
            this.Cbo_TipoMaquina.Location = new System.Drawing.Point(204, 117);
            this.Cbo_TipoMaquina.Name = "Cbo_TipoMaquina";
            this.Cbo_TipoMaquina.Size = new System.Drawing.Size(148, 21);
            this.Cbo_TipoMaquina.TabIndex = 3;
            // 
            // Nud_HoraOperacion
            // 
            this.Nud_HoraOperacion.Location = new System.Drawing.Point(310, 158);
            this.Nud_HoraOperacion.Name = "Nud_HoraOperacion";
            this.Nud_HoraOperacion.Size = new System.Drawing.Size(42, 20);
            this.Nud_HoraOperacion.TabIndex = 4;
            // 
            // Txt_MantenimientoPeriodico
            // 
            this.Txt_MantenimientoPeriodico.Location = new System.Drawing.Point(204, 200);
            this.Txt_MantenimientoPeriodico.Name = "Txt_MantenimientoPeriodico";
            this.Txt_MantenimientoPeriodico.Size = new System.Drawing.Size(148, 20);
            this.Txt_MantenimientoPeriodico.TabIndex = 5;
            // 
            // Dtp_UltimaMantenimiento
            // 
            this.Dtp_UltimaMantenimiento.Location = new System.Drawing.Point(605, 37);
            this.Dtp_UltimaMantenimiento.Name = "Dtp_UltimaMantenimiento";
            this.Dtp_UltimaMantenimiento.Size = new System.Drawing.Size(200, 20);
            this.Dtp_UltimaMantenimiento.TabIndex = 6;
            // 
            // Dtp_ProximoMantenimiento
            // 
            this.Dtp_ProximoMantenimiento.Location = new System.Drawing.Point(605, 76);
            this.Dtp_ProximoMantenimiento.Name = "Dtp_ProximoMantenimiento";
            this.Dtp_ProximoMantenimiento.Size = new System.Drawing.Size(200, 20);
            this.Dtp_ProximoMantenimiento.TabIndex = 7;
            // 
            // Cbo_Area
            // 
            this.Cbo_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Area.FormattingEnabled = true;
            this.Cbo_Area.Location = new System.Drawing.Point(605, 116);
            this.Cbo_Area.Name = "Cbo_Area";
            this.Cbo_Area.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Area.TabIndex = 8;
            // 
            // Nud_DesgastePorcentaje
            // 
            this.Nud_DesgastePorcentaje.Location = new System.Drawing.Point(757, 157);
            this.Nud_DesgastePorcentaje.Name = "Nud_DesgastePorcentaje";
            this.Nud_DesgastePorcentaje.Size = new System.Drawing.Size(48, 20);
            this.Nud_DesgastePorcentaje.TabIndex = 9;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_Estado.Location = new System.Drawing.Point(605, 199);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Estado.TabIndex = 10;
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Location = new System.Drawing.Point(0, 0);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cargar.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Maquinaria";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(44, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hora de Operación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(44, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mantenimiento periódico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(452, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Último mantenimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(452, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Próximo mantenimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(452, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Área";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(450, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Porcentaje de desgaste";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(450, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Estado";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = global::Capa_Vista_Produccion.Properties.Resources.borrar2;
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Location = new System.Drawing.Point(518, 270);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Eliminar.TabIndex = 14;
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
            this.Btn_Actualizar.Location = new System.Drawing.Point(430, 270);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Actualizar.TabIndex = 13;
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
            this.Btn_Agregar.Location = new System.Drawing.Point(342, 270);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Agregar.TabIndex = 11;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_Nuevo.BackgroundImage = global::Capa_Vista_Produccion.Properties.Resources.agregar_archivo__1_;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo.Location = new System.Drawing.Point(258, 270);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(63, 55);
            this.btn_Nuevo.TabIndex = 26;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Frm_Mantenimiento_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(848, 704);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Cargar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Nud_DesgastePorcentaje);
            this.Controls.Add(this.Cbo_Area);
            this.Controls.Add(this.Dtp_ProximoMantenimiento);
            this.Controls.Add(this.Dtp_UltimaMantenimiento);
            this.Controls.Add(this.Txt_MantenimientoPeriodico);
            this.Controls.Add(this.Nud_HoraOperacion);
            this.Controls.Add(this.Cbo_TipoMaquina);
            this.Controls.Add(this.Txt_NombreMaquinaria);
            this.Controls.Add(this.Txt_ID_Maquinaria);
            this.Controls.Add(this.Dgv_Mantenimientos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Mantenimiento_Produccion";
            this.Text = "Frm_Mantenimiento_Produccion";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_HoraOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_DesgastePorcentaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Mantenimientos;
        private System.Windows.Forms.TextBox Txt_ID_Maquinaria;
        private System.Windows.Forms.TextBox Txt_NombreMaquinaria;
        private System.Windows.Forms.ComboBox Cbo_TipoMaquina;
        private System.Windows.Forms.NumericUpDown Nud_HoraOperacion;
        private System.Windows.Forms.TextBox Txt_MantenimientoPeriodico;
        private System.Windows.Forms.DateTimePicker Dtp_UltimaMantenimiento;
        private System.Windows.Forms.DateTimePicker Dtp_ProximoMantenimiento;
        private System.Windows.Forms.ComboBox Cbo_Area;
        private System.Windows.Forms.NumericUpDown Nud_DesgastePorcentaje;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Nuevo;
    }
}