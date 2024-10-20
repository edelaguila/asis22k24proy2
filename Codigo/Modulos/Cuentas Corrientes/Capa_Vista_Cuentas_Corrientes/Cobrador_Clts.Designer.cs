
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Cobrador_Clts
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Txt_tel_cobrador = new System.Windows.Forms.TextBox();
            this.Txt_nom_cobrador = new System.Windows.Forms.TextBox();
            this.Txt_id_cobrador = new System.Windows.Forms.TextBox();
            this.Txt_direc_cobrador = new System.Windows.Forms.TextBox();
            this.Lbl_telef_cobrador = new System.Windows.Forms.Label();
            this.Lbl_direc_cobrador = new System.Windows.Forms.Label();
            this.Lbl_nombre_cobrador = new System.Windows.Forms.Label();
            this.Lbl_id_cobrador = new System.Windows.Forms.Label();
            this.Lbl_depto_cobrador = new System.Windows.Forms.Label();
            this.Txt_depto_cobrador = new System.Windows.Forms.TextBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(277, 27);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(157, 17);
            this.Lbl_titulo.TabIndex = 78;
            this.Lbl_titulo.Text = "COBRADOR  - CLIENTE- ";
            this.Lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_tel_cobrador
            // 
            this.Txt_tel_cobrador.Location = new System.Drawing.Point(348, 153);
            this.Txt_tel_cobrador.Name = "Txt_tel_cobrador";
            this.Txt_tel_cobrador.Size = new System.Drawing.Size(211, 20);
            this.Txt_tel_cobrador.TabIndex = 77;
            // 
            // Txt_nom_cobrador
            // 
            this.Txt_nom_cobrador.Location = new System.Drawing.Point(348, 98);
            this.Txt_nom_cobrador.Name = "Txt_nom_cobrador";
            this.Txt_nom_cobrador.Size = new System.Drawing.Size(211, 20);
            this.Txt_nom_cobrador.TabIndex = 76;
            // 
            // Txt_id_cobrador
            // 
            this.Txt_id_cobrador.Location = new System.Drawing.Point(348, 70);
            this.Txt_id_cobrador.Name = "Txt_id_cobrador";
            this.Txt_id_cobrador.Size = new System.Drawing.Size(211, 20);
            this.Txt_id_cobrador.TabIndex = 75;
            // 
            // Txt_direc_cobrador
            // 
            this.Txt_direc_cobrador.Location = new System.Drawing.Point(348, 126);
            this.Txt_direc_cobrador.Name = "Txt_direc_cobrador";
            this.Txt_direc_cobrador.Size = new System.Drawing.Size(211, 20);
            this.Txt_direc_cobrador.TabIndex = 74;
            // 
            // Lbl_telef_cobrador
            // 
            this.Lbl_telef_cobrador.AutoSize = true;
            this.Lbl_telef_cobrador.Location = new System.Drawing.Point(209, 156);
            this.Lbl_telef_cobrador.Name = "Lbl_telef_cobrador";
            this.Lbl_telef_cobrador.Size = new System.Drawing.Size(101, 13);
            this.Lbl_telef_cobrador.TabIndex = 73;
            this.Lbl_telef_cobrador.Text = "Telefono Cobrador: ";
            // 
            // Lbl_direc_cobrador
            // 
            this.Lbl_direc_cobrador.AutoSize = true;
            this.Lbl_direc_cobrador.Location = new System.Drawing.Point(209, 126);
            this.Lbl_direc_cobrador.Name = "Lbl_direc_cobrador";
            this.Lbl_direc_cobrador.Size = new System.Drawing.Size(101, 13);
            this.Lbl_direc_cobrador.TabIndex = 72;
            this.Lbl_direc_cobrador.Text = "Dirección Cobrador:";
            // 
            // Lbl_nombre_cobrador
            // 
            this.Lbl_nombre_cobrador.AutoSize = true;
            this.Lbl_nombre_cobrador.Location = new System.Drawing.Point(209, 101);
            this.Lbl_nombre_cobrador.Name = "Lbl_nombre_cobrador";
            this.Lbl_nombre_cobrador.Size = new System.Drawing.Size(93, 13);
            this.Lbl_nombre_cobrador.TabIndex = 71;
            this.Lbl_nombre_cobrador.Text = "Nombre Cobrador:";
            // 
            // Lbl_id_cobrador
            // 
            this.Lbl_id_cobrador.AutoSize = true;
            this.Lbl_id_cobrador.Location = new System.Drawing.Point(209, 77);
            this.Lbl_id_cobrador.Name = "Lbl_id_cobrador";
            this.Lbl_id_cobrador.Size = new System.Drawing.Size(67, 13);
            this.Lbl_id_cobrador.TabIndex = 70;
            this.Lbl_id_cobrador.Text = "ID Cobrador:";
            // 
            // Lbl_depto_cobrador
            // 
            this.Lbl_depto_cobrador.AutoSize = true;
            this.Lbl_depto_cobrador.Location = new System.Drawing.Point(209, 187);
            this.Lbl_depto_cobrador.Name = "Lbl_depto_cobrador";
            this.Lbl_depto_cobrador.Size = new System.Drawing.Size(126, 13);
            this.Lbl_depto_cobrador.TabIndex = 79;
            this.Lbl_depto_cobrador.Text = "Departamento Cobrador: ";
            // 
            // Txt_depto_cobrador
            // 
            this.Txt_depto_cobrador.Location = new System.Drawing.Point(348, 184);
            this.Txt_depto_cobrador.Name = "Txt_depto_cobrador";
            this.Txt_depto_cobrador.Size = new System.Drawing.Size(211, 20);
            this.Txt_depto_cobrador.TabIndex = 80;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(548, 229);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(113, 35);
            this.Btn_limpiar.TabIndex = 86;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(160, 229);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(113, 35);
            this.Btn_guardar.TabIndex = 85;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(667, 229);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(113, 35);
            this.Btn_borrar.TabIndex = 84;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_actualizar.Location = new System.Drawing.Point(420, 229);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(113, 35);
            this.Btn_actualizar.TabIndex = 83;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(290, 229);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(113, 35);
            this.Btn_editar.TabIndex = 82;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(28, 229);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(113, 35);
            this.Btn_buscar.TabIndex = 81;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(28, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 157);
            this.dataGridView1.TabIndex = 87;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Cobrador";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Departamento ";
            this.Column5.Name = "Column5";
            // 
            // Cobrador_Clts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_depto_cobrador);
            this.Controls.Add(this.Lbl_depto_cobrador);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Txt_tel_cobrador);
            this.Controls.Add(this.Txt_nom_cobrador);
            this.Controls.Add(this.Txt_id_cobrador);
            this.Controls.Add(this.Txt_direc_cobrador);
            this.Controls.Add(this.Lbl_telef_cobrador);
            this.Controls.Add(this.Lbl_direc_cobrador);
            this.Controls.Add(this.Lbl_nombre_cobrador);
            this.Controls.Add(this.Lbl_id_cobrador);
            this.Name = "Cobrador_Clts";
            this.Text = "Cobradores_Clts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TextBox Txt_tel_cobrador;
        private System.Windows.Forms.TextBox Txt_nom_cobrador;
        private System.Windows.Forms.TextBox Txt_id_cobrador;
        private System.Windows.Forms.TextBox Txt_direc_cobrador;
        private System.Windows.Forms.Label Lbl_telef_cobrador;
        private System.Windows.Forms.Label Lbl_direc_cobrador;
        private System.Windows.Forms.Label Lbl_nombre_cobrador;
        private System.Windows.Forms.Label Lbl_id_cobrador;
        private System.Windows.Forms.Label Lbl_depto_cobrador;
        private System.Windows.Forms.TextBox Txt_depto_cobrador;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}