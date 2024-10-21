
namespace Capa_Vista_Produccion
{
    partial class Frm_Cierre
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
            this.Btn_realizar_cierre = new System.Windows.Forms.Button();
            this.Btn_generar_reporte_cierre = new System.Windows.Forms.Button();
            this.Txt_fecha_cierre = new System.Windows.Forms.TextBox();
            this.Txt_resultado_cierre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_tipo_cierre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cierre";
            // 
            // Btn_realizar_cierre
            // 
            this.Btn_realizar_cierre.Location = new System.Drawing.Point(67, 178);
            this.Btn_realizar_cierre.Name = "Btn_realizar_cierre";
            this.Btn_realizar_cierre.Size = new System.Drawing.Size(103, 44);
            this.Btn_realizar_cierre.TabIndex = 1;
            this.Btn_realizar_cierre.Text = "Realizar Cierre";
            this.Btn_realizar_cierre.UseVisualStyleBackColor = true;
            // 
            // Btn_generar_reporte_cierre
            // 
            this.Btn_generar_reporte_cierre.Location = new System.Drawing.Point(277, 178);
            this.Btn_generar_reporte_cierre.Name = "Btn_generar_reporte_cierre";
            this.Btn_generar_reporte_cierre.Size = new System.Drawing.Size(127, 44);
            this.Btn_generar_reporte_cierre.TabIndex = 2;
            this.Btn_generar_reporte_cierre.Text = "Generar Reporte";
            this.Btn_generar_reporte_cierre.UseVisualStyleBackColor = true;
            // 
            // Txt_fecha_cierre
            // 
            this.Txt_fecha_cierre.Location = new System.Drawing.Point(277, 83);
            this.Txt_fecha_cierre.Name = "Txt_fecha_cierre";
            this.Txt_fecha_cierre.Size = new System.Drawing.Size(127, 22);
            this.Txt_fecha_cierre.TabIndex = 3;
            // 
            // Txt_resultado_cierre
            // 
            this.Txt_resultado_cierre.Location = new System.Drawing.Point(277, 111);
            this.Txt_resultado_cierre.Name = "Txt_resultado_cierre";
            this.Txt_resultado_cierre.Size = new System.Drawing.Size(127, 22);
            this.Txt_resultado_cierre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha del Cierre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // Cbo_tipo_cierre
            // 
            this.Cbo_tipo_cierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_tipo_cierre.FormattingEnabled = true;
            this.Cbo_tipo_cierre.Location = new System.Drawing.Point(277, 139);
            this.Cbo_tipo_cierre.Name = "Cbo_tipo_cierre";
            this.Cbo_tipo_cierre.Size = new System.Drawing.Size(127, 24);
            this.Cbo_tipo_cierre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Cierre";
            // 
            // Frm_Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbo_tipo_cierre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_resultado_cierre);
            this.Controls.Add(this.Txt_fecha_cierre);
            this.Controls.Add(this.Btn_generar_reporte_cierre);
            this.Controls.Add(this.Btn_realizar_cierre);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Cierre";
            this.Text = "Frm_Cierre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_realizar_cierre;
        private System.Windows.Forms.Button Btn_generar_reporte_cierre;
        private System.Windows.Forms.TextBox Txt_fecha_cierre;
        private System.Windows.Forms.TextBox Txt_resultado_cierre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_tipo_cierre;
        private System.Windows.Forms.Label label4;
    }
}