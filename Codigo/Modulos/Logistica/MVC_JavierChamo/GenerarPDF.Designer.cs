
namespace MVC_JavierChamo
{
    partial class GenerarPDF
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
            this.btn_generarPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_mantenimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_generarPDF
            // 
            this.btn_generarPDF.Location = new System.Drawing.Point(427, 37);
            this.btn_generarPDF.Name = "btn_generarPDF";
            this.btn_generarPDF.Size = new System.Drawing.Size(152, 23);
            this.btn_generarPDF.TabIndex = 8;
            this.btn_generarPDF.Text = "Generar PDF";
            this.btn_generarPDF.UseVisualStyleBackColor = true;
            this.btn_generarPDF.Click += new System.EventHandler(this.btn_generarPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID de la Solicitud de Mantenimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generar PDF de Solicitud";
            // 
            // txtID_mantenimiento
            // 
            this.txtID_mantenimiento.Location = new System.Drawing.Point(260, 39);
            this.txtID_mantenimiento.Name = "txtID_mantenimiento";
            this.txtID_mantenimiento.Size = new System.Drawing.Size(161, 20);
            this.txtID_mantenimiento.TabIndex = 5;
            // 
            // GenerarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 84);
            this.Controls.Add(this.btn_generarPDF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID_mantenimiento);
            this.Name = "GenerarPDF";
            this.Text = "GenerarPDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generarPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_mantenimiento;
    }
}