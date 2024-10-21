
namespace Capa_Vista_Produccion
{
    partial class Frm_Enlace_Contabilidad_Cierre
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
            this.Btn_enlazar_polizas = new System.Windows.Forms.Button();
            this.Btn_ver_polizas = new System.Windows.Forms.Button();
            this.Btn_consultar_polizas = new System.Windows.Forms.Button();
            this.Btn_generar_reporte_polizas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_id_poliza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_polizas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_polizas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_enlazar_polizas
            // 
            this.Btn_enlazar_polizas.Location = new System.Drawing.Point(33, 76);
            this.Btn_enlazar_polizas.Name = "Btn_enlazar_polizas";
            this.Btn_enlazar_polizas.Size = new System.Drawing.Size(123, 42);
            this.Btn_enlazar_polizas.TabIndex = 0;
            this.Btn_enlazar_polizas.Text = "Enlazar Polizas";
            this.Btn_enlazar_polizas.UseVisualStyleBackColor = true;
            // 
            // Btn_ver_polizas
            // 
            this.Btn_ver_polizas.Location = new System.Drawing.Point(162, 76);
            this.Btn_ver_polizas.Name = "Btn_ver_polizas";
            this.Btn_ver_polizas.Size = new System.Drawing.Size(123, 42);
            this.Btn_ver_polizas.TabIndex = 1;
            this.Btn_ver_polizas.Text = "Ver Polizas";
            this.Btn_ver_polizas.UseVisualStyleBackColor = true;
            // 
            // Btn_consultar_polizas
            // 
            this.Btn_consultar_polizas.Location = new System.Drawing.Point(291, 76);
            this.Btn_consultar_polizas.Name = "Btn_consultar_polizas";
            this.Btn_consultar_polizas.Size = new System.Drawing.Size(123, 42);
            this.Btn_consultar_polizas.TabIndex = 2;
            this.Btn_consultar_polizas.Text = "Consultar Polizas";
            this.Btn_consultar_polizas.UseVisualStyleBackColor = true;
            // 
            // Btn_generar_reporte_polizas
            // 
            this.Btn_generar_reporte_polizas.Location = new System.Drawing.Point(420, 76);
            this.Btn_generar_reporte_polizas.Name = "Btn_generar_reporte_polizas";
            this.Btn_generar_reporte_polizas.Size = new System.Drawing.Size(123, 42);
            this.Btn_generar_reporte_polizas.TabIndex = 3;
            this.Btn_generar_reporte_polizas.Text = "Generar Reporte";
            this.Btn_generar_reporte_polizas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contabilidad (Enlace)";
            // 
            // Txt_id_poliza
            // 
            this.Txt_id_poliza.Location = new System.Drawing.Point(99, 131);
            this.Txt_id_poliza.Name = "Txt_id_poliza";
            this.Txt_id_poliza.Size = new System.Drawing.Size(113, 22);
            this.Txt_id_poliza.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Poliza";
            // 
            // Dgv_polizas
            // 
            this.Dgv_polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_polizas.Location = new System.Drawing.Point(33, 159);
            this.Dgv_polizas.Name = "Dgv_polizas";
            this.Dgv_polizas.RowHeadersWidth = 51;
            this.Dgv_polizas.RowTemplate.Height = 24;
            this.Dgv_polizas.Size = new System.Drawing.Size(509, 199);
            this.Dgv_polizas.TabIndex = 7;
            // 
            // Frm_Enlace_Contabilidad_Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 385);
            this.Controls.Add(this.Dgv_polizas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_id_poliza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_generar_reporte_polizas);
            this.Controls.Add(this.Btn_consultar_polizas);
            this.Controls.Add(this.Btn_ver_polizas);
            this.Controls.Add(this.Btn_enlazar_polizas);
            this.Name = "Frm_Enlace_Contabilidad_Cierre";
            this.Text = "Frm_Enlace_Contabilidad_Cierre";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_polizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_enlazar_polizas;
        private System.Windows.Forms.Button Btn_ver_polizas;
        private System.Windows.Forms.Button Btn_consultar_polizas;
        private System.Windows.Forms.Button Btn_generar_reporte_polizas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id_poliza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_polizas;
    }
}