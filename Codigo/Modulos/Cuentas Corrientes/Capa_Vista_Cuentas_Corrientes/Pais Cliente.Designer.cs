
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Pais_Cliente
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
            this.Lbl_id_pais = new System.Windows.Forms.Label();
            this.Lbl_nombre_pais = new System.Windows.Forms.Label();
            this.lbl_region_pais = new System.Windows.Forms.Label();
            this.lbl_estatus_pais = new System.Windows.Forms.Label();
            this.Txt_id_pais = new System.Windows.Forms.TextBox();
            this.Txt_nombre_pais = new System.Windows.Forms.TextBox();
            this.Txt_region_pais = new System.Windows.Forms.TextBox();
            this.Cbo_estatus_pais = new System.Windows.Forms.ComboBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id_pais
            // 
            this.Lbl_id_pais.AutoSize = true;
            this.Lbl_id_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_id_pais.Location = new System.Drawing.Point(24, 105);
            this.Lbl_id_pais.Name = "Lbl_id_pais";
            this.Lbl_id_pais.Size = new System.Drawing.Size(44, 13);
            this.Lbl_id_pais.TabIndex = 0;
            this.Lbl_id_pais.Text = "ID Pais:";
            // 
            // Lbl_nombre_pais
            // 
            this.Lbl_nombre_pais.AutoSize = true;
            this.Lbl_nombre_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_nombre_pais.Location = new System.Drawing.Point(24, 134);
            this.Lbl_nombre_pais.Name = "Lbl_nombre_pais";
            this.Lbl_nombre_pais.Size = new System.Drawing.Size(47, 13);
            this.Lbl_nombre_pais.TabIndex = 1;
            this.Lbl_nombre_pais.Text = "Nombre:";
            // 
            // lbl_region_pais
            // 
            this.lbl_region_pais.AutoSize = true;
            this.lbl_region_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_region_pais.Location = new System.Drawing.Point(25, 162);
            this.lbl_region_pais.Name = "lbl_region_pais";
            this.lbl_region_pais.Size = new System.Drawing.Size(44, 13);
            this.lbl_region_pais.TabIndex = 2;
            this.lbl_region_pais.Text = "Región:";
            // 
            // lbl_estatus_pais
            // 
            this.lbl_estatus_pais.AutoSize = true;
            this.lbl_estatus_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_estatus_pais.Location = new System.Drawing.Point(25, 185);
            this.lbl_estatus_pais.Name = "lbl_estatus_pais";
            this.lbl_estatus_pais.Size = new System.Drawing.Size(45, 13);
            this.lbl_estatus_pais.TabIndex = 3;
            this.lbl_estatus_pais.Text = "Estatus:";
            // 
            // Txt_id_pais
            // 
            this.Txt_id_pais.Location = new System.Drawing.Point(97, 102);
            this.Txt_id_pais.Name = "Txt_id_pais";
            this.Txt_id_pais.Size = new System.Drawing.Size(157, 20);
            this.Txt_id_pais.TabIndex = 4;
            // 
            // Txt_nombre_pais
            // 
            this.Txt_nombre_pais.Location = new System.Drawing.Point(97, 131);
            this.Txt_nombre_pais.Name = "Txt_nombre_pais";
            this.Txt_nombre_pais.Size = new System.Drawing.Size(157, 20);
            this.Txt_nombre_pais.TabIndex = 5;
            // 
            // Txt_region_pais
            // 
            this.Txt_region_pais.Location = new System.Drawing.Point(97, 159);
            this.Txt_region_pais.Name = "Txt_region_pais";
            this.Txt_region_pais.Size = new System.Drawing.Size(157, 20);
            this.Txt_region_pais.TabIndex = 6;
            // 
            // Cbo_estatus_pais
            // 
            this.Cbo_estatus_pais.FormattingEnabled = true;
            this.Cbo_estatus_pais.Items.AddRange(new object[] {
            "1.  Habilitado",
            "2.  Inhabilitado"});
            this.Cbo_estatus_pais.Location = new System.Drawing.Point(97, 185);
            this.Cbo_estatus_pais.Name = "Cbo_estatus_pais";
            this.Cbo_estatus_pais.Size = new System.Drawing.Size(121, 21);
            this.Cbo_estatus_pais.TabIndex = 7;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_titulo.Location = new System.Drawing.Point(144, 27);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(110, 13);
            this.Lbl_titulo.TabIndex = 8;
            this.Lbl_titulo.Text = "PAISES ASOCIADOS";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Location = new System.Drawing.Point(131, 230);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(100, 36);
            this.Btn_buscar.TabIndex = 43;
            this.Btn_buscar.Text = "Buscar ";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_eliminar.Location = new System.Drawing.Point(438, 230);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(100, 36);
            this.Btn_eliminar.TabIndex = 42;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.Btn_actualizar.Location = new System.Drawing.Point(340, 230);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(92, 36);
            this.Btn_actualizar.TabIndex = 41;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.Color.Black;
            this.Btn_editar.Location = new System.Drawing.Point(237, 230);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(97, 36);
            this.Btn_editar.TabIndex = 40;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.Btn_guardar.Location = new System.Drawing.Point(16, 230);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(109, 36);
            this.Btn_guardar.TabIndex = 39;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(16, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 150);
            this.dataGridView1.TabIndex = 44;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Pais";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Región";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estatus";
            this.Column4.Name = "Column4";
            // 
            // Pais_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(565, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Cbo_estatus_pais);
            this.Controls.Add(this.Txt_region_pais);
            this.Controls.Add(this.Txt_nombre_pais);
            this.Controls.Add(this.Txt_id_pais);
            this.Controls.Add(this.lbl_estatus_pais);
            this.Controls.Add(this.lbl_region_pais);
            this.Controls.Add(this.Lbl_nombre_pais);
            this.Controls.Add(this.Lbl_id_pais);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Pais_Cliente";
            this.Text = "Pais_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_id_pais;
        private System.Windows.Forms.Label Lbl_nombre_pais;
        private System.Windows.Forms.Label lbl_region_pais;
        private System.Windows.Forms.Label lbl_estatus_pais;
        private System.Windows.Forms.TextBox Txt_id_pais;
        private System.Windows.Forms.TextBox Txt_nombre_pais;
        private System.Windows.Forms.TextBox Txt_region_pais;
        private System.Windows.Forms.ComboBox Cbo_estatus_pais;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}