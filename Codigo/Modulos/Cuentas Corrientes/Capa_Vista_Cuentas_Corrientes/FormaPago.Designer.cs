
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class FormaPago
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
            this.Cbo_nombre_pago = new System.Windows.Forms.ComboBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_estado_pago = new System.Windows.Forms.ComboBox();
            this.Txt_id_pago = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_encargado = new System.Windows.Forms.Label();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
>>>>>>> cdfe74f05c6f905224e0c6d05c08dbfa5cbe5584
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> cdfe74f05c6f905224e0c6d05c08dbfa5cbe5584
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_nombre_pago
            // 
            this.Cbo_nombre_pago.FormattingEnabled = true;
            this.Cbo_nombre_pago.Items.AddRange(new object[] {
            "1. Efectivo Quetzales ",
            "2. Efectivo Dolares",
            "3. Tarjeta de Crédito ",
            "4. Cheques",
            "5. Crédito",
            "6. Otros"});
            this.Cbo_nombre_pago.Location = new System.Drawing.Point(426, 118);
            this.Cbo_nombre_pago.Name = "Cbo_nombre_pago";
            this.Cbo_nombre_pago.Size = new System.Drawing.Size(133, 21);
            this.Cbo_nombre_pago.TabIndex = 62;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(590, 245);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(113, 35);
            this.Btn_limpiar.TabIndex = 61;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
<<<<<<< HEAD
            this.Btn_guardar.Location = new System.Drawing.Point(83, 245);
=======
            this.Btn_guardar.Location = new System.Drawing.Point(202, 245);
>>>>>>> cdfe74f05c6f905224e0c6d05c08dbfa5cbe5584
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(113, 35);
            this.Btn_guardar.TabIndex = 60;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "TIPOS DE PAGO CLIENTE";
            // 
            // Cbo_estado_pago
            // 
            this.Cbo_estado_pago.FormattingEnabled = true;
            this.Cbo_estado_pago.Items.AddRange(new object[] {
            "1. Habilitado ",
            "2. Inhabilitado"});
            this.Cbo_estado_pago.Location = new System.Drawing.Point(426, 175);
            this.Cbo_estado_pago.Name = "Cbo_estado_pago";
            this.Cbo_estado_pago.Size = new System.Drawing.Size(133, 21);
            this.Cbo_estado_pago.TabIndex = 58;
            // 
            // Txt_id_pago
            // 
            this.Txt_id_pago.Location = new System.Drawing.Point(426, 91);
            this.Txt_id_pago.Name = "Txt_id_pago";
            this.Txt_id_pago.Size = new System.Drawing.Size(133, 20);
            this.Txt_id_pago.TabIndex = 57;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(267, 174);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(51, 15);
            this.Lbl_fecha.TabIndex = 56;
            this.Lbl_fecha.Text = "Estado: ";
            // 
            // Lbl_encargado
            // 
            this.Lbl_encargado.AutoSize = true;
            this.Lbl_encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_encargado.Location = new System.Drawing.Point(267, 118);
            this.Lbl_encargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_encargado.Name = "Lbl_encargado";
            this.Lbl_encargado.Size = new System.Drawing.Size(58, 15);
            this.Lbl_encargado.TabIndex = 55;
            this.Lbl_encargado.Text = "Nombre: ";
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_documento.Location = new System.Drawing.Point(267, 91);
            this.Lbl_documento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(51, 15);
            this.Lbl_documento.TabIndex = 54;
            this.Lbl_documento.Text = "ID Pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Encargado,
            this.Fecha,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(202, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 191);
            this.dataGridView1.TabIndex = 53;
            // 
<<<<<<< HEAD
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID Pago";
            this.Column1.Name = "Column1";
            // 
            // Encargado
            // 
            this.Encargado.Frozen = true;
            this.Encargado.HeaderText = "Nombre";
            this.Encargado.Name = "Encargado";
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Moneda";
            this.Fecha.Name = "Fecha";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            // 
=======
>>>>>>> cdfe74f05c6f905224e0c6d05c08dbfa5cbe5584
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(709, 245);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(113, 35);
            this.Btn_borrar.TabIndex = 52;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_actualizar.Location = new System.Drawing.Point(462, 245);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(113, 35);
            this.Btn_actualizar.TabIndex = 51;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(332, 245);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(113, 35);
            this.Btn_editar.TabIndex = 50;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
<<<<<<< HEAD
            this.Btn_buscar.Location = new System.Drawing.Point(202, 245);
=======
            this.Btn_buscar.Location = new System.Drawing.Point(70, 245);
>>>>>>> cdfe74f05c6f905224e0c6d05c08dbfa5cbe5584
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(113, 35);
            this.Btn_buscar.TabIndex = 49;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.  Quetzal ",
            "2.  Dolar"});
            this.comboBox1.Location = new System.Drawing.Point(426, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Moneda: ";
<<<<<<< HEAD
=======
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID Pago";
            this.Column1.Name = "Column1";
            // 
            // Encargado
            // 
            this.Encargado.Frozen = true;
            this.Encargado.HeaderText = "Nombre";
            this.Encargado.Name = "Encargado";
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Moneda";
            this.Fecha.Name = "Fecha";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
>>>>>>> cdfe74f05c6f905224e0c6d05c08dbfa5cbe5584
            // 
            // FormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(860, 510);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbo_nombre_pago);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_estado_pago);
            this.Controls.Add(this.Txt_id_pago);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_encargado);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Name = "FormaPago";
            this.Text = "FormaPago";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_nombre_pago;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_estado_pago;
        private System.Windows.Forms.TextBox Txt_id_pago;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_encargado;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}