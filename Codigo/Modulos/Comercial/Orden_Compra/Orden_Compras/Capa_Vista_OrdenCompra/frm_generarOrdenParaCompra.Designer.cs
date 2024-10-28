
namespace Capa_Vista_OrdenCompra
{
    partial class frm_generarOrdenParaCompra
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
            this.label10 = new System.Windows.Forms.Label();
            this.Dgv_ordenesCompra = new System.Windows.Forms.DataGridView();
            this.id_encabezado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_cancelarDet = new System.Windows.Forms.Button();
            this.Btn_insertarDet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Cmb_id_EncOrCom = new System.Windows.Forms.ComboBox();
            this.Cbo_ProDetOrCom = new System.Windows.Forms.ComboBox();
            this.Txt_Cantidad_DetOrCom = new System.Windows.Forms.TextBox();
            this.Txt_total_DetOrCom = new System.Windows.Forms.TextBox();
            this.Txt_id_DetOrCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Txt_id_orCom = new System.Windows.Forms.TextBox();
            this.Btn_cancearEnc = new System.Windows.Forms.Button();
            this.Btn_insertarEnc = new System.Windows.Forms.Button();
            this.Txt_no_orCom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_id_prov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenesCompra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(441, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Compras";
            // 
            // Dgv_ordenesCompra
            // 
            this.Dgv_ordenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ordenesCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_encabezado,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Dgv_ordenesCompra.Location = new System.Drawing.Point(123, 479);
            this.Dgv_ordenesCompra.Name = "Dgv_ordenesCompra";
            this.Dgv_ordenesCompra.RowHeadersWidth = 62;
            this.Dgv_ordenesCompra.RowTemplate.Height = 28;
            this.Dgv_ordenesCompra.Size = new System.Drawing.Size(815, 224);
            this.Dgv_ordenesCompra.TabIndex = 14;
            // 
            // id_encabezado
            // 
            this.id_encabezado.HeaderText = "id_encabezado";
            this.id_encabezado.MinimumWidth = 8;
            this.id_encabezado.Name = "id_encabezado";
            this.id_encabezado.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id_detalle";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "producto";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "cantidad";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "total";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_cancelarDet);
            this.groupBox2.Controls.Add(this.Btn_insertarDet);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Cmb_id_EncOrCom);
            this.groupBox2.Controls.Add(this.Cbo_ProDetOrCom);
            this.groupBox2.Controls.Add(this.Txt_Cantidad_DetOrCom);
            this.groupBox2.Controls.Add(this.Txt_total_DetOrCom);
            this.groupBox2.Controls.Add(this.Txt_id_DetOrCom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // Btn_cancelarDet
            // 
            this.Btn_cancelarDet.Location = new System.Drawing.Point(880, 106);
            this.Btn_cancelarDet.Name = "Btn_cancelarDet";
            this.Btn_cancelarDet.Size = new System.Drawing.Size(95, 36);
            this.Btn_cancelarDet.TabIndex = 13;
            this.Btn_cancelarDet.Text = "Cancelar";
            this.Btn_cancelarDet.UseVisualStyleBackColor = true;
            // 
            // Btn_insertarDet
            // 
            this.Btn_insertarDet.Location = new System.Drawing.Point(878, 63);
            this.Btn_insertarDet.Name = "Btn_insertarDet";
            this.Btn_insertarDet.Size = new System.Drawing.Size(97, 36);
            this.Btn_insertarDet.TabIndex = 12;
            this.Btn_insertarDet.Text = "Insertar";
            this.Btn_insertarDet.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total:";
            // 
            // Cmb_id_EncOrCom
            // 
            this.Cmb_id_EncOrCom.FormattingEnabled = true;
            this.Cmb_id_EncOrCom.Location = new System.Drawing.Point(171, 83);
            this.Cmb_id_EncOrCom.Name = "Cmb_id_EncOrCom";
            this.Cmb_id_EncOrCom.Size = new System.Drawing.Size(164, 28);
            this.Cmb_id_EncOrCom.TabIndex = 10;
            this.Cmb_id_EncOrCom.SelectedIndexChanged += new System.EventHandler(this.Cmb_id_EncOrCom_SelectedIndexChanged_1);
            // 
            // Cbo_ProDetOrCom
            // 
            this.Cbo_ProDetOrCom.FormattingEnabled = true;
            this.Cbo_ProDetOrCom.Location = new System.Drawing.Point(447, 37);
            this.Cbo_ProDetOrCom.Name = "Cbo_ProDetOrCom";
            this.Cbo_ProDetOrCom.Size = new System.Drawing.Size(145, 28);
            this.Cbo_ProDetOrCom.TabIndex = 9;
            this.Cbo_ProDetOrCom.SelectedIndexChanged += new System.EventHandler(this.Cbo_ProDetOrCom_SelectedIndexChanged);
            // 
            // Txt_Cantidad_DetOrCom
            // 
            this.Txt_Cantidad_DetOrCom.Location = new System.Drawing.Point(447, 83);
            this.Txt_Cantidad_DetOrCom.Name = "Txt_Cantidad_DetOrCom";
            this.Txt_Cantidad_DetOrCom.Size = new System.Drawing.Size(145, 26);
            this.Txt_Cantidad_DetOrCom.TabIndex = 8;
            // 
            // Txt_total_DetOrCom
            // 
            this.Txt_total_DetOrCom.Location = new System.Drawing.Point(447, 142);
            this.Txt_total_DetOrCom.Name = "Txt_total_DetOrCom";
            this.Txt_total_DetOrCom.Size = new System.Drawing.Size(145, 26);
            this.Txt_total_DetOrCom.TabIndex = 7;
            // 
            // Txt_id_DetOrCom
            // 
            this.Txt_id_DetOrCom.Location = new System.Drawing.Point(171, 39);
            this.Txt_id_DetOrCom.Name = "Txt_id_DetOrCom";
            this.Txt_id_DetOrCom.Size = new System.Drawing.Size(164, 26);
            this.Txt_id_DetOrCom.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID Encabezado: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Txt_id_orCom);
            this.groupBox1.Controls.Add(this.Btn_cancearEnc);
            this.groupBox1.Controls.Add(this.Btn_insertarEnc);
            this.groupBox1.Controls.Add(this.Txt_no_orCom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_id_prov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Txt_id_orCom
            // 
            this.Txt_id_orCom.Location = new System.Drawing.Point(193, 31);
            this.Txt_id_orCom.Name = "Txt_id_orCom";
            this.Txt_id_orCom.Size = new System.Drawing.Size(142, 26);
            this.Txt_id_orCom.TabIndex = 8;
            // 
            // Btn_cancearEnc
            // 
            this.Btn_cancearEnc.Location = new System.Drawing.Point(880, 74);
            this.Btn_cancearEnc.Name = "Btn_cancearEnc";
            this.Btn_cancearEnc.Size = new System.Drawing.Size(95, 36);
            this.Btn_cancearEnc.TabIndex = 7;
            this.Btn_cancearEnc.Text = "Cancelar";
            this.Btn_cancearEnc.UseVisualStyleBackColor = true;
            // 
            // Btn_insertarEnc
            // 
            this.Btn_insertarEnc.Location = new System.Drawing.Point(878, 31);
            this.Btn_insertarEnc.Name = "Btn_insertarEnc";
            this.Btn_insertarEnc.Size = new System.Drawing.Size(97, 36);
            this.Btn_insertarEnc.TabIndex = 6;
            this.Btn_insertarEnc.Text = "Insertar";
            this.Btn_insertarEnc.UseVisualStyleBackColor = true;
            // 
            // Txt_no_orCom
            // 
            this.Txt_no_orCom.Location = new System.Drawing.Point(193, 74);
            this.Txt_no_orCom.Name = "Txt_no_orCom";
            this.Txt_no_orCom.Size = new System.Drawing.Size(142, 26);
            this.Txt_no_orCom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Orden:";
            // 
            // Txt_id_prov
            // 
            this.Txt_id_prov.Location = new System.Drawing.Point(459, 22);
            this.Txt_id_prov.Name = "Txt_id_prov";
            this.Txt_id_prov.Size = new System.Drawing.Size(171, 26);
            this.Txt_id_prov.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proveedor:";
            // 
            // frm_generarOrdenParaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1057, 759);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dgv_ordenesCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_generarOrdenParaCompra";
            this.Text = "frm_generarOrdenParaCompra";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenesCompra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Dgv_ordenesCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_encabezado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_cancelarDet;
        private System.Windows.Forms.Button Btn_insertarDet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cmb_id_EncOrCom;
        private System.Windows.Forms.ComboBox Cbo_ProDetOrCom;
        private System.Windows.Forms.TextBox Txt_Cantidad_DetOrCom;
        private System.Windows.Forms.TextBox Txt_total_DetOrCom;
        private System.Windows.Forms.TextBox Txt_id_DetOrCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Txt_id_orCom;
        private System.Windows.Forms.Button Btn_cancearEnc;
        private System.Windows.Forms.Button Btn_insertarEnc;
        private System.Windows.Forms.TextBox Txt_no_orCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_id_prov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}