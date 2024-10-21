
namespace Capa_Vista_Logistica
{
    partial class Administración_de_Lotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dataGridViewLotes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarLote = new System.Windows.Forms.Button();
            this.btnModificarLote = new System.Windows.Forms.Button();
            this.btnAgregarLote = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.LBL_INGRESO = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_SALIDA = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLotes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE LOTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.LBL_SALIDA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbBodega);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.LBL_INGRESO);
            this.groupBox1.Controls.Add(this.dtpFechaEntrada);
            this.groupBox1.Controls.Add(this.cmbProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Location = new System.Drawing.Point(72, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1212, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LOTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "PRODUCTO: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CANTIDAD: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ESTADO:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(137, 84);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 26);
            this.txtCantidad.TabIndex = 1;
            // 
            // dataGridViewLotes
            // 
            this.dataGridViewLotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLotes.Location = new System.Drawing.Point(345, 333);
            this.dataGridViewLotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewLotes.Name = "dataGridViewLotes";
            this.dataGridViewLotes.RowHeadersWidth = 62;
            this.dataGridViewLotes.Size = new System.Drawing.Size(925, 440);
            this.dataGridViewLotes.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarLote);
            this.groupBox2.Controls.Add(this.btnModificarLote);
            this.groupBox2.Controls.Add(this.btnAgregarLote);
            this.groupBox2.Location = new System.Drawing.Point(72, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(248, 440);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AUDITORIA";
            // 
            // btnEliminarLote
            // 
            this.btnEliminarLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.btnEliminarLote.Location = new System.Drawing.Point(52, 280);
            this.btnEliminarLote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarLote.Name = "btnEliminarLote";
            this.btnEliminarLote.Size = new System.Drawing.Size(117, 105);
            this.btnEliminarLote.TabIndex = 2;
            this.btnEliminarLote.Text = "ELIMINAR";
            this.btnEliminarLote.UseVisualStyleBackColor = false;
            // 
            // btnModificarLote
            // 
            this.btnModificarLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.btnModificarLote.Location = new System.Drawing.Point(52, 166);
            this.btnModificarLote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarLote.Name = "btnModificarLote";
            this.btnModificarLote.Size = new System.Drawing.Size(117, 105);
            this.btnModificarLote.TabIndex = 1;
            this.btnModificarLote.Text = "MODIFICAR";
            this.btnModificarLote.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.btnAgregarLote.Location = new System.Drawing.Point(52, 52);
            this.btnAgregarLote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(117, 105);
            this.btnAgregarLote.TabIndex = 0;
            this.btnAgregarLote.Text = "AGREGAR";
            this.btnAgregarLote.UseVisualStyleBackColor = false;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(137, 38);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(204, 28);
            this.cmbProducto.TabIndex = 6;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(888, 35);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaEntrada.TabIndex = 7;
            // 
            // LBL_INGRESO
            // 
            this.LBL_INGRESO.AutoSize = true;
            this.LBL_INGRESO.Location = new System.Drawing.Point(707, 41);
            this.LBL_INGRESO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_INGRESO.Name = "LBL_INGRESO";
            this.LBL_INGRESO.Size = new System.Drawing.Size(174, 20);
            this.LBL_INGRESO.TabIndex = 8;
            this.LBL_INGRESO.Text = "FECHA DE INGRESO:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(463, 38);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(204, 28);
            this.cmbEstado.TabIndex = 9;
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(463, 81);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(204, 28);
            this.cmbBodega.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "BODEGA:";
            // 
            // LBL_SALIDA
            // 
            this.LBL_SALIDA.AutoSize = true;
            this.LBL_SALIDA.Location = new System.Drawing.Point(707, 84);
            this.LBL_SALIDA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_SALIDA.Name = "LBL_SALIDA";
            this.LBL_SALIDA.Size = new System.Drawing.Size(158, 20);
            this.LBL_SALIDA.TabIndex = 12;
            this.LBL_SALIDA.Text = "FECHA DE SALIDA:";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(888, 82);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaSalida.TabIndex = 13;
            // 
            // Administración_de_Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1300, 851);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewLotes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Administración_de_Lotes";
            this.Text = "Administración_de_Lotes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLotes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLotes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarLote;
        private System.Windows.Forms.Button btnEliminarLote;
        private System.Windows.Forms.Button btnModificarLote;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.Label LBL_INGRESO;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label LBL_SALIDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
    }
}